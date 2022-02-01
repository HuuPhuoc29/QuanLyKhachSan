using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.BLL
{

    class BLL_QLKS
    {
        public DataTable DTNV { get; set; }
        public DataTable DTKH { get; set; }
        public DataTable DTP { get; set; }
        public DataTable DTLP { get; set; }
        public DataTable DTDV { get; set; }
        public DataTable DTPDK { get; set; }
        public DataTable DTPDV { get; set; }
        public DataTable DTHD { get; set; }
        public DataTable DTCT { get; set; }
        
        private static BLL_QLKS _Instance;
        public static BLL_QLKS Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLKS();
                return _Instance;
            }
            private set { }
        }
        private BLL_QLKS()
        {
            //Nhân viên
            DTNV = new DataTable();
            DTNV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Mã nhân viên",typeof(string)),
                new DataColumn("Tên nhân viên",typeof(string)),
                new DataColumn("Chức vụ",typeof(string)),
                new DataColumn("Giới tính",typeof(string)),
                new DataColumn("Ngày sinh",typeof(string)),
                new DataColumn("CMND",typeof(string)),
                new DataColumn("SĐT",typeof(string)),
                new DataColumn("Địa chỉ",typeof(string)),
                new DataColumn("Mật khẩu",typeof(string)),

            });
            //Khách hàng
            DTKH= new DataTable();
            DTKH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Mã khách hàng",typeof(string)),
                new DataColumn("Tên khách hàng",typeof(string)),
                new DataColumn("Giới tính",typeof(string)),
                new DataColumn("CMND",typeof(string)),
                new DataColumn("SĐT",typeof(string)),
                new DataColumn("Địa chỉ",typeof(string)),

            });
            //Phòng
            DTP = new DataTable();
            DTP.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Mã phòng",typeof(string)),
                new DataColumn("Số phòng",typeof(string)),
                new DataColumn("Loại Phòng",typeof(string)),
                new DataColumn("Giá phòng",typeof(string)),
                new DataColumn("Tình trạng",typeof(string)),

            });
            // Loại phòng
            DTLP = new DataTable();
            DTLP.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Mã loại phòng",typeof(string)),
                new DataColumn("Tên loại phòng",typeof(string)),
                new DataColumn("Giá",typeof(string)),

            });
            //Dịch vụ
            DTDV = new DataTable();
            DTDV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Mã dịch vụ",typeof(string)),
                new DataColumn("Tên dịch vụ",typeof(string)),
                new DataColumn("Giá",typeof(string)),

            });
            //Phiếu đăng ký
            DTPDK = new DataTable();
            DTPDK.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Mã phiếu đăng ký",typeof(string)),
                new DataColumn("Tên khách hàng",typeof(string)),
                new DataColumn("Tên nhân viên",typeof(string)),
                new DataColumn("Mã phòng",typeof(string)),
                new DataColumn("Ngày đăng ký",typeof(DateTime)),
                new DataColumn("Ngày nhận phòng",typeof(DateTime)),
                new DataColumn("Ngày trả phòng",typeof(DateTime)),
                new DataColumn("Tiền cọc",typeof(string)),

            });
            //Phiếu dịch vụ
            DTPDV = new DataTable();
            DTPDV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("STT",typeof(int)),
                new DataColumn("Tên dịch vụ",typeof(string)),
                new DataColumn("Số lượng",typeof(int)),
                new DataColumn("Giá",typeof(int)),
            });
            //Hóa đơn
            DTHD = new DataTable();
            DTHD.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Mã hóa đơn",typeof(string)),
                new DataColumn("Mã phiếu đăng ký",typeof(string)),
                new DataColumn("Tên khách hàng",typeof(string)),
                new DataColumn("Tên nhân viên",typeof(string)),
                new DataColumn("Phòng",typeof(string)),
                new DataColumn("Loại phòng",typeof(string)),
                new DataColumn("Ngày trả phòng",typeof(DateTime)),
                new DataColumn("Tổng tiền",typeof(string)),

            });
            //Chi tiêu
            DTCT = new DataTable();
            DTCT.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Mã chi tiêu",typeof(string)),
                new DataColumn("Tên chi tiêu",typeof(string)),
                new DataColumn("Số tiền",typeof(string)),
                new DataColumn("Ngày chi tiêu",typeof(DateTime)),
                new DataColumn("Ghi chú",typeof(string)),

            });
        }
        public void loadTrangThai()
        {
            QLKS db = new QLKS();
            foreach(PHONG i in db.PHONGs)
            {
                i.TINHTRANG = "Trống";
                List<PHIEUDANGKY> listPDK = new List<PHIEUDANGKY>();
                listPDK = db.PHIEUDANGKies.Where(p => p.MAPHONG == i.MAPHONG).Select(p => p).ToList();
                if (listPDK.Count!=0)
                {
                    foreach(PHIEUDANGKY j in listPDK)
                    {
                        List<HOADON> listHD = new List<HOADON>();
                        listHD = db.HOADONs.Where(p => p.PHIEUDANGKY.MAPHIEUDANGKY == j.MAPHIEUDANGKY.ToString()).Select(p => p).ToList();
                        if(listHD.Count!=0)
                        {
                            foreach (HOADON k in listHD)
                            {

                                DateTime np = new DateTime(j.NGAYNHANPHONG.Value.Year, j.NGAYNHANPHONG.Value.Month, j.NGAYNHANPHONG.Value.Day);
                                DateTime tp = new DateTime(j.NGAYTRAPHONG.Value.Year, j.NGAYTRAPHONG.Value.Month, j.NGAYTRAPHONG.Value.Day);
                                DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                                if (np<=now && tp>=now)
                                {
                                    if (k.TONGTIEN == 0) i.TINHTRANG = "Đã nhận";
                                }


                            }
                        }
                        else
                        {
                            DateTime np = new DateTime(j.NGAYNHANPHONG.Value.Year, j.NGAYNHANPHONG.Value.Month, j.NGAYNHANPHONG.Value.Day);
                            DateTime tp = new DateTime(j.NGAYTRAPHONG.Value.Year, j.NGAYTRAPHONG.Value.Month, j.NGAYTRAPHONG.Value.Day);
                            DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                            if (np <= now && tp >= now) i.TINHTRANG = "Đã đăng ký";
                        } 
                            
                    }
                }   
            }    
            /*QLKS db = new QLKS();
            HOADON hd = new HOADON();
            List<PHONG> list1 = new List<PHONG>();
            List<PHONG> list2 = new List<PHONG>();
            List<PHONG> list3 = new List<PHONG>();
            foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
            {
                int count = 0;

                List<HOADON> list = new List<HOADON>();
                list = db.HOADONs.Where(p => p.PHIEUDANGKY.MAPHIEUDANGKY == i.MAPHIEUDANGKY.ToString()).Select(p => p).ToList();

                if (list.Count == 0)
                {
                    DateTime np = new DateTime(i.NGAYNHANPHONG.Value.Year, i.NGAYNHANPHONG.Value.Month, i.NGAYNHANPHONG.Value.Day);
                    DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    if (np == now )
                    {
                        PHONG p = db.PHONGs.Find(i.MAPHONG);
                        if (p != null)
                            list1.Add(p);
                    }
                    
                    else 
                    {
                        PHONG p = db.PHONGs.Find(i.MAPHONG);
                        if (p != null)
                            list2.Add(p);
                    }
                }
                else
                {
                    foreach (HOADON j in list)
                    {

                        if (j.TONGTIEN == 0)
                        {

                            PHONG p = db.PHONGs.Find(i.MAPHONG);
                            if (p != null)
                                list3.Add(p);
                        }
                        else //if (j.TONGTIEN == 0)
                        {
                            //MessageBox.Show(i.MAPHIEUDANGKY + "   " + list.Count.ToString() + "   " + j.TONGTIEN.ToString());
                            PHONG p = db.PHONGs.Find(i.MAPHONG);
                            if (p != null)
                                list2.Add(p);
                        }

                    }
                }

            }
            foreach (PHONG i in list1)
            {
                PHONG p = db.PHONGs.Find(i.MAPHONG);
                i.TINHTRANG = "Đã đăng ký";
                db.SaveChanges();
            }

            foreach (PHONG i in list2)
            {
                PHONG p = db.PHONGs.Find(i.MAPHONG);
                i.TINHTRANG = "Trống";
                db.SaveChanges();
            }
            foreach (PHONG i in list3)
            {
                PHONG p = db.PHONGs.Find(i.MAPHONG);
                i.TINHTRANG = "Đã nhận";
                db.SaveChanges();
            }*/


        }
        public bool kiemtraCMND(string ma,string cmnd)
        {
            QLKS db = new QLKS();
            foreach (NHANVIEN i in db.NHANVIENs)
                if (i.CMND == cmnd&& i.MANHANVIEN!=ma)
                    return false;
            foreach (KHACHHANG i in db.KHACHHANGs)
                if (i.CMND == cmnd && i.MAKHACHHANG != ma)
                    return false;
            return true;
        }
        public bool kiemtraSoPhong(string maP,string sophong)
        {
            QLKS db = new QLKS();
            foreach (PHONG i in db.PHONGs)
                if (i.SOPHONG == sophong &&i.MAPHONG!=maP)
                    return false;
            return true;
        }
        public bool kiemtraTinhTrang(string maP)
        {
            QLKS db = new QLKS();
            foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
                if (i.MAPHONG==maP)
                    return false;
            return true;
        }
        public bool checkDaDatPhong(string maPDK, string maP, DateTime np, DateTime tp)
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
        //Nhân viên
        public List<NHANVIEN> GetListNV(string maNV, string tenNV, string gioitinh, string cmnd, string sdt, string diachi, string chucvu)
        {
            QLKS db = new QLKS();
            List<NHANVIEN> data = new List<NHANVIEN>();
            if (maNV == "" && tenNV == "" && gioitinh == "" && cmnd == "" && sdt == "" && diachi == "" && chucvu == "")
            {
                data = db.NHANVIENs.Select(p => p).ToList();
            }
            else if (maNV != "")
            {
                data = db.NHANVIENs.Where(p => p.MANHANVIEN == maNV.ToString()).Select(p => p).ToList();
            }
            else if (tenNV != "")
            {
                data = db.NHANVIENs.Where(p => p.TENNHANVIEN == tenNV.ToString()).Select(p => p).ToList();
            }
            else if (gioitinh != "")
            {
                data = db.NHANVIENs.Where(p => p.GIOITINH == gioitinh.ToString()).Select(p => p).ToList();
            }
            else if (cmnd != "")
            {
                data = db.NHANVIENs.Where(p => p.CMND == cmnd.ToString()).Select(p => p).ToList();
            }
            else if (sdt != "")
            {
                data = db.NHANVIENs.Where(p => p.SDT == sdt.ToString()).Select(p => p).ToList();
            }
            else if (diachi != "")
            {
                data = db.NHANVIENs.Where(p => p.DIACHI == diachi.ToString()).Select(p => p).ToList();
            }
            else if (chucvu != "")
            {
                data = db.NHANVIENs.Where(p => p.CHUCVU == chucvu.ToString()).Select(p => p).ToList();
            }
            return data;
        }
        public DataTable loadNV(string maNV, string tenNV, string gioitinh, string cmnd, string sdt, string diachi, string chucvu)
        {
            QLKS db = new QLKS();
            DTNV.Rows.Clear();
            List<NHANVIEN> list = GetListNV( maNV,  tenNV,  gioitinh,  cmnd,  sdt,  diachi,  chucvu);
            DataTable data = DTNV;
            foreach (NHANVIEN i in list)
            {
                DataRow dr = data.NewRow();
                dr["Mã nhân viên"] = i.MANHANVIEN;
                dr["Tên nhân viên"] = i.TENNHANVIEN;
                dr["Chức vụ"] = i.CHUCVU;
                dr["Giới tính"] = i.GIOITINH;
                dr["Ngày sinh"] = i.NGAYSINH;
                dr["CMND"] = i.CMND;
                dr["SĐT"] = i.SDT;
                dr["Địa chỉ"] = i.DIACHI;
                dr["Mật khẩu"] = i.MATKHAU;
                data.Rows.Add(dr);
            }
            return data;
        }
        public string tangMaNV()
        {
            QLKS db = new QLKS();
            int count = db.NHANVIENs.ToList().Count() + 1;
            while (db.NHANVIENs.Find("NV" + (count).ToString()) != null)
                count++;
            return "NV" + count.ToString();
        }
        public void Them_NV(string maNV, string tenNV, DateTime ngaysinh, string gioitinh, string CMND, string sdt, string chucvu, string diachi,string matkhau)
        {
            QLKS db = new QLKS();
            NHANVIEN nv = new NHANVIEN();
            nv.MANHANVIEN = maNV;
            nv.TENNHANVIEN = tenNV;
            nv.GIOITINH = gioitinh;
            nv.CMND = CMND;
            nv.SDT = sdt;
            nv.NGAYSINH = ngaysinh;
            nv.DIACHI = diachi;
            nv.CHUCVU = chucvu;
            nv.MATKHAU = matkhau;
            NHANVIEN _nv = db.NHANVIENs.Add(nv);
            db.SaveChanges();
        }
        public void Xoa_NV(string maNV)
        {
            QLKS db = new QLKS();
            int count = 0;
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            if (nv != null)
            {
                foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
                {
                    if (i.MANHANVIEN != maNV)
                        count++;
                }
                //kiểm tra khách hàng muốn xóa có nằm trong phiếu dang ky nào ko, nếu ko thì xóa được
                if (db.PHIEUDANGKies.ToList().Count == count) // khach hang dang muon xoa không nằm trong phiếu đăng kí nào
                {

                    db.NHANVIENs.Remove(nv);
                    db.SaveChanges();
                }
            }
        }
        public void ChinhSua_NV(string maNV, string tenNV, DateTime ngaysinh, string gioitinh, string CMND, string sdt, string chucvu, string diachi,string matkhau)
        {
            QLKS db = new QLKS();
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            nv.TENNHANVIEN = tenNV;
            nv.GIOITINH = gioitinh;
            nv.CMND = CMND;
            nv.SDT = sdt;
            nv.NGAYSINH = ngaysinh;
            nv.DIACHI = diachi;
            nv.CHUCVU = chucvu;
            nv.MATKHAU = matkhau;
            db.SaveChanges();
        }


        //Khách hàng
        public List<KHACHHANG> GetListKH(string maKH, string tenKH, string gioitinh, string cmnd, string sdt, string diachi)
        {
            QLKS db = new QLKS();
            List<KHACHHANG> data = new List<KHACHHANG>();
            if (maKH == "" && tenKH == "" && gioitinh == "" && cmnd == "" && sdt == "" && diachi == "")
            {
                data = db.KHACHHANGs.Select(p => p).ToList();
            }
            else if (maKH != "")
            {
                data = db.KHACHHANGs.Where(p => p.MAKHACHHANG == maKH.ToString()).Select(p => p).ToList();
            }
            else if (tenKH != "")
            {
                data = db.KHACHHANGs.Where(p => p.TENKHACHHANG == tenKH.ToString()).Select(p => p).ToList();
            }
            else if (gioitinh != "")
            {
                data = db.KHACHHANGs.Where(p => p.GIOITINH == gioitinh.ToString()).Select(p => p).ToList();
            }
            else if (cmnd != "")
            {
                data = db.KHACHHANGs.Where(p => p.CMND == cmnd.ToString()).Select(p => p).ToList();
            }
            else if (sdt != "")
            {
                data = db.KHACHHANGs.Where(p => p.SDT == sdt.ToString()).Select(p => p).ToList();
            }
            else if (diachi != "")
            {
                data = db.KHACHHANGs.Where(p => p.DIACHI == diachi.ToString()).Select(p => p).ToList();
            }
            foreach(HOADON i in db.HOADONs)
                if(i.TONGTIEN!=0 )
                {
                    PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(i.MAPHIEUDANGKY);
                    KHACHHANG kh = db.KHACHHANGs.Find(pdk.MAKHACHHANG);
                    data.Remove(kh);
                }    

            return data;
        }
        /*public List<KHACHHANG> GetListKH_ChuaThanhToan(string maKH, string tenKH, string gioitinh, string cmnd, string sdt, string diachi)
        {
            QLKS db = new QLKS();
            List<KHACHHANG> data = new List<KHACHHANG>();
            foreach (KHACHHANG i in db.KHACHHANGs)
                if (i.MAKHACHHANG == maKH)
                    foreach (PHIEUDANGKY j in db.PHIEUDANGKies)
                        if (j.MAKHACHHANG == i.MAKHACHHANG)
                            foreach (HOADON k in db.HOADONs)
                                if (j.MAPHIEUDANGKY == k.MAPHIEUDANGKY)
                                    if (k.TONGTIEN == 0)
                                    {
                                        
                                        //khach han nay chua tinh tien, chua bị xoa

                                        if (maKH == "" && tenKH == "" && gioitinh == "" && cmnd == "" && sdt == "" && diachi == "")
                                        {
                                            data = db.KHACHHANGs.Select(p => p).ToList();
                                        }
                                        else if (maKH != "")
                                        {
                                            data = db.KHACHHANGs.Where(p => p.MAKHACHHANG == maKH.ToString()).Select(p => p).ToList();
                                        }
                                        else if (tenKH != "")
                                        {
                                            data = db.KHACHHANGs.Where(p => p.TENKHACHHANG == tenKH.ToString()).Select(p => p).ToList();
                                        }
                                        else if (gioitinh != "")
                                        {
                                            data = db.KHACHHANGs.Where(p => p.GIOITINH == gioitinh.ToString()).Select(p => p).ToList();
                                        }
                                        else if (cmnd != "")
                                        {
                                            data = db.KHACHHANGs.Where(p => p.CMND == cmnd.ToString()).Select(p => p).ToList();
                                        }
                                        else if (sdt != "")
                                        {
                                            data = db.KHACHHANGs.Where(p => p.SDT == sdt.ToString()).Select(p => p).ToList();
                                        }
                                        else if (diachi != "")
                                        {
                                            data = db.KHACHHANGs.Where(p => p.DIACHI == diachi.ToString()).Select(p => p).ToList();
                                        }
                                    }



            return data;
        }*/
        public DataTable loadKH(string maKH, string tenKH, string gioitinh, string cmnd, string sdt, string diachi)
        {
            QLKS db = new QLKS();
            DTKH.Rows.Clear();
            List<KHACHHANG> list = GetListKH(maKH, tenKH, gioitinh, cmnd, sdt, diachi);
            DataTable data = DTKH;
            foreach (KHACHHANG i in list)
            {
                DataRow dr = data.NewRow();
                dr["Mã khách hàng"] = i.MAKHACHHANG;
                dr["Tên khách hàng"] = i.TENKHACHHANG;
                dr["Giới tính"] = i.GIOITINH;
                dr["CMND"] = i.CMND;
                dr["SĐT"] = i.SDT;
                dr["Địa chỉ"] = i.DIACHI;
                data.Rows.Add(dr);
            }
            return data;
        }
        public string tangMaKH()
        {
            QLKS db = new QLKS();
            int count = db.KHACHHANGs.ToList().Count() + 1;
            while (db.KHACHHANGs.Find("KH" + (count).ToString()) != null)
                count++;
            return "KH" + (count).ToString();
        }
        public void Them_KH(string maKH, string tenKH, string gioitinh, string cmnd, string sdt, string diachi)
        {
            QLKS db = new QLKS();
            KHACHHANG kh = new KHACHHANG();
            kh.MAKHACHHANG = maKH;
            kh.TENKHACHHANG = tenKH;
            kh.GIOITINH = gioitinh;
            kh.CMND = cmnd;
            kh.SDT = sdt;
            kh.DIACHI = diachi;
            KHACHHANG _kh = db.KHACHHANGs.Add(kh);
            db.SaveChanges();
        }
        public void Xoa_KH(string maKH)
        {
            QLKS db = new QLKS();
            int count = 0;
            KHACHHANG kh = db.KHACHHANGs.Find(maKH);
            if (kh != null)
            {
                foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
                {
                    if (i.MAKHACHHANG != maKH)
                        count++;
                }
                //kiểm tra khách hàng muốn xóa có nằm trong phiếu dang ky nào ko, nếu ko thì xóa được
                if (db.PHIEUDANGKies.ToList().Count == count) // khach hang dang muon xoa không nằm trong phiếu đăng kí nào
                {

                    db.KHACHHANGs.Remove(kh);
                    db.SaveChanges();
                }
            }

        }
        /*public void Xoa_KH2(string maKH)
        {
            QLKS db = new QLKS();
            int count = 0;
            KHACHHANG kh = db.KHACHHANGs.Find(maKH);
            string maPDK = "";
            if (kh != null)
            {
                foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
                {
                    if (i.MAKHACHHANG == maKH)
                    {
                        maPDK = i.MAPHIEUDANGKY;

                    }

                    foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
                    {
                        if (i.MAKHACHHANG != maKH)
                            count++;
                    }
                    //kiểm tra khách hàng muốn xóa có nằm trong phiếu dang ky nào ko, nếu ko thì xóa được
                    if (db.PHIEUDANGKies.ToList().Count == count) // khach hang dang muon xoa không nằm trong phiếu đăng kí nào
                    {

                        db.KHACHHANGs.Remove(kh);
                        db.SaveChanges();
                    }
                }

                if (maPDK != null)
                {
                    PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(maPDK);
                    pdk.MAKHACHHANG = maKH;
                    db.SaveChanges();
                }

                db.KHACHHANGs.Remove(kh);
                db.SaveChanges();
            }

        }*/
        public void ChinhSua_KH(string maKH, string tenKH, string gioitinh, string cmnd, string sdt, string diachi)
        {
            QLKS db = new QLKS();
            KHACHHANG kh = db.KHACHHANGs.Find(maKH);
            kh.TENKHACHHANG = tenKH;
            kh.GIOITINH = gioitinh;
            kh.CMND = cmnd;
            kh.SDT = sdt;
            kh.DIACHI = diachi;
            db.SaveChanges();
        }


        //Phòng
        public List<PHONG> GetListP(string maP, string soP, string loaiP, string gia, string tinhtrang)
        {
            QLKS db = new QLKS();
            List<PHONG> data = new List<PHONG>();
            if (maP == "" && loaiP == "" && soP == "" && tinhtrang == "" && gia == "")
            {
                data = db.PHONGs.Select(p => p).ToList();
            }
            else if (maP != "")
            {
                data = db.PHONGs.Where(p => p.MAPHONG == maP.ToString()).Select(p => p).ToList();
            }
            else if (loaiP != "")
            {
                data = db.PHONGs.Where(p => p.LOAIPHONG.TENLOAIPHONG == loaiP.ToString()).Select(p => p).ToList();
            }
            else if (soP != "")
            {
                data = db.PHONGs.Where(p => p.SOPHONG == soP.ToString()).Select(p => p).ToList();
            }
            else if (tinhtrang != "")
            {
                data = db.PHONGs.Where(p => p.TINHTRANG == tinhtrang.ToString()).Select(p => p).ToList();
            }
            else if (gia != "")
            {
                data = db.PHONGs.Where(p => p.LOAIPHONG.GIAPHONG.ToString() == gia).Select(p => p).ToList();
            }
            return data;
           
        }
        public DataTable loadP(string maP, string soP, string loaiP, string gia, string tinhtrang)
        {
            QLKS db = new QLKS();
            DTP.Rows.Clear();
            List<PHONG> list = GetListP(maP, soP, loaiP, gia, tinhtrang);
            DataTable data = DTP;
            foreach (PHONG i in list)
            {
                DataRow dr = data.NewRow();
                dr["Mã phòng"] = i.MAPHONG;
                dr["Số phòng"] = i.SOPHONG;
                LOAIPHONG lp = db.LOAIPHONGs.Find(i.MALOAIPHONG);
                if (lp != null)
                {
                    dr["Loại Phòng"] = lp.TENLOAIPHONG;
                    dr["Giá phòng"] = lp.GIAPHONG;
                }   
                dr["Tình trạng"] = i.TINHTRANG;
                data.Rows.Add(dr);
            }
            return data;
        }
        public void Them_P(string maP, string tenLP, string soP, string tinhtrang)
        {
            QLKS db = new QLKS();
            PHONG p = new PHONG();
            p.MAPHONG = maP;
            foreach(LOAIPHONG i in db.LOAIPHONGs)
                if(i.TENLOAIPHONG==tenLP)
                {
                    p.MALOAIPHONG = i.MALOAIPHONG;
                    break;
                }    
            p.TINHTRANG = tinhtrang;
            p.SOPHONG = soP;
            PHONG _p = db.PHONGs.Add(p);
            db.SaveChanges();
        }
        public void ChinhSua_P(string maP, string maLP, string tenP, string tinhtrang)
        {
            QLKS db = new QLKS();
            PHONG p = db.PHONGs.Find(maP);
            if(p!=null)
            {
                p.MALOAIPHONG = maLP;
                p.SOPHONG = tenP;
                p.TINHTRANG = tinhtrang;
                db.SaveChanges();
            }    
            
        }
        public void Xoa_P(string maP)
        {
            QLKS db = new QLKS();
            int count = 0;
            PHONG p = db.PHONGs.Find(maP);
            if (p != null)
            {
                foreach (PHIEUDANGKY i in db.PHIEUDANGKies)
                {
                    if (i.MAPHONG != maP)
                        count++;
                }
                //kiểm tra phong muốn xóa có nằm trong phiếu dang ky nào ko, nếu ko thì xóa được
                if (db.PHIEUDANGKies.ToList().Count == count) // phongf dang muon xoa không nằm trong phiếu đăng kí nào
                {

                    db.PHONGs.Remove(p);
                    db.SaveChanges();
                }
            }
        }


        //Loại phòng
        public List<LOAIPHONG> GetListLP(string maLP, string tenLP, string gia)
        {
            QLKS db = new QLKS();
            List<LOAIPHONG> data = new List<LOAIPHONG>();
            if (maLP == "" && tenLP == "" && gia == "")
            {
                data = db.LOAIPHONGs.Select(p => p).ToList();
            }
            else if (maLP != "")
            {
                data = db.LOAIPHONGs.Where(p => p.MALOAIPHONG == maLP.ToString()).Select(p => p).ToList();
            }
            else if (tenLP != "")
            {
                data = db.LOAIPHONGs.Where(p => p.TENLOAIPHONG == tenLP.ToString()).Select(p => p).ToList();
            }
            else if (gia != "")
            {
                data = db.LOAIPHONGs.Where(p => p.GIAPHONG.ToString() == gia).Select(p => p).ToList();
            }
            return data;
        }
        public DataTable loadLP(string maLP, string tenLP, string gia)
        {
            QLKS db = new QLKS();
            DTLP.Rows.Clear();
            List<LOAIPHONG> list = GetListLP(maLP, tenLP, gia);
            DataTable data = DTLP;
            foreach (LOAIPHONG i in list)
            {
                DataRow dr = data.NewRow();
                dr["Mã loại phòng"] = i.MALOAIPHONG;
                dr["Tên loại phòng"] = i.TENLOAIPHONG;
                dr["Giá"] = i.GIAPHONG;
                data.Rows.Add(dr);

            }
            return data;
        }
        public void Them_LP(string maLP, string tenLP, string gia)
        {
            QLKS db = new QLKS();
            LOAIPHONG lp = new LOAIPHONG();
            lp.MALOAIPHONG = maLP;
            lp.TENLOAIPHONG = tenLP;
            lp.GIAPHONG =Convert.ToInt32( gia);
            LOAIPHONG _lp = db.LOAIPHONGs.Add(lp);
            db.SaveChanges();
        }
        public void Xoa_LP(string maLP)
        {
            QLKS db = new QLKS();
            int count = 0;
            LOAIPHONG lp = db.LOAIPHONGs.Find(maLP);
            if (lp != null)
            {
                foreach (PHONG i in db.PHONGs)
                {
                    if (i.MALOAIPHONG != maLP)
                        count++;
                }
                //kiểm traloại phong muốn xóa có nằm trong phòng nào ko, nếu ko thì xóa được
                if (db.PHONGs.ToList().Count == count) //loai phongf dang muon xoa không nằm trong phong nào
                {

                    db.LOAIPHONGs.Remove(lp);
                    db.SaveChanges();
                }
            }
        }
        public void ChinhSua_LP(string maLP, string tenLP, string gia)
        {
            QLKS db = new QLKS();
            LOAIPHONG lp = db.LOAIPHONGs.Find(maLP);
            lp.TENLOAIPHONG = tenLP;
            lp.GIAPHONG =Convert.ToInt32( gia);
            db.SaveChanges();
        }


        //Dịch vụ
        public List<LOAIDICHVU> GetListDV(string maDV, string tenDV, string giaDV)
        {
            QLKS db = new QLKS();
            List<LOAIDICHVU> data = new List<LOAIDICHVU>();
            if (maDV == "" && tenDV == "" && giaDV == "")
            {
                data = db.LOAIDICHVUs.Select(p => p).ToList();
            }
            else if (maDV != "")
            {
                data = db.LOAIDICHVUs.Where(p => p.MALOAIDICHVU == maDV.ToString()).Select(p => p).ToList();
            }
            else if (tenDV != "")
            {
                data = db.LOAIDICHVUs.Where(p => p.TENLOAIDICHVU == tenDV.ToString()).Select(p => p).ToList();
            }
            else if (giaDV != "")
            {
                data = db.LOAIDICHVUs.Where(p => p.GIALOAIDICHVU.ToString() == giaDV).Select(p => p).ToList();
            }
            return data;
        }
        public DataTable loadDV(string maDV, string tenDV, string gia)
        {
            QLKS db = new QLKS();
            DTDV.Rows.Clear();
            List<LOAIDICHVU> list = GetListDV(maDV, tenDV, gia);
            DataTable data = DTDV;
            foreach (LOAIDICHVU i in list)
            {
                DataRow dr = data.NewRow();
                dr["Mã dịch vụ"] = i.MALOAIDICHVU;
                dr["Tên dịch vụ"] = i.TENLOAIDICHVU;
                dr["Giá"] = i.GIALOAIDICHVU;
                data.Rows.Add(dr);
            }
            return data;
        }
        public string tangMaDV()
        {
            QLKS db = new QLKS();
            int count = db.LOAIDICHVUs.ToList().Count() + 1;
            while (db.LOAIDICHVUs.Find("DV" + (count).ToString()) != null)
                count++;
            return "DV" + count.ToString();
        }
        public void Them_DV(string maDV, string tenDV, string gia)
        {
            QLKS db = new QLKS();
            LOAIDICHVU dv = new LOAIDICHVU();

            dv.MALOAIDICHVU = maDV;
            dv.TENLOAIDICHVU = tenDV;
            dv.GIALOAIDICHVU = Convert.ToInt32(gia);
            LOAIDICHVU _dv = db.LOAIDICHVUs.Add(dv);
            db.SaveChanges();
        }
        public void Xoa_DV(string maDV)
        {
            QLKS db = new QLKS();
            int count = 0;
            LOAIDICHVU dv = db.LOAIDICHVUs.Find(maDV);
            if (dv != null)
            {
                foreach (PHIEUDICHVU i in db.PHIEUDICHVUs)
                {
                    if (i.MALOAIDICHVU != maDV)
                        count++;
                }
                
                if (db.PHIEUDICHVUs.ToList().Count == count) 
                {

                    db.LOAIDICHVUs.Remove(dv);
                    db.SaveChanges();
                }
            }
        }
        public void ChinhSua_DV(string maDV, string tenDV, string gia)
        {
            QLKS db = new QLKS();
            LOAIDICHVU dv = db.LOAIDICHVUs.Find(maDV);
            dv.TENLOAIDICHVU = tenDV;
            dv.GIALOAIDICHVU = Convert.ToInt32(gia);
            db.SaveChanges();
        }

        //Phiếu đăng ký
        public List<PHIEUDANGKY> GetListPDK(string maPDK, DateTime dk, DateTime np, DateTime tp, string maP, string maNV,string tiencoc, string maKH, string tenKH, string gioitinh, string cmnd, string sdt, string diachi)
        {
            QLKS db = new QLKS();
            List<PHIEUDANGKY> data = new List<PHIEUDANGKY>();
            data = db.PHIEUDANGKies.Select(p => p).ToList();
            if (maPDK == "" && maP == "" && maNV == "" &&  tiencoc=="" && maKH == "" && tenKH == "" && gioitinh == "" && cmnd == "" && sdt == "" && diachi == "")
            {
                data = db.PHIEUDANGKies.Select(p => p).ToList();

            }
            else if (maPDK != "")
            {
                data = db.PHIEUDANGKies.Where(p => p.MAPHIEUDANGKY == maPDK.ToString()).Select(p => p).ToList();
            }
            else if (maP != "")
            {
                data = db.PHIEUDANGKies.Where(p => p.MAPHONG == maP.ToString()).Select(p => p).ToList();
            }
            else if (maNV != "")
            {
                data = db.PHIEUDANGKies.Where(p => p.MANHANVIEN == maNV.ToString()).Select(p => p).ToList();
            }
            else if (tiencoc != "")
            {
                data = db.PHIEUDANGKies.Where(p => p.TIENCOC.ToString() == tiencoc).Select(p => p).ToList();
            }
            else if (maKH != "")
            {
                data = db.PHIEUDANGKies.Where(p => p.MAKHACHHANG == maKH.ToString()).Select(p => p).ToList();
            }
            else if (tenKH != "")
            {
                data = db.PHIEUDANGKies.Where(p => p.KHACHHANG.TENKHACHHANG == tenKH.ToString()).Select(p => p).ToList();
            }
            else if (gioitinh != "")
            {
                data = db.PHIEUDANGKies.Where(p => p.KHACHHANG.GIOITINH == gioitinh.ToString()).Select(p => p).ToList();
            }
            else if (cmnd != "")
            {
                data = db.PHIEUDANGKies.Where(p => p.KHACHHANG.CMND == cmnd.ToString()).Select(p => p).ToList();
            }
            else if (sdt != "")
            {
                data = db.PHIEUDANGKies.Where(p => p.KHACHHANG.SDT == sdt.ToString()).Select(p => p).ToList();
            }
            else if (diachi != "")
            {
                data = db.PHIEUDANGKies.Where(p => p.KHACHHANG.DIACHI == diachi.ToString()).Select(p => p).ToList();
            }
            foreach (HOADON i in db.HOADONs)
                if (i.TONGTIEN != 0)
                {
                    PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(i.MAPHIEUDANGKY);
                    data.Remove(pdk);
                }

            return data;
        }
        public DataTable loadPDK(string maPDK, DateTime dk, DateTime np, DateTime tp, string maP, string maNV,string tiencoc, string maKH, string tenKH, string gioitinh, string cmnd, string sdt, string diachi)
        {
            QLKS db = new QLKS();
            DTPDK.Rows.Clear();
            List<PHIEUDANGKY> list = GetListPDK(maPDK, dk, np, tp, maP, maNV,tiencoc, maKH, tenKH, gioitinh, cmnd, sdt, diachi);
            DataTable data = DTPDK;
            foreach (PHIEUDANGKY i in list)
            {

                DataRow dr = data.NewRow();
                dr["Mã phiếu đăng ký"] = i.MAPHIEUDANGKY;
                KHACHHANG kh = db.KHACHHANGs.Find(i.MAKHACHHANG);
                NHANVIEN nv = db.NHANVIENs.Find(i.MANHANVIEN);
                if (kh != null) dr["Tên khách hàng"] = kh.TENKHACHHANG;
                if (nv != null) dr["Tên nhân viên"] = nv.TENNHANVIEN;
                dr["Mã phòng"] = i.MAPHONG;
                dr["Ngày đăng ký"] = Convert.ToDateTime(i.NGAYDANGKY.Value);
                dr["Ngày nhận phòng"] = Convert.ToDateTime(i.NGAYNHANPHONG.Value);
                dr["Ngày trả phòng"] = Convert.ToDateTime(i.NGAYTRAPHONG.Value);
                dr["Tiền cọc"] = i.TIENCOC;
                data.Rows.Add(dr);
            }
            return data;
        }
        public string tangMaPDK()
        {
            QLKS db = new QLKS();
            int count = db.PHIEUDANGKies.ToList().Count() + 1;
            while (db.PHIEUDANGKies.Find("PDK" + (count).ToString()) != null)
                count++;
            return "PDK" + count.ToString();
        }
        public void Them_PDK(string maPDK, DateTime dk, DateTime np, DateTime tp, string maP, string maNV,string tiencoc, string maKH, string tenKH, string gioitinh, string cmnd, string sdt, string diachi)
        {

            QLKS db = new QLKS();
            Them_KH(maKH, tenKH, gioitinh, cmnd, sdt, diachi);
            PHIEUDANGKY pdk = new PHIEUDANGKY();
            pdk.MAPHIEUDANGKY = maPDK;
            pdk.NGAYDANGKY = DateTime.Now;
            pdk.NGAYNHANPHONG = np;
            pdk.NGAYTRAPHONG = tp;
            pdk.MANHANVIEN = maNV;
            pdk.MAPHONG = maP;
            pdk.MAKHACHHANG = maKH;
            pdk.TIENCOC =Convert.ToInt32( tiencoc);
            DateTime _np = new DateTime(np.Year, np.Month, np.Day);
            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            PHONG p = db.PHONGs.Find(maP);
            if (_np == today) p.TINHTRANG = "Đã đăng ký";
            PHIEUDANGKY _pdk = db.PHIEUDANGKies.Add(pdk);
            db.SaveChanges();
        }
        public void Xoa_PDK(string maPDK)
        {
            QLKS db = new QLKS();
            PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(maPDK);
            if (pdk != null)
            {
                int count = 0;
                foreach (HOADON i in db.HOADONs)
                {
                    if (i.MAPHIEUDANGKY != maPDK)
                        count++;
                }
                PHONG p = db.PHONGs.Find(pdk.MAPHONG);
                //kiểm tra phieu dang ky muốn xóa có nằm trong phiếu hóa đơn nào ko, nếu ko thì xóa được
                if (db.HOADONs.ToList().Count == count)
                {
                    db.PHIEUDANGKies.Remove(pdk);
                    if (p != null)
                        p.TINHTRANG = "Trống";
                    db.SaveChanges();
                }
            }

        }
        public void ChinhSua_PDK(string maPDK, DateTime dk, DateTime np, DateTime tp, string maP, string maNV,string tiencoc)
        {

            QLKS db = new QLKS();
            PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(maPDK);
            pdk.NGAYDANGKY = dk;
            pdk.NGAYNHANPHONG = np;
            pdk.NGAYTRAPHONG = tp;
            pdk.MANHANVIEN = maNV;
            if (pdk.MAPHONG!=maP)
            {
                PHONG p = db.PHONGs.Find(pdk.MAPHONG);
                p.TINHTRANG = "Trống";
                PHONG _p = db.PHONGs.Find(maP);
                List<HOADON> list = db.HOADONs.Where(k => k.MAPHIEUDANGKY == pdk.MAPHIEUDANGKY && k.TONGTIEN == 0).Select(k => k).ToList();
                if(list.Count==0)
                {
                    
                    _p.TINHTRANG = "Đã đăng ký";
                    pdk.MAPHONG = maP;
                }  
                else
                {
                    _p.TINHTRANG = "Đã nhận";
                    pdk.MAPHONG = maP;
                }   
            }    
            
            pdk.TIENCOC = Convert.ToInt32(tiencoc);
            db.SaveChanges();
        }

        

        public List<HOADON> GetListHD(string thuoctinh, string ten)
        {
            QLKS db = new QLKS();
            List<HOADON> data = new List<HOADON>();
            TimeSpan t = new TimeSpan(0, 0, 0);
            if (thuoctinh == "" && ten == "")
            {
                data = db.HOADONs.Select(p => p).ToList();

            }
            else if (thuoctinh=="Mã hóa đơn")
            {
                data = db.HOADONs.Where(p => p.MAHOADON == ten.ToString()).Select(p => p).ToList();
            }

            else if (thuoctinh == "Mã phiếu đăng ký")
            {
                data = db.HOADONs.Where(p => p.MAPHIEUDANGKY == ten.ToString()).Select(p => p).ToList();
            }
            else if (thuoctinh == "Tên khách hàng")
            {
                foreach (HOADON i in db.HOADONs)
                {
                    PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(i.MAPHIEUDANGKY);
                    KHACHHANG kh = db.KHACHHANGs.Find(pdk.MAKHACHHANG);
                    if (kh.TENKHACHHANG == ten)
                        data.Add(i);
                }
            }
            else if (thuoctinh == "Phòng")
            {
                foreach (HOADON i in db.HOADONs)
                {
                    PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(i.MAPHIEUDANGKY);
                    PHONG p = db.PHONGs.Find(pdk.MAPHONG);
                    if (p.MAPHONG == ten)
                        data.Add(i);
                }
            }
            else if (thuoctinh == "Loại phòng")
            {
                foreach (HOADON i in db.HOADONs)
                {
                    PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(i.MAPHIEUDANGKY);
                    PHONG p = db.PHONGs.Find(pdk.MAPHONG);
                    LOAIPHONG lp = db.LOAIPHONGs.Find(p.MALOAIPHONG);
                    if (lp.TENLOAIPHONG == ten)
                        data.Add(i);
                }
            }
            else if (thuoctinh == "Tên nhân viên")
            {
                foreach (HOADON i in db.HOADONs)
                {
                    PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(i.MAPHIEUDANGKY);
                    NHANVIEN nv = db.NHANVIENs.Find(pdk.MANHANVIEN);
                    if (nv.TENNHANVIEN == ten)
                        data.Add(i);
                }
            }
            else if (thuoctinh == "Ngày trả phòng")
            {
                foreach (HOADON i in db.HOADONs)
                {
                    PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(i.MAPHIEUDANGKY);
                    {
                        DateTime date = new DateTime(i.NGAYTHANHTOAN.Value.Year, i.NGAYTHANHTOAN.Value.Month, i.NGAYTHANHTOAN.Value.Day);
                        if (date.ToShortDateString() ==ten)
                            data.Add(i);
                    }
                    
                }

            }
            else if (thuoctinh == "Tổng tiền")
            {
                data = db.HOADONs.Where(p => p.TONGTIEN.ToString() == ten.ToString()).Select(p => p).ToList();
            }
            return data;
        }
        public List<HOADON> GetSortListHD(string _Index)
        {
            int Index = Convert.ToInt32(_Index);
            QLKS db = new QLKS();
            TimeSpan t = new TimeSpan(0, 0, 0);
            List<HOADON> list = GetListHD("", "");
            List<object[]> temp = new List<object[]>();
            foreach (HOADON i in list)
            {
                object[] o = new object[8];
                o[0] = i.MAHOADON;
                o[1] = i.MAPHIEUDANGKY;
                PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(i.MAPHIEUDANGKY);
                KHACHHANG kh = db.KHACHHANGs.Find(pdk.MAKHACHHANG);
                NHANVIEN nv = db.NHANVIENs.Find(pdk.MANHANVIEN);
                PHONG p = db.PHONGs.Find(pdk.MAPHONG);
                LOAIPHONG lp = db.LOAIPHONGs.Find(p.MALOAIPHONG);
                o[2] = kh.TENKHACHHANG;
                o[3] = nv.TENNHANVIEN;
                o[4] = pdk.MAPHONG.ToString();
                o[5] = lp.TENLOAIPHONG;
                o[6] = pdk.NGAYTRAPHONG.Value.ToString();
                o[7] = i.TONGTIEN.ToString();
                temp.Add(o);
            }
            for (int i = 0; i < temp.Count; i++)
                for (int j = i + 1; j < temp.Count; j++)
                    if (String.Compare(temp[i][Index].ToString(), temp[j][Index].ToString()) > 0)
                    {
                        object[] ob = temp[i];
                        temp[i] = temp[j];
                        temp[j] = ob;
                    }
            for (int i = 0; i < list.Count; i++)
            {
                list[i].MAHOADON = temp[i][0].ToString();
                list[i].MAPHIEUDANGKY = temp[i][1].ToString();
                list[i].NGAYTHANHTOAN = Convert.ToDateTime(temp[i][6]);
                list[i].TONGTIEN = Convert.ToInt32(temp[i][7]);
            }
            return list;


        }
        public DataTable loadHD(string thuoctinh, string ten,string Index,List<HOADON> list)
        {
            QLKS db = new QLKS();
            if(list==null)
            {
                //List<HOADON> list = new List<HOADON>();
                DTHD.Rows.Clear();
                if (Index == "")
                {
                    list = GetListHD(thuoctinh, ten);
                }
                else
                {
                    list = GetSortListHD(Index);
                }
            }    
            
            DataTable data = DTHD;
            foreach (HOADON i in list)
            {
                int TienThucTe=0;
                DataRow dr = data.NewRow();
                dr["Mã hóa đơn"] = i.MAHOADON;
                dr["Mã phiếu đăng ký"] = i.MAPHIEUDANGKY;
                PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(i.MAPHIEUDANGKY);
                if(pdk!=null)
                {
                    dr["Ngày trả phòng"] = pdk.NGAYTRAPHONG.Value;
                    KHACHHANG kh = db.KHACHHANGs.Find(pdk.MAKHACHHANG);
                    NHANVIEN nv = db.NHANVIENs.Find(pdk.MANHANVIEN);
                    if (kh != null) dr["Tên khách hàng"] = kh.TENKHACHHANG;
                    if (nv != null) dr["Tên nhân viên"] = nv.TENNHANVIEN;
                    PHONG p = db.PHONGs.Find(pdk.MAPHONG);
                     int TienDV = 0;
                       foreach (PHIEUDICHVU j in db.PHIEUDICHVUs)
                                {
                                    if (i.MAHOADON == j.MAHOADON)
                                    {
                                        LOAIDICHVU ldv = db.LOAIDICHVUs.Find(j.MALOAIDICHVU);
                                        TienDV +=Convert.ToInt32( ldv.GIALOAIDICHVU * j.SOLUONG);
                                    }
                                }
                                
                    if (p != null)
                    {
                        dr["Phòng"] = pdk.MAPHONG;
                        LOAIPHONG lp = db.LOAIPHONGs.Find(p.MALOAIPHONG);
                        if (lp != null)
                        {
                            dr["Loại phòng"] = lp.TENLOAIPHONG;

                            DateTime date1 = new DateTime(pdk.NGAYNHANPHONG.Value.Year, pdk.NGAYNHANPHONG.Value.Month, pdk.NGAYNHANPHONG.Value.Day);
                            DateTime date2 = new DateTime(pdk.NGAYTRAPHONG.Value.Year, pdk.NGAYTRAPHONG.Value.Month, pdk.NGAYTRAPHONG.Value.Day);
                            TimeSpan NgayO = date2 - date1;
                            TienThucTe =Convert.ToInt32( NgayO.Days * lp.GIAPHONG)+TienDV;
                        }
                    }
                }   
                if(TienThucTe>i.TONGTIEN && i.TONGTIEN>0) dr["Tổng tiền"] = i.TONGTIEN+" (50%)";
                else if(TienThucTe==0|| TienThucTe==i.TONGTIEN) dr["Tổng tiền"] = i.TONGTIEN;
                data.Rows.Add(dr);
            }
            return data;
        }
        public string tangMaHD()
        {
            QLKS db = new QLKS();
            int count = db.HOADONs.ToList().Count() + 1;
            while (db.HOADONs.Find("HD" + (count).ToString()) != null)
                count++;
            return "HD" + count.ToString();
        }
        public void Them_HD(string maHD, string maPDK)
        {
            QLKS db = new QLKS();
            PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(maPDK); 
            if (pdk != null)
            {
                
                PHONG p = db.PHONGs.Find(pdk.MAPHONG);
                p.TINHTRANG = "Đã nhận";
                HOADON hd = new HOADON();
                hd.MAHOADON = maHD;
                hd.NGAYTHANHTOAN = pdk.NGAYTRAPHONG;
                hd.MAPHIEUDANGKY = maPDK;
                hd.TONGTIEN = 0;
                HOADON _hd = db.HOADONs.Add(hd);
                db.SaveChanges();
            }
            

        }
        public void ChinhSua_HD(string maHD, string maPDK)
        {
            QLKS db = new QLKS();
            HOADON hd = db.HOADONs.Find(maHD);
            if(hd!=null)
            {
                PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(hd.MAPHIEUDANGKY);
                hd.NGAYTHANHTOAN = pdk.NGAYTRAPHONG;

                db.SaveChanges();
            }
           
        }
        public void Xoa_HD(string maHD)
        {
            QLKS db = new QLKS();
            HOADON hd = db.HOADONs.Find(maHD);
            if (hd != null)
            {
                PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(hd.MAPHIEUDANGKY);
                if (pdk != null)
                {
                    PHONG p = db.PHONGs.Find(pdk.MAPHONG);
                    p.TINHTRANG = "Trống";
                    db.SaveChanges();
                    db.HOADONs.Remove(hd);
                    db.SaveChanges();

                }
            }
        }
        
        public DataTable loadPDV(string maHD)
        {
            int count = 0;
            QLKS db = new QLKS();
            DTPDV.Rows.Clear();
            foreach (PHIEUDICHVU j in db.PHIEUDICHVUs)
            {
                if (maHD == j.MAHOADON)
                {
                    LOAIDICHVU ldv = db.LOAIDICHVUs.Find(j.MALOAIDICHVU);
                    DataRow dr = DTPDV.NewRow();
                    dr["STT"] = (++count);
                    dr["Tên dịch vụ"] = ldv.TENLOAIDICHVU;
                    dr["Số lượng"] = j.SOLUONG.ToString();
                    dr["Giá"] = ldv.GIALOAIDICHVU.ToString();
                    DTPDV.Rows.Add(dr);
                }
            }
            return DTPDV;
        }
        public void Them_PDV(string maHD, string tenDV, string soluong)
        {
            QLKS db = new QLKS(); List<PHIEUDICHVU> list = new List<PHIEUDICHVU>();
            HOADON hd = db.HOADONs.Find(maHD);
            int flag = 0;
            int sl = 0;
            string maPDV = "", maLDV = "";
            foreach (LOAIDICHVU i in db.LOAIDICHVUs)
                if (i.TENLOAIDICHVU == tenDV) maLDV = i.MALOAIDICHVU;

            foreach (PHIEUDICHVU i in db.PHIEUDICHVUs)
            {

                if (i.MAHOADON == maHD && i.MALOAIDICHVU == maLDV)
                {
                    flag++;
                    sl = Convert.ToInt32(i.SOLUONG);
                    maPDV = i.MAPHIEUDICHVU;
                }

            }
            if (flag == 0)
            {
                PHIEUDICHVU pdv = new PHIEUDICHVU();
                int count = db.PHIEUDICHVUs.Select(p => p).ToList().Count;
                while (db.PHIEUDICHVUs.Find("PDV" + (count).ToString()) != null) count++;
                pdv.MAPHIEUDICHVU = "PDV" + (count).ToString();
                pdv.MAHOADON = maHD;
                pdv.MALOAIDICHVU = maLDV;
                pdv.SOLUONG = Convert.ToInt32(soluong);
                db.PHIEUDICHVUs.Add(pdv);
                db.SaveChanges();
            }
            else
            {
                PHIEUDICHVU a = db.PHIEUDICHVUs.Find(maPDV);
                a.SOLUONG = sl + Convert.ToInt32(soluong);
                db.SaveChanges();
            }


        }
        public void Xoa_PDV(string maHD, string maLDV)
        {
            QLKS db = new QLKS();
            PHIEUDICHVU pdv = new PHIEUDICHVU();
            foreach (LOAIDICHVU i in db.LOAIDICHVUs)
                if (i.MALOAIDICHVU == maLDV)
                {
                    foreach (PHIEUDICHVU j in db.PHIEUDICHVUs)
                        if (j.MAHOADON == maHD)
                        {
                            pdv = j;
                            break;
                        }
                }
            if (pdv != null)
                db.PHIEUDICHVUs.Remove(pdv);
            db.SaveChanges();


        }


        //Chi tiêu
        public List<CHITIEU> GetListCT(string ma,string ten, int gia, DateTime ngay,string ghichu)
        {
            QLKS db = new QLKS();
            List<CHITIEU> data = new List<CHITIEU>();
            if (ten == "" && gia == 0)
            {
                data = db.CHITIEUx.Select(p => p).ToList();
            }
            else if (ten != "")
            {
                data = db.CHITIEUx.Where(p => p.TEN== ten.ToString()).Select(p => p).ToList();
            }
            else if (gia != 0)
            {
                data = db.CHITIEUx.Where(p => p.GIA == gia).Select(p => p).ToList();
            }
            return data;
        }
        public DataTable loadCT(string ma, string ten, int gia, DateTime ngay, string ghichu,List<CHITIEU> list)
        {
            QLKS db = new QLKS();
            DTCT.Rows.Clear();
            if (list==null)
                list = GetListCT(ma,ten, gia, ngay,ghichu);
            DataTable data = DTCT;
            foreach (CHITIEU i in list)
            {
                DataRow dr = data.NewRow();
                dr["Mã chi tiêu"] = i.MACHITIEU;
                dr["Tên chi tiêu"] = i.TEN;
                dr["Số tiền"] = i.GIA;
                dr["Ngày chi tiêu"] = i.NGAY;
                dr["Ghi chú"] = i.GHICHU;
                data.Rows.Add(dr);

            }
            return data;
        }
        public string tangMaCT()
        {
            QLKS db = new QLKS();
            int count = db.CHITIEUx.ToList().Count() + 1;
            while (db.CHITIEUx.Find("CT" + (count).ToString()) != null)
                count++;
            return "CT" + count.ToString();
        }
        public void Them_CT(string ma, string ten, int gia, DateTime ngay, string ghichu)
        {
            QLKS db = new QLKS();
            CHITIEU ct = new CHITIEU();
            ct.MACHITIEU = ma;
            ct.TEN = ten;
            ct.GIA = gia;
            ct.NGAY = ngay;
            ct.GHICHU = ghichu;
            CHITIEU _ct = db.CHITIEUx.Add(ct);
            db.SaveChanges();
        }
        public void Xoa_CT(string ma)
        {
            QLKS db = new QLKS();
            CHITIEU ct = db.CHITIEUx.Find(ma);
            if (ct != null) db.CHITIEUx.Remove(ct);
            db.SaveChanges();
            
        }
        public void ChinhSua_CT(string ma, string ten, int gia, DateTime ngay, string ghichu)
        {
            QLKS db = new QLKS();
            CHITIEU ct = db.CHITIEUx.Find(ma);
            ct.TEN = ten;
            ct.GIA = gia;
            ct.NGAY = ngay;
            ct.GHICHU = ghichu;

            db.SaveChanges();
        }

    }
}
