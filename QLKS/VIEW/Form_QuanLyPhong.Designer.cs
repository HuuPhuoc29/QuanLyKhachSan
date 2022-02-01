
namespace QLKS
{
    partial class Form_QuanLyPhong
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
            this.DS_LP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_LamMoi = new System.Windows.Forms.Button();
            this.textBox_GiaLoaiPhong = new System.Windows.Forms.TextBox();
            this.textBox_TenLoaiPhong = new System.Windows.Forms.TextBox();
            this.textBox_MaLoaiPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ThoatLP = new System.Windows.Forms.Button();
            this.button_TimKiemLP = new System.Windows.Forms.Button();
            this.button_ChinhSuaLP = new System.Windows.Forms.Button();
            this.button_XoaLP = new System.Windows.Forms.Button();
            this.button_ThemLP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DS_LP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DS_LP
            // 
            this.DS_LP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DS_LP.Location = new System.Drawing.Point(7, 21);
            this.DS_LP.Name = "DS_LP";
            this.DS_LP.RowHeadersWidth = 51;
            this.DS_LP.RowTemplate.Height = 24;
            this.DS_LP.Size = new System.Drawing.Size(474, 294);
            this.DS_LP.TabIndex = 3;
            this.DS_LP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DS_LP_CellClick);
            this.DS_LP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DS_LP_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_LamMoi);
            this.groupBox1.Controls.Add(this.textBox_GiaLoaiPhong);
            this.groupBox1.Controls.Add(this.textBox_TenLoaiPhong);
            this.groupBox1.Controls.Add(this.textBox_MaLoaiPhong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_ThoatLP);
            this.groupBox1.Controls.Add(this.button_TimKiemLP);
            this.groupBox1.Controls.Add(this.button_ChinhSuaLP);
            this.groupBox1.Controls.Add(this.button_XoaLP);
            this.groupBox1.Controls.Add(this.button_ThemLP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 324);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại phòng";
            // 
            // button_LamMoi
            // 
            this.button_LamMoi.Location = new System.Drawing.Point(171, 253);
            this.button_LamMoi.Name = "button_LamMoi";
            this.button_LamMoi.Size = new System.Drawing.Size(92, 44);
            this.button_LamMoi.TabIndex = 78;
            this.button_LamMoi.Text = "Làm mới";
            this.button_LamMoi.UseVisualStyleBackColor = true;
            this.button_LamMoi.Click += new System.EventHandler(this.button_LamMoi_Click);
            // 
            // textBox_GiaLoaiPhong
            // 
            this.textBox_GiaLoaiPhong.Location = new System.Drawing.Point(185, 127);
            this.textBox_GiaLoaiPhong.Name = "textBox_GiaLoaiPhong";
            this.textBox_GiaLoaiPhong.Size = new System.Drawing.Size(183, 22);
            this.textBox_GiaLoaiPhong.TabIndex = 77;
            this.textBox_GiaLoaiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_TenLoaiPhong
            // 
            this.textBox_TenLoaiPhong.Location = new System.Drawing.Point(185, 87);
            this.textBox_TenLoaiPhong.Name = "textBox_TenLoaiPhong";
            this.textBox_TenLoaiPhong.Size = new System.Drawing.Size(183, 22);
            this.textBox_TenLoaiPhong.TabIndex = 76;
            this.textBox_TenLoaiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_MaLoaiPhong
            // 
            this.textBox_MaLoaiPhong.Location = new System.Drawing.Point(185, 47);
            this.textBox_MaLoaiPhong.Name = "textBox_MaLoaiPhong";
            this.textBox_MaLoaiPhong.Size = new System.Drawing.Size(183, 22);
            this.textBox_MaLoaiPhong.TabIndex = 75;
            this.textBox_MaLoaiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Giá loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tên loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Mã loại phòng";
            // 
            // button_ThoatLP
            // 
            this.button_ThoatLP.Location = new System.Drawing.Point(301, 253);
            this.button_ThoatLP.Name = "button_ThoatLP";
            this.button_ThoatLP.Size = new System.Drawing.Size(92, 44);
            this.button_ThoatLP.TabIndex = 71;
            this.button_ThoatLP.Text = "Thoát";
            this.button_ThoatLP.UseVisualStyleBackColor = true;
            this.button_ThoatLP.Click += new System.EventHandler(this.button_ThoatLP_Click);
            // 
            // button_TimKiemLP
            // 
            this.button_TimKiemLP.Location = new System.Drawing.Point(41, 253);
            this.button_TimKiemLP.Name = "button_TimKiemLP";
            this.button_TimKiemLP.Size = new System.Drawing.Size(92, 44);
            this.button_TimKiemLP.TabIndex = 70;
            this.button_TimKiemLP.Text = "Tìm kiếm";
            this.button_TimKiemLP.UseVisualStyleBackColor = true;
            this.button_TimKiemLP.Click += new System.EventHandler(this.button_TimKiemLP_Click);
            // 
            // button_ChinhSuaLP
            // 
            this.button_ChinhSuaLP.Location = new System.Drawing.Point(301, 187);
            this.button_ChinhSuaLP.Name = "button_ChinhSuaLP";
            this.button_ChinhSuaLP.Size = new System.Drawing.Size(92, 44);
            this.button_ChinhSuaLP.TabIndex = 69;
            this.button_ChinhSuaLP.Text = "Chỉnh sửa";
            this.button_ChinhSuaLP.UseVisualStyleBackColor = true;
            this.button_ChinhSuaLP.Click += new System.EventHandler(this.button_ChinhSuaLP_Click);
            // 
            // button_XoaLP
            // 
            this.button_XoaLP.Location = new System.Drawing.Point(171, 187);
            this.button_XoaLP.Name = "button_XoaLP";
            this.button_XoaLP.Size = new System.Drawing.Size(92, 44);
            this.button_XoaLP.TabIndex = 68;
            this.button_XoaLP.Text = "Xóa";
            this.button_XoaLP.UseVisualStyleBackColor = true;
            this.button_XoaLP.Click += new System.EventHandler(this.button_XoaLP_Click);
            // 
            // button_ThemLP
            // 
            this.button_ThemLP.Location = new System.Drawing.Point(41, 187);
            this.button_ThemLP.Name = "button_ThemLP";
            this.button_ThemLP.Size = new System.Drawing.Size(92, 44);
            this.button_ThemLP.TabIndex = 67;
            this.button_ThemLP.Text = "Thêm";
            this.button_ThemLP.UseVisualStyleBackColor = true;
            this.button_ThemLP.Click += new System.EventHandler(this.button_ThemLP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DS_LP);
            this.groupBox2.Location = new System.Drawing.Point(454, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 324);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại phòng";
            // 
            // Form_QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(955, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_QuanLyPhong";
            this.Text = "Quản lý phòng";
            ((System.ComponentModel.ISupportInitialize)(this.DS_LP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.DataGridView DS_LP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ThoatLP;
        private System.Windows.Forms.Button button_TimKiemLP;
        private System.Windows.Forms.Button button_ChinhSuaLP;
        private System.Windows.Forms.Button button_XoaLP;
        private System.Windows.Forms.Button button_ThemLP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_GiaLoaiPhong;
        private System.Windows.Forms.TextBox textBox_TenLoaiPhong;
        private System.Windows.Forms.TextBox textBox_MaLoaiPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_LamMoi;
    }
}
