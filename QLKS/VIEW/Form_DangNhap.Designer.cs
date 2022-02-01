
namespace QLKS
{
    partial class Form_DangNhap
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

        private void InitializeComponent()
        {
            this.panelUsername = new System.Windows.Forms.Panel();
            this.comboBox_ChucVu = new System.Windows.Forms.ComboBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxUsername = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_Ma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUsername.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsername
            // 
            this.panelUsername.Controls.Add(this.comboBox_ChucVu);
            this.panelUsername.Controls.Add(this.labelUsername);
            this.panelUsername.Location = new System.Drawing.Point(83, 205);
            this.panelUsername.Margin = new System.Windows.Forms.Padding(4);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(463, 53);
            this.panelUsername.TabIndex = 2;
            // 
            // comboBox_ChucVu
            // 
            this.comboBox_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ChucVu.FormattingEnabled = true;
            this.comboBox_ChucVu.Location = new System.Drawing.Point(181, 9);
            this.comboBox_ChucVu.Name = "comboBox_ChucVu";
            this.comboBox_ChucVu.Size = new System.Drawing.Size(231, 33);
            this.comboBox_ChucVu.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelUsername.Location = new System.Drawing.Point(4, 18);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(143, 24);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Mã nhân viên:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.textBox_MatKhau);
            this.panel1.Location = new System.Drawing.Point(83, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 54);
            this.panel1.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPassword.Location = new System.Drawing.Point(4, 18);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(104, 24);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Mật khẩu:";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBox_MatKhau.Location = new System.Drawing.Point(181, 14);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(231, 32);
            this.textBox_MatKhau.TabIndex = 1;
            this.textBox_MatKhau.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.Location = new System.Drawing.Point(203, 328);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(152, 41);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.Location = new System.Drawing.Point(203, 375);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(152, 41);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelMain.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelMain.Location = new System.Drawing.Point(29, 92);
            this.labelMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(489, 46);
            this.labelMain.TabIndex = 2;
            this.labelMain.Text = "Đăng nhập vào hệ thống!";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelWelcome.ForeColor = System.Drawing.Color.Red;
            this.labelWelcome.Location = new System.Drawing.Point(179, 31);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(246, 46);
            this.labelWelcome.TabIndex = 6;
            this.labelWelcome.Text = "WELCOME!";
            // 
            // pictureBoxUsername
            // 
            this.pictureBoxUsername.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUsername.Name = "pictureBoxUsername";
            this.pictureBoxUsername.Size = new System.Drawing.Size(133, 62);
            this.pictureBoxUsername.TabIndex = 2;
            this.pictureBoxUsername.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(133, 62);
            this.pictureBoxPassword.TabIndex = 1;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox_Ma);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(83, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 53);
            this.panel2.TabIndex = 1;
            // 
            // comboBox_Ma
            // 
            this.comboBox_Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Ma.FormattingEnabled = true;
            this.comboBox_Ma.Items.AddRange(new object[] {
            "Quản lí",
            "Nhân viên"});
            this.comboBox_Ma.Location = new System.Drawing.Point(181, 14);
            this.comboBox_Ma.Name = "comboBox_Ma";
            this.comboBox_Ma.Size = new System.Drawing.Size(231, 33);
            this.comboBox_Ma.TabIndex = 1;
            this.comboBox_Ma.Leave += new System.EventHandler(this.comboBox_ChucVu_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chức vụ :";
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.pictureBoxUsername);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxUsername;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ChucVu;
        private System.Windows.Forms.ComboBox comboBox_Ma;
    }
}
