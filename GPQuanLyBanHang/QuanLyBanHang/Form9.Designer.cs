namespace QuanLyBanHang
{
    partial class Form9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMaHD = new System.Windows.Forms.ComboBox();
            this.cbxMaSP = new System.Windows.Forms.ComboBox();
            this.cbxSoLuong = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.dgvCHITIETHOADON = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETHOADON)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxSoLuong);
            this.panel1.Controls.Add(this.cbxMaSP);
            this.panel1.Controls.Add(this.cbxMaHD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 122);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng :";
            // 
            // cbxMaHD
            // 
            this.cbxMaHD.FormattingEnabled = true;
            this.cbxMaHD.Location = new System.Drawing.Point(130, 13);
            this.cbxMaHD.Name = "cbxMaHD";
            this.cbxMaHD.Size = new System.Drawing.Size(199, 24);
            this.cbxMaHD.TabIndex = 3;
            // 
            // cbxMaSP
            // 
            this.cbxMaSP.FormattingEnabled = true;
            this.cbxMaSP.Location = new System.Drawing.Point(130, 49);
            this.cbxMaSP.Name = "cbxMaSP";
            this.cbxMaSP.Size = new System.Drawing.Size(199, 24);
            this.cbxMaSP.TabIndex = 4;
            // 
            // cbxSoLuong
            // 
            this.cbxSoLuong.Location = new System.Drawing.Point(130, 81);
            this.cbxSoLuong.Name = "cbxSoLuong";
            this.cbxSoLuong.Size = new System.Drawing.Size(100, 22);
            this.cbxSoLuong.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCHITIETHOADON);
            this.panel2.Location = new System.Drawing.Point(13, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 261);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnHuyBo);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnReLoad);
            this.panel3.Location = new System.Drawing.Point(12, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 91);
            this.panel3.TabIndex = 3;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(472, 409);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(56, 91);
            this.btnTroVe.TabIndex = 6;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(317, 53);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(168, 53);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(100, 38);
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(3, 53);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 38);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(317, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(168, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 38);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnReLoad
            // 
            this.btnReLoad.Location = new System.Drawing.Point(3, 0);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(100, 38);
            this.btnReLoad.TabIndex = 0;
            this.btnReLoad.Text = "ReLoad";
            this.btnReLoad.UseVisualStyleBackColor = true;
            // 
            // dgvCHITIETHOADON
            // 
            this.dgvCHITIETHOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCHITIETHOADON.Location = new System.Drawing.Point(0, 0);
            this.dgvCHITIETHOADON.Name = "dgvCHITIETHOADON";
            this.dgvCHITIETHOADON.RowTemplate.Height = 24;
            this.dgvCHITIETHOADON.Size = new System.Drawing.Size(532, 261);
            this.dgvCHITIETHOADON.TabIndex = 0;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 512);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form9";
            this.Text = "Quản Lý Danh Mục Chi Tiết Hóa Đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETHOADON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cbxSoLuong;
        private System.Windows.Forms.ComboBox cbxMaSP;
        private System.Windows.Forms.ComboBox cbxMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvCHITIETHOADON;
    }
}