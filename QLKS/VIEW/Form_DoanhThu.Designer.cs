
namespace QLKS
{
    partial class Form_DoanhThu
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
            this.dataGridView_ChiTieu = new System.Windows.Forms.DataGridView();
            this.textBox_TongThu = new System.Windows.Forms.TextBox();
            this.dateTimePicker_BatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_KetThuc = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_HoaDon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TongChi = new System.Windows.Forms.TextBox();
            this.textBox_LoiNhuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Tinh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChiTieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(476, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOANH THU";
            // 
            // dataGridView_ChiTieu
            // 
            this.dataGridView_ChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChiTieu.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_ChiTieu.Name = "dataGridView_ChiTieu";
            this.dataGridView_ChiTieu.RowHeadersWidth = 51;
            this.dataGridView_ChiTieu.RowTemplate.Height = 24;
            this.dataGridView_ChiTieu.Size = new System.Drawing.Size(1124, 252);
            this.dataGridView_ChiTieu.TabIndex = 0;
            // 
            // textBox_TongThu
            // 
            this.textBox_TongThu.Location = new System.Drawing.Point(633, 99);
            this.textBox_TongThu.Name = "textBox_TongThu";
            this.textBox_TongThu.ReadOnly = true;
            this.textBox_TongThu.Size = new System.Drawing.Size(160, 22);
            this.textBox_TongThu.TabIndex = 89;
            // 
            // dateTimePicker_BatDau
            // 
            this.dateTimePicker_BatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_BatDau.Location = new System.Drawing.Point(268, 103);
            this.dateTimePicker_BatDau.Name = "dateTimePicker_BatDau";
            this.dateTimePicker_BatDau.Size = new System.Drawing.Size(159, 22);
            this.dateTimePicker_BatDau.TabIndex = 90;
            // 
            // dateTimePicker_KetThuc
            // 
            this.dateTimePicker_KetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_KetThuc.Location = new System.Drawing.Point(268, 148);
            this.dateTimePicker_KetThuc.Name = "dateTimePicker_KetThuc";
            this.dateTimePicker_KetThuc.Size = new System.Drawing.Size(159, 22);
            this.dateTimePicker_KetThuc.TabIndex = 91;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_ChiTieu);
            this.groupBox1.Location = new System.Drawing.Point(1, 531);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 281);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chi tiêu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_HoaDon);
            this.groupBox2.Location = new System.Drawing.Point(1, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1146, 334);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dataGridView_HoaDon
            // 
            this.dataGridView_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HoaDon.Location = new System.Drawing.Point(11, 21);
            this.dataGridView_HoaDon.Name = "dataGridView_HoaDon";
            this.dataGridView_HoaDon.RowHeadersWidth = 51;
            this.dataGridView_HoaDon.RowTemplate.Height = 24;
            this.dataGridView_HoaDon.Size = new System.Drawing.Size(1124, 307);
            this.dataGridView_HoaDon.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 95;
            this.label3.Text = "Đến ngày";
            // 
            // textBox_TongChi
            // 
            this.textBox_TongChi.Location = new System.Drawing.Point(633, 127);
            this.textBox_TongChi.Name = "textBox_TongChi";
            this.textBox_TongChi.ReadOnly = true;
            this.textBox_TongChi.Size = new System.Drawing.Size(160, 22);
            this.textBox_TongChi.TabIndex = 96;
            // 
            // textBox_LoiNhuan
            // 
            this.textBox_LoiNhuan.Location = new System.Drawing.Point(633, 155);
            this.textBox_LoiNhuan.Name = "textBox_LoiNhuan";
            this.textBox_LoiNhuan.ReadOnly = true;
            this.textBox_LoiNhuan.Size = new System.Drawing.Size(160, 22);
            this.textBox_LoiNhuan.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 98;
            this.label4.Text = "Tổng thu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 99;
            this.label5.Text = "Tổng chi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 100;
            this.label6.Text = "Lợi nhuận";
            // 
            // button_Tinh
            // 
            this.button_Tinh.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tinh.Location = new System.Drawing.Point(898, 79);
            this.button_Tinh.Name = "button_Tinh";
            this.button_Tinh.Size = new System.Drawing.Size(130, 53);
            this.button_Tinh.TabIndex = 101;
            this.button_Tinh.Text = "TÍNH";
            this.button_Tinh.UseVisualStyleBackColor = false;
            this.button_Tinh.Click += new System.EventHandler(this.button_Tinh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(898, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 102;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 812);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Tinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_LoiNhuan);
            this.Controls.Add(this.textBox_TongChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker_KetThuc);
            this.Controls.Add(this.dateTimePicker_BatDau);
            this.Controls.Add(this.textBox_TongThu);
            this.Controls.Add(this.label1);
            this.Name = "Form_DoanhThu";
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.Form_DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChiTieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_ChiTieu;
        private System.Windows.Forms.TextBox textBox_TongThu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BatDau;
        private System.Windows.Forms.DateTimePicker dateTimePicker_KetThuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_HoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TongChi;
        private System.Windows.Forms.TextBox textBox_LoiNhuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Tinh;
        private System.Windows.Forms.Button button1;
    }
}