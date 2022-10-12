using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_DA;
using DTO_DA;
namespace GUI_DoAn
{
    public partial class GUI_HOADONNHAP : Form
    {
        BUS_HOADONNHAP busHOADONNHAP = new BUS_HOADONNHAP();
        
        public GUI_HOADONNHAP()
        {
            InitializeComponent();
            comboBoxNHACUNGCAP.DataSource = busHOADONNHAP.getMANHACUNGCAP();
            comboBoxNHACUNGCAP.DisplayMember = "MANHACUNGCAP";
        }

        private void GUI_HOADONNHAP_Load(object sender, EventArgs e)
        {
            dataGridViewDANHSACHHOADONNHAP.DataSource = busHOADONNHAP.getHOADONNHAP();
            dataGridViewDANHSACHHOADONNHAP.Columns[0].HeaderText = "Mã Hóa Đơn Nhập";
            dataGridViewDANHSACHHOADONNHAP.Columns[1].HeaderText = "Mã Nhà Cung Cấp";
            dataGridViewDANHSACHHOADONNHAP.Columns[2].HeaderText = "Ngày Nhập";
            dataGridViewDANHSACHHOADONNHAP.Columns[3].HeaderText = "Thành Tiền";
            
        }

        private void dataGridViewDANHSACHHOADONNHAP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy về hàng đang chọn
            int i = e.RowIndex;
            txtMAHOADONNHAP.Text = dataGridViewDANHSACHHOADONNHAP.Rows[i].Cells[0].Value.ToString();
            comboBoxNHACUNGCAP.Text = dataGridViewDANHSACHHOADONNHAP[1, i].Value.ToString();
            dateTimePickerNGAYNHAP.Text = dataGridViewDANHSACHHOADONNHAP[2, i].Value.ToString();
            txtTHANHTIEN.Text = dataGridViewDANHSACHHOADONNHAP[3, i].Value.ToString();
            txtMAHOADONNHAP.Enabled = false;

        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            DTO_HOADONNHAP hdn = new DTO_HOADONNHAP(txtMAHOADONNHAP.Text, comboBoxNHACUNGCAP.Text, dateTimePickerNGAYNHAP.Value, float.Parse(txtTHANHTIEN.Text));

            if (busHOADONNHAP.kiemtramatrung(txtMAHOADONNHAP.Text) == 1)
                MessageBox.Show("Phiếu hóa đơn nhập này đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else
            {
                if (busHOADONNHAP.ThemHOADONNHAP(hdn) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewDANHSACHHOADONNHAP.DataSource = busHOADONNHAP.getHOADONNHAP();
                }
            }
        }

        private void btnMOI_Click(object sender, EventArgs e)
        {
            txtMAHOADONNHAP.Enabled = true;
            txtMAHOADONNHAP.Text = "";
            comboBoxNHACUNGCAP.Text = "";
            dateTimePickerNGAYNHAP.Value = DateTime.Now;
            txtTHANHTIEN.Text = "";
            
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            DTO_HOADONNHAP hdn = new DTO_HOADONNHAP(txtMAHOADONNHAP.Text, comboBoxNHACUNGCAP.Text, dateTimePickerNGAYNHAP.Value, float.Parse(txtTHANHTIEN.Text));

            if (busHOADONNHAP.SuaHOADONNHAP(hdn) == true)
            {
                MessageBox.Show("Sửa thành công");
                dataGridViewDANHSACHHOADONNHAP.DataSource = busHOADONNHAP.getHOADONNHAP();
            }
        }

       

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DTO_HOADONNHAP hdn = new DTO_HOADONNHAP(txtMAHOADONNHAP.Text, comboBoxNHACUNGCAP.Text, dateTimePickerNGAYNHAP.Value, float.Parse(txtTHANHTIEN.Text));

            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                if (busHOADONNHAP.XoaHOADONNHAP(hdn) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewDANHSACHHOADONNHAP.DataSource = busHOADONNHAP.getHOADONNHAP();
                }
            }
            else
            {

            }
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm kiếm thành công");
            dataGridViewDANHSACHHOADONNHAP.DataSource = busHOADONNHAP.TimHOADONNHAP(txtTIMKIEM.Text);

        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_CTHOADONNHAP cthd = new GUI_CTHOADONNHAP();
            this.Hide();
            cthd.ShowDialog();
            this.Show();
        }

        private void txtTHANHTIEN_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra xem kí tự vừa nhập có phải số và các ký tự điều khiển hay k
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }
    }
}
