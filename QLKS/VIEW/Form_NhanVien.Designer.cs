
namespace QLKS
{
    partial class Form_NhanVien
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
            this.DS_NV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.comboBoxChucVu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ThoatNV = new System.Windows.Forms.Button();
            this.button_TimKiemNV = new System.Windows.Forms.Button();
            this.button_ChinhSuaNV = new System.Windows.Forms.Button();
            this.button_XoaNV = new System.Windows.Forms.Button();
            this.button_ThemNV = new System.Windows.Forms.Button();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.boxDiaChi = new System.Windows.Forms.TextBox();
            this.boxSDT = new System.Windows.Forms.TextBox();
            this.boxCMND = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.boxMa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boxNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.boxGioiTinh = new System.Windows.Forms.ComboBox();
            this.boxTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DS_NV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DS_NV
            // 
            this.DS_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DS_NV.Location = new System.Drawing.Point(0, 20);
            this.DS_NV.Name = "DS_NV";
            this.DS_NV.RowHeadersWidth = 51;
            this.DS_NV.RowTemplate.Height = 24;
            this.DS_NV.Size = new System.Drawing.Size(1007, 434);
            this.DS_NV.TabIndex = 3;
            this.DS_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DS_NV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLamMoi);
            this.groupBox1.Controls.Add(this.comboBoxChucVu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_ThoatNV);
            this.groupBox1.Controls.Add(this.button_TimKiemNV);
            this.groupBox1.Controls.Add(this.button_ChinhSuaNV);
            this.groupBox1.Controls.Add(this.button_XoaNV);
            this.groupBox1.Controls.Add(this.button_ThemNV);
            this.groupBox1.Controls.Add(this.textBox_MatKhau);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.boxDiaChi);
            this.groupBox1.Controls.Add(this.boxSDT);
            this.groupBox1.Controls.Add(this.boxCMND);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.boxMa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.boxNgaySinh);
            this.groupBox1.Controls.Add(this.boxGioiTinh);
            this.groupBox1.Controls.Add(this.boxTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 271);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Location = new System.Drawing.Point(704, 206);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(117, 40);
            this.buttonLamMoi.TabIndex = 74;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ"});
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Items.AddRange(new object[] {
            "Quản lí",
            "Nhân viên"});
            this.comboBoxChucVu.Location = new System.Drawing.Point(817, 81);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(183, 24);
            this.comboBoxChucVu.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(723, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Chức vụ";
            // 
            // button_ThoatNV
            // 
            this.button_ThoatNV.Location = new System.Drawing.Point(871, 206);
            this.button_ThoatNV.Name = "button_ThoatNV";
            this.button_ThoatNV.Size = new System.Drawing.Size(117, 40);
            this.button_ThoatNV.TabIndex = 71;
            this.button_ThoatNV.Text = "Thoát";
            this.button_ThoatNV.UseVisualStyleBackColor = true;
            this.button_ThoatNV.Click += new System.EventHandler(this.button_ThoatNV_Click);
            // 
            // button_TimKiemNV
            // 
            this.button_TimKiemNV.Location = new System.Drawing.Point(535, 206);
            this.button_TimKiemNV.Name = "button_TimKiemNV";
            this.button_TimKiemNV.Size = new System.Drawing.Size(117, 40);
            this.button_TimKiemNV.TabIndex = 70;
            this.button_TimKiemNV.Text = "Tìm kiếm";
            this.button_TimKiemNV.UseVisualStyleBackColor = true;
            this.button_TimKiemNV.Click += new System.EventHandler(this.button_TimKiemNV_Click);
            // 
            // button_ChinhSuaNV
            // 
            this.button_ChinhSuaNV.Location = new System.Drawing.Point(370, 206);
            this.button_ChinhSuaNV.Name = "button_ChinhSuaNV";
            this.button_ChinhSuaNV.Size = new System.Drawing.Size(117, 40);
            this.button_ChinhSuaNV.TabIndex = 69;
            this.button_ChinhSuaNV.Text = "Chỉnh sửa";
            this.button_ChinhSuaNV.UseVisualStyleBackColor = true;
            this.button_ChinhSuaNV.Click += new System.EventHandler(this.button_ChinhSuaNV_Click);
            // 
            // button_XoaNV
            // 
            this.button_XoaNV.Location = new System.Drawing.Point(205, 206);
            this.button_XoaNV.Name = "button_XoaNV";
            this.button_XoaNV.Size = new System.Drawing.Size(117, 40);
            this.button_XoaNV.TabIndex = 68;
            this.button_XoaNV.Text = "Xóa";
            this.button_XoaNV.UseVisualStyleBackColor = true;
            this.button_XoaNV.Click += new System.EventHandler(this.button_XoaNV_Click);
            // 
            // button_ThemNV
            // 
            this.button_ThemNV.Location = new System.Drawing.Point(40, 206);
            this.button_ThemNV.Name = "button_ThemNV";
            this.button_ThemNV.Size = new System.Drawing.Size(117, 40);
            this.button_ThemNV.TabIndex = 67;
            this.button_ThemNV.Text = "Thêm";
            this.button_ThemNV.UseVisualStyleBackColor = true;
            this.button_ThemNV.Click += new System.EventHandler(this.button_ThemNV_Click);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(817, 125);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(183, 22);
            this.textBox_MatKhau.TabIndex = 66;
            this.textBox_MatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(716, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 65;
            this.label13.Text = "Mật khẩu";
            // 
            // boxDiaChi
            // 
            this.boxDiaChi.Location = new System.Drawing.Point(817, 42);
            this.boxDiaChi.Name = "boxDiaChi";
            this.boxDiaChi.Size = new System.Drawing.Size(183, 22);
            this.boxDiaChi.TabIndex = 64;
            this.boxDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxSDT
            // 
            this.boxSDT.Location = new System.Drawing.Point(489, 82);
            this.boxSDT.Name = "boxSDT";
            this.boxSDT.Size = new System.Drawing.Size(183, 22);
            this.boxSDT.TabIndex = 63;
            this.boxSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxCMND
            // 
            this.boxCMND.Location = new System.Drawing.Point(489, 42);
            this.boxCMND.Name = "boxCMND";
            this.boxCMND.Size = new System.Drawing.Size(183, 22);
            this.boxCMND.TabIndex = 62;
            this.boxCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(732, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 61;
            this.label10.Text = "Địa chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(403, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 60;
            this.label11.Text = "CMND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(363, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 18);
            this.label12.TabIndex = 59;
            this.label12.Text = "Số điện thoại";
            // 
            // boxMa
            // 
            this.boxMa.Location = new System.Drawing.Point(139, 41);
            this.boxMa.Name = "boxMa";
            this.boxMa.Size = new System.Drawing.Size(183, 22);
            this.boxMa.TabIndex = 58;
            this.boxMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 57;
            this.label8.Text = "Mã nhân viên";
            // 
            // boxNgaySinh
            // 
            this.boxNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.boxNgaySinh.Location = new System.Drawing.Point(489, 124);
            this.boxNgaySinh.Name = "boxNgaySinh";
            this.boxNgaySinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxNgaySinh.Size = new System.Drawing.Size(183, 22);
            this.boxNgaySinh.TabIndex = 56;
            // 
            // boxGioiTinh
            // 
            this.boxGioiTinh.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ"});
            this.boxGioiTinh.FormattingEnabled = true;
            this.boxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.boxGioiTinh.Location = new System.Drawing.Point(139, 121);
            this.boxGioiTinh.Name = "boxGioiTinh";
            this.boxGioiTinh.Size = new System.Drawing.Size(183, 24);
            this.boxGioiTinh.TabIndex = 55;
            // 
            // boxTen
            // 
            this.boxTen.Location = new System.Drawing.Point(139, 81);
            this.boxTen.Name = "boxTen";
            this.boxTen.Size = new System.Drawing.Size(183, 22);
            this.boxTen.TabIndex = 54;
            this.boxTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 53;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 18);
            this.label9.TabIndex = 51;
            this.label9.Text = "Tên nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DS_NV);
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1007, 454);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1031, 755);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_NhanVien";
            this.Text = "Nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.DS_NV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.DataGridView DS_NV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ThoatNV;
        private System.Windows.Forms.Button button_TimKiemNV;
        private System.Windows.Forms.Button button_ChinhSuaNV;
        private System.Windows.Forms.Button button_XoaNV;
        private System.Windows.Forms.Button button_ThemNV;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox boxDiaChi;
        private System.Windows.Forms.TextBox boxSDT;
        private System.Windows.Forms.TextBox boxCMND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox boxMa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker boxNgaySinh;
        private System.Windows.Forms.ComboBox boxGioiTinh;
        private System.Windows.Forms.TextBox boxTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLamMoi;
    }
}