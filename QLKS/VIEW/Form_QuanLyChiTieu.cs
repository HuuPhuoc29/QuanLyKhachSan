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
    public partial class Form_QuanLyChiTieu : Form
    {
        public delegate void MyDel(string maNV);
        string maNV = "";
        public Form_QuanLyChiTieu(string _maNV=null)
        {
            InitializeComponent();
            maNV = _maNV;
            textBox_Ma.Text= BLL.BLL_QLKS.Instance.tangMaCT();
            Show("", "", 0, DateTime.Now, "");
        }

       
        public void Show(string ma, string ten, int gia, DateTime ngay, string ghichu)
        {
            dataGridView1.DataSource = BLL.BLL_QLKS.Instance.loadCT(ma, ten, gia, ngay, ghichu,null);
        }
        private void button_ThemCT_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            if(db.CHITIEUx.Find(textBox_Ma.Text)!=null)
            {
                MessageBox.Show("Mã chi tiêu : " + textBox_Ma.Text + " đã tồn tại", "Chú ý ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BLL.BLL_QLKS.Instance.Them_CT(textBox_Ma.Text, textBox_Ten.Text, Convert.ToInt32(textBox_Gia.Text), dateTimePicker1.Value, textBox_GhiChu.Text);
            Show("", "", 0, DateTime.Now, "");
        }
        private void button_ThoatCT_Click(object sender, EventArgs e)
        {
            Form_TrangChu TC = new Form_TrangChu(maNV);
            TC.Location = new Point(0, 0);
            TC.StartPosition = FormStartPosition.Manual;
            this.Dispose();
            TC.ShowDialog();
        }

        private void button_XoaCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                QLKS db = new QLKS();
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    string ma = dataGridView1.SelectedRows[i].Cells["Mã chi tiêu"].Value.ToString();
                    BLL.BLL_QLKS.Instance.Xoa_CT(ma);

                }
                textBox_Ma.Text = BLL.BLL_QLKS.Instance.tangMaCT();
                textBox_Ten.Text = "";
                textBox_Gia.Text = "";
                textBox_GhiChu.Text = "";
                Show("", "", 0, DateTime.Now, "");




            }    
                
        }

        private void button_ChinhSuaCT_Click(object sender, EventArgs e)
        {
            BLL.BLL_QLKS.Instance.ChinhSua_CT(textBox_Ma.Text, textBox_Ten.Text,Convert.ToInt32( textBox_Gia.Text),dateTimePicker1.Value,textBox_GhiChu.Text);
            Show("", "", 0, DateTime.Now, "");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    textBox_Ma.Text = dataGridView1.Rows[e.RowIndex].Cells["Mã chi tiêu"].FormattedValue.ToString();
                    textBox_Ten.Text = dataGridView1.Rows[e.RowIndex].Cells["Tên chi tiêu"].FormattedValue.ToString();
                    textBox_Gia.Text = dataGridView1.Rows[e.RowIndex].Cells["Số tiền"].FormattedValue.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Ngày chi tiêu"].FormattedValue);
                    textBox_GhiChu.Text = dataGridView1.Rows[e.RowIndex].Cells["Ghi chú"].FormattedValue.ToString();
                    textBox_Ma.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
