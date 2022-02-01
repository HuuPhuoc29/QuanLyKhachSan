
namespace QLKS
{
    partial class Form_KhachHang
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
            this.DS_KH = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_LamMoi = new System.Windows.Forms.Button();
            this.button_ThoatKH = new System.Windows.Forms.Button();
            this.button_TimKiemKH = new System.Windows.Forms.Button();
            this.button_ChinhSuaKH = new System.Windows.Forms.Button();
            this.button_XoaKH = new System.Windows.Forms.Button();
            this.button_ThemKH = new System.Windows.Forms.Button();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.textBox_SDT = new System.Windows.Forms.TextBox();
            this.textBox_CMND = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_MaKhachHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_GioiTinh = new System.Windows.Forms.ComboBox();
            this.textBox_TenKhachHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DS_KH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DS_KH
            // 
            this.DS_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DS_KH.Location = new System.Drawing.Point(0, 20);
            this.DS_KH.Name = "DS_KH";
            this.DS_KH.RowHeadersWidth = 51;
            this.DS_KH.RowTemplate.Height = 24;
            this.DS_KH.Size = new System.Drawing.Size(870, 421);
            this.DS_KH.TabIndex = 3;
            this.DS_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DS_KH_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_LamMoi);
            this.groupBox1.Controls.Add(this.button_ThoatKH);
            this.groupBox1.Controls.Add(this.button_TimKiemKH);
            this.groupBox1.Controls.Add(this.button_ChinhSuaKH);
            this.groupBox1.Controls.Add(this.button_XoaKH);
            this.groupBox1.Controls.Add(this.button_ThemKH);
            this.groupBox1.Controls.Add(this.textBox_DiaChi);
            this.groupBox1.Controls.Add(this.textBox_SDT);
            this.groupBox1.Controls.Add(this.textBox_CMND);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_MaKhachHang);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_GioiTinh);
            this.groupBox1.Controls.Add(this.textBox_TenKhachHang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 255);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_LamMoi
            // 
            this.button_LamMoi.Location = new System.Drawing.Point(590, 185);
            this.button_LamMoi.Name = "button_LamMoi";
            this.button_LamMoi.Size = new System.Drawing.Size(117, 40);
            this.button_LamMoi.TabIndex = 72;
            this.button_LamMoi.Text = "Làm mới";
            this.button_LamMoi.UseVisualStyleBackColor = true;
            this.button_LamMoi.Click += new System.EventHandler(this.button_LamMoi_Click);
            // 
            // button_ThoatKH
            // 
            this.button_ThoatKH.Location = new System.Drawing.Point(735, 185);
            this.button_ThoatKH.Name = "button_ThoatKH";
            this.button_ThoatKH.Size = new System.Drawing.Size(117, 40);
            this.button_ThoatKH.TabIndex = 71;
            this.button_ThoatKH.Text = "Thoát";
            this.button_ThoatKH.UseVisualStyleBackColor = true;
            this.button_ThoatKH.Click += new System.EventHandler(this.button_ThoatNV_Click);
            // 
            // button_TimKiemKH
            // 
            this.button_TimKiemKH.Location = new System.Drawing.Point(445, 185);
            this.button_TimKiemKH.Name = "button_TimKiemKH";
            this.button_TimKiemKH.Size = new System.Drawing.Size(117, 40);
            this.button_TimKiemKH.TabIndex = 70;
            this.button_TimKiemKH.Text = "Tìm kiếm";
            this.button_TimKiemKH.UseVisualStyleBackColor = true;
            this.button_TimKiemKH.Click += new System.EventHandler(this.button_TimKiemKH_Click);
            // 
            // button_ChinhSuaKH
            // 
            this.button_ChinhSuaKH.Location = new System.Drawing.Point(300, 185);
            this.button_ChinhSuaKH.Name = "button_ChinhSuaKH";
            this.button_ChinhSuaKH.Size = new System.Drawing.Size(117, 40);
            this.button_ChinhSuaKH.TabIndex = 69;
            this.button_ChinhSuaKH.Text = "Chỉnh sửa";
            this.button_ChinhSuaKH.UseVisualStyleBackColor = true;
            this.button_ChinhSuaKH.Click += new System.EventHandler(this.button_ChinhSuaKH_Click);
            // 
            // button_XoaKH
            // 
            this.button_XoaKH.Location = new System.Drawing.Point(155, 185);
            this.button_XoaKH.Name = "button_XoaKH";
            this.button_XoaKH.Size = new System.Drawing.Size(117, 40);
            this.button_XoaKH.TabIndex = 68;
            this.button_XoaKH.Text = "Xóa";
            this.button_XoaKH.UseVisualStyleBackColor = true;
            this.button_XoaKH.Click += new System.EventHandler(this.button_XoaKH_Click);
            // 
            // button_ThemKH
            // 
            this.button_ThemKH.Location = new System.Drawing.Point(10, 185);
            this.button_ThemKH.Name = "button_ThemKH";
            this.button_ThemKH.Size = new System.Drawing.Size(117, 40);
            this.button_ThemKH.TabIndex = 67;
            this.button_ThemKH.Text = "Thêm";
            this.button_ThemKH.UseVisualStyleBackColor = true;
            this.button_ThemKH.Click += new System.EventHandler(this.button_ThemKH_Click);
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Location = new System.Drawing.Point(582, 123);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(183, 22);
            this.textBox_DiaChi.TabIndex = 64;
            this.textBox_DiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.Location = new System.Drawing.Point(582, 83);
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_SDT.Size = new System.Drawing.Size(183, 22);
            this.textBox_SDT.TabIndex = 63;
            this.textBox_SDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_CMND
            // 
            this.textBox_CMND.Location = new System.Drawing.Point(582, 43);
            this.textBox_CMND.Name = "textBox_CMND";
            this.textBox_CMND.Size = new System.Drawing.Size(183, 22);
            this.textBox_CMND.TabIndex = 62;
            this.textBox_CMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(497, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 61;
            this.label10.Text = "Địa chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(496, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 60;
            this.label11.Text = "CMND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(456, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 18);
            this.label12.TabIndex = 59;
            this.label12.Text = "Số điện thoại";
            // 
            // textBox_MaKhachHang
            // 
            this.textBox_MaKhachHang.Location = new System.Drawing.Point(190, 43);
            this.textBox_MaKhachHang.Name = "textBox_MaKhachHang";
            this.textBox_MaKhachHang.Size = new System.Drawing.Size(183, 22);
            this.textBox_MaKhachHang.TabIndex = 58;
            this.textBox_MaKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 57;
            this.label8.Text = "Mã khách hàng";
            // 
            // comboBox_GioiTinh
            // 
            this.comboBox_GioiTinh.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ"});
            this.comboBox_GioiTinh.FormattingEnabled = true;
            this.comboBox_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_GioiTinh.Location = new System.Drawing.Point(190, 123);
            this.comboBox_GioiTinh.Name = "comboBox_GioiTinh";
            this.comboBox_GioiTinh.Size = new System.Drawing.Size(183, 24);
            this.comboBox_GioiTinh.TabIndex = 55;
            // 
            // textBox_TenKhachHang
            // 
            this.textBox_TenKhachHang.Location = new System.Drawing.Point(190, 83);
            this.textBox_TenKhachHang.Name = "textBox_TenKhachHang";
            this.textBox_TenKhachHang.Size = new System.Drawing.Size(183, 22);
            this.textBox_TenKhachHang.TabIndex = 54;
            this.textBox_TenKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 18);
            this.label9.TabIndex = 51;
            this.label9.Text = "Tên khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DS_KH);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 442);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // Form_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(891, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_KhachHang";
            this.Text = "Khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.DS_KH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.DataGridView DS_KH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ThoatKH;
        private System.Windows.Forms.Button button_TimKiemKH;
        private System.Windows.Forms.Button button_ChinhSuaKH;
        private System.Windows.Forms.Button button_XoaKH;
        private System.Windows.Forms.Button button_ThemKH;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.TextBox textBox_SDT;
        private System.Windows.Forms.TextBox textBox_CMND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_MaKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_GioiTinh;
        private System.Windows.Forms.TextBox textBox_TenKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_LamMoi;
    }
}