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
    public partial class Form11 : Form
    {
        SqlConnection conn = null;
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;

        SqlDataAdapter daHD = null;
        DataTable dtHD = null;

        SqlDataAdapter daNV = null;
        DataTable dtNV = null;

        public void LoadHD()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");
                daKhachHang = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);
                cbxKhachHang.DataSource = dtKhachHang;
                cbxKhachHang.DisplayMember = "TenCty";
                cbxKhachHang.ValueMember = "MaKH";
                LoadHD_KhachHang();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        public void LoadHD_KhachHang()
        {
            try
            {

                (dgvHDtheoKH.Columns["Column2"] as DataGridViewComboBoxColumn).DataSource = dtKhachHang;
                (dgvHDtheoKH.Columns["Column2"] as DataGridViewComboBoxColumn).DisplayMember = "TenCty";
                (dgvHDtheoKH.Columns["Column2"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";


                daNV = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
                dtNV = new DataTable();
                dtNV.Clear();
                daNV.Fill(dtNV);
                dtNV.Columns.Add("fullname", typeof(string), "Ho + ' ' + Ten");


                (dgvHDtheoKH.Columns["Column3"] as DataGridViewComboBoxColumn).DataSource = dtNV;
                (dgvHDtheoKH.Columns["Column3"] as DataGridViewComboBoxColumn).DisplayMember = "fullname";
                (dgvHDtheoKH.Columns["Column3"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";


                daHD = new SqlDataAdapter("SELECT * FROM HoaDon WHERE MaKH='" + cbxKhachHang.SelectedValue.ToString() + "'", conn);
                dtHD = new DataTable();
                dtHD.Clear();
                daHD.Fill(dtHD);
                dgvHDtheoKH.DataSource = dtHD;

                // so luong 

                daHD = new SqlDataAdapter("SELECT COUNT(*) FROM HoaDon WHERE MaKH='" + cbxKhachHang.SelectedValue.ToString() + "'", conn);
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

        public Form11()
        {
            InitializeComponent();
            LoadHD();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadHD_KhachHang();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
