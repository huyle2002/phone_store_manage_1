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
    public partial class GUI_KHACHHANG : Form
    {
        public GUI_KHACHHANG()
        {
            InitializeComponent();
        }
        BUS_KHACHHANG busKHACHHANG = new BUS_KHACHHANG();
        

       

        private void btnMOI_Click(object sender, EventArgs e)
        {
            txtMKH.Enabled = true;
            txtMKH.Text = "";
            txtTENKHACHHANG.Text = "";
            comboBoxGIOITINH.Text = "";
            txtSODIENTHOAI.Text = "";
            txtDIACHI.Text = "";
            dateTimePickerNGAYSINH.Value = DateTime.Now;
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            DTO_KHACHHANG KH = new DTO_KHACHHANG(txtMKH.Text, txtTENKHACHHANG.Text, comboBoxGIOITINH.Text, txtSODIENTHOAI.Text, txtDIACHI.Text, dateTimePickerNGAYSINH.Value);

            if (busKHACHHANG.kiemtramatrung(txtMKH.Text) == 1)
                MessageBox.Show("Mã khách hàng đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else
            {
                if (busKHACHHANG.ThemKHACHHANG(KH) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewDANHSACHKHACHHANG.DataSource = busKHACHHANG.getKHACHHANG();
                }
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            DTO_KHACHHANG KH = new DTO_KHACHHANG(txtMKH.Text, txtTENKHACHHANG.Text, comboBoxGIOITINH.Text, txtSODIENTHOAI.Text, txtDIACHI.Text, dateTimePickerNGAYSINH.Value);

            if (busKHACHHANG.SuaKHACHHANG(KH) == true)
            {
                MessageBox.Show("Sửa thành công");
                dataGridViewDANHSACHKHACHHANG.DataSource = busKHACHHANG.getKHACHHANG();
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DTO_KHACHHANG KH = new DTO_KHACHHANG(txtMKH.Text, txtTENKHACHHANG.Text, comboBoxGIOITINH.Text, txtSODIENTHOAI.Text, txtDIACHI.Text, dateTimePickerNGAYSINH.Value);

            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                if (busKHACHHANG.XoaKHACHHANG(KH) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewDANHSACHKHACHHANG.DataSource = busKHACHHANG.getKHACHHANG();
                }
            }
            else
            {

            }
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm kiếm thành công");
            dataGridViewDANHSACHKHACHHANG.DataSource = busKHACHHANG.TimKHACHHANG(txtTIMKIEM.Text);

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

        private void GUI_KHACHHANG_Load(object sender, EventArgs e)
        {
            dataGridViewDANHSACHKHACHHANG.DataSource = busKHACHHANG.getKHACHHANG();
            dataGridViewDANHSACHKHACHHANG.Columns[0].HeaderText = "Mã Khách Hàng";
            dataGridViewDANHSACHKHACHHANG.Columns[1].HeaderText = "Tên Khách Hàng";
            dataGridViewDANHSACHKHACHHANG.Columns[2].HeaderText = "Giới Tính";
            dataGridViewDANHSACHKHACHHANG.Columns[3].HeaderText = "Số Điện Thoại";
            dataGridViewDANHSACHKHACHHANG.Columns[4].HeaderText = "Địa Chỉ";
            dataGridViewDANHSACHKHACHHANG.Columns[5].HeaderText = "Ngày Sinh";
        }

        private void dataGridViewDANHSACHKHACHHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy về hàng đang chọn
            int i = e.RowIndex;
            txtMKH.Text = dataGridViewDANHSACHKHACHHANG.Rows[i].Cells[0].Value.ToString();
            txtTENKHACHHANG.Text = dataGridViewDANHSACHKHACHHANG[1, i].Value.ToString();
            comboBoxGIOITINH.Text = dataGridViewDANHSACHKHACHHANG[2, i].Value.ToString();
            txtSODIENTHOAI.Text = dataGridViewDANHSACHKHACHHANG[3, i].Value.ToString();
            txtDIACHI.Text = dataGridViewDANHSACHKHACHHANG[4, i].Value.ToString();
            dateTimePickerNGAYSINH.Text = dataGridViewDANHSACHKHACHHANG[5, i].Value.ToString();
            txtMKH.Enabled = false;
        }

        private void panelQLNCC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBoxLUACHONCONGVIEC_Enter(object sender, EventArgs e)
        {

        }
    }
}
