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
    public partial class Form_ThongTinTaiKhoan : Form
    {
        public delegate void MyDel(string maNV);
        string maNV = "";
        public Form_ThongTinTaiKhoan(string _maNV=null)
        {
            InitializeComponent();
            maNV = _maNV;
            Show();
        }
        public void Show()
        {
            QLKS db = new QLKS();
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            if (nv == null) return;
            boxMa.Text = nv.MANHANVIEN;
            boxTen.Text = nv.TENNHANVIEN;
            boxGioiTinh.Text = nv.GIOITINH;
            boxCMND.Text = nv.CMND;
            boxSDT.Text = nv.SDT;
            boxNgaySinh.Text = nv.NGAYSINH.ToString();
            boxDiaChi.Text = nv.DIACHI;
            boxChucVu.Text = nv.CHUCVU;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }
    }
}
