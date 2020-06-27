namespace QuanLyBanHang
{
    partial class Form8
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtNgLapHD = new System.Windows.Forms.TextBox();
            this.txtNgLapNH = new System.Windows.Forms.TextBox();
            this.cbxMaKH = new System.Windows.Forms.ComboBox();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.dgvHOADON = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxMaNV);
            this.panel1.Controls.Add(this.cbxMaKH);
            this.panel1.Controls.Add(this.txtNgLapNH);
            this.panel1.Controls.Add(this.txtNgLapHD);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 124);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã KH :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã NV :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Lập Hóa Đơn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Lập Nhận Hàng :";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(116, 15);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(226, 22);
            this.txtMaHD.TabIndex = 5;
            // 
            // txtNgLapHD
            // 
            this.txtNgLapHD.Location = new System.Drawing.Point(672, 15);
            this.txtNgLapHD.Name = "txtNgLapHD";
            this.txtNgLapHD.Size = new System.Drawing.Size(194, 22);
            this.txtNgLapHD.TabIndex = 6;
            // 
            // txtNgLapNH
            // 
            this.txtNgLapNH.Location = new System.Drawing.Point(676, 48);
            this.txtNgLapNH.Name = "txtNgLapNH";
            this.txtNgLapNH.Size = new System.Drawing.Size(190, 22);
            this.txtNgLapNH.TabIndex = 7;
            // 
            // cbxMaKH
            // 
            this.cbxMaKH.FormattingEnabled = true;
            this.cbxMaKH.Location = new System.Drawing.Point(116, 45);
            this.cbxMaKH.Name = "cbxMaKH";
            this.cbxMaKH.Size = new System.Drawing.Size(288, 24);
            this.cbxMaKH.TabIndex = 8;
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(116, 85);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(288, 24);
            this.cbxMaNV.TabIndex = 9;
            // 
            // dgvHOADON
            // 
            this.dgvHOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHOADON.Location = new System.Drawing.Point(13, 143);
            this.dgvHOADON.Name = "dgvHOADON";
            this.dgvHOADON.RowTemplate.Height = 24;
            this.dgvHOADON.Size = new System.Drawing.Size(887, 271);
            this.dgvHOADON.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTroVe);
            this.panel3.Controls.Add(this.btnHuyBo);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnReLoad);
            this.panel3.Location = new System.Drawing.Point(12, 420);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 48);
            this.panel3.TabIndex = 4;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(788, 0);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(100, 38);
            this.btnTroVe.TabIndex = 6;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(641, 0);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(100, 38);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(486, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 38);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(324, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 38);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(161, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 38);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnReLoad
            // 
            this.btnReLoad.Location = new System.Drawing.Point(0, 0);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(100, 38);
            this.btnReLoad.TabIndex = 1;
            this.btnReLoad.Text = "ReLoad";
            this.btnReLoad.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 494);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvHOADON);
            this.Controls.Add(this.panel1);
            this.Name = "Form8";
            this.Text = "Quản Lý Danh Mục Hóa Đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.ComboBox cbxMaKH;
        private System.Windows.Forms.TextBox txtNgLapNH;
        private System.Windows.Forms.TextBox txtNgLapHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHOADON;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnReLoad;
    }
}