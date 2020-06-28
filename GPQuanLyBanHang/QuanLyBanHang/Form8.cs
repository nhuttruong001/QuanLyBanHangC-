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
    public partial class Form8 : Form
    {

        bool Them;
        SqlConnection conn = null;
        SqlDataAdapter daHoaDon = null;
        DataTable dtHoaDon = null;

        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;

        SqlDataAdapter daNhanVien = null;
        DataTable dtNhanVien = null;


        public Form8()
        {
            InitializeComponent();
            this.ChangeButtonState(0);
            LoadHD();
        }

        public void LoadHD(int disableInput = 0)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");

            // Vận chuyển dữ liệu vào DataTable dtThanhPho
            daKhachHang = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
            dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            daKhachHang.Fill(dtKhachHang);

            (dgvHOADON.Columns["Column2"] as DataGridViewComboBoxColumn).DataSource = dtKhachHang;
            (dgvHOADON.Columns["Column2"] as DataGridViewComboBoxColumn).DisplayMember = "TenCty";
            (dgvHOADON.Columns["Column2"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";
            //==========them cbb
            cbxMaKH.DataSource = dtKhachHang;
            cbxMaKH.DisplayMember = "TenCty";
            cbxMaKH.ValueMember = "MaKH";


            daNhanVien = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            daNhanVien.Fill(dtNhanVien);


            dtNhanVien.Columns.Add("fullname", typeof(string), "Ho + ' ' + Ten");

            (dgvHOADON.Columns["Column3"] as DataGridViewComboBoxColumn).DataSource = dtNhanVien;
            (dgvHOADON.Columns["Column3"] as DataGridViewComboBoxColumn).DisplayMember = "fullname";
            (dgvHOADON.Columns["Column3"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";

       
            cbxMaNV.DataSource = dtNhanVien;
            cbxMaNV.DisplayMember = "fullname";
            cbxMaNV.ValueMember = "MaNV";


            daHoaDon = new SqlDataAdapter("SELECT * FROM HoaDon", conn);
            dtHoaDon = new DataTable();
            dtHoaDon.Clear();
            daHoaDon.Fill(dtHoaDon);
            dgvHOADON.DataSource = dtHoaDon;
            if (disableInput == 1) ChangeButtonState(0);

        }

        public void ChangeButtonState(int state)
        {
            if (state == 1)
            {
                this.btnLuu.Enabled = true;
                this.btnHuyBo.Enabled = true;
                this.panel1.Enabled = true;
                this.txtMaHD.Enabled = true;

                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnTroVe.Enabled = false;
                this.btnSua.Enabled = false;

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
            ResetTxt();
        }
        public void ResetTxt()
        {
            this.txtMaHD.ResetText();
            this.txtNgLapHD.ResetText();
            this.txtNgLapNH.ResetText();
            this.txtMaHD.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Them = true;
            this.ResetTxt();
            this.ChangeButtonState(1);
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
                    cmd.CommandText = System.String.Concat("INSERT INTO HoaDon VALUES (N'"
                        + this.txtMaHD.Text + "', N'"
                        + this.cbxMaKH.SelectedValue.ToString() + "', N'"
                        + this.cbxMaNV.SelectedValue.ToString() + "', '"
                        + this.txtNgLapHD.Text + "','"
                        + this.txtNgLapNH.Text + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadHD();
                    ResetTxt();
                    MessageBox.Show("Đã thêm Thành Công!");
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
                    cmd.CommandText = String.Concat("UPDATE HoaDon SET MaKH=N'"
                        + this.cbxMaKH.SelectedValue.ToString() + "', MaNV= N'"
                        + this.cbxMaNV.SelectedValue.ToString() + "', NgayLapHD= '"
                        + this.txtNgLapHD.Text + "', NgayNhanHang='"
                        + this.txtNgLapNH.Text + "' WHERE MaHD ='"
                        + this.txtMaHD.Text + "'");

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    this.LoadHD();
                    MessageBox.Show("Chỉnh sửa thành công");
                    this.ChangeButtonState(0);
                }
                catch (Exception sqlE)
                {
                    MessageBox.Show(sqlE.ToString());
                }
                this.LoadHD(1);
            }

            conn.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            this.ChangeButtonState(1);

            int rowIndex = dgvHOADON.CurrentCell.RowIndex;

            this.txtMaHD.Text = dgvHOADON.Rows[rowIndex].Cells[0].Value.ToString();
            this.cbxMaKH.SelectedValue = dgvHOADON.Rows[rowIndex].Cells[1].Value.ToString();
            this.cbxMaNV.SelectedValue = dgvHOADON.Rows[rowIndex].Cells[2].Value.ToString();
            this.txtNgLapHD.Text = dgvHOADON.Rows[rowIndex].Cells[3].Value.ToString();
            this.txtNgLapNH.Text = dgvHOADON.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.ChangeButtonState(0);
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            this.LoadHD(1);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                int rowIndex = dgvHOADON.CurrentCell.RowIndex;

                string strMaHD =
                dgvHOADON.Rows[rowIndex].Cells[0].Value.ToString();

                cmd.CommandText = System.String.Concat("Delete From HoaDon Where MaHD = '" + strMaHD + "'");
                cmd.CommandType = CommandType.Text; cmd.ExecuteNonQuery();

                LoadHD();

                MessageBox.Show("Đã xóa Thành Công!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Xóa Thất bại. Lỗi rồi!!!");
            }

            conn.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
