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
    public partial class Form_DichVu : Form
    {
        public delegate void MyDel(string maNV);
        string maNV = "";
        public Form_DichVu(string _maNV=null)
        {
            InitializeComponent();
            maNV = _maNV;
            textBox_MaDichVu.Text=BLL.BLL_QLKS.Instance.tangMaDV();
            loadTheoChucNang();
            Show("", "", "");

        }
        public void Show(string maDV, string tenDV, string giaDV)
        {
            DS_DV.DataSource = BLL.BLL_QLKS.Instance.loadDV(maDV, tenDV, giaDV);
        }

        public void loadTheoChucNang()
        {
            QLKS db = new QLKS();
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            if (nv == null) return;
            if (nv.CHUCVU == "Nhân viên")
            {
                button_ThemDV.Enabled = false;
                button_XoaDV.Enabled = false;
                button_ChinhSuaDV.Enabled = false;
                button_XoaDV.Enabled = false;
            }
        }
        private void button_ThoatDV_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }

        private void button_ThemDV_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            if (db.NHANVIENs.Find(textBox_MaDichVu.Text) != null)
            {
                MessageBox.Show("Mã dịch vụ  =" + textBox_MaDichVu.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (textBox_MaDichVu.Text==""|| textBox_TenDichVu.Text == "" || textBox_GiaDichVu.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BLL.BLL_QLKS.Instance.Them_DV(textBox_MaDichVu.Text, textBox_TenDichVu.Text, textBox_GiaDichVu.Text);
            Show("", "", "");
        }

        private void DS_DV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DS_DV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DS_DV.CurrentRow.Selected = true;
                    textBox_MaDichVu.Text = DS_DV.Rows[e.RowIndex].Cells["Mã dịch vụ"].FormattedValue.ToString();
                    textBox_TenDichVu.Text = DS_DV.Rows[e.RowIndex].Cells["Tên dịch vụ"].FormattedValue.ToString();
                    textBox_GiaDichVu.Text = DS_DV.Rows[e.RowIndex].Cells["Giá"].FormattedValue.ToString();
                    textBox_MaDichVu.Enabled = false;
                }
            }
            catch (Exception ex)
            {
               
            }
            
        }

        private void button_XoaDV_Click(object sender, EventArgs e)
        {
            if (DS_DV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            QLKS db = new QLKS();
            List<LOAIDICHVU> list = new List<LOAIDICHVU>();
            for (int i = 0; i < DS_DV.SelectedRows.Count; i++)
            {
                string maDV = DS_DV.SelectedRows[i].Cells["Mã dịch vụ"].Value.ToString();
                    LOAIDICHVU ldv = db.LOAIDICHVUs.Find(maDV);
                int count = db.LOAIDICHVUs.ToList().Count;
                BLL.BLL_QLKS.Instance.Xoa_DV(maDV);
                    if (db.LOAIDICHVUs.ToList().Count == count)
                        list.Add(ldv);
            }
            string thongbao = "Mã dịch vụ : ";
            if (list.Count > 0)
            {
                foreach (LOAIDICHVU i in list)
                    thongbao += i.MALOAIDICHVU + "  ";
                MessageBox.Show(thongbao + "đang được đăng ký, không thể xóa được!", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox_MaDichVu.Enabled = true;
            textBox_MaDichVu.Text = BLL.BLL_QLKS.Instance.tangMaDV();
            textBox_TenDichVu.Text = "";
            textBox_GiaDichVu.Text = "";
            Show("", "", "");
        }

        private void button_ChinhSuaDV_Click(object sender, EventArgs e)
        {
            BLL.BLL_QLKS.Instance.ChinhSua_DV(textBox_MaDichVu.Text,textBox_TenDichVu.Text,textBox_GiaDichVu.Text);
            Show("", "", "");
        }

        private void button_TimKiemDV_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (textBox_MaDichVu.Text != "") count++;
            if (textBox_TenDichVu.Text != "") count++;
            if (textBox_GiaDichVu.Text != "") count++;
            if (count > 1)
            {
                MessageBox.Show("Chỉ tìm kiếm được một thuộc tính ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Show(textBox_MaDichVu.Text, textBox_TenDichVu.Text, textBox_GiaDichVu.Text);
        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            textBox_MaDichVu.Enabled = true;
            textBox_MaDichVu.Text = BLL.BLL_QLKS.Instance.tangMaDV();
            textBox_TenDichVu.Text = "";
            textBox_GiaDichVu.Text = "";
            Show("", "", "");
        }
    }
}