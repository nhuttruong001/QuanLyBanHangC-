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
    public partial class Form9 : Form
    {
        bool Them;
        SqlConnection conn = null;
        SqlDataAdapter daHoaDon = null;
        DataTable dtHoaDon = null;
        SqlDataAdapter daChiTietHD = null;
        DataTable dtChiTietHD = null;
        SqlDataAdapter daSanPham = null;
        DataTable dtSanPham = null;


        public Form9()
        {
            InitializeComponent();
            ChangeButtonState(0);
            LoadCTHD();
        }

        public void LoadCTHD(int disableInput = 0)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");

            // Vận chuyển dữ liệu vào DataTable dtThanhPho
            daSanPham = new SqlDataAdapter("SELECT * FROM SanPham", conn);
            dtSanPham = new DataTable();
            dtSanPham.Clear();
            daSanPham.Fill(dtSanPham);

            (dgvCHITIETHOADON.Columns["TenSanPhamColumn"] as DataGridViewComboBoxColumn).DataSource = dtSanPham;
            (dgvCHITIETHOADON.Columns["TenSanPhamColumn"] as DataGridViewComboBoxColumn).DisplayMember = "TenSP";
            (dgvCHITIETHOADON.Columns["TenSanPhamColumn"] as DataGridViewComboBoxColumn).ValueMember = "MaSP";
            
            this.cbxMaSP.DataSource = dtSanPham;
            this.cbxMaSP.DisplayMember = "TenSP";
            this.cbxMaSP.ValueMember = "MaSP";


            daHoaDon = new SqlDataAdapter("SELECT * FROM HoaDon", conn);
            dtHoaDon = new DataTable();
            dtHoaDon.Clear();
            daHoaDon.Fill(dtHoaDon);

            (dgvCHITIETHOADON.Columns["MaHoaDonColumn"] as DataGridViewComboBoxColumn).DataSource = dtHoaDon;
            (dgvCHITIETHOADON.Columns["MaHoaDonColumn"] as DataGridViewComboBoxColumn).DisplayMember = "MaHD";
            (dgvCHITIETHOADON.Columns["MaHoaDonColumn"] as DataGridViewComboBoxColumn).ValueMember = "MaHD";

            
            this.cbxMaHD.DataSource = dtHoaDon;
            this.cbxMaHD.DisplayMember = "MaHD";
            this.cbxMaHD.ValueMember = "MaHD";


            daChiTietHD = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon", conn);
            dtChiTietHD = new DataTable();
            dtChiTietHD.Clear();
            daChiTietHD.Fill(dtChiTietHD);
            dgvCHITIETHOADON.DataSource = dtChiTietHD;
            if (disableInput == 1) this.ChangeButtonState(0);
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
            this.txtSoLuong.ResetText();
            this.txtSoLuong.Focus();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void cbxSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Them = true;
            this.ResetTxt();
            this.ChangeButtonState(1);
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            this.LoadCTHD(1);
            this.ChangeButtonState(0);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.ChangeButtonState(1);
            int rowIndex = dgvCHITIETHOADON.CurrentCell.RowIndex;
            this.cbxMaHD.SelectedValue = dgvCHITIETHOADON.Rows[rowIndex].Cells[0].Value.ToString();
            this.cbxMaSP.SelectedValue = dgvCHITIETHOADON.Rows[rowIndex].Cells[1].Value.ToString();
            this.txtSoLuong.Text = dgvCHITIETHOADON.Rows[rowIndex].Cells[2].Value.ToString();
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

                int rowIndex = dgvCHITIETHOADON.CurrentCell.RowIndex;

                string strMaHD =
                dgvCHITIETHOADON.Rows[rowIndex].Cells[0].Value.ToString();

                cmd.CommandText = System.String.Concat("Delete From ChiTietHoaDon Where MaHD = '"
                    + strMaHD + "' and MaSP ='" + this.cbxMaSP.SelectedValue.ToString() + "'");
                cmd.CommandType = CommandType.Text; cmd.ExecuteNonQuery();

                LoadCTHD();

                MessageBox.Show("Đã xóa Thành Công!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Xóa Thất bại. Lỗi rồi!!!");
            }

            conn.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.ChangeButtonState(0);
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
                    cmd.CommandText = System.String.Concat("INSERT INTO ChiTietHoaDon VALUES (N'"
                        + this.cbxMaHD.SelectedValue.ToString() + "', N'"
                        + this.cbxMaSP.SelectedValue.ToString() + "', N'"
                        + this.txtSoLuong.Text + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadCTHD();
                    MessageBox.Show("Đã thêm Thành Công!");
                }
                catch (SqlException sqlE)
                {
                    MessageBox.Show(sqlE.ToString());
                }
                ResetTxt();
            }
            else
            {
                
                try
                {
                 
                    int rowIndex = dgvCHITIETHOADON.CurrentCell.RowIndex;
                    String maSP = dgvCHITIETHOADON.Rows[rowIndex].Cells[1].Value.ToString();
   
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("UPDATE ChiTietHoaDon SET MaSP = '"
                        + this.cbxMaSP.SelectedValue.ToString()
                        + "', SoLuong = "
                        + this.txtSoLuong.Text + " WHERE MaHD='" 
                        + this.cbxMaHD.SelectedValue.ToString() + "' and MaSP ='"
                        + maSP + "'");
                     
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadCTHD(1);
                    MessageBox.Show("Đã Sửa Thành Công!");
                }
                catch (Exception sqlE)
                {
                    MessageBox.Show(sqlE.ToString());
                }
            
                     

            }

            conn.Close();
        
        }
    }
}
