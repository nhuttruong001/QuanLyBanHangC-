namespace QuanLyBanHang
{
    partial class Form10
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
            this.cbxChonThanhPho = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongSoKH = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dgvKHTHEOTP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHTHEOTP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTongSoKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.cbxChonThanhPho);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Thành Phố :";
            // 
            // cbxChonThanhPho
            // 
            this.cbxChonThanhPho.FormattingEnabled = true;
            this.cbxChonThanhPho.Location = new System.Drawing.Point(173, 13);
            this.cbxChonThanhPho.Name = "cbxChonThanhPho";
            this.cbxChonThanhPho.Size = new System.Drawing.Size(207, 24);
            this.cbxChonThanhPho.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(397, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(44, 26);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng Số KH :";
            // 
            // txtTongSoKH
            // 
            this.txtTongSoKH.Location = new System.Drawing.Point(729, 11);
            this.txtTongSoKH.Name = "txtTongSoKH";
            this.txtTongSoKH.Size = new System.Drawing.Size(100, 22);
            this.txtTongSoKH.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvKHTHEOTP);
            this.panel2.Location = new System.Drawing.Point(13, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 346);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTroVe);
            this.panel3.Location = new System.Drawing.Point(13, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 53);
            this.panel3.TabIndex = 2;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(729, 3);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(100, 39);
            this.btnTroVe.TabIndex = 0;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // dgvKHTHEOTP
            // 
            this.dgvKHTHEOTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHTHEOTP.Location = new System.Drawing.Point(-1, -1);
            this.dgvKHTHEOTP.Name = "dgvKHTHEOTP";
            this.dgvKHTHEOTP.RowTemplate.Height = 24;
            this.dgvKHTHEOTP.Size = new System.Drawing.Size(852, 347);
            this.dgvKHTHEOTP.TabIndex = 0;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 492);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form10";
            this.Text = "Quản Lý Khách Hàng Theo Thành Phố";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHTHEOTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbxChonThanhPho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongSoKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvKHTHEOTP;
    }
}