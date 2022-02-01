
namespace QLKS
{
    partial class Form_DichVu
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
            this.DS_DV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_LamMoi = new System.Windows.Forms.Button();
            this.textBox_GiaDichVu = new System.Windows.Forms.TextBox();
            this.textBox_TenDichVu = new System.Windows.Forms.TextBox();
            this.textBox_MaDichVu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ThoatDV = new System.Windows.Forms.Button();
            this.button_TimKiemDV = new System.Windows.Forms.Button();
            this.button_ChinhSuaDV = new System.Windows.Forms.Button();
            this.button_XoaDV = new System.Windows.Forms.Button();
            this.button_ThemDV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DS_DV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DS_DV
            // 
            this.DS_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DS_DV.Location = new System.Drawing.Point(7, 21);
            this.DS_DV.Name = "DS_DV";
            this.DS_DV.RowHeadersWidth = 51;
            this.DS_DV.RowTemplate.Height = 24;
            this.DS_DV.Size = new System.Drawing.Size(476, 294);
            this.DS_DV.TabIndex = 3;
            this.DS_DV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DS_DV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_LamMoi);
            this.groupBox1.Controls.Add(this.textBox_GiaDichVu);
            this.groupBox1.Controls.Add(this.textBox_TenDichVu);
            this.groupBox1.Controls.Add(this.textBox_MaDichVu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_ThoatDV);
            this.groupBox1.Controls.Add(this.button_TimKiemDV);
            this.groupBox1.Controls.Add(this.button_ChinhSuaDV);
            this.groupBox1.Controls.Add(this.button_XoaDV);
            this.groupBox1.Controls.Add(this.button_ThemDV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 324);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dich vụ";
            // 
            // button_LamMoi
            // 
            this.button_LamMoi.Location = new System.Drawing.Point(160, 254);
            this.button_LamMoi.Name = "button_LamMoi";
            this.button_LamMoi.Size = new System.Drawing.Size(92, 44);
            this.button_LamMoi.TabIndex = 78;
            this.button_LamMoi.Text = "Làm mới";
            this.button_LamMoi.UseVisualStyleBackColor = true;
            this.button_LamMoi.Click += new System.EventHandler(this.button_LamMoi_Click);
            // 
            // textBox_GiaDichVu
            // 
            this.textBox_GiaDichVu.Location = new System.Drawing.Point(185, 127);
            this.textBox_GiaDichVu.Name = "textBox_GiaDichVu";
            this.textBox_GiaDichVu.Size = new System.Drawing.Size(183, 22);
            this.textBox_GiaDichVu.TabIndex = 77;
            this.textBox_GiaDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_TenDichVu
            // 
            this.textBox_TenDichVu.Location = new System.Drawing.Point(185, 87);
            this.textBox_TenDichVu.Name = "textBox_TenDichVu";
            this.textBox_TenDichVu.Size = new System.Drawing.Size(183, 22);
            this.textBox_TenDichVu.TabIndex = 76;
            this.textBox_TenDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_MaDichVu
            // 
            this.textBox_MaDichVu.Location = new System.Drawing.Point(185, 47);
            this.textBox_MaDichVu.Name = "textBox_MaDichVu";
            this.textBox_MaDichVu.Size = new System.Drawing.Size(183, 22);
            this.textBox_MaDichVu.TabIndex = 75;
            this.textBox_MaDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Giá dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Mã dịch vụ";
            // 
            // button_ThoatDV
            // 
            this.button_ThoatDV.Location = new System.Drawing.Point(290, 254);
            this.button_ThoatDV.Name = "button_ThoatDV";
            this.button_ThoatDV.Size = new System.Drawing.Size(92, 44);
            this.button_ThoatDV.TabIndex = 71;
            this.button_ThoatDV.Text = "Thoát";
            this.button_ThoatDV.UseVisualStyleBackColor = true;
            this.button_ThoatDV.Click += new System.EventHandler(this.button_ThoatDV_Click);
            // 
            // button_TimKiemDV
            // 
            this.button_TimKiemDV.Location = new System.Drawing.Point(30, 254);
            this.button_TimKiemDV.Name = "button_TimKiemDV";
            this.button_TimKiemDV.Size = new System.Drawing.Size(92, 44);
            this.button_TimKiemDV.TabIndex = 70;
            this.button_TimKiemDV.Text = "Tìm kiếm";
            this.button_TimKiemDV.UseVisualStyleBackColor = true;
            this.button_TimKiemDV.Click += new System.EventHandler(this.button_TimKiemDV_Click);
            // 
            // button_ChinhSuaDV
            // 
            this.button_ChinhSuaDV.Location = new System.Drawing.Point(290, 187);
            this.button_ChinhSuaDV.Name = "button_ChinhSuaDV";
            this.button_ChinhSuaDV.Size = new System.Drawing.Size(92, 44);
            this.button_ChinhSuaDV.TabIndex = 69;
            this.button_ChinhSuaDV.Text = "Chỉnh sửa";
            this.button_ChinhSuaDV.UseVisualStyleBackColor = true;
            this.button_ChinhSuaDV.Click += new System.EventHandler(this.button_ChinhSuaDV_Click);
            // 
            // button_XoaDV
            // 
            this.button_XoaDV.Location = new System.Drawing.Point(160, 187);
            this.button_XoaDV.Name = "button_XoaDV";
            this.button_XoaDV.Size = new System.Drawing.Size(92, 44);
            this.button_XoaDV.TabIndex = 68;
            this.button_XoaDV.Text = "Xóa";
            this.button_XoaDV.UseVisualStyleBackColor = true;
            this.button_XoaDV.Click += new System.EventHandler(this.button_XoaDV_Click);
            // 
            // button_ThemDV
            // 
            this.button_ThemDV.Location = new System.Drawing.Point(30, 187);
            this.button_ThemDV.Name = "button_ThemDV";
            this.button_ThemDV.Size = new System.Drawing.Size(92, 44);
            this.button_ThemDV.TabIndex = 67;
            this.button_ThemDV.Text = "Thêm";
            this.button_ThemDV.UseVisualStyleBackColor = true;
            this.button_ThemDV.Click += new System.EventHandler(this.button_ThemDV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DS_DV);
            this.groupBox2.Location = new System.Drawing.Point(454, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 324);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách dịch vụ";
            // 
            // Form_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(955, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_DichVu";
            this.Text = "Dich vụ";
            ((System.ComponentModel.ISupportInitialize)(this.DS_DV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.DataGridView DS_DV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ThoatDV;
        private System.Windows.Forms.Button button_TimKiemDV;
        private System.Windows.Forms.Button button_ChinhSuaDV;
        private System.Windows.Forms.Button button_XoaDV;
        private System.Windows.Forms.Button button_ThemDV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_GiaDichVu;
        private System.Windows.Forms.TextBox textBox_TenDichVu;
        private System.Windows.Forms.TextBox textBox_MaDichVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_LamMoi;
    }
}
