
namespace QLKS
{
    partial class Form_QuanLyChiTieu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_GhiChu = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_ThoatCT = new System.Windows.Forms.Button();
            this.button_ChinhSuaCT = new System.Windows.Forms.Button();
            this.button_XoaCT = new System.Windows.Forms.Button();
            this.button_ThemCT = new System.Windows.Forms.Button();
            this.textBox_Gia = new System.Windows.Forms.TextBox();
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Ma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button_ThoatCT);
            this.groupBox1.Controls.Add(this.button_ChinhSuaCT);
            this.groupBox1.Controls.Add(this.button_XoaCT);
            this.groupBox1.Controls.Add(this.button_ThemCT);
            this.groupBox1.Controls.Add(this.textBox_Gia);
            this.groupBox1.Controls.Add(this.textBox_Ten);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 255);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiêu";
            // 
            // textBox_Ma
            // 
            this.textBox_Ma.Location = new System.Drawing.Point(153, 41);
            this.textBox_Ma.Name = "textBox_Ma";
            this.textBox_Ma.Size = new System.Drawing.Size(183, 22);
            this.textBox_Ma.TabIndex = 76;
            this.textBox_Ma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "Mã chi tiêu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_GhiChu);
            this.groupBox2.Location = new System.Drawing.Point(371, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 139);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ghi chú";
            // 
            // textBox_GhiChu
            // 
            this.textBox_GhiChu.Location = new System.Drawing.Point(14, 23);
            this.textBox_GhiChu.Multiline = true;
            this.textBox_GhiChu.Name = "textBox_GhiChu";
            this.textBox_GhiChu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_GhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_GhiChu.Size = new System.Drawing.Size(357, 110);
            this.textBox_GhiChu.TabIndex = 75;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 22);
            this.dateTimePicker1.TabIndex = 73;
            // 
            // button_ThoatCT
            // 
            this.button_ThoatCT.Location = new System.Drawing.Point(572, 199);
            this.button_ThoatCT.Name = "button_ThoatCT";
            this.button_ThoatCT.Size = new System.Drawing.Size(117, 40);
            this.button_ThoatCT.TabIndex = 71;
            this.button_ThoatCT.Text = "Thoát";
            this.button_ThoatCT.UseVisualStyleBackColor = true;
            this.button_ThoatCT.Click += new System.EventHandler(this.button_ThoatCT_Click);
            // 
            // button_ChinhSuaCT
            // 
            this.button_ChinhSuaCT.Location = new System.Drawing.Point(422, 199);
            this.button_ChinhSuaCT.Name = "button_ChinhSuaCT";
            this.button_ChinhSuaCT.Size = new System.Drawing.Size(117, 40);
            this.button_ChinhSuaCT.TabIndex = 69;
            this.button_ChinhSuaCT.Text = "Chỉnh sửa";
            this.button_ChinhSuaCT.UseVisualStyleBackColor = true;
            this.button_ChinhSuaCT.Click += new System.EventHandler(this.button_ChinhSuaCT_Click);
            // 
            // button_XoaCT
            // 
            this.button_XoaCT.Location = new System.Drawing.Point(272, 199);
            this.button_XoaCT.Name = "button_XoaCT";
            this.button_XoaCT.Size = new System.Drawing.Size(117, 40);
            this.button_XoaCT.TabIndex = 68;
            this.button_XoaCT.Text = "Xóa";
            this.button_XoaCT.UseVisualStyleBackColor = true;
            this.button_XoaCT.Click += new System.EventHandler(this.button_XoaCT_Click);
            // 
            // button_ThemCT
            // 
            this.button_ThemCT.Location = new System.Drawing.Point(122, 199);
            this.button_ThemCT.Name = "button_ThemCT";
            this.button_ThemCT.Size = new System.Drawing.Size(117, 40);
            this.button_ThemCT.TabIndex = 67;
            this.button_ThemCT.Text = "Thêm";
            this.button_ThemCT.UseVisualStyleBackColor = true;
            this.button_ThemCT.Click += new System.EventHandler(this.button_ThemCT_Click);
            // 
            // textBox_Gia
            // 
            this.textBox_Gia.Location = new System.Drawing.Point(153, 109);
            this.textBox_Gia.Name = "textBox_Gia";
            this.textBox_Gia.Size = new System.Drawing.Size(183, 22);
            this.textBox_Gia.TabIndex = 63;
            this.textBox_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.Location = new System.Drawing.Point(153, 75);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(183, 22);
            this.textBox_Ten.TabIndex = 58;
            this.textBox_Ten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 57;
            this.label8.Text = "Tên chi tiêu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "Ngày chi tiêu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 51;
            this.label9.Text = "Số tiền";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 354);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách chi tiêu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form_QuanLyChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 645);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_QuanLyChiTieu";
            this.Text = "Quản lý chi tiêu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ThoatCT;
        private System.Windows.Forms.Button button_ChinhSuaCT;
        private System.Windows.Forms.Button button_XoaCT;
        private System.Windows.Forms.Button button_ThemCT;
        private System.Windows.Forms.TextBox textBox_Gia;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_GhiChu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Ma;
        private System.Windows.Forms.Label label1;
    }
}