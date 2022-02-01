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
    public partial class Form_DanhSachHoaDon : Form
    {
        public delegate void MyDel(string maNV);
        string maNV = "";
        public Form_DanhSachHoaDon(string _maNV=null)
        {
            InitializeComponent();
            maNV = _maNV;
            setCBBSort();
            TimeSpan t = new TimeSpan(0, 0, 0);
            Show("", "","");
            loadTheoChucNang();
        }
        public void setCBBSort()
        {
            QLKS db = new QLKS();
            int count = 0;
            foreach (DataColumn i in BLL.BLL_QLKS.Instance.DTHD.Columns)
            {
                comboBox_ThuocTinh.Items.Add(new CBBItem { Text = i.ColumnName, Value = (count++).ToString() }); ;
            }
        }
        public void Show(string thuoctinh,string ten,string Index)
        {
            dataGridView1.DataSource = BLL.BLL_QLKS.Instance.loadHD("","","",null);
        }
        public void loadTheoChucNang()
        {
            QLKS db = new QLKS();
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            if (nv == null) return;
            if (nv.CHUCVU == "Nhân viên")
            {
                button_Xoa.Enabled = false;
            }
        }
        private void Form_DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            TimeSpan t = new TimeSpan(0, 0, 0);
            Show("", "","");

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            QLKS db = new QLKS();
            List<HOADON> list = new List<HOADON>();
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    string MaHD = dataGridView1.SelectedRows[i].Cells["Mã hóa đơn"].Value.ToString();
                    HOADON hd = db.HOADONs.Find(MaHD);  
                    PHIEUDANGKY pdk = db.PHIEUDANGKies.Find(hd.MAPHIEUDANGKY);
                    if (pdk != null)
                    {
                        KHACHHANG kh = db.KHACHHANGs.Find(pdk.MAKHACHHANG);
                        if (kh != null)
                        {
                            foreach (PHIEUDICHVU j in db.PHIEUDICHVUs)
                                if (j.MAHOADON == hd.MAHOADON)
                                    BLL.BLL_QLKS.Instance.Xoa_PDV(hd.MAHOADON, j.MALOAIDICHVU);
                            BLL.BLL_QLKS.Instance.Xoa_HD(hd.MAHOADON);
                            BLL.BLL_QLKS.Instance.Xoa_PDK(pdk.MAPHIEUDANGKY);
                            BLL.BLL_QLKS.Instance.Xoa_KH(kh.MAKHACHHANG);
                        }
                        else list.Add(hd);
                    }
                    else  list.Add(hd);
                        
                }
                if (list.Count==0) MessageBox.Show("Đã xóa thành công !");
                else
                {
                    string thongbao = "Hóa đơn xóa thất bại :";
                    foreach (HOADON i in list)
                        thongbao += i.MAHOADON + "  ";
                    MessageBox.Show(thongbao);
                }    
            }
            TimeSpan t = new TimeSpan(0, 0, 0);
            Show("", "","");
            

        }

        private void button_Thoát_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }



        private void button_SapXep_Click(object sender, EventArgs e)
        {
            string Index = ((CBBItem)comboBox_ThuocTinh.SelectedItem).Value;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLL.BLL_QLKS.Instance.loadHD("", "", Index, null);
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string thuoctinh = comboBox_ThuocTinh.Text;
            string ten = textBox1.Text;
            dataGridView1.DataSource = BLL.BLL_QLKS.Instance.loadHD(thuoctinh,ten,"", null);
        }

        private void button_ChiTiet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string maHD = dataGridView1.SelectedRows[0].Cells["Mã hóa đơn"].Value.ToString();
                Form_ChiTietHoaDon CTDH = new Form_ChiTietHoaDon();
                CTDH.Sender(maNV,maHD);
                this.Dispose();
                CTDH.ShowDialog();
            }
            else if (dataGridView1.SelectedRows.Count==0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dataGridView1.SelectedRows.Count >1)
            {
                MessageBox.Show("Không thể xem chi tiết của nhiều hóa đơn cùng lúc !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
