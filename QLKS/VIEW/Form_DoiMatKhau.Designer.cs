
namespace QLKS
{
    partial class Form_DoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MatKhauCu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_NhapLai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Doi = new System.Windows.Forms.Button();
            this.button_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // textBox_MatKhauCu
            // 
            this.textBox_MatKhauCu.Location = new System.Drawing.Point(198, 133);
            this.textBox_MatKhauCu.Name = "textBox_MatKhauCu";
            this.textBox_MatKhauCu.Size = new System.Drawing.Size(183, 22);
            this.textBox_MatKhauCu.TabIndex = 1;
            this.textBox_MatKhauCu.UseSystemPasswordChar = true;
            this.textBox_MatKhauCu.Leave += new System.EventHandler(this.textBox_MatKhauCu_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 111;
            this.label9.Text = "Mật khẩu cũ";
            // 
            // textBox_MatKhauMoi
            // 
            this.textBox_MatKhauMoi.Location = new System.Drawing.Point(198, 168);
            this.textBox_MatKhauMoi.Name = "textBox_MatKhauMoi";
            this.textBox_MatKhauMoi.Size = new System.Drawing.Size(183, 22);
            this.textBox_MatKhauMoi.TabIndex = 2;
            this.textBox_MatKhauMoi.UseSystemPasswordChar = true;
            this.textBox_MatKhauMoi.Leave += new System.EventHandler(this.textBox_MatKhauMoi_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 17);
            this.label16.TabIndex = 108;
            this.label16.Text = "Mật khẩu mới ";
            // 
            // textBox_NhapLai
            // 
            this.textBox_NhapLai.Location = new System.Drawing.Point(198, 206);
            this.textBox_NhapLai.Name = "textBox_NhapLai";
            this.textBox_NhapLai.Size = new System.Drawing.Size(183, 22);
            this.textBox_NhapLai.TabIndex = 3;
            this.textBox_NhapLai.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 113;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // button_Doi
            // 
            this.button_Doi.Location = new System.Drawing.Point(68, 286);
            this.button_Doi.Name = "button_Doi";
            this.button_Doi.Size = new System.Drawing.Size(109, 38);
            this.button_Doi.TabIndex = 4;
            this.button_Doi.Text = "Đổi ";
            this.button_Doi.UseVisualStyleBackColor = true;
            this.button_Doi.Click += new System.EventHandler(this.button_Doi_Click);
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(244, 286);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(109, 38);
            this.button_Huy.TabIndex = 5;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // Form_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 368);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.button_Doi);
            this.Controls.Add(this.textBox_NhapLai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MatKhauCu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_MatKhauMoi);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Name = "Form_DoiMatKhau";
            this.Text = "Form_DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MatKhauCu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_MatKhauMoi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_NhapLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Doi;
        private System.Windows.Forms.Button button_Huy;
    }
}