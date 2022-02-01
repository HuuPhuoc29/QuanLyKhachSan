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
    public partial class Form_NhanVien : Form
    {
        public delegate void MyDel(string maNV);
        string maNV = "";
        public Form_NhanVien(string _maNV=null)
        {
            InitializeComponent();
            maNV = _maNV;
            boxMa.Text = BLL.BLL_QLKS.Instance.tangMaNV();
            Show("","","","","","","");
        }
        public void Show(string maNV,string tenNV,string gioitinh, string cmnd, string sdt,string diachi, string chucvu)
        {
            DS_NV.DataSource = BLL.BLL_QLKS.Instance.loadNV(maNV, tenNV, gioitinh, cmnd, sdt, diachi, chucvu);

        }
       
        
        private void DS_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DS_NV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DS_NV.CurrentRow.Selected = true;
                    boxMa.Text = DS_NV.Rows[e.RowIndex].Cells["Mã nhân viên"].FormattedValue.ToString();
                    comboBoxChucVu.Text = DS_NV.Rows[e.RowIndex].Cells["Chức vụ"].FormattedValue.ToString();
                    boxTen.Text = DS_NV.Rows[e.RowIndex].Cells["Tên nhân viên"].FormattedValue.ToString();
                    boxGioiTinh.Text = DS_NV.Rows[e.RowIndex].Cells["Giới tính"].FormattedValue.ToString();
                    boxNgaySinh.Value = Convert.ToDateTime(DS_NV.Rows[e.RowIndex].Cells["Ngày sinh"].FormattedValue);
                    boxCMND.Text = DS_NV.Rows[e.RowIndex].Cells["CMND"].FormattedValue.ToString();
                    boxSDT.Text = DS_NV.Rows[e.RowIndex].Cells["SĐT"].FormattedValue.ToString();
                    boxDiaChi.Text = DS_NV.Rows[e.RowIndex].Cells["Địa chỉ"].FormattedValue.ToString();
                    textBox_MatKhau.Text = DS_NV.Rows[e.RowIndex].Cells["Mật khẩu"].FormattedValue.ToString();
                    boxMa.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                
            }
           
        }
        private void button_ThemNV_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            if (db.NHANVIENs.Find(boxMa.Text) != null)
            {
                MessageBox.Show("Mã nhân viên  =" + boxMa.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (BLL.BLL_QLKS.Instance.kiemtraCMND(boxMa.Text,boxCMND.Text)==false)
            {
                MessageBox.Show("CMND =" + boxCMND.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (boxMa.Text == "" || boxTen.Text=="" || boxGioiTinh.Text=="" || boxCMND.Text=="" || boxSDT.Text=="" || boxDiaChi.Text=="" || comboBoxChucVu.Text=="")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BLL.BLL_QLKS.Instance.Them_NV(boxMa.Text, boxTen.Text,boxNgaySinh.Value, boxGioiTinh.Text, boxCMND.Text, boxSDT.Text, comboBoxChucVu.Text,boxDiaChi.Text,textBox_MatKhau.Text);
            Show("","","","","","","");
            
        }
        private void button_XoaNV_Click(object sender, EventArgs e)
        {
            if (DS_NV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            QLKS db = new QLKS();
            List<NHANVIEN> list = new List<NHANVIEN>();
            for (int i = 0; i < DS_NV.SelectedRows.Count; i++)
            {
                string MaNV = DS_NV.SelectedRows[i].Cells["Mã nhân viên"].Value.ToString();
                NHANVIEN nv = db.NHANVIENs.Find(MaNV);
                int count = db.NHANVIENs.ToList().Count;
                BLL.BLL_QLKS.Instance.Xoa_NV(MaNV);
                if (db.NHANVIENs.ToList().Count == count)
                    list.Add(nv);
            }
            string thongbao = "Mã nhân viên : ";
            if (list.Count > 0)
            {
                foreach (NHANVIEN i in list)
                    thongbao += i.MANHANVIEN + "  ";
                MessageBox.Show(thongbao + "đang thực hiện giao dịch, không thể xóa được!", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            boxMa.Enabled = true;
            boxMa.Text = BLL.BLL_QLKS.Instance.tangMaNV();
            comboBoxChucVu.Text = "";
            boxTen.Text = "";
            boxGioiTinh.Text = "";
            boxNgaySinh.Value = DateTime.Now;
            boxCMND.Text = "";
            boxSDT.Text = "";
            boxDiaChi.Text = "";
            Show("", "", "", "", "", "", "");
        }
        private void button_ChinhSuaNV_Click(object sender, EventArgs e)
        {
            if (BLL.BLL_QLKS.Instance.kiemtraCMND(boxMa.Text,boxCMND.Text) == false)
            {
                MessageBox.Show("CMND =" + boxCMND.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            BLL.BLL_QLKS.Instance.ChinhSua_NV(boxMa.Text, boxTen.Text, boxNgaySinh.Value, boxGioiTinh.Text, boxCMND.Text, boxSDT.Text, comboBoxChucVu.Text, boxDiaChi.Text,textBox_MatKhau.Text);
            Show("", "", "", "", "", "", "");
        }
        private void button_TimKiemNV_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (boxMa.Text != "") count++;
            if (boxTen.Text != "") count++;
            if (boxGioiTinh.Text != "") count++;
            if (boxCMND.Text != "") count++;
            if (boxSDT.Text != "") count++;
            if (boxDiaChi.Text != "") count++;
            if (comboBoxChucVu.Text != "") count++;
            if (count>1)
            {
                MessageBox.Show("Chỉ tìm kiếm được một thuộc tính ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Show(boxMa.Text,boxTen.Text,boxGioiTinh.Text,boxCMND.Text,boxSDT.Text,boxDiaChi.Text,comboBoxChucVu.Text);
        }
        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            boxMa.Enabled = true;
            boxMa.Text = BLL.BLL_QLKS.Instance.tangMaNV();
            comboBoxChucVu.Text = "";
            boxTen.Text = "";
            boxGioiTinh.Text = "";
            boxNgaySinh.Value = DateTime.Now;
            boxCMND.Text = ""; 
            boxSDT.Text = "";
            boxDiaChi.Text = "";
            Show("", "", "", "", "", "", "");
        }
        private void button_ThoatNV_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }
    }
}
