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
    public partial class Form15 : Form
    {
        SqlConnection conn = null;
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;
        SqlDataAdapter daThanhPho = null;
        DataTable dtThanhPho = null;
        SqlDataAdapter daNV = null;
        DataTable dtNV = null;

        SqlDataAdapter daHD = null;
        DataTable dtHD = null;

        SqlDataAdapter daSP = null;
        DataTable dtSP = null;

        SqlDataAdapter daChiTietHD = null;
        DataTable dtChiTietHD = null;

        SqlDataAdapter daHDSL = null;
        DataTable dtHDSL = null;

        SqlDataAdapter daKhachHangSL = null;
        DataTable dtKhachHangSL = null;

        SqlDataAdapter daChiTietHDSL = null;
        DataTable dtChiTietHDSL = null;

        public Form15()
        {
            InitializeComponent();
            LoadThanhPho();
        }

        public void LoadThanhPho()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");

            // Vận chuyển dữ liệu vào DataTable dtThanhPho
            daThanhPho = new SqlDataAdapter("SELECT * FROM ThanhPho", conn);
            dtThanhPho = new DataTable();
            dtThanhPho.Clear();
            daThanhPho.Fill(dtThanhPho);
            this.cbxThanhPho.DataSource = dtThanhPho;
            this.cbxThanhPho.DisplayMember = "TenThanhPho";
            this.cbxThanhPho.ValueMember = "ThanhPho";

            LoadData();

        }

        public void LoadData()
        {
            // load Khach Hang
            daKhachHang = new SqlDataAdapter("SELECT * FROM KhachHang WHERE ThanhPho='" + cbxThanhPho.SelectedValue.ToString() + "'", conn);
            dtKhachHang = new DataTable();
            dtKhachHang.Clear();

            (dgvDSKH.Columns["Column4"] as DataGridViewComboBoxColumn).DataSource = dtThanhPho;
            (dgvDSKH.Columns["Column4"] as DataGridViewComboBoxColumn).DisplayMember = "TenThanhPho";
            (dgvDSKH.Columns["Column4"] as DataGridViewComboBoxColumn).ValueMember = "ThanhPho";

            daKhachHang.Fill(dtKhachHang);
            dgvDSKH.DataSource = dtKhachHang;


            daKhachHangSL = new SqlDataAdapter("SELECT COUNT(*) FROM KhachHang WHERE ThanhPho='" + cbxThanhPho.SelectedValue.ToString() + "'", conn);
            dtKhachHangSL = new DataTable();
            dtKhachHangSL.Clear();
            daKhachHangSL.Fill(dtKhachHangSL);
            txtDSKH.Text = dtKhachHangSL.Rows[0][0].ToString();




            String sqlTest = "";
            if (dtKhachHang.Rows.Count > 0) sqlTest = " WHERE "; else sqlTest = "WHERE MaHD='sdkfjhasdfkhf'";
            for (int i = 0; i < dtKhachHang.Rows.Count; i++)
            {
                if (i == 0) sqlTest += " MaKH = '" + dtKhachHang.Rows[i][0] + "' ";
                else sqlTest += "or MaKH = '" + dtKhachHang.Rows[i][0] + "' ";
            }


            daKhachHang = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
            dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            daKhachHang.Fill(dtKhachHang);
            (dgvDSHD.Columns["Column1"] as DataGridViewComboBoxColumn).DataSource = dtKhachHang;
            (dgvDSHD.Columns["Column1"] as DataGridViewComboBoxColumn).DisplayMember = "TenCty";
            (dgvDSHD.Columns["Column1"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";


            daNV = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            dtNV = new DataTable();
            dtNV.Clear();
            daNV.Fill(dtNV);
            dtNV.Columns.Add("fullname", typeof(string), "Ho + ' ' + Ten");


            (dgvDSHD.Columns["Column8"] as DataGridViewComboBoxColumn).DataSource = dtNV;
            (dgvDSHD.Columns["Column8"] as DataGridViewComboBoxColumn).DisplayMember = "fullname";
            (dgvDSHD.Columns["Column8"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";

            String sqlQuery = "SELECT * FROM HoaDon " + sqlTest + ";";
            daHD = new SqlDataAdapter(sqlQuery, conn);

            dtHD = new DataTable();
            dtHD.Clear();
            daHD.Fill(dtHD);
            dgvDSHD.DataSource = dtHD;



            sqlQuery = "SELECT COUNT(*) FROM HoaDon " + sqlTest + ";";
            daHDSL = new SqlDataAdapter(sqlQuery, conn);
            dtHDSL = new DataTable();
            dtHDSL.Clear();
            daHDSL.Fill(dtHDSL);
            txtDSHD.Text = dtHDSL.Rows[0][0].ToString();



            // Chi tiet hoa don

            sqlTest = "";
            if (dtHD.Rows.Count > 0) sqlTest = " WHERE "; else sqlTest = "WHERE MaHD='sdkfjhasdfkhf'";
            for (int i = 0; i < dtHD.Rows.Count; i++)
            {
                if (i == 0) sqlTest += " MaHD = '" + dtHD.Rows[i][0] + "' ";
                else sqlTest += "or MaHD = '" + dtHD.Rows[i][0] + "' ";
            }


            daSP = new SqlDataAdapter("SELECT * FROM SanPham", conn);
            dtSP = new DataTable();
            dtSP.Clear();
            daSP.Fill(dtSP);


            (dgvChiTietHD.Columns["Column12"] as DataGridViewComboBoxColumn).DataSource = dtSP;
            (dgvChiTietHD.Columns["Column12"] as DataGridViewComboBoxColumn).DisplayMember = "TenSP";
            (dgvChiTietHD.Columns["Column12"] as DataGridViewComboBoxColumn).ValueMember = "MaSP";


            daChiTietHD = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon " + sqlTest, conn);
            dtChiTietHD = new DataTable();
            dtChiTietHD.Clear();
            daChiTietHD.Fill(dtChiTietHD);
            dgvChiTietHD.DataSource = dtChiTietHD;


            daChiTietHDSL = new SqlDataAdapter("SELECT COUNT(*) FROM ChiTietHoaDon " + sqlTest, conn);
            dtChiTietHDSL = new DataTable();
            dtChiTietHDSL.Clear();
            daChiTietHDSL.Fill(dtChiTietHDSL);
            txtSLCTHD.Text = dtChiTietHDSL.Rows[0][0].ToString();


        }
    }
}