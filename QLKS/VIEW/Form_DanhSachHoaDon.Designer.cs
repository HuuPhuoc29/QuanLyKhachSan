
namespace QLKS
{
    partial class Form_DanhSachHoaDon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_ChiTiet = new System.Windows.Forms.Button();
            this.button_Thoát = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.comboBox_ThuocTinh = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_SapXep = new System.Windows.Forms.Button();
            this.button_TimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(409, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_ChiTiet
            // 
            this.button_ChiTiet.Location = new System.Drawing.Point(524, 577);
            this.button_ChiTiet.Name = "button_ChiTiet";
            this.button_ChiTiet.Size = new System.Drawing.Size(113, 36);
            this.button_ChiTiet.TabIndex = 85;
            this.button_ChiTiet.Text = "Chi tiết";
            this.button_ChiTiet.UseVisualStyleBackColor = true;
            this.button_ChiTiet.Click += new System.EventHandler(this.button_ChiTiet_Click);
            // 
            // button_Thoát
            // 
            this.button_Thoát.Location = new System.Drawing.Point(924, 577);
            this.button_Thoát.Name = "button_Thoát";
            this.button_Thoát.Size = new System.Drawing.Size(113, 36);
            this.button_Thoát.TabIndex = 86;
            this.button_Thoát.Text = "Thoát";
            this.button_Thoát.UseVisualStyleBackColor = true;
            this.button_Thoát.Click += new System.EventHandler(this.button_Thoát_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(724, 577);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(113, 36);
            this.button_Xoa.TabIndex = 87;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // comboBox_ThuocTinh
            // 
            this.comboBox_ThuocTinh.FormattingEnabled = true;
            this.comboBox_ThuocTinh.Location = new System.Drawing.Point(77, 536);
            this.comboBox_ThuocTinh.Name = "comboBox_ThuocTinh";
            this.comboBox_ThuocTinh.Size = new System.Drawing.Size(160, 24);
            this.comboBox_ThuocTinh.TabIndex = 88;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 536);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 89;
            // 
            // button_SapXep
            // 
            this.button_SapXep.Location = new System.Drawing.Point(124, 577);
            this.button_SapXep.Name = "button_SapXep";
            this.button_SapXep.Size = new System.Drawing.Size(113, 36);
            this.button_SapXep.TabIndex = 90;
            this.button_SapXep.Text = "Sắp xếp";
            this.button_SapXep.UseVisualStyleBackColor = true;
            this.button_SapXep.Click += new System.EventHandler(this.button_SapXep_Click);
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Location = new System.Drawing.Point(324, 577);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(113, 36);
            this.button_TimKiem.TabIndex = 91;
            this.button_TimKiem.Text = "Tìm kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // Form_DanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 641);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.button_SapXep);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox_ThuocTinh);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Thoát);
            this.Controls.Add(this.button_ChiTiet);
            this.Controls.Add(this.label1);
            this.Name = "Form_DanhSachHoaDon";
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.Form_DanhSachHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ChiTiet;
        private System.Windows.Forms.Button button_Thoát;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.ComboBox comboBox_ThuocTinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_SapXep;
        private System.Windows.Forms.Button button_TimKiem;
    }
}