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
    public partial class Form_DanhSachPhong : Form
    {
        public delegate void MyDel(string maNV);
        string maNV = "";
        public Form_DanhSachPhong(string _maNV=null)
        {
            InitializeComponent();
            maNV = _maNV;
            setCBB();
            Show("", "", "","","");
            loadTheoChucNang();

        }
        public void setCBB()
        {
            QLKS db = new QLKS();
            foreach (LOAIPHONG i in db.LOAIPHONGs)
            {
                comboBox_LoaiPhong.Items.Add(new CBBItem { Text = i.TENLOAIPHONG, Value = i.MALOAIPHONG });
            }
        }
        public void Show(string maP, string soP, string loaiP, string gia, string tinhtrang)
        {
            DS_PKS.DataSource =BLL.BLL_QLKS.Instance.loadP(maP, soP,loaiP,gia, tinhtrang);
        }
        public void loadTheoChucNang()
        {
            QLKS db = new QLKS();
            NHANVIEN nv = db.NHANVIENs.Find(maNV);
            if (nv == null) return;
            if (nv.CHUCVU == "Nhân viên")
            {
                button_ThemP.Enabled = false;
                button_XoaP.Enabled = false;
                button_ChinhSuaP.Enabled = false;

            }

        }
        private void PhongKhachSan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }
        private void button_ThoatP_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            //this.hide();
            TC.ShowDialog();
        }
        private void DS_PKS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DS_PKS.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    QLKS db = new QLKS();
                    DS_PKS.CurrentRow.Selected = true;
                    string maP = DS_PKS.Rows[e.RowIndex].Cells["Mã phòng"].FormattedValue.ToString();
                    PHONG p = db.PHONGs.Find(maP);
                    if (p != null)
                    {
                        textBox_MaPhong.Text = p.MAPHONG;
                        textBox_SoPhong.Text = p.SOPHONG;

                        LOAIPHONG lp = db.LOAIPHONGs.Find(p.MALOAIPHONG);
                        if (lp != null)
                        {
                            comboBox_LoaiPhong.Text = lp.TENLOAIPHONG;
                            comboBox_TinhTrang.Text = p.TINHTRANG;
                            textBox_Gia.Text = lp.GIAPHONG.ToString();
                            textBox_MaPhong.Enabled = false;
                            textBox_Gia.Enabled = false;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                
            }
            
        }

        private void button_ThemP_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            if (db.PHONGs.Find(textBox_MaPhong.Text) != null)
            {
                MessageBox.Show("Mã loại phòng : " + textBox_MaPhong.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (BLL.BLL_QLKS.Instance.kiemtraSoPhong(textBox_MaPhong.Text,textBox_SoPhong.Text) == false)
            {
                MessageBox.Show("Số phòng =" + textBox_SoPhong.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (textBox_MaPhong.Text == "" || textBox_SoPhong.Text == "" || comboBox_TinhTrang.Text == "" || comboBox_LoaiPhong.Text == "" || textBox_Gia.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BLL.BLL_QLKS.Instance.Them_P(textBox_MaPhong.Text, comboBox_LoaiPhong.Text, textBox_SoPhong.Text, comboBox_TinhTrang.Text);
            Show("", "", "","","");
        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            textBox_MaPhong.Enabled = true;
            textBox_MaPhong.Text = "";
            comboBox_LoaiPhong.Text = "";
            textBox_SoPhong.Text = "";
            comboBox_TinhTrang.Text = "";
            textBox_Gia.Text = "";
            Show("", "", "","","");
        }

        private void button_XoaP_Click(object sender, EventArgs e)
        {
            if (DS_PKS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            QLKS db = new QLKS();
            List<PHONG> list = new List<PHONG>();
            for (int i = 0; i < DS_PKS.SelectedRows.Count; i++)
            {
                string maP = DS_PKS.SelectedRows[i].Cells["Mã phòng"].Value.ToString();
                PHONG p = db.PHONGs.Find(maP);
                int count = db.PHONGs.ToList().Count;
                BLL.BLL_QLKS.Instance.Xoa_P(maP);
                if (db.PHONGs.ToList().Count == count)
                    list.Add(p);

            }
            string thongbao = "Mã phòng : ";
            if (list.Count > 0)
            {
                foreach (PHONG i in list)
                    thongbao += i.MAPHONG + "  ";
                MessageBox.Show(thongbao + "đang được đăng ký/nhận, không thể xóa được!", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox_MaPhong.Text = "";
            comboBox_TinhTrang.Text = "";
            textBox_SoPhong.Text = "";
            comboBox_TinhTrang.Text = "";
            Show("", "", "", "", "");
        }

        private void button_ChinhSuaP_Click(object sender, EventArgs e)
        {
            if (BLL.BLL_QLKS.Instance.kiemtraSoPhong(textBox_MaPhong.Text, textBox_SoPhong.Text) == false)
            {
                MessageBox.Show("Số phòng :" + textBox_SoPhong.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (BLL.BLL_QLKS.Instance.kiemtraTinhTrang(textBox_MaPhong.Text) == false)
            {
                MessageBox.Show("Số phòng :" + textBox_SoPhong.Text + " đang được giao dịch!\n Không thể thay đổi tình trạng phòng", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            QLKS db = new QLKS();
            BLL.BLL_QLKS.Instance.ChinhSua_P(textBox_MaPhong.Text, ((CBBItem)comboBox_LoaiPhong.SelectedItem).Value, textBox_SoPhong.Text, comboBox_TinhTrang.Text);
            
            Show("", "", "","","");
        }

        private void button_TimKiemP_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (textBox_MaPhong.Text != "") count++;
            if (textBox_SoPhong.Text != "") count++;
            if (comboBox_LoaiPhong.Text != "") count++;
            if (comboBox_TinhTrang.Text != "") count++;
            if (count > 1)
            {
                MessageBox.Show("Chỉ tìm kiếm được một thuộc tính ! ", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Show(textBox_MaPhong.Text, textBox_SoPhong.Text, comboBox_LoaiPhong.Text, textBox_Gia.Text,comboBox_TinhTrang.Text);
        }

        private void comboBox_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            foreach (LOAIPHONG i in db.LOAIPHONGs)
                if (i.TENLOAIPHONG == comboBox_LoaiPhong.Text)
                    textBox_Gia.Text = i.GIAPHONG.ToString();
            
        }

        private void comboBox_TinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    

}

