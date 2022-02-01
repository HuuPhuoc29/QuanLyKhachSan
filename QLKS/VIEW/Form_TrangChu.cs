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
    public partial class Form_TrangChu : Form
    {
        public List<Panel> listPanel = new List<Panel>();
        public int width = 100;
        public int height = 100;
        public string maP = "";

        public delegate void MyDel(string maNV);
        string maNV = "";

        public Point initialLocation { get; private set; }

        public Form_TrangChu(string _maNV=null)
        {
            InitializeComponent();
            maNV = _maNV;
            BLL.BLL_QLKS.Instance.loadTrangThai();
            loadTheoChucNang();
        }
        public void loadTheoChucNang()
        {
            QLKS db = new QLKS();
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            if (nv == null) return;
            if(nv.CHUCVU=="Nhân viên")
            {
                nhânViênToolStripMenuItem.Enabled = false;
                DoanhThuToolStripMenuItem1.Enabled = false;
                quảnLýChiTiêuToolStripMenuItem1.Enabled = false;
            }    

        }
        public void loadTangNgay()
        {
            int count = 0;
            QLKS db = new QLKS();
            List<PHIEUDANGKY> list = new List<PHIEUDANGKY>();
            foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
                if (db.HOADONs.Where(p => p.MAPHIEUDANGKY == i.MAPHIEUDANGKY.ToString()).Select(p => p).ToList() == null)
                    list.Add(i);
            foreach (HOADON i in db.HOADONs)
            {
                if (i.NGAYTHANHTOAN.Value.Day == (DateTime.Now.Day) && DateTime.Now.Hour > 12 && (i.TONGTIEN == 0 || i.TONGTIEN == null))
                {
                    foreach (PHIEUDANGKY j in list)
                        if (i.NGAYTHANHTOAN.Value.Day <= j.NGAYTRAPHONG.Value.Day && (i.NGAYTHANHTOAN.Value.Month == j.NGAYTRAPHONG.Value.Month))
                            count++;
                    if (count == list.Count())
                    {
                        PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(i.MAPHIEUDANGKY);
                        if (pdk != null)
                        {
                            KHACHHANG kh = db.KHACHHANGs.Find(pdk.MAKHACHHANG);
                            NHANVIEN nv = db.NHANVIENs.Find(pdk.MANHANVIEN);
                            if (kh != null && nv != null)
                            {

                                DateTime tp = DateTime.Now;
                                BLL.BLL_QLKS.Instance.ChinhSua_PDK(pdk.MAPHIEUDANGKY, pdk.NGAYDANGKY.Value, pdk.NGAYNHANPHONG.Value, tp, pdk.MAPHONG, pdk.MANHANVIEN, pdk.TIENCOC.ToString());
                                BLL.BLL_QLKS.Instance.ChinhSua_HD(i.MAHOADON, i.MAPHIEUDANGKY);
                            }
                        }
                    }

                }
            }

        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            loadTangNgay();
            QLKS db = new QLKS();
            FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new System.Drawing.Point(12, 30);
            flowLayoutPanel1.Size = new System.Drawing.Size(800, 500);
            flowLayoutPanel1.BackColor = Color.White;

            listPanel.Clear();
            foreach (PHONG i in db.PHONGs)
            {
                Panel p = new Panel() { Width = width, Height = height };
                Label label = new Label() { Text = i.SOPHONG.ToString() };
                label.BackColor = Color.CornflowerBlue;
                label.Size = new System.Drawing.Size(45, 25);
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(27, 50);
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label.Click += new EventHandler(Form_TrangChu_MouseClick);

                PictureBox pictureBox = new PictureBox() { Width = width, Height = height };
                pictureBox.Image = new Bitmap(@"C:\Users\Admin\source\repos\DoAn\DoAn1\QLKS\hinh\home_trong.png");
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox.Name = i.MAPHONG;
                pictureBox.Click += new EventHandler(Form_TrangChu_MouseClick);
                //pictureBox.Click += new EventHandler(Form1_MouseClick);
                if (i.TINHTRANG == "Đã nhận")
                {
                    pictureBox.Image = new Bitmap(@"C:\Users\Admin\source\repos\DoAn\hinh\home_danhan.jpg");
                    label.BackColor = Color.Purple;
                }
                else if (i.TINHTRANG == "Trống")
                {
                    pictureBox.Image = new Bitmap(@"C:\Users\Admin\source\repos\DoAn\hinh\home_trong.jpg");
                    label.BackColor = Color.DeepSkyBlue;
                }
                else if (i.TINHTRANG == "Đã đăng ký")
                {
                    pictureBox.Image = new Bitmap(@"C:\Users\Admin\source\repos\DoAn\hinh\home_datphong.jpg");
                    label.BackColor = Color.MediumBlue;
                }
                else 
                {
                    pictureBox.Image = new Bitmap(@"C:\Users\Admin\source\repos\DoAn\hinh\home_suachua.jpg");
                    label.BackColor = Color.DimGray;
                }
                p.Controls.Add(label);
                p.Controls.Add(pictureBox);

                p.Name = i.MAPHONG;
                listPanel.Add(p);
                flowLayoutPanel1.Controls.Add(p);
            }
            this.Controls.Add(flowLayoutPanel1);
           this.initialLocation = this.Location;

        }
        private void Form_TrangChu_MouseClick(object sender, EventArgs e)
        {
            foreach (Panel i in listPanel)
            {
                if ((MousePosition.X - 20) >= (i.Location.X) && (MousePosition.X - 20) <= (i.Height + i.Location.X) && (MousePosition.Y - 55) >= i.Location.Y && (MousePosition.Y - 55) <= (i.Width + i.Location.Y))
                {
                    maP = i.Name;
                    loadFormDatPhong(maP);
                }

            }
        }
        private void loadFormDatPhong(string maP)
        {
            QLKS db = new QLKS();
            PHONG p = db.PHONGs.Find(maP);
            DateTime np = DateTime.Now;
            foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
            {
                List<HOADON> list = db.HOADONs.Where(_p => _p.MAPHIEUDANGKY == i.MAPHIEUDANGKY.ToString()).Select(_p => _p).ToList();
                foreach (HOADON j in list)
                    if (i.MAPHONG == p.MAPHONG && p.TINHTRANG == "Đã nhận" && j.TONGTIEN == 0)
                        np = i.NGAYNHANPHONG.Value;
            }

            if (p.TINHTRANG == "Đã nhận")
            {

                Form_DatPhong DP = new Form_DatPhong();
                DP.Sender(maNV, maP, np);
                this.Hide();
                DP.ShowDialog();
            }
            else if (p.TINHTRANG == "Trống")
            {
                Form_DatPhong DP = new Form_DatPhong();
                DP.Sender(maNV, maP, DateTime.Now);
                this.Hide();
                DP.ShowDialog();
            }
            else if (p.TINHTRANG == "Sửa chữa")
            {
                MessageBox.Show("Phòng " + p.SOPHONG + " đang sửa chữa !", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
                if (i.NGAYNHANPHONG.Value.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy") && i.MAPHONG == maP)
                {
                    Form_DatPhong DP = new Form_DatPhong();
                    DP.Sender(maNV, maP, DateTime.Now);
                    this.Dispose();
                    DP.ShowDialog();
                }
        }

        private void quảnLýĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QuanLyDangKy QLDK = new Form_QuanLyDangKy(maNV);
            this.Dispose();
            QLDK.ShowDialog();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_DangNhap DN = new Form_DangNhap();
            this.Dispose();
            DN.ShowDialog();
            
        }
        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ThongTinTaiKhoan f = new Form_ThongTinTaiKhoan(maNV);
            this.Dispose();
            f.ShowDialog();
        }
        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DoiMatKhau f = new Form_DoiMatKhau(maNV);
            this.Dispose();
            f.ShowDialog();
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NhanVien a = new Form_NhanVien(maNV);
            this.Dispose();
            a.ShowDialog();
        }
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_KhachHang KH = new Form_KhachHang(maNV);
            this.Dispose();
            KH.ShowDialog();
        }
        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DanhSachPhong P = new Form_DanhSachPhong(maNV);
            this.Dispose();
            //this.Hide();
            P.ShowDialog();
        }
        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QuanLyPhong QLP = new Form_QuanLyPhong(maNV);
            this.Dispose();
            //this.Hide();
            QLP.ShowDialog();
        }
        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DichVu DV = new Form_DichVu(maNV);
            this.Dispose();
            //this.Hide();
            DV.ShowDialog();
        }
        private void tínhLợiNhuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DanhSachHoaDon HD = new Form_DanhSachHoaDon(maNV);
            this.Dispose();
            HD.ShowDialog();
        }
        private void danhSáchHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_DoanhThu DT = new Form_DoanhThu(maNV);
            this.Dispose();
            DT.ShowDialog();
        }
        private void quảnLýChiTiêuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_QuanLyChiTieu QLCT = new Form_QuanLyChiTieu(maNV);
            this.Dispose();
            QLCT.ShowDialog();
        }

        private void Form_TrangChu_Move(object sender, EventArgs e)
        {
            this.Location = this.initialLocation;
        }

    }
}

