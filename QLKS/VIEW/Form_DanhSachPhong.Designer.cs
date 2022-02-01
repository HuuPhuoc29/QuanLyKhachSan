
namespace QLKS
{
    partial class Form_DanhSachPhong
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
            this.DS_PKS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_TinhTrang = new System.Windows.Forms.ComboBox();
            this.button_LamMoi = new System.Windows.Forms.Button();
            this.button_ThoatP = new System.Windows.Forms.Button();
            this.button_TimKiemP = new System.Windows.Forms.Button();
            this.button_ChinhSuaP = new System.Windows.Forms.Button();
            this.button_XoaP = new System.Windows.Forms.Button();
            this.button_ThemP = new System.Windows.Forms.Button();
            this.textBox_Gia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_MaPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.textBox_SoPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PKS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DS_PKS
            // 
            this.DS_PKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DS_PKS.Location = new System.Drawing.Point(6, 21);
            this.DS_PKS.Name = "DS_PKS";
            this.DS_PKS.RowHeadersWidth = 51;
            this.DS_PKS.RowTemplate.Height = 24;
            this.DS_PKS.Size = new System.Drawing.Size(858, 430);
            this.DS_PKS.TabIndex = 2;
            this.DS_PKS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DS_PKS_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_TinhTrang);
            this.groupBox1.Controls.Add(this.button_LamMoi);
            this.groupBox1.Controls.Add(this.button_ThoatP);
            this.groupBox1.Controls.Add(this.button_TimKiemP);
            this.groupBox1.Controls.Add(this.button_ChinhSuaP);
            this.groupBox1.Controls.Add(this.button_XoaP);
            this.groupBox1.Controls.Add(this.button_ThemP);
            this.groupBox1.Controls.Add(this.textBox_Gia);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_MaPhong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_LoaiPhong);
            this.groupBox1.Controls.Add(this.textBox_SoPhong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 255);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // comboBox_TinhTrang
            // 
            this.comboBox_TinhTrang.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ"});
            this.comboBox_TinhTrang.FormattingEnabled = true;
            this.comboBox_TinhTrang.Items.AddRange(new object[] {
            "Trống",
            "Đã nhận",
            "Đã đăng ký",
            "Sửa chữa"});
            this.comboBox_TinhTrang.Location = new System.Drawing.Point(582, 41);
            this.comboBox_TinhTrang.Name = "comboBox_TinhTrang";
            this.comboBox_TinhTrang.Size = new System.Drawing.Size(183, 24);
            this.comboBox_TinhTrang.TabIndex = 73;
            this.comboBox_TinhTrang.SelectedIndexChanged += new System.EventHandler(this.comboBox_TinhTrang_SelectedIndexChanged);
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
            // button_ThoatP
            // 
            this.button_ThoatP.Location = new System.Drawing.Point(735, 185);
            this.button_ThoatP.Name = "button_ThoatP";
            this.button_ThoatP.Size = new System.Drawing.Size(117, 40);
            this.button_ThoatP.TabIndex = 71;
            this.button_ThoatP.Text = "Thoát";
            this.button_ThoatP.UseVisualStyleBackColor = true;
            this.button_ThoatP.Click += new System.EventHandler(this.button_ThoatP_Click);
            // 
            // button_TimKiemP
            // 
            this.button_TimKiemP.Location = new System.Drawing.Point(445, 185);
            this.button_TimKiemP.Name = "button_TimKiemP";
            this.button_TimKiemP.Size = new System.Drawing.Size(117, 40);
            this.button_TimKiemP.TabIndex = 70;
            this.button_TimKiemP.Text = "Tìm kiếm";
            this.button_TimKiemP.UseVisualStyleBackColor = true;
            this.button_TimKiemP.Click += new System.EventHandler(this.button_TimKiemP_Click);
            // 
            // button_ChinhSuaP
            // 
            this.button_ChinhSuaP.Location = new System.Drawing.Point(300, 185);
            this.button_ChinhSuaP.Name = "button_ChinhSuaP";
            this.button_ChinhSuaP.Size = new System.Drawing.Size(117, 40);
            this.button_ChinhSuaP.TabIndex = 69;
            this.button_ChinhSuaP.Text = "Chỉnh sửa";
            this.button_ChinhSuaP.UseVisualStyleBackColor = true;
            this.button_ChinhSuaP.Click += new System.EventHandler(this.button_ChinhSuaP_Click);
            // 
            // button_XoaP
            // 
            this.button_XoaP.Location = new System.Drawing.Point(145, 185);
            this.button_XoaP.Name = "button_XoaP";
            this.button_XoaP.Size = new System.Drawing.Size(117, 40);
            this.button_XoaP.TabIndex = 68;
            this.button_XoaP.Text = "Xóa";
            this.button_XoaP.UseVisualStyleBackColor = true;
            this.button_XoaP.Click += new System.EventHandler(this.button_XoaP_Click);
            // 
            // button_ThemP
            // 
            this.button_ThemP.Location = new System.Drawing.Point(10, 185);
            this.button_ThemP.Name = "button_ThemP";
            this.button_ThemP.Size = new System.Drawing.Size(117, 40);
            this.button_ThemP.TabIndex = 67;
            this.button_ThemP.Text = "Thêm";
            this.button_ThemP.UseVisualStyleBackColor = true;
            this.button_ThemP.Click += new System.EventHandler(this.button_ThemP_Click);
            // 
            // textBox_Gia
            // 
            this.textBox_Gia.Location = new System.Drawing.Point(582, 83);
            this.textBox_Gia.Name = "textBox_Gia";
            this.textBox_Gia.Size = new System.Drawing.Size(183, 22);
            this.textBox_Gia.TabIndex = 63;
            this.textBox_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(477, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 18);
            this.label11.TabIndex = 60;
            this.label11.Text = "Tình trạng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(474, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 18);
            this.label12.TabIndex = 59;
            this.label12.Text = "Giá phòng";
            // 
            // textBox_MaPhong
            // 
            this.textBox_MaPhong.Location = new System.Drawing.Point(190, 43);
            this.textBox_MaPhong.Name = "textBox_MaPhong";
            this.textBox_MaPhong.Size = new System.Drawing.Size(183, 22);
            this.textBox_MaPhong.TabIndex = 58;
            this.textBox_MaPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 57;
            this.label8.Text = "Mã phòng";
            // 
            // comboBox_LoaiPhong
            // 
            this.comboBox_LoaiPhong.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ"});
            this.comboBox_LoaiPhong.FormattingEnabled = true;
            this.comboBox_LoaiPhong.Location = new System.Drawing.Point(190, 83);
            this.comboBox_LoaiPhong.Name = "comboBox_LoaiPhong";
            this.comboBox_LoaiPhong.Size = new System.Drawing.Size(183, 24);
            this.comboBox_LoaiPhong.TabIndex = 55;
            this.comboBox_LoaiPhong.SelectedIndexChanged += new System.EventHandler(this.comboBox_LoaiPhong_SelectedIndexChanged);
            // 
            // textBox_SoPhong
            // 
            this.textBox_SoPhong.Location = new System.Drawing.Point(190, 124);
            this.textBox_SoPhong.Name = "textBox_SoPhong";
            this.textBox_SoPhong.Size = new System.Drawing.Size(183, 22);
            this.textBox_SoPhong.TabIndex = 54;
            this.textBox_SoPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "Số phòng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 51;
            this.label9.Text = "Loại phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DS_PKS);
            this.groupBox2.Location = new System.Drawing.Point(12, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 461);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng";
            // 
            // Form_DanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(897, 739);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_DanhSachPhong";
            this.Text = "Phòng khách sạn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhongKhachSan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DS_PKS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DS_PKS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ThoatP;
        private System.Windows.Forms.Button button_TimKiemP;
        private System.Windows.Forms.Button button_ChinhSuaP;
        private System.Windows.Forms.Button button_XoaP;
        private System.Windows.Forms.Button button_ThemP;
        private System.Windows.Forms.TextBox textBox_Gia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_MaPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_LoaiPhong;
        private System.Windows.Forms.TextBox textBox_SoPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_LamMoi;
        private System.Windows.Forms.ComboBox comboBox_TinhTrang;
    }
}