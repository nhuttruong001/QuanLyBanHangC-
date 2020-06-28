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
    public partial class Form6 : Form
    {
        bool Them;
        SqlConnection conn = null;
        SqlDataAdapter daNhanVien = null;
        DataTable dtNhanVien = null;
        public Form6()
        {
            InitializeComponent();
            ChangeButtonState(0);
            LoadNV();
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
                this.txtMaNV.Enabled = true;
                this.txtMaNV.Focus();
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

      /*  public void ResetText()
        {
            this.txtDiaChi.ResetText();
            this.txtHoLot.ResetText();
            this.txtMaNV.ResetText();
            this.txtNgayNV.ResetText();
            this.txtDienThoai.ResetText();
            this.txtTen.ResetText();
        }*/

        public void LoadNV()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");

            daNhanVien = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            daNhanVien.Fill(dtNhanVien);
            dgvNHANVIEN.DataSource = dtNhanVien;
            this.ChangeButtonState(0);
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Trả lời", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                conn.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    int rowIndex = dgvNHANVIEN.CurrentCell.RowIndex;

                    string strMaNV = dgvNHANVIEN.Rows[rowIndex].Cells[0].Value.ToString();

                    cmd.CommandText = System.String.Concat("Delete From NhanVien Where MaNV = '" + strMaNV + "'");
                    cmd.CommandType = CommandType.Text; cmd.ExecuteNonQuery();

                    LoadNV();

                    MessageBox.Show("Xóa Thành Công!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Xóa Thất bại. Lỗi rồi!!!");
                }

                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Them = true;
            this.ChangeButtonState(1);
            this.ResetText();
            this.txtMaNV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (this.Them)
            {
                try
                {
                    int nu;
                    if (this.chkNu.Checked) nu = 1; else nu = 0;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("INSERT INTO NhanVien VALUES (N'" + this.txtMaNV.Text + "', N'" + this.txtHoLot.Text + "', N'" + this.txtTen.Text + "', " + nu + ", '" + this.txtNgayNV.Text + "', N'" + this.txtDiaChi.Text + "', N'" + this.txtDienThoai.Text + "', NULL)");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadNV();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException sqlE)
                {
                    MessageBox.Show(sqlE.ToString());
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Concat("UPDATE NhanVien SET Ho=N'"
                    + this.txtHoLot.Text + "', Ten=N'"
                    + this.txtTen.Text + "', Nu= "
                    + Convert.ToInt32(this.chkNu.Checked) + ", NgayNV= '"
                    + this.txtNgayNV.Text + "', DiaChi=N'"
                    + this.txtDiaChi.Text + "', DienThoai='"
                    + this.txtDienThoai.Text + "' WHERE MaNV ='"
                    + this.txtMaNV.Text + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                this.LoadNV();
                MessageBox.Show("Chỉnh sửa thành công");
                this.ChangeButtonState(0);

            }

            conn.Close();

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.ChangeButtonState(1);
            int rowIndex = dgvNHANVIEN.CurrentCell.RowIndex;
            int GioiTinh = Convert.ToInt32(dgvNHANVIEN.Rows[rowIndex].Cells[3].Value.ToString());
            this.txtMaNV.Text = dgvNHANVIEN.Rows[rowIndex].Cells[0].Value.ToString();
            this.txtHoLot.Text = dgvNHANVIEN.Rows[rowIndex].Cells[1].Value.ToString();
            this.txtTen.Text = dgvNHANVIEN.Rows[rowIndex].Cells[2].Value.ToString();
            this.chkNu.Checked = Convert.ToBoolean(GioiTinh);
            this.txtNgayNV.Text = dgvNHANVIEN.Rows[rowIndex].Cells[4].Value.ToString();
            this.txtDiaChi.Text = dgvNHANVIEN.Rows[rowIndex].Cells[5].Value.ToString();
            this.txtDienThoai.Text = dgvNHANVIEN.Rows[rowIndex].Cells[6].Value.ToString();
            this.txtMaNV.Enabled = false;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.ChangeButtonState(0);
            this.txtMaNV.ResetText();
            this.txtHoLot.ResetText();
            this.txtTen.ResetText();
            this.chkNu.Checked = false;
            this.txtNgayNV.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
