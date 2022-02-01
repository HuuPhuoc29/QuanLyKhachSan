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
    public partial class Form_DoanhThu : Form
    {
        public delegate void MyDel(string maNV);
        string maNV = "";
        public Form_DoanhThu(string _maNV=null)
        {
            InitializeComponent();
            maNV = _maNV;
            dateTimePicker_BatDau.Value = DateTime.Now;
            dateTimePicker_KetThuc.Value = DateTime.Now;
            
        }
        public List<HOADON> Show(DateTime _start,DateTime _end)
        {
            List<HOADON> list = new List<HOADON>();
            DateTime start = new DateTime(_start.Year, _start.Month, _start.Day, 0, 0, 0);
            DateTime end = new DateTime(_end.Year, _end.Month, _end.Day, 23, 59, 59);

            QLKS db = new QLKS();
            foreach (HOADON i in db.HOADONs)
                if (i.TONGTIEN != 0 || i.TONGTIEN != null)
                {
                    if (i.NGAYTHANHTOAN.Value >= start && i.NGAYTHANHTOAN.Value <= end)
                        list.Add(i);
                }
            return list;
        }

        private void button_Tinh_Click(object sender, EventArgs e)
        {
            double thu = 0;
            double chi = 0;
            List<CHITIEU> listCT = new List<CHITIEU>();
            List<HOADON> listHD = new List<HOADON>();
            DataTable DT = (DataTable)dataGridView_HoaDon.DataSource;
            DataTable _DT = (DataTable)dataGridView_ChiTieu.DataSource;
            if (DT != null)  DT.Clear();
            if (_DT != null) _DT.Clear();
            DateTime start = new DateTime(dateTimePicker_BatDau.Value.Year, dateTimePicker_BatDau.Value.Month, dateTimePicker_BatDau.Value.Day,0,0,0);
            DateTime end = new DateTime(dateTimePicker_KetThuc.Value.Year, dateTimePicker_KetThuc.Value.Month, dateTimePicker_KetThuc.Value.Day,23,59,59);
            
            QLKS db = new QLKS();
            foreach (HOADON i in db.HOADONs)
                if (i.TONGTIEN!=0 )
                {
                    DateTime day = new DateTime(i.NGAYTHANHTOAN.Value.Year, i.NGAYTHANHTOAN.Value.Month, i.NGAYTHANHTOAN.Value.Day, i.NGAYTHANHTOAN.Value.Hour, i.NGAYTHANHTOAN.Value.Minute, i.NGAYTHANHTOAN.Value.Second);
                    if (day >= start && day <= end)
                    {
                        listHD.Add(i);
                        thu += Convert.ToDouble(i.TONGTIEN);
                    }    
                        
                }
            textBox_TongThu.Text = thu.ToString();
            dataGridView_HoaDon.DataSource = BLL.BLL_QLKS.Instance.loadHD("","","", listHD);

            foreach(CHITIEU i in db.CHITIEUx)
            {
                DateTime day = new DateTime(i.NGAY.Value.Year, i.NGAY.Value.Month, i.NGAY.Value.Day, i.NGAY.Value.Hour, i.NGAY.Value.Minute, i.NGAY.Value.Second);
                if (day >= start && day <= end)
                {
                    listCT.Add(i);
                    chi += Convert.ToDouble(i.GIA);
                }
            }
            textBox_TongChi.Text = chi.ToString();
            dataGridView_ChiTieu.DataSource = BLL.BLL_QLKS.Instance.loadCT("", "", 0,DateTime.Now,"", listCT);

            textBox_LoiNhuan.Text = (thu - chi).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }

        private void Form_DoanhThu_Load(object sender, EventArgs e)
        {
            //if(button_Tinh_Click==true)

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
