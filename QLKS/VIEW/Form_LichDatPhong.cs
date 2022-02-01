using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace QLKS
{
    public partial class Form_LichDatPhong : Form
    {
        string maNV = "";
        string maP = "";
        DateTime np = DateTime.Now;
        DateTime tp = DateTime.Now;
        public static int buttonWidth =52;
        public static int buttonHeight =40;
        public static int DayOfWeek = 7;
        public static int DayOfColumn = 6;
        private List<List<Button>> matrixButton;
        public List<List<Button>> MatrixButton { get => matrixButton; set => matrixButton = value; }

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday","Wednesday" ,"Thursday", "Friday" ,"Saturday", "Sunday" };
        public Form_LichDatPhong(string _maNV = null,string _maP=null)
        {
            maNV = _maNV;
            maP = _maP;
            InitializeComponent();
            loadLich();
            setCBB();
        }
        public void setCBB()
        {
            QLKS db = new QLKS();
            foreach (LOAIPHONG i in db.LOAIPHONGs)
            {
                comboBox_LoaiPhong.Items.Add(new CBBItem { Text = i.TENLOAIPHONG, Value = i.MALOAIPHONG });
            }
        }
        private void comboBox_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_SoPhong.Items.Clear();
            QLKS db = new QLKS();
            string maLP = "";
            foreach (LOAIPHONG i in db.LOAIPHONGs)
                if (i.TENLOAIPHONG == comboBox_LoaiPhong.Text)
                {
                    maLP = i.MALOAIPHONG;
                    break;
                }
            foreach (PHONG i in db.PHONGs)
                if (i.MALOAIPHONG == maLP)
                {
                    comboBox_SoPhong.Items.Add(new CBBItem { Text = i.MAPHONG, Value = i.SOPHONG });
                }
        }
        private void comboBox_SoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNgay(dateTimePicker.Value, (sender as ComboBox));


        }
        //tao ra một m trận các button lịch
        public void loadLich()
        {
            MatrixButton = new List<List<Button>>();
            Button bt = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < DayOfColumn; i++)
            {
                MatrixButton.Add(new List<Button>());
                for (int j = 0; j < DayOfWeek; j++)
                {
                    Button _bt = new Button { Width = buttonWidth, Height = buttonHeight };
                    _bt.Location = new Point(bt.Location.X + bt.Width+5, bt.Location.Y );
                    panel2.Controls.Add(_bt);
                    MatrixButton[i].Add(_bt);
                    bt = _bt;
                }
                bt = new Button() { Width = 0, Height = 0, Location = new Point(0, bt.Location.Y + buttonHeight+5) };
            }
            SetDefaultDate();

        }
        int DayOfMonth(DateTime date)
        {
            switch(date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else return 28;
                default: 
                    return 30;

            }
        }
        //load các ngày lên ma trận button
        public void loadNgay(DateTime date,ComboBox box)
        {
            ClearMatrixButton();
            if (box!=null)
            {
                
                QLKS db = new QLKS();
                string maP = box.Text;
                DateTime useDate = new DateTime(date.Year, date.Month, 1);
                int line = 0;
                for (int i = 1; i <= DayOfMonth(date); i++)
                {
                    int count = 0;
                    int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                    Button bt = MatrixButton[line][column];
                    bt.Text = i.ToString();
                    bt.BackColor = Color.DeepSkyBlue;
                    List<PHIEUDANGKY> listPDK = new List<PHIEUDANGKY>();
                    listPDK = db.PHIEUDANGKies.Where(p => p.MAPHONG == maP.ToString()).Select(p => p).ToList();
                    DateTime now = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, i);
                    foreach (PHIEUDANGKY j in listPDK)
                    {
                       

                        if (count != 0) break;
                        DateTime start = new DateTime(j.NGAYNHANPHONG.Value.Year, j.NGAYNHANPHONG.Value.Month, j.NGAYNHANPHONG.Value.Day);
                        DateTime end = new DateTime(j.NGAYTRAPHONG.Value.Year, j.NGAYTRAPHONG.Value.Month, j.NGAYTRAPHONG.Value.Day);
                        if (start <= now && end>=now)
                        {
                            List<HOADON> listHD = new List<HOADON>();
                            listHD = db.HOADONs.Where(p => p.MAPHIEUDANGKY == j.MAPHIEUDANGKY).Select(p => p).ToList();
                            if (listHD.Count()!=0)
                            {
                                foreach(HOADON k in listHD)
                                    if(k.TONGTIEN==0)
                                    {
                                        bt.BackColor = Color.MediumBlue; //đã nhận
                                        count++;
                                    }    
                            }  
                            else
                            {
                                bt.BackColor = Color.MediumBlue; //đã nhận
                                count++;
                            }    
                           
                        }
                    }
                    DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    if (today == now)
                    {
                        bt.Text += "\nNow";
                        // bt.Font= new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }    
                    if (column >= 6) line++;
                    useDate = useDate.AddDays(1);
                }

            }    
            

        }
        void ClearMatrixButton()
        {
            for(int i=0;i<MatrixButton.Count;i++)
            {
                for(int j=0;j<matrixButton[i].Count;j++)
                {
                    Button bt = MatrixButton[i][j];
                    bt.Text = "";
                    bt.BackColor = Color.White;
                }
            }
        }
        private void Form_LichDatPhong_Load(object sender, EventArgs e)
        {
            if(maP!="")
            {
                QLKS db = new QLKS();
                PHONG p= db.PHONGs.Find(maP);
                if(p!=null)
                {
                    LOAIPHONG lp = db.LOAIPHONGs.Find(p.MALOAIPHONG);
                    comboBox_LoaiPhong.Text = lp.TENLOAIPHONG;
                    comboBox_SoPhong.Text = p.MAPHONG;
                    dateTimePicker_NgayNhan.Enabled = false;
                }
            }
            else
            {
                dateTimePicker_NgayNhan.Enabled = true;
            }
        }

        private void button_ThangTruoc_Click(object sender, EventArgs e)
        {
            DateTime before = new DateTime();
            if (dateTimePicker.Value.Month == 1)
                before = new DateTime(dateTimePicker.Value.Year - 1, 12, dateTimePicker.Value.Day);
            else before = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month - 1, dateTimePicker.Value.Day);
            dateTimePicker.Value = Convert.ToDateTime(before);
        }
       
        private void button_ThangSau_Click(object sender, EventArgs e)
        {
                DateTime after = new DateTime();
            if (dateTimePicker.Value.Month == 12)
                after = new DateTime(dateTimePicker.Value.Year + 1, 1, dateTimePicker.Value.Day);
            else after = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month + 1, dateTimePicker.Value.Day);
            dateTimePicker.Value = Convert.ToDateTime(after);
        }
        void SetDefaultDate()
        {
            dateTimePicker.Value = DateTime.Now;
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            loadNgay((sender as DateTimePicker).Value,comboBox_SoPhong);
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            if (dateTimePicker_NgayNhan.Enabled == false)
            {
                Form_DatPhong DP = new Form_DatPhong();
                DP.Sender(maNV, maP, dateTimePicker_NgayNhan.Value);
                DP.getNgay(comboBox_SoPhong.Text, dateTimePicker_NgayNhan.Value, dateTimePicker_NgayTra.Value);
                this.Dispose();
                DP.ShowDialog();
            }
            else
            {
                Form_QuanLyDangKy QLDK = new Form_QuanLyDangKy(maNV);
                QLDK.getNgay(comboBox_SoPhong.Text, dateTimePicker_NgayNhan.Value, dateTimePicker_NgayTra.Value);
                this.Dispose();
                QLDK.ShowDialog();
            }
        }

        private void button_Chon_Click(object sender, EventArgs e)
        {
            if (BLL.BLL_QLKS.Instance.checkDaDatPhong("", comboBox_SoPhong.Text, Convert.ToDateTime(dateTimePicker_NgayNhan.Value), Convert.ToDateTime(dateTimePicker_NgayTra.Value)) == false)
            {
                MessageBox.Show("Phòng " + comboBox_SoPhong.Text + " đã đăng ký !\n" + "Vui lòng chọn ngày nhận phòng/trả phòng khác", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateTimePicker_NgayNhan.Enabled==false)
            {
                Form_DatPhong DP = new Form_DatPhong();
                DP.Sender(maNV, maP, dateTimePicker_NgayNhan.Value);
                DP.getNgay(comboBox_SoPhong.Text ,dateTimePicker_NgayNhan.Value, dateTimePicker_NgayTra.Value);
                this.Dispose();
                DP.ShowDialog();
            }    
            else
            {
                Form_QuanLyDangKy QLDK = new Form_QuanLyDangKy(maNV);
                QLDK.getNgay(comboBox_SoPhong.Text, dateTimePicker_NgayNhan.Value, dateTimePicker_NgayTra.Value);
                this.Dispose();
                QLDK.ShowDialog();
            }    
            
        }
    }
}
