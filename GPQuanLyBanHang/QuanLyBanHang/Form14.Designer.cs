namespace QuanLyBanHang
{
    partial class Form14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongSoHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxMaHD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChiTietHDtheoHD = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDtheoHD)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTongSoHD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.cbxMaHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 55);
            this.panel1.TabIndex = 4;
            // 
            // txtTongSoHD
            // 
            this.txtTongSoHD.Location = new System.Drawing.Point(706, 14);
            this.txtTongSoHD.Name = "txtTongSoHD";
            this.txtTongSoHD.Size = new System.Drawing.Size(82, 22);
            this.txtTongSoHD.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng số HĐ :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(380, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(44, 26);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbxMaHD
            // 
            this.cbxMaHD.FormattingEnabled = true;
            this.cbxMaHD.Location = new System.Drawing.Point(103, 11);
            this.cbxMaHD.Name = "cbxMaHD";
            this.cbxMaHD.Size = new System.Drawing.Size(262, 24);
            this.cbxMaHD.TabIndex = 1;
            this.cbxMaHD.SelectedIndexChanged += new System.EventHandler(this.cbxMaHD_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐ :";
            // 
            // dgvChiTietHDtheoHD
            // 
            this.dgvChiTietHDtheoHD.AllowUserToAddRows = false;
            this.dgvChiTietHDtheoHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDtheoHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.tenSP,
            this.Column3});
            this.dgvChiTietHDtheoHD.Location = new System.Drawing.Point(12, 69);
            this.dgvChiTietHDtheoHD.Name = "dgvChiTietHDtheoHD";
            this.dgvChiTietHDtheoHD.RowTemplate.Height = 24;
            this.dgvChiTietHDtheoHD.Size = new System.Drawing.Size(795, 347);
            this.dgvChiTietHDtheoHD.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTroVe);
            this.panel3.Location = new System.Drawing.Point(13, 420);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 39);
            this.panel3.TabIndex = 6;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(694, 0);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(100, 39);
            this.btnTroVe.TabIndex = 0;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "MaHD";
            this.maHD.HeaderText = "Mã HĐ";
            this.maHD.Name = "maHD";
            this.maHD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tenSP
            // 
            this.tenSP.DataPropertyName = "MaSP";
            this.tenSP.HeaderText = "Tên SP";
            this.tenSP.Name = "tenSP";
            this.tenSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tenSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 471);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvChiTietHDtheoHD);
            this.Controls.Add(this.panel1);
            this.Name = "Form14";
            this.Text = "Quản Lý Chi Tiết Hóa Đơn Theo Hóa Đơn";
            this.Load += new System.EventHandler(this.Form14_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDtheoHD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbxMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChiTietHDtheoHD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.TextBox txtTongSoHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}