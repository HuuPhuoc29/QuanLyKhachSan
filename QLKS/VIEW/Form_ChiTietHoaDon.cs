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
    public partial class Form_ChiTietHoaDon : Form
    {
        public delegate void MyDel(string maNV,string maHD);
        public MyDel Sender;
        string maHD = "";
        string maNV = "";
        private void getData(string _maNV,string _maHD)
        {
            maHD = _maHD;
            maNV = _maNV;
        }
        public Form_ChiTietHoaDon()
        {
            InitializeComponent();
            Sender = new MyDel(getData);
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            Form_DanhSachHoaDon DSHD = new Form_DanhSachHoaDon(maNV);
            this.Dispose();
            DSHD.ShowDialog();
        }
        
        private void Form_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.BLL_QLKS.Instance.loadPDV(maHD);
            QLKS db = new QLKS();
            HOADON hd = db.HOADONs.Find(maHD);
            if (hd != null)
            {
                PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(hd.MAPHIEUDANGKY);
                if (pdk != null)
                {
                    KHACHHANG kh = db.KHACHHANGs.Find(pdk.MAKHACHHANG);
                    NHANVIEN nv = db.NHANVIENs.Find(pdk.MANHANVIEN);
                    PHONG p = db.PHONGs.Find(pdk.MAPHONG);
                    if (p != null)
                    {
                        LOAIPHONG lp = db.LOAIPHONGs.Find(p.MALOAIPHONG);
                        DateTime date1 = new DateTime(pdk.NGAYNHANPHONG.Value.Year, pdk.NGAYNHANPHONG.Value.Month, pdk.NGAYNHANPHONG.Value.Day);
                        DateTime date2 = new DateTime(pdk.NGAYTRAPHONG.Value.Year, pdk.NGAYTRAPHONG.Value.Month, pdk.NGAYTRAPHONG.Value.Day);
                        TimeSpan NgayO = date2 - date1;
                        textBox_MaHoaDon.Text = hd.MAHOADON;
                        textBox_TenNhanVien.Text = nv.TENNHANVIEN;
                        textBox_TenKhachHang.Text = kh.TENKHACHHANG;
                        textBox_SoNgayO.Text = NgayO.Days.ToString();
                        textBox_TongTien.Text = hd.TONGTIEN.ToString();
                        int TienDV = 0;
                        foreach (HOADON i in db.HOADONs)
                        {
                            if (i.MAHOADON == textBox_MaHoaDon.Text)
                            {
                                foreach (PHIEUDICHVU j in db.PHIEUDICHVUs)
                                {
                                    if (i.MAHOADON == j.MAHOADON)
                                    {
                                        LOAIDICHVU ldv = db.LOAIDICHVUs.Find(j.MALOAIDICHVU);
                                        TienDV +=Convert.ToInt32( ldv.GIALOAIDICHVU * j.SOLUONG);
                                    }
                                }
                                break;
                            }
                        }
                        int TienThucTe =Convert.ToInt32( NgayO.Days * lp.GIAPHONG)+TienDV;
                        if (hd.TONGTIEN == 0)
                        {
                            label_TrangThai.Text = " Chưa thanh toán !";
                            label_TrangThai.ForeColor = Color.Red;

                        } 
                        else if(TienThucTe==hd.TONGTIEN)
                        {
                            label_TrangThai.Text = " Đã thanh toán !";
                            label_TrangThai.ForeColor = Color.Blue;

                        }
                        else if (TienThucTe>hd.TONGTIEN)
                        {
                            label_TrangThai.Text = " Hóa đơn hủy đặt phòng !";
                            label_TrangThai.ForeColor = Color.Orange;

                        }


                        textBox_MaPhieuDangKy.Text = pdk.MAPHIEUDANGKY;
                        textBox_SoPhong.Text = p.SOPHONG;
                        textBox_LoaiPhong.Text = lp.TENLOAIPHONG;
                        textBox_GiaPhong.Text = lp.GIAPHONG.ToString();
                        textBox_NgayDangKy.Text = pdk.NGAYDANGKY.Value.ToString();
                        textBox_NgayNhan.Text = pdk.NGAYNHANPHONG.Value.ToString();
                        textBox_NgayTra.Text = pdk.NGAYTRAPHONG.Value.ToString();

                        textBox_MaKhachHang.Text = kh.MAKHACHHANG;
                        textBox_TenKhachHang.Text = kh.TENKHACHHANG;
                        textBox_GioiTinh.Text = kh.GIOITINH;
                        textBox_CMND.Text = kh.CMND;
                        textBox_SDT.Text = kh.SDT;
                        textBox_DiaChi.Text = kh.DIACHI;
                        
                    }

                }

            }
           
        }

        private void label_TrangThai_Click(object sender, EventArgs e)
        {

        }
    }
}
