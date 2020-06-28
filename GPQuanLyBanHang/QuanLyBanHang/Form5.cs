using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyBanHang
{
    public partial class Form5 : Form
    {
        SqlConnection conn = null;
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;
        SqlDataAdapter daThanhPho = null;
        DataTable dtThanhPho = null;

        bool Them;

        public void LoadKH(int disableInput = 0)
        {

            conn = new SqlConnection(@"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");

            
            daThanhPho = new SqlDataAdapter("SELECT * FROM ThanhPho", conn);
            dtThanhPho = new DataTable();
            dtThanhPho.Clear();
            daThanhPho.Fill(dtThanhPho);

            (dgvKHACHHANG.Columns["Column4"] as DataGridViewComboBoxColumn).DataSource = dtThanhPho;
            (dgvKHACHHANG.Columns["Column4"] as DataGridViewComboBoxColumn).DisplayMember = "TenThanhPho";
            (dgvKHACHHANG.Columns["Column4"] as DataGridViewComboBoxColumn).ValueMember = "ThanhPho";

            this.cbxThanhPho.DataSource = dtThanhPho;
            this.cbxThanhPho.DisplayMember = "TenThanhPho";
            this.cbxThanhPho.ValueMember = "ThanhPho";


            daKhachHang = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
            dtKhachHang = new DataTable();
            dtKhachHang.Clear();

            daKhachHang.Fill(dtKhachHang);

            dgvKHACHHANG.DataSource = dtKhachHang;

            if (disableInput == 1) ChangeButtonState(0);
        }


        public Form5()
        {
            InitializeComponent();
            LoadKH(1);

        }

        public void ChangeButtonState(int state)
        {
            if (state == 1)
            {
                this.btnLuu.Enabled = true;
                this.btnHuyBo.Enabled = true;
                this.panel1.Enabled = true;

                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnTroVe.Enabled = false;
                this.btnSua.Enabled = false;
                this.txtMaKH.Focus();
            }
            else
            {
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel1.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
                this.btnSua.Enabled = true;
            }
        }

       /* public void ResetText()
        {
            this.txtMaKH.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtTenCty.ResetText();
            this.txtMaKH.Focus();
        }*/

        private void Form5_Load(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.btnReLoad.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Them = true;
            this.ChangeButtonState(1);
            this.txtMaKH.Focus();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            this.LoadKH(1);
        }

        private void dgvKHACHHANG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            this.cbxThanhPho.DataSource = dtThanhPho;
            this.cbxThanhPho.DisplayMember = "TenThanhPho";
            this.cbxThanhPho.ValueMember = "ThanhPho";

            this.panel1.Enabled = true;

            int rowIndex = dgvKHACHHANG.CurrentCell.RowIndex;

            this.txtMaKH.Text =
            dgvKHACHHANG.Rows[rowIndex].Cells[0].Value.ToString();
            this.txtTenCty.Text =
            dgvKHACHHANG.Rows[rowIndex].Cells[1].Value.ToString();
            this.txtDiaChi.Text =
            dgvKHACHHANG.Rows[rowIndex].Cells[2].Value.ToString();
            this.cbxThanhPho.SelectedValue =
            dgvKHACHHANG.Rows[rowIndex].Cells[3].Value.ToString();
            this.txtDienThoai.Text = dgvKHACHHANG.Rows[rowIndex].Cells[4].Value.ToString();

            this.ChangeButtonState(1);
            this.txtMaKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Trả lời", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                conn.Open();
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    int rowIndex = dgvKHACHHANG.CurrentCell.RowIndex;

                    string strMAKH =
                    dgvKHACHHANG.Rows[rowIndex].Cells[0].Value.ToString();

                    cmd.CommandText = System.String.Concat("Delete From KhachHang Where MaKH = '" + strMAKH + "'");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    LoadKH();

                    MessageBox.Show("Đã Xóa Thành công!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Xóa không thành công. Lỗi rồi!!!");
                }
                conn.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (this.Them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("INSERT INTO KhachHang VALUES (N'"
                        + this.txtMaKH.Text + "', N'"
                        + this.txtTenCty.Text + "', N'"
                        + this.txtDiaChi.Text + "', N'"
                        + this.cbxThanhPho.SelectedValue.ToString() + "', N'"
                        + this.txtDienThoai.Text + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadKH();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException sqlE)
                {
                    MessageBox.Show(sqlE.ToString());
                }
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    int rowIndex = dgvKHACHHANG.CurrentCell.RowIndex;

                    string strMAKH =
                    dgvKHACHHANG.Rows[rowIndex].Cells[0].Value.ToString();

                    cmd.CommandText = System.String.Concat("Update KhachHang Set TenCty = N'"
                        + this.txtTenCty.Text.ToString() + "', DiaChi=N'"
                        + this.txtDiaChi.Text.ToString() + "', ThanhPho = N'"
                        + this.cbxThanhPho.SelectedValue.ToString() + "', DienThoai = '"
                        + this.txtDienThoai.Text.ToString()
                        + "' Where MaKH = '" + strMAKH + "'");

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadKH();
                    MessageBox.Show("Đã sửa Thành Công!");
                    ChangeButtonState(0);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.ToString());
                }
            }
            //ResetText();
            conn.Close();   
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Them = false;
            this.ChangeButtonState(0);
           // this.ResetText();
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
