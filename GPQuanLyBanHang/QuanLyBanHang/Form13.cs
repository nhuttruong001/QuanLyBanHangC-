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
    public partial class Form13 : Form
    {

        SqlConnection conn = null;
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;

        SqlDataAdapter daHD = null;
        DataTable dtHD = null;

        SqlDataAdapter daNV = null;
        DataTable dtNV = null;

        public Form13()
        {
            InitializeComponent();
            loadNhanVien();
        }

        public void loadNhanVien()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");
                daNV = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
                dtNV = new DataTable();
                dtNV.Clear();
                daNV.Fill(dtNV);
                dtNV.Columns.Add("fullname", typeof(string), "Ho + ' ' + Ten");
                cbxNhanVien.DataSource = dtNV;
                cbxNhanVien.DisplayMember = "fullname";
                cbxNhanVien.ValueMember = "MaNV";
                LoadHD_NhanVien();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        public void LoadHD_NhanVien()
        {
            try
            {

                daKhachHang = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);

                (dgvHDtheoNV.Columns["Column3"] as DataGridViewComboBoxColumn).DataSource = dtKhachHang;
                (dgvHDtheoNV.Columns["Column3"] as DataGridViewComboBoxColumn).DisplayMember = "TenCty";
                (dgvHDtheoNV.Columns["Column3"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";


                daNV = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
                dtNV = new DataTable();
                dtNV.Clear();
                daNV.Fill(dtNV);
                dtNV.Columns.Add("fullname", typeof(string), "Ho + ' ' + Ten");


                (dgvHDtheoNV.Columns["Column2"] as DataGridViewComboBoxColumn).DataSource = dtNV;
                (dgvHDtheoNV.Columns["Column2"] as DataGridViewComboBoxColumn).DisplayMember = "fullname";
                (dgvHDtheoNV.Columns["Column2"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";


                daHD = new SqlDataAdapter("SELECT * FROM HoaDon WHERE MaNV='" + cbxNhanVien.SelectedValue.ToString() + "'", conn);
                dtHD = new DataTable();
                dtHD.Clear();
                daHD.Fill(dtHD);
                dgvHDtheoNV.DataSource = dtHD;

                // so luong 

                daHD = new SqlDataAdapter("SELECT COUNT(*) FROM HoaDon WHERE MaNV='" + cbxNhanVien.SelectedValue.ToString() + "'", conn);
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
        

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadHD_NhanVien();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
