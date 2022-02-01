
namespace QLKS
{
    partial class Form_ThanhToan
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
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ThanhToan = new System.Windows.Forms.Button();
            this.button_Huy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SoPhong = new System.Windows.Forms.TextBox();
            this.textBox_TenKhachHang = new System.Windows.Forms.TextBox();
            this.textBox_GiaPhong = new System.Windows.Forms.TextBox();
            this.textBox_MaHoaDon = new System.Windows.Forms.TextBox();
            this.label_Tong = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_ThanhToan = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_TienCoc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_NgayNhan = new System.Windows.Forms.TextBox();
            this.textBox_NgayTra = new System.Windows.Forms.TextBox();
            this.textBox_SoNgayO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_MaNhanVien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(306, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 17);
            this.label16.TabIndex = 82;
            this.label16.Text = "Tên khách hàng ";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 17);
            this.label15.TabIndex = 80;
            this.label15.Text = "Mã hoá đơn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(382, 70);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(106, 17);
            this.label14.TabIndex = 78;
            this.label14.Text = "Ngày trả phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "Số phòng   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "Ngày nhận phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(37, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 200);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Giá phòng";
            // 
            // button_ThanhToan
            // 
            this.button_ThanhToan.Location = new System.Drawing.Point(192, 642);
            this.button_ThanhToan.Name = "button_ThanhToan";
            this.button_ThanhToan.Size = new System.Drawing.Size(113, 36);
            this.button_ThanhToan.TabIndex = 85;
            this.button_ThanhToan.Text = "Thanh toán";
            this.button_ThanhToan.UseVisualStyleBackColor = true;
            this.button_ThanhToan.Click += new System.EventHandler(this.button_ThanhToan_Click);
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(459, 642);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(113, 36);
            this.button_Huy.TabIndex = 86;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 87;
            this.label4.Text = "Tạm tính  :   ";
            // 
            // textBox_SoPhong
            // 
            this.textBox_SoPhong.Location = new System.Drawing.Point(155, 140);
            this.textBox_SoPhong.Name = "textBox_SoPhong";
            this.textBox_SoPhong.ReadOnly = true;
            this.textBox_SoPhong.Size = new System.Drawing.Size(183, 22);
            this.textBox_SoPhong.TabIndex = 93;
            this.textBox_SoPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_TenKhachHang
            // 
            this.textBox_TenKhachHang.Location = new System.Drawing.Point(155, 108);
            this.textBox_TenKhachHang.Name = "textBox_TenKhachHang";
            this.textBox_TenKhachHang.ReadOnly = true;
            this.textBox_TenKhachHang.Size = new System.Drawing.Size(183, 22);
            this.textBox_TenKhachHang.TabIndex = 92;
            this.textBox_TenKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_TenKhachHang.TextChanged += new System.EventHandler(this.textBox_TenKhachHang_TextChanged);
            // 
            // textBox_GiaPhong
            // 
            this.textBox_GiaPhong.Location = new System.Drawing.Point(155, 175);
            this.textBox_GiaPhong.Name = "textBox_GiaPhong";
            this.textBox_GiaPhong.ReadOnly = true;
            this.textBox_GiaPhong.Size = new System.Drawing.Size(183, 22);
            this.textBox_GiaPhong.TabIndex = 90;
            this.textBox_GiaPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_MaHoaDon
            // 
            this.textBox_MaHoaDon.Location = new System.Drawing.Point(155, 35);
            this.textBox_MaHoaDon.Name = "textBox_MaHoaDon";
            this.textBox_MaHoaDon.ReadOnly = true;
            this.textBox_MaHoaDon.Size = new System.Drawing.Size(183, 22);
            this.textBox_MaHoaDon.TabIndex = 94;
            this.textBox_MaHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Tong
            // 
            this.label_Tong.AutoSize = true;
            this.label_Tong.Location = new System.Drawing.Point(613, 145);
            this.label_Tong.Name = "label_Tong";
            this.label_Tong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_Tong.Size = new System.Drawing.Size(14, 17);
            this.label_Tong.TabIndex = 95;
            this.label_Tong.Text = "x";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_MaNhanVien);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label_ThanhToan);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label_TienCoc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_NgayNhan);
            this.groupBox2.Controls.Add(this.textBox_NgayTra);
            this.groupBox2.Controls.Add(this.label_Tong);
            this.groupBox2.Controls.Add(this.textBox_SoNgayO);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_TenKhachHang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_MaHoaDon);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_SoPhong);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox_GiaPhong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(37, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 278);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(681, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 104;
            this.label11.Text = "VNĐ ";
            // 
            // label_ThanhToan
            // 
            this.label_ThanhToan.AutoSize = true;
            this.label_ThanhToan.Location = new System.Drawing.Point(613, 200);
            this.label_ThanhToan.Name = "label_ThanhToan";
            this.label_ThanhToan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_ThanhToan.Size = new System.Drawing.Size(14, 17);
            this.label_ThanhToan.TabIndex = 103;
            this.label_ThanhToan.Text = "x";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(466, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 17);
            this.label13.TabIndex = 102;
            this.label13.Text = "Tống thanh toán   :  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 101;
            this.label8.Text = "VNĐ ";
            // 
            // label_TienCoc
            // 
            this.label_TienCoc.AutoSize = true;
            this.label_TienCoc.Location = new System.Drawing.Point(605, 173);
            this.label_TienCoc.Name = "label_TienCoc";
            this.label_TienCoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_TienCoc.Size = new System.Drawing.Size(14, 17);
            this.label_TienCoc.TabIndex = 100;
            this.label_TienCoc.Text = "x";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 99;
            this.label10.Text = "Tiền cọc  :   ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 97;
            this.label7.Text = "VNĐ ";
            // 
            // textBox_NgayNhan
            // 
            this.textBox_NgayNhan.Location = new System.Drawing.Point(517, 35);
            this.textBox_NgayNhan.Name = "textBox_NgayNhan";
            this.textBox_NgayNhan.ReadOnly = true;
            this.textBox_NgayNhan.Size = new System.Drawing.Size(183, 22);
            this.textBox_NgayNhan.TabIndex = 98;
            this.textBox_NgayNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_NgayTra
            // 
            this.textBox_NgayTra.Location = new System.Drawing.Point(517, 70);
            this.textBox_NgayTra.Name = "textBox_NgayTra";
            this.textBox_NgayTra.ReadOnly = true;
            this.textBox_NgayTra.Size = new System.Drawing.Size(183, 22);
            this.textBox_NgayTra.TabIndex = 97;
            this.textBox_NgayTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_SoNgayO
            // 
            this.textBox_SoNgayO.Location = new System.Drawing.Point(517, 105);
            this.textBox_SoNgayO.Name = "textBox_SoNgayO";
            this.textBox_SoNgayO.ReadOnly = true;
            this.textBox_SoNgayO.Size = new System.Drawing.Size(183, 22);
            this.textBox_SoNgayO.TabIndex = 96;
            this.textBox_SoNgayO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 95;
            this.label6.Text = "Số ngày ở";
            // 
            // textBox_MaNhanVien
            // 
            this.textBox_MaNhanVien.Location = new System.Drawing.Point(155, 73);
            this.textBox_MaNhanVien.Name = "textBox_MaNhanVien";
            this.textBox_MaNhanVien.ReadOnly = true;
            this.textBox_MaNhanVien.Size = new System.Drawing.Size(183, 22);
            this.textBox_MaNhanVien.TabIndex = 106;
            this.textBox_MaNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 105;
            this.label9.Text = "Mã nhân viên ";
            // 
            // Form_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 701);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.button_ThanhToan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_ThanhToan";
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.Form_ThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ThanhToan;
        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_SoPhong;
        private System.Windows.Forms.TextBox textBox_TenKhachHang;
        private System.Windows.Forms.TextBox textBox_GiaPhong;
        private System.Windows.Forms.TextBox textBox_MaHoaDon;
        private System.Windows.Forms.Label label_Tong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_SoNgayO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_NgayNhan;
        private System.Windows.Forms.TextBox textBox_NgayTra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_ThanhToan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_TienCoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_MaNhanVien;
        private System.Windows.Forms.Label label9;
    }
}