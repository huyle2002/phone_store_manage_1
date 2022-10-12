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
    public partial class GUI_NHANVIEN : Form
    {
        public GUI_NHANVIEN()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN busNHANVIEN = new BUS_NHANVIEN();

        

        

        private void btnMOI_Click(object sender, EventArgs e)
        {
            txtMANHANVIEN.Enabled = true;
            txtMANHANVIEN.Text = "";
            txtTENNHANVIEN.Text = "";
            comboBoxGIOITINH.Text = "";
            txtSODIENTHOAI.Text = "";
            txtDIACHI.Text = "";
            dateTimePickerNGAYSINH.Value = DateTime.Now;
            txtLCB.Text = "";
            txtPHUCAP.Text = "";
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            DTO_NHANVIEN NV = new DTO_NHANVIEN(txtMANHANVIEN.Text, txtTENNHANVIEN.Text, comboBoxGIOITINH.Text, txtSODIENTHOAI.Text, txtDIACHI.Text, dateTimePickerNGAYSINH.Value, float.Parse(txtLCB.Text), int.Parse(txtPHUCAP.Text));

            if (busNHANVIEN.kiemtramatrung(txtMANHANVIEN.Text) == 1)
                MessageBox.Show("Mã nhân viên này đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else
            {
                if (busNHANVIEN.ThemNHANVIEN(NV) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewDANHSACHNHANVIEN.DataSource = busNHANVIEN.getNHANVIEN();
                }
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            DTO_NHANVIEN NV = new DTO_NHANVIEN(txtMANHANVIEN.Text, txtTENNHANVIEN.Text, comboBoxGIOITINH.Text, txtSODIENTHOAI.Text, txtDIACHI.Text, dateTimePickerNGAYSINH.Value, float.Parse(txtLCB.Text), int.Parse(txtPHUCAP.Text));
            if (busNHANVIEN.SuaNHANVIEN(NV) == true)
            {
                MessageBox.Show("Sửa thành công");
                dataGridViewDANHSACHNHANVIEN.DataSource = busNHANVIEN.getNHANVIEN();
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DTO_NHANVIEN NV = new DTO_NHANVIEN(txtMANHANVIEN.Text, txtTENNHANVIEN.Text, comboBoxGIOITINH.Text, txtSODIENTHOAI.Text, txtDIACHI.Text, dateTimePickerNGAYSINH.Value, float.Parse(txtLCB.Text), int.Parse(txtPHUCAP.Text));
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                if (busNHANVIEN.XoaNHANVIEN(NV) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewDANHSACHNHANVIEN.DataSource = busNHANVIEN.getNHANVIEN();
                }
            }
            else
            {

            }
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm kiếm thành công");
            dataGridViewDANHSACHNHANVIEN.DataSource = busNHANVIEN.TimNHANVIEN(txtTIMKIEM.Text);

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

        private void txtLCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra xem kí tự vừa nhập có phải số và các ký tự điều khiển hay k
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void txtPHUCAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra xem kí tự vừa nhập có phải số và các ký tự điều khiển hay k
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void GUI_NHANVIEN_Load(object sender, EventArgs e)
        {
            dataGridViewDANHSACHNHANVIEN.DataSource = busNHANVIEN.getNHANVIEN();
            dataGridViewDANHSACHNHANVIEN.Columns[0].HeaderText = "Mã Nhân Viên";
            dataGridViewDANHSACHNHANVIEN.Columns[1].HeaderText = "Tên Nhân Viên";
            dataGridViewDANHSACHNHANVIEN.Columns[2].HeaderText = "Giới Tính";
            dataGridViewDANHSACHNHANVIEN.Columns[3].HeaderText = "Số Điện Thoại";
            dataGridViewDANHSACHNHANVIEN.Columns[4].HeaderText = "Địa Chỉ";
            dataGridViewDANHSACHNHANVIEN.Columns[5].HeaderText = "Ngày Sinh";
            dataGridViewDANHSACHNHANVIEN.Columns[6].HeaderText = "Lương Cơ Bản";
            dataGridViewDANHSACHNHANVIEN.Columns[7].HeaderText = "Phụ Cấp";
        }

        private void dataGridViewDANHSACHNHANVIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy về hàng đang chọn
            int i = e.RowIndex;
            txtMANHANVIEN.Text = dataGridViewDANHSACHNHANVIEN.Rows[i].Cells[0].Value.ToString();
            txtTENNHANVIEN.Text = dataGridViewDANHSACHNHANVIEN[1, i].Value.ToString();
            comboBoxGIOITINH.Text = dataGridViewDANHSACHNHANVIEN[2, i].Value.ToString();
            txtSODIENTHOAI.Text = dataGridViewDANHSACHNHANVIEN[3, i].Value.ToString();
            txtDIACHI.Text = dataGridViewDANHSACHNHANVIEN[4, i].Value.ToString();
            dateTimePickerNGAYSINH.Text = dataGridViewDANHSACHNHANVIEN[5, i].Value.ToString();
            txtLCB.Text = dataGridViewDANHSACHNHANVIEN[6, i].Value.ToString();
            txtPHUCAP.Text = dataGridViewDANHSACHNHANVIEN[7, i].Value.ToString();
            txtMANHANVIEN.Enabled = false;
        }
    }
}
