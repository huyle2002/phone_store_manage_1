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
    public partial class GUI_NHACUNGCAP : Form
    {
        public GUI_NHACUNGCAP()
        {
            InitializeComponent();
        }
        BUS_NHACUNGCAP busNHACUNGCAP = new BUS_NHACUNGCAP();

      

        

        private void btnMOI_Click(object sender, EventArgs e)
        {
            txtMNCC.Enabled = true;
            txtMNCC.Text = "";
            txtTENNCC.Text = "";
            txtDIACHI.Text = "";
            comboBoxGIOITINH.Text = "";
            dateTimePickerNGAYSINH.Value = DateTime.Now;
            txtSDT.Text = "";
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            DTO_NHACUNGCAP NCC = new DTO_NHACUNGCAP(txtMNCC.Text, txtTENNCC.Text, txtDIACHI.Text, comboBoxGIOITINH.Text, dateTimePickerNGAYSINH.Value, txtSDT.Text);

            if (busNHACUNGCAP.kiemtramatrung(txtMNCC.Text) == 1)
                MessageBox.Show("Mã nhà cung cấp đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else
            {
                if (busNHACUNGCAP.ThemNHACUNGCAP(NCC) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewDANHSACHNHACUNGCAP.DataSource = busNHACUNGCAP.getNHACUNGCAP();
                }
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            DTO_NHACUNGCAP NCC = new DTO_NHACUNGCAP(txtMNCC.Text, txtTENNCC.Text, txtDIACHI.Text, comboBoxGIOITINH.Text, dateTimePickerNGAYSINH.Value, txtSDT.Text);

            if (busNHACUNGCAP.SuaNHACUNGCAP(NCC) == true)
            {
                MessageBox.Show("Sửa thành công");
                dataGridViewDANHSACHNHACUNGCAP.DataSource = busNHACUNGCAP.getNHACUNGCAP();
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DTO_NHACUNGCAP NCC = new DTO_NHACUNGCAP(txtMNCC.Text, txtTENNCC.Text, txtDIACHI.Text, comboBoxGIOITINH.Text, dateTimePickerNGAYSINH.Value, txtSDT.Text);

            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                if (busNHACUNGCAP.XoaNHACUNGCAP(NCC) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewDANHSACHNHACUNGCAP.DataSource = busNHACUNGCAP.getNHACUNGCAP();
                }
            }
            else
            {

            }
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm kiếm thành công");

            dataGridViewDANHSACHNHACUNGCAP.DataSource = busNHACUNGCAP.TimNHACUNGCAP(txtTIMKIEM.Text);

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

        private void GUI_NHACUNGCAP_Load(object sender, EventArgs e)
        {
            dataGridViewDANHSACHNHACUNGCAP.DataSource = busNHACUNGCAP.getNHACUNGCAP();
            dataGridViewDANHSACHNHACUNGCAP.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dataGridViewDANHSACHNHACUNGCAP.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dataGridViewDANHSACHNHACUNGCAP.Columns[2].HeaderText = "Địa Chỉ";
            dataGridViewDANHSACHNHACUNGCAP.Columns[3].HeaderText = "Giới Tính";
            dataGridViewDANHSACHNHACUNGCAP.Columns[4].HeaderText = "Ngày Sinh";
            dataGridViewDANHSACHNHACUNGCAP.Columns[5].HeaderText = "Số Điện Thoại";

        }

        private void dataGridViewDANHSACHNHACUNGCAP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy về hàng đang chọn
            int i = e.RowIndex;
            txtMNCC.Text = dataGridViewDANHSACHNHACUNGCAP.Rows[i].Cells[0].Value.ToString();
            txtTENNCC.Text = dataGridViewDANHSACHNHACUNGCAP[1, i].Value.ToString();
            txtDIACHI.Text = dataGridViewDANHSACHNHACUNGCAP[2, i].Value.ToString();
            comboBoxGIOITINH.Text = dataGridViewDANHSACHNHACUNGCAP[3, i].Value.ToString();
            dateTimePickerNGAYSINH.Text = dataGridViewDANHSACHNHACUNGCAP[4, i].Value.ToString();
            txtSDT.Text = dataGridViewDANHSACHNHACUNGCAP[5, i].Value.ToString();
            txtMNCC.Enabled = false;
        }
    }
}
