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
    public partial class Form_ThanhToan : Form
    {
        public delegate void MyDel(string maHD);
        public MyDel Sender;
        string maHD = "";
        string maP = "";
        private void getData(string _maHD)
        {
            maHD = _maHD;
        }
        public Form_ThanhToan()
        {
            Sender = new MyDel(getData);
            InitializeComponent();
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            Form_DatPhong DP = new Form_DatPhong();
            DP.Sender(textBox_MaNhanVien.Text, textBox_SoPhong.Text ,Convert.ToDateTime( textBox_NgayNhan.Text));
            this.Dispose();
            DP.ShowDialog();
        }
        
        private void Form_ThanhToan_Load(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            HOADON hd = db.HOADONs.Find(maHD);
            PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(hd.MAPHIEUDANGKY);
            //PHIEUDICHVU pdv = db.PHIEUDICHVUs.Find(hd.MAPHIEUDICHVU);
            KHACHHANG kh = db.KHACHHANGs.Find(pdk.MAKHACHHANG);
            PHONG p = db.PHONGs.Find(pdk.MAPHONG);
            LOAIPHONG lp = db.LOAIPHONGs.Find(p.MALOAIPHONG);
            textBox_MaHoaDon.Text = hd.MAHOADON;
            textBox_TenKhachHang.Text = kh.TENKHACHHANG;
            textBox_MaNhanVien.Text = pdk.MANHANVIEN;
            //textBox_SoPhong.Text = p.MAPHONG + "  (" + lp.TENLOAIPHONG + ")";
            textBox_SoPhong.Text = p.MAPHONG;
            textBox_GiaPhong.Text = lp.GIAPHONG.ToString();
            textBox_NgayNhan.Text = pdk.NGAYNHANPHONG.Value.ToString();
            textBox_NgayTra.Text = pdk.NGAYTRAPHONG.Value.ToString();
            dataGridView1.DataSource = BLL.BLL_QLKS.Instance.loadPDV(textBox_MaHoaDon.Text);
            double tongtien = 0;
            DateTime date1 = new DateTime(pdk.NGAYNHANPHONG.Value.Year, pdk.NGAYNHANPHONG.Value.Month, pdk.NGAYNHANPHONG.Value.Day);
            DateTime date2 = new DateTime(pdk.NGAYTRAPHONG.Value.Year, pdk.NGAYTRAPHONG.Value.Month, pdk.NGAYTRAPHONG.Value.Day);
            TimeSpan NgayO = date2 - date1;
            tongtien += Convert.ToDouble(lp.GIAPHONG) * NgayO.Days;
            foreach (HOADON i in db.HOADONs)
            {
                if (i.MAHOADON == textBox_MaHoaDon.Text)
                {
                    foreach (PHIEUDICHVU j in db.PHIEUDICHVUs)
                    {
                        if (i.MAHOADON == j.MAHOADON)
                        {
                            LOAIDICHVU ldv = db.LOAIDICHVUs.Find(j.MALOAIDICHVU);
                            tongtien += Convert.ToDouble(ldv.GIALOAIDICHVU * j.SOLUONG);
                        }
                    }
                    break;
                }
            }
            textBox_SoNgayO.Text = NgayO.Days.ToString();
            label_Tong.Text = tongtien.ToString();
            label_TienCoc.Text = pdk.TIENCOC.ToString()+ " -" ;
            label_ThanhToan.Text = (tongtien - pdk.TIENCOC).ToString();
        }

        private void button_ThanhToan_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            HOADON hd = db.HOADONs.Find(maHD);
            hd.TONGTIEN = Convert.ToInt32(label_Tong.Text);
            db.SaveChanges();
            PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(hd.MAPHIEUDANGKY);
            PHONG p = db.PHONGs.Find(textBox_SoPhong.Text);
            p.TINHTRANG = "Trống";
            db.SaveChanges();
            if (db.HOADONs.Find(maHD).TONGTIEN != 0)
            {
                MessageBox.Show("Thanh toán thành công");
                Form_TrangChu TC = new Form_TrangChu(textBox_MaNhanVien.Text);
                TC.Location = new Point(0, 0);
                TC.StartPosition = FormStartPosition.Manual;
                this.Dispose();
                TC.ShowDialog();
            } 
            else
            {
                MessageBox.Show("Thanh toán thất bại !");
            }    
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_TenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
