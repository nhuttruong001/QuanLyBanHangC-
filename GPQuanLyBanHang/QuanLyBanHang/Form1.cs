using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void XemDanhMuc(int intDanhMuc)
        {
            Form frm = new Form3();
            frm.Text = intDanhMuc.ToString();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmlogin();
        }

        private void frmlogin()
        {
            Form frm = new Form2();
            frm.ShowDialog();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
             DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if ( traloi == DialogResult.OK)
            Application.Exit();
        }

        private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }

        private void danhMụcChiTiếtHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void danhMụcThànhPhốToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Text = "Quản lý Danh mục Thành Phố";
            frm.ShowDialog();
        }
    }
}
