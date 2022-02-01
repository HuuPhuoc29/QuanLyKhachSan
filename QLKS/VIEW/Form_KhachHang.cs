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
    public partial class Form_KhachHang : Form
    {
        public delegate void MyDel(string maNV);
        string maNV = "";
        public Form_KhachHang(string _maNV=null)
        {
            InitializeComponent();
            maNV = _maNV;
            //textBox_MaKhachHang.Enabled = false;
            textBox_MaKhachHang.Text = BLL.BLL_QLKS.Instance.tangMaKH();
            Show("", "", "", "", "", "");

        }
        public void Show(string maKH, string tenKH, string gioitinh, string cmnd, string sdt, string diachi)
        {
            DS_KH.DataSource = BLL.BLL_QLKS.Instance.loadKH(maKH, tenKH, gioitinh, cmnd, sdt, diachi);

        }
        
        private void DS_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DS_KH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DS_KH.CurrentRow.Selected = true;
                    textBox_MaKhachHang.Text = DS_KH.Rows[e.RowIndex].Cells["Mã khách hàng"].FormattedValue.ToString();
                    textBox_TenKhachHang.Text = DS_KH.Rows[e.RowIndex].Cells["Tên khách hàng"].FormattedValue.ToString();
                    comboBox_GioiTinh.Text = DS_KH.Rows[e.RowIndex].Cells["Giới tính"].FormattedValue.ToString();
                    textBox_CMND.Text = DS_KH.Rows[e.RowIndex].Cells["CMND"].FormattedValue.ToString();
                    textBox_SDT.Text = DS_KH.Rows[e.RowIndex].Cells["SĐT"].FormattedValue.ToString();
                    textBox_DiaChi.Text = DS_KH.Rows[e.RowIndex].Cells["Địa chỉ"].FormattedValue.ToString();
                    // textBox_MaKhachHang.Enabled = false;
                }
            }
            catch (Exception ex)
            { }
            
        }
        private void button_ThemKH_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            if (db.NHANVIENs.Find(textBox_MaKhachHang.Text) != null)
            {
                MessageBox.Show("Mã khách hàng =" + textBox_MaKhachHang.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (BLL.BLL_QLKS.Instance.kiemtraCMND(textBox_MaKhachHang.Text,textBox_CMND.Text) == false)
            {
                MessageBox.Show("CMND =" + textBox_CMND.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (textBox_MaKhachHang.Text==""|| textBox_TenKhachHang.Text == "" || comboBox_GioiTinh.Text == "" || textBox_CMND.Text == "" || textBox_SDT.Text == "" || textBox_DiaChi.Text == "" )
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BLL.BLL_QLKS.Instance.Them_KH(textBox_MaKhachHang.Text, textBox_TenKhachHang.Text, comboBox_GioiTinh.Text, textBox_CMND.Text, textBox_SDT.Text, textBox_DiaChi.Text);
            Show("", "", "", "", "", "");

        }
        private void button_XoaKH_Click(object sender, EventArgs e)
        {
            if (DS_KH.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            QLKS db = new QLKS();
            List<KHACHHANG> list = new List<KHACHHANG>();
            for(int i=0; i<DS_KH.SelectedRows.Count;i++)
            {
                string MaKH = DS_KH.SelectedRows[i].Cells["Mã khách hàng"].Value.ToString();
                KHACHHANG kh = db.KHACHHANGs.Find(MaKH);
                int count = db.KHACHHANGs.ToList().Count;
                BLL.BLL_QLKS.Instance.Xoa_KH(MaKH);
                if (db.KHACHHANGs.ToList().Count == count)
                    list.Add(kh);
                   
            }
            string thongbao = "Mã khách hàng : ";
            if(list.Count>0)
            {
                foreach (KHACHHANG i in list)
                    thongbao += i.MAKHACHHANG + "  ";
                MessageBox.Show(thongbao+"đang thực hiện giao dịch, không thể xóa được!", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            textBox_MaKhachHang.Enabled = true;
            textBox_MaKhachHang.Text = BLL.BLL_QLKS.Instance.tangMaKH();
            textBox_TenKhachHang.Text = "";
            comboBox_GioiTinh.Text = "";
            textBox_CMND.Text = "";
            textBox_SDT.Text = "";
            textBox_DiaChi.Text = "";
            Show("", "", "", "", "", "");
        }
        private void button_ChinhSuaKH_Click(object sender, EventArgs e)
        {
            if (BLL.BLL_QLKS.Instance.kiemtraCMND(textBox_MaKhachHang.Text,textBox_CMND.Text) == false)
            {
                MessageBox.Show("CMND =" + textBox_CMND.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            BLL.BLL_QLKS.Instance.ChinhSua_KH(textBox_MaKhachHang.Text, textBox_TenKhachHang.Text, comboBox_GioiTinh.Text, textBox_CMND.Text, textBox_SDT.Text, textBox_DiaChi.Text);
            Show("", "", "", "", "", "");
        }
        private void button_TimKiemKH_Click(object sender, EventArgs e)
        {
            int count = 0;
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
            Show(textBox_MaKhachHang.Text, textBox_TenKhachHang.Text, comboBox_GioiTinh.Text, textBox_CMND.Text, textBox_SDT.Text, textBox_DiaChi.Text);
        }
        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            textBox_MaKhachHang.Enabled = true;
            textBox_MaKhachHang.Text = BLL.BLL_QLKS.Instance.tangMaKH();
            textBox_TenKhachHang.Text = "";
            comboBox_GioiTinh.Text = "";
            textBox_CMND.Text = "";
            textBox_SDT.Text = "";
            textBox_DiaChi.Text = "";
            Show("", "", "", "", "", "");
        }
        private void button_ThoatNV_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
