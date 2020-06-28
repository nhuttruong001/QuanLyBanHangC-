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
    public partial class Form14 : Form
    {

        SqlConnection conn = null;
        SqlDataAdapter daHD = null;
        DataTable dtHD = null;
        SqlDataAdapter daSP = null;
        DataTable dtSP = null;

        SqlDataAdapter daChiTietHD = null;
        DataTable dtChiTietHD = null;

        public Form14()
        {
            InitializeComponent();
            loadHoaDon();
        }
        public void loadHoaDon()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");
                daHD = new SqlDataAdapter("SELECT * FROM HoaDon", conn);
                dtHD = new DataTable();
                dtHD.Clear();
                daHD.Fill(dtHD);
                this.cbxMaHD.DataSource = dtHD;
                this.cbxMaHD.DisplayMember = "MaHD";
                this.cbxMaHD.ValueMember = "MaHD";

                loadChiTietTheoSP();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }



        private void loadChiTietTheoSP()
        {
            daSP = new SqlDataAdapter("SELECT * FROM SanPham", conn);
            dtSP = new DataTable();
            dtSP.Clear();
            daSP.Fill(dtSP);
            (dgvChiTietHDtheoHD.Columns["tenSP"] as DataGridViewComboBoxColumn).DataSource = dtSP;
            (dgvChiTietHDtheoHD.Columns["tenSP"] as DataGridViewComboBoxColumn).DisplayMember = "TenSP";
            (dgvChiTietHDtheoHD.Columns["tenSP"] as DataGridViewComboBoxColumn).ValueMember = "MaSP";


            daChiTietHD = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon WHERE MaHD='" + this.cbxMaHD.SelectedValue.ToString() + "'", conn);
            dtChiTietHD = new DataTable();
            dtChiTietHD.Clear();
            daChiTietHD.Fill(dtChiTietHD);
            dgvChiTietHDtheoHD.DataSource = dtChiTietHD;
  

            daHD = new SqlDataAdapter("SELECT COUNT(*) FROM ChiTietHoaDon WHERE MaHD='" + this.cbxMaHD.SelectedValue.ToString() + "'", conn);
            dtHD = new DataTable();
            dtHD.Clear();
            daHD.Fill(dtHD);
            this.txtTongSoHD.Text = dtHD.Rows[0][0].ToString();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            loadChiTietTheoSP();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
