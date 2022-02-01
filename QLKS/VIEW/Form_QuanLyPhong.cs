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
    public partial class Form_QuanLyPhong : Form
    {
        public delegate void MyDel(string maNV);
        string maNV = "";
        public Form_QuanLyPhong(string _maNV=null)
        {
            InitializeComponent();
            maNV = _maNV;
            Show("", "", "");
            loadTheoChucNang();

        }

        public void Show(string maLP, string tenLP, string gia)
        {
            DS_LP.DataSource = BLL.BLL_QLKS.Instance.loadLP(maLP, tenLP,gia);
        }
        public void loadTheoChucNang()
        {
            QLKS db = new QLKS();
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            if (nv == null) return;
            if (nv.CHUCVU == "Nhân viên")
            {
                button_ThemLP.Enabled = false;
                button_XoaLP.Enabled = false;
                button_ChinhSuaLP.Enabled = false;

            }

        }

        private void DS_LP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DS_LP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DS_LP.CurrentRow.Selected = true;
                    textBox_MaLoaiPhong.Text = DS_LP.Rows[e.RowIndex].Cells["Mã loại phòng"].FormattedValue.ToString();
                    textBox_TenLoaiPhong.Text = DS_LP.Rows[e.RowIndex].Cells["Tên loại phòng"].FormattedValue.ToString();
                    textBox_GiaLoaiPhong.Text = DS_LP.Rows[e.RowIndex].Cells["Giá"].FormattedValue.ToString();
                    textBox_MaLoaiPhong.Enabled = false;
                }
            }
            
            catch(Exception ex)
            {
            }
        }
        private void button_ThemLP_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            if (db.LOAIPHONGs.Find(textBox_MaLoaiPhong.Text) != null)
            {
                MessageBox.Show("Mã loại phòng : " + textBox_MaLoaiPhong.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_MaLoaiPhong.Text == "" || textBox_TenLoaiPhong.Text == "" || textBox_GiaLoaiPhong.Text == "" )
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BLL.BLL_QLKS.Instance.Them_LP(textBox_MaLoaiPhong.Text, textBox_TenLoaiPhong.Text, textBox_GiaLoaiPhong.Text);
            Show("", "", "");

        }
        private void button_XoaLP_Click(object sender, EventArgs e)
        {
            if (DS_LP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            QLKS db = new QLKS();
            List<LOAIPHONG> list = new List<LOAIPHONG>();
            for (int i = 0; i < DS_LP.SelectedRows.Count; i++)
            {
                string maLP = DS_LP.SelectedRows[i].Cells["Mã loại phòng"].Value.ToString();
                LOAIPHONG lp = db.LOAIPHONGs.Find(maLP);
                int count = db.LOAIPHONGs.ToList().Count;
                BLL.BLL_QLKS.Instance.Xoa_LP(maLP);
                if (db.LOAIPHONGs.ToList().Count == count)
                    list.Add(lp);
            }
            string thongbao = "Mã loại phòng : ";
            if (list.Count > 0)
            {
                foreach (LOAIPHONG i in list)
                    thongbao += i.MALOAIPHONG + "  ";
                MessageBox.Show(thongbao + "đang được đăng ký/nhận, không thể xóa được!", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox_MaLoaiPhong.Text = "";
            textBox_TenLoaiPhong.Text = "";
            textBox_GiaLoaiPhong.Text = "";
            Show("", "", "");
        }
        private void button_ChinhSuaLP_Click(object sender, EventArgs e)
        {
            BLL.BLL_QLKS.Instance.ChinhSua_LP(textBox_MaLoaiPhong.Text, textBox_TenLoaiPhong.Text, textBox_GiaLoaiPhong.Text);
            Show("", "","");
        }
        private void button_TimKiemLP_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (textBox_MaLoaiPhong.Text != "") count++;
            if (textBox_TenLoaiPhong.Text != "") count++;
            if (textBox_GiaLoaiPhong.Text != "") count++;
            if (count > 1)
            {
                MessageBox.Show("Chỉ tìm kiếm được một thuộc tính ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Show(textBox_MaLoaiPhong.Text, textBox_TenLoaiPhong.Text,textBox_GiaLoaiPhong.Text);
        }
        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            textBox_MaLoaiPhong.Enabled = true;
            textBox_MaLoaiPhong.Text = "";
            textBox_TenLoaiPhong.Text = "";
            textBox_GiaLoaiPhong.Text = "";
            Show("", "", "");
        }
        private void button_ThoatLP_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }

        private void DS_LP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
