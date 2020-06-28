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
    public partial class Form7 : Form
    {

        bool Them;
        SqlConnection conn = null;
        SqlDataAdapter daSanPham = null;
        DataTable dtSanPham = null;

        public Form7()
        {
            InitializeComponent();
            ChangeButtonState(0);
            LoadSP();
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
                this.txtMaSP.Enabled = true;
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

        public void LoadSP(int disableInput = 0)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");

            // Vận chuyển dữ liệu vào DataTable dtThanhPho
            daSanPham = new SqlDataAdapter("SELECT * FROM SanPham", conn);
            dtSanPham = new DataTable();
            dtSanPham.Clear();
            daSanPham.Fill(dtSanPham);
            dgvSANPHAM.DataSource = dtSanPham;
            if (disableInput == 1) this.ChangeButtonState(0);
        }



        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
             LoadSP(1);
             this.ChangeButtonState(0);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Them = true;
            this.ChangeButtonState(1);
            this.Resettxt();
            this.txtMaSP.Focus();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.ChangeButtonState(1);
            this.txtMaSP.Enabled = false;
            int rowIndex = dgvSANPHAM.CurrentCell.RowIndex;

            int GioiTinh = Convert.ToInt32(dgvSANPHAM.Rows[rowIndex].Cells[3].Value.ToString());

            this.txtMaSP.Text = dgvSANPHAM.Rows[rowIndex].Cells[0].Value.ToString();
            this.txtTenSanPham.Text = dgvSANPHAM.Rows[rowIndex].Cells[1].Value.ToString();
            this.txtDonViTinh.Text = dgvSANPHAM.Rows[rowIndex].Cells[2].Value.ToString();
            this.txtDonGia.Text = dgvSANPHAM.Rows[rowIndex].Cells[3].Value.ToString(); 
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.ChangeButtonState(0);
            this.txtMaSP.ResetText();
            this.txtTenSanPham.ResetText();
            this.txtDonViTinh.ResetText();
            this.txtDonGia.ResetText();
        }

        public void Resettxt()
        {
            this.txtMaSP.ResetText();
            this.txtTenSanPham.ResetText();
            this.txtDonViTinh.ResetText();
            this.txtDonGia.ResetText();
            txtMaSP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Bạn có chắc chắn muốn Xóa ?", "Trả lời", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                conn.Open();
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    int rowIndex = dgvSANPHAM.CurrentCell.RowIndex;

                    string strMaSP = dgvSANPHAM.Rows[rowIndex].Cells[0].Value.ToString();

                    cmd.CommandText = System.String.Concat("Delete From SanPham Where MaSP = '" + strMaSP + "'");
                    cmd.CommandType = CommandType.Text; cmd.ExecuteNonQuery();

                    LoadSP();

                    MessageBox.Show("Xóa Thành Công!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Xóa Thất bại. Lỗi rồi!!!");
                }

                conn.Close();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    cmd.CommandText = System.String.Concat("INSERT INTO SanPham VALUES (N'" + this.txtMaSP.Text + "', N'" + this.txtTenSanPham.Text + "', N'" + this.txtDonViTinh.Text + "', " + this.txtDonGia.Text + ",NULL)");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadSP();

                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException sqlE)
                {
                    MessageBox.Show(sqlE.ToString());
                }
                Resettxt();
            }
            else
            {

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = String.Concat("UPDATE SanPham SET TenSP=N'"
                        + this.txtTenSanPham.Text + "', DonViTinh= N'"
                        + this.txtDonViTinh.Text + "', DonGia= "
                        + this.txtDonGia.Text + " WHERE MaSP ='"
                        + this.txtMaSP.Text + "'");

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    this.LoadSP(1);
                    MessageBox.Show(" Sửa thành công");
                }
                catch (Exception sqlE)
                {
                    MessageBox.Show(sqlE.ToString());
                }
                this.Resettxt();
            }

            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
