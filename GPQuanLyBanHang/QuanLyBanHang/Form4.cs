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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadData();
            ChangeButtonState(0);
        }

        String sqlConnection = @"Data Source=DESKTOP-I2RPGMO\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daThanhPho = null;
        DataTable dtThanhPho = null;
        bool Them;


        public void LoadData(int disableInput = 0)
        {
            try
            {
                conn = new SqlConnection(sqlConnection);
                daThanhPho = new SqlDataAdapter("SELECT * FROM THANHPHO", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();

                daThanhPho.Fill(dtThanhPho);

                dgvTHANHPHO.DataSource = dtThanhPho;
                dgvTHANHPHO.AutoResizeColumns();

            }
            catch (SqlException sqlExpception)
            {
                MessageBox.Show(sqlExpception.ToString());
            }
            if (disableInput == 1)
            {
                ChangeButtonState(0);
            }
        }

        public void ChangeButtonState(int state)
        {
            if (state == 0)
            {

                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel1.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
            }
            else
            {

                this.btnLuu.Enabled = true;
                this.btnHuyBo.Enabled = true;
                this.panel1.Enabled = true;
                this.txtThanhPho.Enabled = true;
                this.btnThem.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnTroVe.Enabled = false;

                this.txtThanhPho.Focus();
            }
        }

       /* public void ResetText()
        {
            this.txtTenThanhPho.ResetText();
            this.txtThanhPho.ResetText();
            this.txtThanhPho.Focus();
        }*/

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dtThanhPho.Dispose();
            dtThanhPho = null;
            conn = null;
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData(1);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.ChangeButtonState(1);
            this.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvTHANHPHO.CurrentCell.RowIndex;
            String strThanhPho = dgvTHANHPHO.Rows[index].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mã thành phố: " + strThanhPho + " ?", "Trả lời", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("Delete From ThanhPho Where ThanhPho = '"
                        + strThanhPho + "'");
                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteNonQuery();

                    LoadData();

                    MessageBox.Show("Đã xóa xong!");

                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.ToString());
                }
                conn.Close();
            }

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {

            this.ResetText();
            this.ChangeButtonState(0);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (Them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("insert into ThanhPho VALUES('"
                        + this.txtThanhPho.Text
                        + "',N'"
                        + this.txtTenThanhPho.Text
                        + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm Thành công!");
                }
                catch (SqlException sqlException)
                {
                    MessageBox.Show(sqlException.ToString());
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                int rowIndex = dgvTHANHPHO.CurrentCell.RowIndex;
                String maThanhPho = dgvTHANHPHO.Rows[rowIndex].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("UPDATE THANHPHO SET TenThanhPho=N'"
                    + this.txtTenThanhPho.Text
                    + "' WHERE ThanhPho ='"
                    + maThanhPho
                    + "'");

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật thành công");
                this.LoadData();
                ChangeButtonState(0);
            }
            ResetText();
            conn.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Them = false;
            int rowIndex = this.dgvTHANHPHO.CurrentCell.RowIndex;
            this.txtThanhPho.Text = this.dgvTHANHPHO.Rows[rowIndex].Cells[0].Value.ToString();
            this.txtTenThanhPho.Text = this.dgvTHANHPHO.Rows[rowIndex].Cells[1].Value.ToString();
            ChangeButtonState(1);
            this.txtThanhPho.Enabled = false;
            this.txtTenThanhPho.Focus();
        }

        private void txtTenThanhPho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(sender, e);
            }
        }
    }
}
