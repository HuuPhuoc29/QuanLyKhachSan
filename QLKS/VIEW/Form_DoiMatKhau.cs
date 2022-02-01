using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Form_DoiMatKhau : Form
    {
        public delegate void MyDel(string maNV);
        string maNV = "";
        public Form_DoiMatKhau(string _maNV=null)
        {
            InitializeComponent();
            maNV = _maNV;
        }
        private void textBox_MatKhauCu_Leave(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            if (nv == null) return;
            if (nv.MATKHAU != textBox_MatKhauCu.Text)
            {
                Label label1 = new Label();
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Location = new System.Drawing.Point(200, 248);
                label1.Name = "label_Loi";
                label1.Size = new System.Drawing.Size(34, 17);
                label1.Text = "Nhập lại không đúng !";
                this.Controls.Add(label1);
            }
        }

        private void textBox_MatKhauMoi_Leave(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            if (nv == null) return;
            if (textBox_MatKhauMoi.Text == textBox_MatKhauCu.Text)
            {
                Label label1 = new Label();
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Location = new System.Drawing.Point(200, 248);
                label1.Name = "label_Loi";
                label1.Size = new System.Drawing.Size(34, 17);
                label1.Text = "Mật khẩu mới trùng mật khẩu cũ !";
                this.Controls.Add(label1);
            }
        }

       
        private void button_Doi_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            if (nv == null) return;
            if (nv.MATKHAU != textBox_MatKhauCu.Text)
            {
                MessageBox.Show("Mật khẩu cũ không đúng ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nv == null) return;
            if (textBox_MatKhauMoi.Text == textBox_MatKhauCu.Text)
            {
                MessageBox.Show("Mật khẩu mới trùng mới mật khẩu cũ ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_MatKhauMoi.Text != textBox_NhapLai.Text)
            {
                MessageBox.Show("Nhập lại mật không không đúng ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_MatKhauCu.Text=="" || textBox_MatKhauMoi.Text=="" || textBox_NhapLai.Text=="")
            {
                MessageBox.Show("Nhập lại đầy đủ các thông tin trên ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            nv.MATKHAU = textBox_MatKhauMoi.Text;
            db.SaveChanges();
            MessageBox.Show("Đã đổi mật khẩu thành công ");
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }

       
    }
}
