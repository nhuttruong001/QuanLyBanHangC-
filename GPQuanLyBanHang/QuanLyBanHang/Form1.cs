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

        private void danhMụcKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.Text = "Quản lý Danh mục Khách Hàng";
            frm.ShowDialog();
        }

        private void danhMụcNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form6();
            frm.Text = "Quản lý Danh mục Nhân Viên";
            frm.ShowDialog();
        }

        private void danhMụcSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form7();
            frm.Text = "Quản lý Danh mục Sản Phẩm";
            frm.ShowDialog();
        }

        private void danhMụcHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form8();
            frm.Text = "Quản lý Danh mục Hóa Đơn";
            frm.ShowDialog();
        }

        private void danhMụcChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form9();
            frm.Text = "Quản lý Danh mục Chi Tiết Hóa Đơn";
            frm.ShowDialog();
        }

        private void kháchHàngTheoThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form10();
            frm.Text = "Quản lý Khách Hàng Theo Thành Phố";
            frm.ShowDialog();
        }

        private void hóaĐơnTheoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form11();
            frm.Text = "Quản lý Hóa Đơn Theo Khách Hàng";
            frm.ShowDialog();
        }

        private void hóaĐơnTheoSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form12();
            frm.Text = "Quản lý Hóa Đơn Theo Sản Phẩm";
            frm.ShowDialog();
        }

        private void hóaĐơnTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form13();
            frm.Text = "Quản lý Hóa Đơn Theo Nhân Viên";
            frm.ShowDialog();
        }

        private void chiTiếtHóaĐơnTheoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form14();
            frm.Text = "Quản lý Hóa Đơn Theo Chi Tiết Hóa Đơn";
            frm.ShowDialog();
        }

        private void đaCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form15();
            frm.Text = "Quản lý Đa Cấp";
            frm.ShowDialog();
        }
    }
}
