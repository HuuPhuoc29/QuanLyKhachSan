using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Form_QuanLyDangKy : Form
    {
        public int tiencoc = 0;
         public string _maKH = "";
        public string maP = "";
        public DateTime NgayNhan = DateTime.Now;
        public DateTime NgayTra = DateTime.Now;
        string maNV = "";
       public void getNgay(string _maP,DateTime _NgayNhan,DateTime _NgayTra)
        {
            maP = _maP;
            NgayNhan = _NgayNhan;
            NgayTra = _NgayTra;
        }
        public Form_QuanLyDangKy(string _maNV = null)
        {
            InitializeComponent();
            maNV = _maNV;
            setCBB();
            textBox_MaPhieuDangKy.Text= BLL.BLL_QLKS.Instance.tangMaPDK();
            textBox_MaKhachHang.Text = BLL.BLL_QLKS.Instance.tangMaKH();
            textBox_MaNhanVien.Text = maNV;
            textBox_MaNhanVien.Enabled = true;
            dateTimePicker_NgayDangKy.Value = DateTime.Now;
            dateTimePicker_NgayNhanPhong.Value = DateTime.Now;
            dateTimePicker_NgayTraPhong.Value = DateTime.Now;
            Show("", DateTime.Now, DateTime.Now, DateTime.Now, "", "","", "", "", "", "", "", "");

        }
        public void setCBB()
        {
            QLKS db = new QLKS();
            foreach (LOAIPHONG i in db.LOAIPHONGs)
            {
                comboBox_LoaiPhong.Items.Add(new CBBItem { Text = i.TENLOAIPHONG, Value = i.MALOAIPHONG });
            }
        }
        public void Show(string maPDK, DateTime dk, DateTime np, DateTime tp, string maP, string maNV, string tiencoc, string maKH, string tenKH, string gioitinh, string cmnd, string sdt, string diachi)
        {
            DS_PDK.DataSource =BLL.BLL_QLKS.Instance.loadPDK(maPDK, dk, np, tp, maP, maNV, tiencoc, maKH, tenKH, gioitinh, cmnd, sdt, diachi);
        }
        
        private void DS_PDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DS_PDK.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    QLKS db = new QLKS();
                    DS_PDK.CurrentRow.Selected = true;
                    textBox_MaPhieuDangKy.Text = DS_PDK.SelectedRows[0].Cells["Mã phiếu đăng ký"].Value.ToString();
                    PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(textBox_MaPhieuDangKy.Text);
                    if (pdk != null)
                    {
                        dateTimePicker_NgayDangKy.Value = pdk.NGAYDANGKY.Value;
                        dateTimePicker_NgayNhanPhong.Value = pdk.NGAYNHANPHONG.Value;
                        dateTimePicker_NgayTraPhong.Value = pdk.NGAYTRAPHONG.Value;
                        comboBox_MaPhong.Text = pdk.MAPHONG;
                        textBox_MaNhanVien.Text = pdk.MANHANVIEN;
                        textBox_TienCoc.Text = pdk.TIENCOC.ToString();
                        KHACHHANG kh = db.KHACHHANGs.Find(pdk.MAKHACHHANG);
                        if (kh != null)
                        {
                            textBox_MaKhachHang.Text = kh.MAKHACHHANG;
                            textBox_TenKhachHang.Text = kh.TENKHACHHANG;
                            comboBox_GioiTinh.Text = kh.GIOITINH;
                            textBox_CMND.Text = kh.CMND;
                            textBox_SDT.Text = kh.SDT;
                            textBox_DiaChi.Text = kh.DIACHI;
                            _maKH = kh.MAKHACHHANG;
                        }
                    }
                    PHONG p = db.PHONGs.Find(DS_PDK.SelectedRows[0].Cells["Mã phòng"].Value.ToString());
                    if (p != null)
                    {
                        LOAIPHONG lp = db.LOAIPHONGs.Find(p.MALOAIPHONG);
                        if (lp != null) comboBox_LoaiPhong.Text = lp.TENLOAIPHONG;
                    }
                    List<HOADON> hd = db.HOADONs.Where(_p => _p.MAPHIEUDANGKY == textBox_MaPhieuDangKy.Text).Select(_p => _p).ToList();
                    if (hd.Count == 0)
                    {
                        button_HoanTien.Enabled = true;
                    }
                    else
                    {
                        button_HoanTien.Enabled = false;
                    }
                    textBox_MaPhieuDangKy.Enabled = false;
                    textBox_MaNhanVien.Enabled = false;
                    dateTimePicker_NgayDangKy.Enabled = false;


                }
            }
            catch(Exception ex)
            {
               
            }
            
        }
        public bool checkNhapNgay()
        {
            DateTime np = new DateTime(dateTimePicker_NgayNhanPhong.Value.Year, dateTimePicker_NgayNhanPhong.Value.Month, dateTimePicker_NgayNhanPhong.Value.Day);
            DateTime tp = new DateTime(dateTimePicker_NgayTraPhong.Value.Year, dateTimePicker_NgayTraPhong.Value.Month, dateTimePicker_NgayTraPhong.Value.Day);
            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if ((today - np).Days > 0)
            {
                MessageBox.Show("Nhập sai ! \n" + "Ngày nhận phòng không được trước hôm nay ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if ((today - tp).Days > 0)
            {
                MessageBox.Show("Nhập sai ! \n" + "Ngày trả phòng không được trước hôm nay ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if ((tp-np).Days < 1 )
            {
                MessageBox.Show("Nhập sai ! \n" + "Ngày trả phòng phải sau ngày nhận phòng ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        
        private void lịchĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_LichDatPhong TC = new Form_LichDatPhong(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Hide();
            TC.ShowDialog();
        }
        private void button_ThemPDK_Click(object sender, EventArgs e)
        {
            //checkDaDatPhong(textBox_MaPhieuDangKy.Text, comboBox_MaPhong.Text, Convert.ToDateTime(dateTimePicker_NgayNhanPhong.Value), Convert.ToDateTime(dateTimePicker_NgayTraPhong.Value));
            QLKS db = new QLKS();
            if (db.NHANVIENs.Find(textBox_MaNhanVien.Text) == null)
            {
                MessageBox.Show("Mã nhân viên: " + textBox_MaNhanVien.Text + " không tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (db.PHONGs.Find(comboBox_MaPhong.Text) == null)
            {
                MessageBox.Show("Mã phòng: " + comboBox_MaPhong.Text + " không tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (BLL.BLL_QLKS.Instance.kiemtraCMND(textBox_MaKhachHang.Text,textBox_CMND.Text) == false)
            {
                MessageBox.Show("CMND =" + textBox_CMND.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkNhapNgay() == false) return;
            PHONG _p = db.PHONGs.Find(comboBox_MaPhong.Text);
            if (_p.TINHTRANG == "Sửa chữa")
            {
                MessageBox.Show("Phòng " + _p.SOPHONG + " đang sửa chữa ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*if (_p.TINHTRANG == "Đã nhận")
            {
                MessageBox.Show("Phòng " + _p.SOPHONG + " đã nhận !", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            if (BLL.BLL_QLKS.Instance.checkDaDatPhong(textBox_MaPhieuDangKy.Text, comboBox_MaPhong.Text, Convert.ToDateTime(dateTimePicker_NgayNhanPhong.Value), Convert.ToDateTime(dateTimePicker_NgayTraPhong.Value)) == false)
            {
                MessageBox.Show("Phòng " + _p.SOPHONG + " đã đăng ký !\n" + "Vui lòng chọn ngày nhận phòng/trả phòng khác", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (db.PHIEUDANGKies.Find(textBox_MaPhieuDangKy.Text) != null)
            {
                MessageBox.Show("Mã phiếu đăng ký: " + textBox_MaPhieuDangKy.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (db.KHACHHANGs.Find(textBox_MaKhachHang.Text) != null)
            {
                MessageBox.Show("Mã khách hàng: " + textBox_MaKhachHang.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            if (textBox_MaPhieuDangKy.Text=="" || comboBox_MaPhong.Text == "" || textBox_MaNhanVien.Text == "" || textBox_TienCoc.Text=="" || textBox_MaKhachHang.Text == "" || textBox_TenKhachHang.Text == "" || comboBox_GioiTinh.Text == "" || textBox_CMND.Text == "" || textBox_SDT.Text == "" || textBox_DiaChi.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            BLL.BLL_QLKS.Instance.Them_PDK(textBox_MaPhieuDangKy.Text, dateTimePicker_NgayDangKy.Value, dateTimePicker_NgayNhanPhong.Value, dateTimePicker_NgayTraPhong.Value, comboBox_MaPhong.Text, textBox_MaNhanVien.Text,(textBox_TienCoc.Text), textBox_MaKhachHang.Text, textBox_TenKhachHang.Text, comboBox_GioiTinh.Text, textBox_CMND.Text, textBox_SDT.Text, textBox_DiaChi.Text);
            
            Show("",DateTime.Now, DateTime.Now, DateTime.Now, "", "", "" , "","", "", "", "", "");
        }

        private void button_XoaPDK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                QLKS db = new QLKS();
                List<LOAIPHONG> list = new List<LOAIPHONG>();
                List<PHIEUDANGKY> listPDK = new List<PHIEUDANGKY>();
                for (int i = 0; i < DS_PDK.SelectedRows.Count; i++)
                {
                    string MaPDK = DS_PDK.SelectedRows[i].Cells["Mã phiếu đăng ký"].Value.ToString();
                    PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(MaPDK);
                    string maKH = db.PHIEUDANGKies.Find(MaPDK).MAKHACHHANG;
                    int count = db.PHIEUDANGKies.ToList().Count;
                    BLL.BLL_QLKS.Instance.Xoa_PDK(MaPDK);
                    BLL.BLL_QLKS.Instance.Xoa_KH(maKH);
                    if (db.PHIEUDANGKies.ToList().Count == count)
                        listPDK.Add(pdk);
                        

                }
                string thongbao = "Mã phiếu đăng ký : ";
                if (listPDK.Count > 0)
                {
                    foreach (PHIEUDANGKY i in listPDK)
                        thongbao += i.MAPHIEUDANGKY + "  ";
                    MessageBox.Show(thongbao + "đã chuyển qua nhận phòng ! \n" + "Không thể xóa được !", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBox_MaPhieuDangKy.Enabled = true;
                textBox_MaPhieuDangKy.Text = BLL.BLL_QLKS.Instance.tangMaPDK();
                textBox_MaKhachHang.Enabled = true;
                textBox_MaKhachHang.Text = BLL.BLL_QLKS.Instance.tangMaKH();
                comboBox_LoaiPhong.Text = "";
                comboBox_MaPhong.Text = "";
                dateTimePicker_NgayDangKy.Value = DateTime.Now;
                dateTimePicker_NgayNhanPhong.Value = DateTime.Now;
                dateTimePicker_NgayTraPhong.Value = DateTime.Now;
                textBox_TenKhachHang.Text = "";
                textBox_MaNhanVien.Text = maNV;
                comboBox_GioiTinh.Text = "";
                textBox_CMND.Text = "";
                textBox_SDT.Text = "";
                textBox_DiaChi.Text = "";
                Show("", DateTime.Now, DateTime.Now, DateTime.Now, "", "", "", "", "", "", "", "", "");
            }
            
        }

        private void button_ChinhSuaPDK_Click(object sender, EventArgs e)
        {
            
            
            if (checkNhapNgay() == false) return; 
            QLKS db = new QLKS();
            
            if (db.NHANVIENs.Find(textBox_MaNhanVien.Text) == null)
            {
                MessageBox.Show("Mã nhân viên : " + textBox_MaNhanVien.Text + " không tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (db.PHONGs.Find(comboBox_MaPhong.Text) == null)
            {
                MessageBox.Show("Mã phòng : " + comboBox_MaPhong.Text + " không tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BLL.BLL_QLKS.Instance.checkDaDatPhong(textBox_MaPhieuDangKy.Text, comboBox_MaPhong.Text, Convert.ToDateTime(dateTimePicker_NgayNhanPhong.Value), Convert.ToDateTime(dateTimePicker_NgayTraPhong.Value)) == false)
            {
                MessageBox.Show("Phòng " + comboBox_MaPhong.Text + " đã đăng ký !\n" + "Vui lòng chọn ngày nhận phòng/trả phòng khách", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox_MaPhong.Text == "" || textBox_MaNhanVien.Text == "" || textBox_MaKhachHang.Text == "" || textBox_TenKhachHang.Text == "" || comboBox_GioiTinh.Text == "" || textBox_CMND.Text == "" || textBox_SDT.Text == "" || textBox_DiaChi.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BLL.BLL_QLKS.Instance.ChinhSua_KH(textBox_MaKhachHang.Text, textBox_TenKhachHang.Text, comboBox_GioiTinh.Text, textBox_CMND.Text, textBox_SDT.Text, textBox_DiaChi.Text);
            BLL.BLL_QLKS.Instance.ChinhSua_PDK(textBox_MaPhieuDangKy.Text, dateTimePicker_NgayDangKy.Value, dateTimePicker_NgayNhanPhong.Value, dateTimePicker_NgayTraPhong.Value, comboBox_MaPhong.Text, textBox_MaNhanVien.Text, textBox_TienCoc.Text);

            BLL.BLL_QLKS.Instance.loadTrangThai();
            Show("", DateTime.Now, DateTime.Now, DateTime.Now, "", "","", "", "", "", "", "", "");
        }

        private void button_TimKiemPDK_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (textBox_MaPhieuDangKy.Text != "") count++;
            if (textBox_MaNhanVien.Text != "") count++;
            if (comboBox_MaPhong.Text != "") count++;
            if (textBox_MaKhachHang.Text != "") count++;
            if (textBox_TenKhachHang.Text != "") count++;
            if (comboBox_GioiTinh.Text != "") count++;
            if (textBox_CMND.Text != "") count++;
            if (textBox_SDT.Text != "") count++;
            if (textBox_DiaChi.Text != "") count++;
            if (count > 1)
            {
                MessageBox.Show("Chỉ tìm kiếm được một thuộc tính ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Show(textBox_MaPhieuDangKy.Text,dateTimePicker_NgayDangKy.Value,dateTimePicker_NgayNhanPhong.Value,dateTimePicker_NgayTraPhong.Value, comboBox_MaPhong.Text, textBox_MaNhanVien.Text,(textBox_TienCoc.Text), textBox_MaKhachHang.Text, textBox_TenKhachHang.Text, comboBox_GioiTinh.Text, textBox_CMND.Text, textBox_SDT.Text, textBox_DiaChi.Text);
        }

        private void button_LamMoiPDK_Click(object sender, EventArgs e)
        {
            
            textBox_MaPhieuDangKy.Enabled = true;
            textBox_MaPhieuDangKy.Text = BLL.BLL_QLKS.Instance.tangMaPDK();
            textBox_MaKhachHang.Enabled = true;
            textBox_MaKhachHang.Text = BLL.BLL_QLKS.Instance.tangMaKH();
            textBox_MaNhanVien.Text = maNV;
            comboBox_MaPhong.Enabled = true;
            comboBox_LoaiPhong.Enabled = true;
            comboBox_LoaiPhong.Text = "";
            comboBox_MaPhong.Text = "";
            dateTimePicker_NgayDangKy.Value = DateTime.Now;
            dateTimePicker_NgayNhanPhong.Enabled = true;
            dateTimePicker_NgayNhanPhong.Value = DateTime.Now;
            textBox_TenKhachHang.Text = "";
            comboBox_GioiTinh.Text = "";
            textBox_CMND.Text = "";
            textBox_SDT.Text = "";
            textBox_DiaChi.Text = "";
            textBox_TienCoc.Text = "";
            Show("",DateTime.Now, DateTime.Now, DateTime.Now, "", "", "","", "", "", "", "", "");
        }

        private void button_ThoatPDK_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }

        private void comboBox_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_MaPhong.Items.Clear();
            QLKS db = new QLKS();
            string maLP="";
            foreach (LOAIPHONG i in db.LOAIPHONGs)
                if (i.TENLOAIPHONG == comboBox_LoaiPhong.Text)
                {
                    maLP = i.MALOAIPHONG;
                    break;
                }    
            foreach(PHONG i in db.PHONGs)
                if(i.MALOAIPHONG==maLP)
                {
                    comboBox_MaPhong.Items.Add(new CBBItem { Text = i.MAPHONG, Value = i.SOPHONG });
                }    
        }

        private void dateTimePicker_NgayTraPhong_ValueChanged(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            string maLP = "";
            foreach (LOAIPHONG i in db.LOAIPHONGs)
                if (i.TENLOAIPHONG == comboBox_LoaiPhong.Text)
                {
                    maLP = i.MALOAIPHONG;
                    break;
                }
            int gia = 0;
            LOAIPHONG lp = db.LOAIPHONGs.Find(maLP);
            if (lp != null)
            {
                DateTime date1 = new DateTime(dateTimePicker_NgayNhanPhong.Value.Year, dateTimePicker_NgayNhanPhong.Value.Month, dateTimePicker_NgayNhanPhong.Value.Day);
                DateTime date2 = new DateTime(dateTimePicker_NgayTraPhong.Value.Year, dateTimePicker_NgayTraPhong.Value.Month, dateTimePicker_NgayTraPhong.Value.Day);
                TimeSpan NgayO = date2 - date1;
                textBox_TienCoc.Text = (Convert.ToDouble(lp.GIAPHONG) * NgayO.Days).ToString();
            }
        }
        private void dateTimePicker_NgayNhanPhong_ValueChanged(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            string maLP = "";
            foreach (LOAIPHONG i in db.LOAIPHONGs)
                if (i.TENLOAIPHONG == comboBox_LoaiPhong.Text)
                {
                    maLP = i.MALOAIPHONG;
                    break;
                }
            int gia = 0;
            LOAIPHONG lp = db.LOAIPHONGs.Find(maLP);
            if (lp != null)
            {
                DateTime date1 = new DateTime(dateTimePicker_NgayNhanPhong.Value.Year, dateTimePicker_NgayNhanPhong.Value.Month, dateTimePicker_NgayNhanPhong.Value.Day);
                DateTime date2 = new DateTime(dateTimePicker_NgayTraPhong.Value.Year, dateTimePicker_NgayTraPhong.Value.Month, dateTimePicker_NgayTraPhong.Value.Day);
                TimeSpan NgayO = date2 - date1;
                textBox_TienCoc.Text = (Convert.ToDouble(lp.GIAPHONG) * NgayO.Days).ToString();
            }
        }

        private void DS_PDK_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (DS_PDK.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                QLKS db = new QLKS();
                string maPDK = (DS_PDK.Rows[e.RowIndex].Cells["Mã phiếu đăng ký"].FormattedValue.ToString());
                PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(maPDK);
                PHONG p = db.PHONGs.Find(pdk.MAPHONG);
                List<HOADON> hd = db.HOADONs.Where(_p => _p.MAPHIEUDANGKY == pdk.MAPHIEUDANGKY.ToString()).Select(_p => _p).ToList();
                if (pdk != null)
                {
                    DateTime np = new DateTime(pdk.NGAYNHANPHONG.Value.Year, pdk.NGAYNHANPHONG.Value.Month, pdk.NGAYNHANPHONG.Value.Day);
                    DateTime tp = new DateTime(pdk.NGAYTRAPHONG.Value.Year, pdk.NGAYTRAPHONG.Value.Month, pdk.NGAYTRAPHONG.Value.Day);
                    DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    if ((today > tp) || (today == tp && DateTime.Now.Hour > 12))
                    {
                        MessageBox.Show(" Đã quá ngày nhận phòng ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if ((today < np)|| (today==np&& DateTime.Now.Hour<12))
                    {
                        MessageBox.Show(" Chưa tới ngày nhận phòng ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if ((today > np || (today == np && DateTime.Now.Hour > 12)))
                    {
                        Form_DatPhong DP = new Form_DatPhong();
                        DP.Sender(pdk.MANHANVIEN, pdk.MAPHONG, pdk.NGAYNHANPHONG.Value);
                        this.Dispose();
                        DP.ShowDialog();
                    }

                }

            }
        }

        private void xóaVàHoàn100TiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hoàn tiền 100%", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                QLKS db = new QLKS();
                foreach (DataGridViewRow i in DS_PDK.SelectedRows)
                {
                    string MaPDK = DS_PDK.SelectedRows[0].Cells["Mã phiếu đăng ký"].Value.ToString();
                    string maKH = db.PHIEUDANGKies.Find(MaPDK).MAKHACHHANG;
                    int count = db.PHIEUDANGKies.ToList().Count;
                    BLL.BLL_QLKS.Instance.Xoa_PDK(MaPDK);
                    BLL.BLL_QLKS.Instance.Xoa_KH(maKH);
                    if (db.PHIEUDANGKies.ToList().Count == count)
                        MessageBox.Show("Phiêu đăng ký đã chuyển qua nhận phòng ! \n" + "Không thể hoàn tiền được ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                textBox_MaPhieuDangKy.Enabled = true;
                textBox_MaPhieuDangKy.Text = BLL.BLL_QLKS.Instance.tangMaPDK();
                textBox_MaKhachHang.Enabled = true;
                textBox_MaKhachHang.Text = BLL.BLL_QLKS.Instance.tangMaKH();
                textBox_TenKhachHang.Text = "";
                textBox_MaNhanVien.Text = maNV;
                comboBox_GioiTinh.Text = "";
                textBox_CMND.Text = "";
                textBox_SDT.Text = "";
                textBox_DiaChi.Text = "";
                Show("", DateTime.Now, DateTime.Now, DateTime.Now, "", "", "", "", "", "", "", "", "");
            }

        }

        private void xóaVàHoàn50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hoàn tiền 50%", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                QLKS db = new QLKS();
                string maHD = BLL.BLL_QLKS.Instance.tangMaHD();
                BLL.BLL_QLKS.Instance.Them_HD(maHD, textBox_MaPhieuDangKy.Text);
                PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(textBox_MaPhieuDangKy.Text);
                HOADON hd = db.HOADONs.Find(maHD);
                if (hd != null && pdk != null)
                    hd.TONGTIEN = pdk.TIENCOC / 2;
                db.SaveChanges();


            }    
        }

        private void Form_QuanLyDangKy_Load(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            dateTimePicker_NgayNhanPhong.Value = NgayNhan;
            dateTimePicker_NgayTraPhong.Value = NgayTra;
            comboBox_MaPhong.Text = maP;
            PHONG p = db.PHONGs.Find(maP);
            if (p != null)
            {
                int gia = 0;
                LOAIPHONG lp = db.LOAIPHONGs.Find(p.MALOAIPHONG);
                comboBox_LoaiPhong.Text = lp.TENLOAIPHONG;
                gia = Convert.ToInt32(lp.GIAPHONG);
                int SoNgayO = (Convert.ToDateTime(dateTimePicker_NgayTraPhong.Value) - Convert.ToDateTime(dateTimePicker_NgayNhanPhong.Value)).Days;
                textBox_TienCoc.Text = (gia * SoNgayO).ToString();
                tiencoc = gia * SoNgayO;
            }
        }


        private void button_HoanTien_Click(object sender, EventArgs e)
        {

        }
    }
}

