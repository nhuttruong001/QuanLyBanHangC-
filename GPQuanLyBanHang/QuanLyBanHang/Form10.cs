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
    public partial class Form10 : Form
    {
        SqlConnection conn = null;
        SqlDataAdapter daThanhPho = null;
        DataTable dtThanhPho = null;

        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;

        public Form10()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            try
            {

                conn = new SqlConnection(@"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");
                daThanhPho = new SqlDataAdapter("SELECT * FROM ThanhPho", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);

                cbxThanhPho.DataSource = dtThanhPho;
                cbxThanhPho.DisplayMember = "TenThanhPho";
                cbxThanhPho.ValueMember = "ThanhPho";

                (dgvKHTHEOTP.Columns["Column4"] as DataGridViewComboBoxColumn).DataSource = dtThanhPho;
                (dgvKHTHEOTP.Columns["Column4"] as DataGridViewComboBoxColumn).DisplayMember = "TenThanhPho";
                (dgvKHTHEOTP.Columns["Column4"] as DataGridViewComboBoxColumn).ValueMember = "ThanhPho";

                this.cbxThanhPho.DataSource = dtThanhPho;
                this.cbxThanhPho.DisplayMember = "TenThanhPho";
                this.cbxThanhPho.ValueMember = "ThanhPho";
                LoadKhachHang();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        public void LoadKhachHang()
        {

            daKhachHang = new SqlDataAdapter("SELECT * FROM KhachHang WHERE ThanhPho = '"
                    + cbxThanhPho.SelectedValue.ToString() + "'", conn);
            dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            daKhachHang.Fill(dtKhachHang);
            dgvKHTHEOTP.DataSource = dtKhachHang;



            daKhachHang = new SqlDataAdapter("SELECT COUNT(*) FROM KhachHang WHERE ThanhPho = '"
                    + cbxThanhPho.SelectedValue.ToString() + "'", conn);
            dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            daKhachHang.Fill(dtKhachHang);

            this.txtTongSoKH.Text = dtKhachHang.Rows[0][0].ToString();

        }


        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
