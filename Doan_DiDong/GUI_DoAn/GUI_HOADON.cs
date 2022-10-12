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
    public partial class GUI_HOADON : Form
    {
        public GUI_HOADON()
        {
            InitializeComponent();
        }
        BUS_HOADON busHOADON = new BUS_HOADON();
        private void lblMOTA_Click(object sender, EventArgs e)
        {

        }

        

        

        private void btnMOI_Click(object sender, EventArgs e)
        {
            txtMAHOADON.Enabled = true;
            txtMAHOADON.Text = "";
            comboBoxMAKHACHHANG.Text = "";
            comboBoxMANHANVIEN.Text = "";
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            DTO_HOADON HD = new DTO_HOADON(comboBoxMAKHACHHANG.Text, comboBoxMANHANVIEN.Text, txtMAHOADON.Text);

            if (busHOADON.kiemtramatrung(txtMAHOADON.Text) == 1)
                MessageBox.Show("Mã hóa đơn đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else
            {
                if (busHOADON.ThemHOADON(HD) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewDANHSACHHOADON.DataSource = busHOADON.getHOADON();
                }
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            DTO_HOADON HD = new DTO_HOADON(comboBoxMAKHACHHANG.Text, comboBoxMANHANVIEN.Text, txtMAHOADON.Text);
            if (busHOADON.SuaHOADON(HD) == true)
            {
                MessageBox.Show("Sửa thành công");
                dataGridViewDANHSACHHOADON.DataSource = busHOADON.getHOADON();
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DTO_HOADON HD = new DTO_HOADON(comboBoxMAKHACHHANG.Text, comboBoxMANHANVIEN.Text, txtMAHOADON.Text);
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                if (busHOADON.XoaHOADON(HD) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewDANHSACHHOADON.DataSource = busHOADON.getHOADON();
                }
            }
            else
            {

            }
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm kiếm thành công");
            dataGridViewDANHSACHHOADON.DataSource = busHOADON.TimHOADON(txtTIMKIEM.Text);
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
            GUI_CHITIETHOADON cthd = new GUI_CHITIETHOADON();
            this.Hide();
            cthd.ShowDialog();
            this.Show();
        }

        private void GUI_HOADON_Load(object sender, EventArgs e)
        {
            dataGridViewDANHSACHHOADON.DataSource = busHOADON.getHOADON();
            dataGridViewDANHSACHHOADON.Columns[0].HeaderText = "Mã Khách Hàng";
            dataGridViewDANHSACHHOADON.Columns[1].HeaderText = "Mã Nhân Viên";
            dataGridViewDANHSACHHOADON.Columns[2].HeaderText = "Mã Hóa Đơn";
        }

        private void dataGridViewDANHSACHHOADON_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy về hàng đang chọn
            int i = e.RowIndex;
            comboBoxMAKHACHHANG.Text = dataGridViewDANHSACHHOADON.Rows[i].Cells[0].Value.ToString();
            comboBoxMANHANVIEN.Text = dataGridViewDANHSACHHOADON[1, i].Value.ToString();
            txtMAHOADON.Text = dataGridViewDANHSACHHOADON[2, i].Value.ToString();
            txtMAHOADON.Enabled = false;
        }
    }
}
