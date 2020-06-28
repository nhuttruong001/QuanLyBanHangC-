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
    public partial class Form12 : Form
    {
        SqlConnection conn = null;
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;

        SqlDataAdapter daHD = null;
        DataTable dtHD = null;

        SqlDataAdapter daNV = null;
        DataTable dtNV = null;

        SqlDataAdapter daSP = null;
        DataTable dtSP = null;

        public Form12()
        {
            InitializeComponent();
            loadSanPham();
        }

        public void loadSanPham()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");
                daSP = new SqlDataAdapter("SELECT * FROM SanPham", conn);
                dtSP = new DataTable();
                dtSP.Clear();
                daSP.Fill(dtSP);

                cbxSanPham.DataSource = dtSP;
                cbxSanPham.DisplayMember = "TenSP";
                cbxSanPham.ValueMember = "MaSP";

                LoadHD_SanPham();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        public void LoadHD_SanPham()
        {
            try
            {

                daKhachHang = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);

                (dgvHDtheoSP.Columns["Column4"] as DataGridViewComboBoxColumn).DataSource = dtKhachHang;
                (dgvHDtheoSP.Columns["Column4"] as DataGridViewComboBoxColumn).DisplayMember = "TenCty";
                (dgvHDtheoSP.Columns["Column4"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";


                daNV = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
                dtNV = new DataTable();
                dtNV.Clear();
                daNV.Fill(dtNV);
                dtNV.Columns.Add("fullname", typeof(string), "Ho + ' ' + Ten");


                (dgvHDtheoSP.Columns["Column3"] as DataGridViewComboBoxColumn).DataSource = dtNV;
                (dgvHDtheoSP.Columns["Column3"] as DataGridViewComboBoxColumn).DisplayMember = "fullname";
                (dgvHDtheoSP.Columns["Column3"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";


                daHD = new SqlDataAdapter("SELECT HoaDon.* FROM HoaDon, ChiTietHoaDon WHERE HoaDon.MaHD = ChiTietHoaDon.MaHD and ChiTietHoaDon.MaSP = '" + cbxSanPham.SelectedValue.ToString() + "'", conn);
                dtHD = new DataTable();
                dtHD.Clear();
                daHD.Fill(dtHD);
                dgvHDtheoSP.DataSource = dtHD;

                // so luong 

                daHD = new SqlDataAdapter("SELECT COUNT(*) FROM HoaDon, ChiTietHoaDon WHERE HoaDon.MaHD = ChiTietHoaDon.MaHD and ChiTietHoaDon.MaSP = '" + cbxSanPham.SelectedValue.ToString() + "'", conn);
                dtHD = new DataTable();
                dtHD.Clear();
                daHD.Fill(dtHD);
                this.txtTongSoHD.Text = dtHD.Rows[0][0].ToString();


            }
            catch (Exception sqlException)
            {
                MessageBox.Show(sqlException.ToString());
            }
        }


        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void cbxChonSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvHDtheoSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
