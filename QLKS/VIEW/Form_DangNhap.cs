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
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
           
        }

        /*private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
         {
             if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.Yes)
             {
                 e.Cancel = true;
             }
         }*/
        private void comboBox_ChucVu_Leave(object sender, EventArgs e)
        {
            comboBox_ChucVu.Items.Clear();
            QLKS db = new QLKS();
            foreach (NHANVIEN i in db.NHANVIENs)
                if (i.CHUCVU == comboBox_Ma.Text)
                {
                    comboBox_ChucVu.Items.Add(new CBBItem { Text = i.MANHANVIEN, Value = i.MANHANVIEN });
                }
            
        }
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            NHANVIEN nv = db.NHANVIENs.Find(comboBox_ChucVu.Text);
            if(nv==null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            else
            {
                if(nv.MATKHAU==textBox_MatKhau.Text)
                {
                    Form_TrangChu TC = new Form_TrangChu(nv.MANHANVIEN);
                    this.Hide();
                    TC.Location = new Point(0, 0);
                    TC.StartPosition = FormStartPosition.Manual;
                    //TC.FormBorderStyle =FormBorderStyle.None;
                    TC.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Mật khẩu của "+comboBox_ChucVu.Text+" sai !\n"+ "Vui lòng nhập lại !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
