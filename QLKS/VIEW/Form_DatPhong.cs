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
    public partial class Form_DatPhong : Form
    {
        List<LOAIDICHVU> list = new List<LOAIDICHVU>();
        public delegate void MyDel(string _maNV,string _maP,DateTime _np);
        public MyDel Sender;
        public DateTime _NgayNhan = DateTime.Now;
        public DateTime _NgayTra=DateTime.Now;
        string _maNV="";
        string _maP = "";
        private void getData(string maNV,string maP,DateTime NgayNhan)
        {
            _maNV = maNV;
            _maP = maP;
            _NgayNhan = NgayNhan;
        }
        public void getNgay(string maP, DateTime NgayNhan, DateTime NgayTra)
        {
            _maP = maP;
            _NgayNhan= NgayNhan ;
            _NgayTra = NgayTra ;
        }
        public Form_DatPhong()
        {
            
            Sender = new MyDel(getData);
            InitializeComponent();
            dateTimePicker_DP.Value = DateTime.Now;
            dateTimePicker_TP.Value = DateTime.Now;
            textBox_TienCoc.Text = "0";
            setCBB();
            
            
        }
        public void setCBB()
        {
            QLKS db = new QLKS();
            foreach (LOAIDICHVU i in db.LOAIDICHVUs)
            {
                comboBox_LoaiDV.Items.Add(new CBBItem { Text = i.TENLOAIDICHVU, Value = i.MALOAIDICHVU });
            }
        }
       
        public bool checkNhapNgay()
        {
            DateTime np = new DateTime(dateTimePicker_DP.Value.Year, dateTimePicker_DP.Value.Month, dateTimePicker_DP.Value.Day);
            DateTime tp = new DateTime(dateTimePicker_TP.Value.Year, dateTimePicker_TP.Value.Month, dateTimePicker_TP.Value.Day);
            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if ((today - tp).Days > 0)
            {
                MessageBox.Show("Nhập sai ! \n" + "Ngày trả phòng không được trước hôm nay ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if ((tp - np).Days < 1)
            {
                MessageBox.Show("Nhập sai ! \n" + "Ngày trả phòng phải sau ngày nhận phòng ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public bool checkDaDatPhong(string maPDK,string maP, DateTime np, DateTime tp)
        {
            QLKS db = new QLKS();
            foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
            {
                List<HOADON> list = new List<HOADON>();
                if (i.MAPHIEUDANGKY != maPDK && i.MAPHONG == maP)
                {

                    int count = 0, count1 = 0;
                    int _count = 0, _count1 = 0;
                    list = db.HOADONs.Where(p => p.MAPHIEUDANGKY == i.MAPHIEUDANGKY.ToString()).Select(p => p).ToList();
                    if (list.Count != 0)
                    {
                        foreach (HOADON hd in list)
                            if (hd.TONGTIEN == 0)
                            {
                                count1++;
                                DateTime np1 = new DateTime(i.NGAYNHANPHONG.Value.Year, i.NGAYNHANPHONG.Value.Month, i.NGAYNHANPHONG.Value.Day);
                                DateTime tp1 = new DateTime(i.NGAYTRAPHONG.Value.Year, i.NGAYTRAPHONG.Value.Month, i.NGAYTRAPHONG.Value.Day);
                                if (((tp <= np1.AddDays(1)) || (np >= tp1)))
                                    count++;
                                if (count != count1) return false;

                            }
                    }
                    else if (list.Count == 0)
                    {

                        _count1++;
                        DateTime np1 = new DateTime(i.NGAYNHANPHONG.Value.Year, i.NGAYNHANPHONG.Value.Month, i.NGAYNHANPHONG.Value.Day);
                        DateTime tp1 = new DateTime(i.NGAYTRAPHONG.Value.Year, i.NGAYTRAPHONG.Value.Month, i.NGAYTRAPHONG.Value.Day);
                        if (((tp <= np1.AddDays(1)) || (np >= tp1)))
                            _count++;
                        if (_count != _count1) return false;
                    }
                }

            }
            return true;
        }
       
        private void Form_DatPhong_Load(object sender, EventArgs e)
        {
            dateTimePicker_DP.Value = _NgayNhan;
            dateTimePicker_TP.Value = _NgayTra;
            textBox_MaPhong.Text = _maP;
            QLKS db = new QLKS();
            PHONG _p = db.PHONGs.Find(_maP);
            List<HOADON> listHD = new List<HOADON>();
            List<PHIEUDANGKY> listPDK = new List<PHIEUDANGKY>();
            if (_p != null)
            {
                if (_p.TINHTRANG != "Trống" )
                {
                    foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
                        if(i.MAPHONG==_p.MAPHONG && i.NGAYNHANPHONG.Value.ToShortDateString()== _NgayNhan.ToShortDateString())
                        {
                            double tongtien = 0;
                            listHD = db.HOADONs.Where(p => p.MAPHIEUDANGKY == i.MAPHIEUDANGKY.ToString()).Select(p => p).ToList();
                            
                            if (listHD.Count != 0)
                            {
                                foreach (HOADON j in listHD)
                                {
                                    
                                    if (j.TONGTIEN == 0)
                                    {
                                        textBox_MaHoaDon.Text = j.MAHOADON;
                                        dataGridView1.DataSource = BLL.BLL_QLKS.Instance.loadPDV(textBox_MaHoaDon.Text);
                                        textBox_MaHoaDon.Enabled = false;
                                        buttonDatPhong.Enabled = false;
                                        button_NhapLai.Enabled = false;
                                        foreach (PHIEUDICHVU k in db.PHIEUDICHVUs)
                                        {
                                            if (k.MAHOADON == j.MAHOADON)
                                            {
                                                LOAIDICHVU ldv = db.LOAIDICHVUs.Find(k.MALOAIDICHVU);
                                                tongtien += Convert.ToDouble(ldv.GIALOAIDICHVU * k.SOLUONG);
                                            }
                                        }
                                        if (textBox_MaHoaDon.Text == "")
                                            textBox_MaHoaDon.Text = BLL.BLL_QLKS.Instance.tangMaHD();
                                        KHACHHANG kh = db.KHACHHANGs.Find(i.MAKHACHHANG);
                                        textBox_MaKhachHang.Text = kh.MAKHACHHANG;
                                        textBox_TenKhachHang.Text = kh.TENKHACHHANG;
                                        comboBox_GioiTinh.Text = kh.GIOITINH;
                                        textBox_CMND.Text = kh.CMND;
                                        textBox_SDT.Text = kh.SDT;
                                        textBox_DiaChi.Text = kh.DIACHI;
                                        textBox_MaPDK.Text = i.MAPHIEUDANGKY;
                                        textBox_MaNhanVien.Text = i.MANHANVIEN;
                                        dateTimePicker_DP.Value = _NgayNhan;
                                        dateTimePicker_DP.Enabled = false;
                                        dateTimePicker_TP.Value = i.NGAYTRAPHONG.Value;
                                        textBox_MaPhong.Text = _maP;
                                        textBox_MaKhachHang.Enabled = false;
                                        textBox_MaPDK.Enabled = false;
                                        textBox_MaPhong.Enabled = false;
                                        button_NhapLai.Enabled = false;

                                        DateTime date1 = new DateTime(i.NGAYNHANPHONG.Value.Year, i.NGAYNHANPHONG.Value.Month, i.NGAYNHANPHONG.Value.Day);
                                        DateTime date2 = new DateTime(i.NGAYTRAPHONG.Value.Year, i.NGAYTRAPHONG.Value.Month, i.NGAYTRAPHONG.Value.Day);
                                        TimeSpan NgayO = date2 - date1;
                                        LOAIPHONG lp = db.LOAIPHONGs.Find(_p.MALOAIPHONG);
                                        tongtien += Convert.ToDouble(lp.GIAPHONG) * NgayO.Days;

                                        textBox_TongTien.Text = tongtien.ToString();
                                        textBox_TienCoc.Text = i.TIENCOC.ToString();

                                    }
                                }    
                                    
                               
                            }
                            else
                            {
                                if (textBox_MaHoaDon.Text == "")
                                    textBox_MaHoaDon.Text = BLL.BLL_QLKS.Instance.tangMaHD();
                                KHACHHANG kh = db.KHACHHANGs.Find(i.MAKHACHHANG);
                                textBox_MaKhachHang.Text = kh.MAKHACHHANG;
                                textBox_TenKhachHang.Text = kh.TENKHACHHANG;
                                comboBox_GioiTinh.Text = kh.GIOITINH;
                                textBox_CMND.Text = kh.CMND;
                                textBox_SDT.Text = kh.SDT;
                                textBox_DiaChi.Text = kh.DIACHI;
                                textBox_MaPDK.Text = i.MAPHIEUDANGKY;
                                textBox_MaNhanVien.Text = i.MANHANVIEN;
                                dateTimePicker_DP.Value = _NgayNhan;
                                dateTimePicker_DP.Enabled = false;
                                dateTimePicker_TP.Value = i.NGAYTRAPHONG.Value;
                                textBox_MaPhong.Text = _maP;
                                textBox_MaKhachHang.Enabled = false;
                                textBox_MaPDK.Enabled = false;
                                textBox_MaPhong.Enabled = false;
                                button_NhapLai.Enabled = false;

                                DateTime date1 = new DateTime(i.NGAYNHANPHONG.Value.Year, i.NGAYNHANPHONG.Value.Month, i.NGAYNHANPHONG.Value.Day);
                                DateTime date2 = new DateTime(i.NGAYTRAPHONG.Value.Year, i.NGAYTRAPHONG.Value.Month, i.NGAYTRAPHONG.Value.Day);
                                TimeSpan NgayO = date2 - date1;
                                LOAIPHONG lp = db.LOAIPHONGs.Find(_p.MALOAIPHONG);
                                tongtien += Convert.ToDouble(lp.GIAPHONG) * NgayO.Days;

                                textBox_TongTien.Text = tongtien.ToString();
                                textBox_TienCoc.Text = i.TIENCOC.ToString();
                            }
                        }    
                    

                }
                else if (_p.TINHTRANG == "Trống")
                {
                    textBox_MaPhong.Text = _maP;
                    textBox_MaHoaDon.Text = BLL.BLL_QLKS.Instance.tangMaHD();
                    textBox_MaPDK.Text= BLL.BLL_QLKS.Instance.tangMaPDK();
                    textBox_MaKhachHang.Text = BLL.BLL_QLKS.Instance.tangMaKH();
                    textBox_MaNhanVien.Text = _maNV;
                    textBox_MaNhanVien.Enabled = false;
                    textBox_MaPhong.Enabled = false;
                    button_ThanhToan.Enabled = false;
                }

            }
            
            //textBox_TienCoc.Text = t.ToString();
        }
        private void buttonDatPhong_Click(object sender, EventArgs e)
        {
            if (checkNhapNgay()==false) return ;
            //checkDaDatPhong(textBox_MaPDK.Text, textBox_MaPhong.Text, Convert.ToDateTime(dateTimePicker_DP.Value), Convert.ToDateTime(dateTimePicker_TP.Value));
            QLKS db = new QLKS();
            int count = db.HOADONs.ToList().Count;
            if (db.HOADONs.Find(textBox_MaHoaDon.Text) != null)
            {
                MessageBox.Show("Mã hóa đơn : " + textBox_MaKhachHang.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkDaDatPhong(textBox_MaPDK.Text, textBox_MaPhong.Text, Convert.ToDateTime(dateTimePicker_DP.Value), Convert.ToDateTime(dateTimePicker_TP.Value)) == false)
            {
                MessageBox.Show("Phòng " + textBox_MaPhong.Text + " đã đăng ký !\n" + "Vui lòng chọn ngày nhận phòng/trả phòng khác", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_MaHoaDon.Text == "" || textBox_MaPDK.Text == "" ||  textBox_MaPhong.Text == "" || textBox_MaNhanVien.Text == "" || textBox_MaKhachHang.Text == "" || textBox_TenKhachHang.Text == "" || comboBox_GioiTinh.Text == "" || textBox_CMND.Text == "" || textBox_SDT.Text == "" || textBox_DiaChi.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (db.PHIEUDANGKies.Find(textBox_MaPDK.Text)!=null)
            {
                BLL.BLL_QLKS.Instance.Them_HD(textBox_MaHoaDon.Text, textBox_MaPDK.Text);
            }
            else
            {
                if (db.KHACHHANGs.Find(textBox_MaKhachHang.Text) != null)
                {
                    MessageBox.Show("Mã khách hàng: " + textBox_MaKhachHang.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (db.PHIEUDANGKies.Find(textBox_MaPDK.Text) != null)
                {
                    MessageBox.Show("Mã phiếu đăng ký : " + textBox_MaPDK.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (db.NHANVIENs.Find(textBox_MaNhanVien.Text) == null)
                {
                    MessageBox.Show("Mã nhân viên : " + textBox_MaKhachHang.Text + " không tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BLL.BLL_QLKS.Instance.Them_PDK(textBox_MaPDK.Text, dateTimePicker_DP.Value, dateTimePicker_DP.Value, dateTimePicker_TP.Value, textBox_MaPhong.Text, textBox_MaNhanVien.Text,textBox_TienCoc.Text, textBox_MaKhachHang.Text, textBox_TenKhachHang.Text, comboBox_GioiTinh.Text, textBox_CMND.Text, textBox_SDT.Text, textBox_DiaChi.Text);
                BLL.BLL_QLKS.Instance.Them_HD(textBox_MaHoaDon.Text, textBox_MaPDK.Text);
            }
            if(count!= db.HOADONs.ToList().Count)
                MessageBox.Show("Đã nhận phòng thành công", "Thông báo");
            Form_TrangChu TC = new Form_TrangChu(_maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }
        private void button_ThanhToan_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            DateTime tp = new DateTime(dateTimePicker_TP.Value.Year, dateTimePicker_TP.Value.Month, dateTimePicker_TP.Value.Day);
            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            /*if(today<tp)
            {
                MessageBox.Show("Chưa tới ngày trả phòng ! \n" + "Nếu muốn thanh toán trước thì có thể cộng vào tiền cọc ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            } */   
            Form_ThanhToan TT = new Form_ThanhToan();
            TT.Sender(textBox_MaHoaDon.Text);
            this.Dispose();
            TT.ShowDialog();
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(_maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }
        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            if (checkNhapNgay() == false) return;
            QLKS db = new QLKS();
            if (checkDaDatPhong(textBox_MaPDK.Text, textBox_MaPhong.Text, Convert.ToDateTime(dateTimePicker_DP.Value), Convert.ToDateTime(dateTimePicker_TP.Value)) == false)
            {
                MessageBox.Show("Phòng " + textBox_MaPhong.Text + " đã đăng ký !\n" + "Vui lòng chọn ngày nhận phòng/trả phòng khác", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (db.NHANVIENs.Find(textBox_MaNhanVien.Text) == null)
            {
                MessageBox.Show("Mã nhân viên : " + textBox_MaNhanVien.Text + " không tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ( textBox_MaNhanVien.Text == "" ||  textBox_TenKhachHang.Text == "" || comboBox_GioiTinh.Text == "" || textBox_CMND.Text == "" || textBox_SDT.Text == "" || textBox_DiaChi.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(textBox_MaPDK.Text);
            BLL.BLL_QLKS.Instance.ChinhSua_KH(textBox_MaKhachHang.Text, textBox_TenKhachHang.Text, comboBox_GioiTinh.Text, textBox_CMND.Text, textBox_SDT.Text, textBox_DiaChi.Text);
            BLL.BLL_QLKS.Instance.ChinhSua_PDK(textBox_MaPDK.Text, pdk.NGAYDANGKY.Value, dateTimePicker_DP.Value, dateTimePicker_TP.Value, textBox_MaPhong.Text, textBox_MaNhanVien.Text, textBox_TienCoc.Text);
            BLL.BLL_QLKS.Instance.ChinhSua_HD(textBox_MaHoaDon.Text, textBox_MaPDK.Text);
            MessageBox.Show("Đã chỉnh sửa phòng !", "Thông báo");
        }
        private void buttonThemDV_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            if (comboBox_LoaiDV.Text == "" || textBox_SoLuongDV.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin khi thêm dịch vụ !", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string s = Convert.ToString(textBox_SoLuongDV.Text);
            foreach (char c in s)
            {
                int i = (int)c;
                if (i > 57 || i < 48)
                {
                    MessageBox.Show("Số lượng phải ở dạng số !", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            BLL.BLL_QLKS.Instance.Them_PDV(textBox_MaHoaDon.Text, comboBox_LoaiDV.Text, textBox_SoLuongDV.Text);
            db.SaveChanges();
            dataGridView1.DataSource = BLL.BLL_QLKS.Instance.loadPDV(textBox_MaHoaDon.Text);
            double tongtien = Convert.ToDouble(textBox_TongTien.Text);
            foreach (LOAIDICHVU i in db.LOAIDICHVUs)
                if (i.TENLOAIDICHVU == comboBox_LoaiDV.Text)
                {
                    tongtien += Convert.ToDouble(i.GIALOAIDICHVU * Convert.ToInt32(textBox_SoLuongDV.Text));
                }
            /*foreach (PHIEUDICHVU k in db.PHIEUDICHVUs)
            {
                if (k.MAHOADON == textBox_MaHoaDon.Text)
                {
                    LOAIDICHVU ldv = db.LOAIDICHVUs.Find(k.MALOAIDICHVU);
                    tongtien += Convert.ToDouble(ldv.GIALOAIDICHVU * k.SOLUONG);
                }
            }*/
            textBox_TongTien.Text = tongtien.ToString();
        }
        private void button_XoaDV_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            foreach (DataGridViewRow i in dataGridView1.SelectedRows)
            {
                string tenDV = dataGridView1.SelectedRows[0].Cells["Tên dịch vụ"].Value.ToString();
                string soluong = dataGridView1.SelectedRows[0].Cells["Số lượng"].Value.ToString();
                foreach (LOAIDICHVU j in db.LOAIDICHVUs)
                    if(j.TENLOAIDICHVU==tenDV)
                        BLL.BLL_QLKS.Instance.Xoa_PDV(textBox_MaHoaDon.Text, j.MALOAIDICHVU);
                dataGridView1.DataSource = BLL.BLL_QLKS.Instance.loadPDV(textBox_MaHoaDon.Text);
                double tongtien = Convert.ToDouble(textBox_TongTien.Text);
                foreach (LOAIDICHVU j in db.LOAIDICHVUs)
                    if (j.TENLOAIDICHVU ==tenDV)
                    {
                        tongtien = tongtien - Convert.ToDouble(j.GIALOAIDICHVU * Convert.ToInt32(soluong));
                    }
                textBox_TongTien.Text = tongtien.ToString();
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_TienCoc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_TienCoc_Leave(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            //int t =Convert.ToInt32( textBox_TienCoc.Text);
            if (Convert.ToInt32(textBox_TienCoc.Text) > Convert.ToInt32(textBox_TongTien.Text))
            {
                MessageBox.Show("Tiền cọc không được lớn hơn tổng tiền", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_TienCoc.Text = db.PHIEUDANGKies.Find(textBox_MaPDK.Text).TIENCOC.ToString();
            }
           /* PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(textBox_MaPDK.Text);
            pdk.TIENCOC = Convert.ToInt32(textBox_TienCoc.Text);
            db.SaveChanges();*/
        } 

        private void lichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_LichDatPhong TC = new Form_LichDatPhong(_maNV,_maP);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }

        private void dateTimePicker_TP_ValueChanged(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            DateTime date1 = new DateTime(dateTimePicker_DP.Value.Year, dateTimePicker_DP.Value.Month, dateTimePicker_DP.Value.Day);
            DateTime date2 = new DateTime(dateTimePicker_TP.Value.Year, dateTimePicker_TP.Value.Month, dateTimePicker_TP.Value.Day);
            TimeSpan NgayO = date2 - date1;
            PHONG p = db.PHONGs.Find(textBox_MaPhong.Text);
            if(p!=null)
            {
                LOAIPHONG lp = db.LOAIPHONGs.Find(p.MALOAIPHONG);
                textBox_TongTien.Text = (Convert.ToDouble(lp.GIAPHONG) * NgayO.Days).ToString();
            }    
            
        }

        private void chuyểnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_MaKhachHang.Enabled = false;
            textBox_TenKhachHang.Enabled = false;
            comboBox_GioiTinh.Enabled = false;
            textBox_SDT.Enabled = false;
            textBox_CMND.Enabled = false;
            textBox_DiaChi.Enabled = false;
            textBox_MaHoaDon.Enabled = false;
            textBox_MaPDK.Enabled = false;
            textBox_MaNhanVien.Enabled = false;
            dateTimePicker_DP.Enabled = false;
            dateTimePicker_TP.Enabled = false;
            textBox_MaPhong.Enabled = true;
            buttonDatPhong.Enabled = false;
            button_ThanhToan.Enabled = false;
            button_NhapLai.Enabled = false;
        }
    }
}

