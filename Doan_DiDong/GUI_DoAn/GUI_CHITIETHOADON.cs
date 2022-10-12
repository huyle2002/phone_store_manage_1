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
    public partial class GUI_CHITIETHOADON : Form
    {
        public GUI_CHITIETHOADON()
        {
            InitializeComponent();
        }
        BUS_CHITIETHOADON busCHITIETHOADON = new BUS_CHITIETHOADON();
        BUS_SANPHAM busSP = new BUS_SANPHAM();





        private void btnMOI_Click(object sender, EventArgs e)
        {
            comboBoxMASP.Enabled = true;
            comboBoxMAHD.Enabled = true;
            comboBoxMASP.Text = "";
            comboBoxMAHD.Text = "";
            txtSOLUONG.Text = "";
            txtGIABAN.Text = "";
            dateTimePickerNGAYMUAHANG.Value = DateTime.Now;
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            DTO_CHITIETHOADON cthd = new DTO_CHITIETHOADON(comboBoxMASP.Text, comboBoxMAHD.Text, int.Parse(txtSOLUONG.Text), float.Parse(txtGIABAN.Text), dateTimePickerNGAYMUAHANG.Value);
            if (busCHITIETHOADON.kiemtramatrung(comboBoxMASP.Text, comboBoxMAHD.Text) == 1)
                MessageBox.Show("Phiếu chi tiết hóa đơn này đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else
            {
                if (busCHITIETHOADON.ThemCHITIETHOADON(cthd) == true && busSP.TruSLSANPHAM(comboBoxMASP.Text, int.Parse(txtSOLUONG.Text)))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewDANHSACHCHITIETHOADON.DataSource = busCHITIETHOADON.getCHITIETHOADON();
                }
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            DTO_CHITIETHOADON cthd = new DTO_CHITIETHOADON(comboBoxMASP.Text, comboBoxMAHD.Text, int.Parse(txtSOLUONG.Text), float.Parse(txtGIABAN.Text), dateTimePickerNGAYMUAHANG.Value);
            if (busCHITIETHOADON.SuaCHITIETHOADON(cthd) == true && busSP.TruSLSANPHAM(comboBoxMASP.Text, int.Parse(txtSOLUONG.Text)))
            {
                MessageBox.Show("Sửa thành công");
                dataGridViewDANHSACHCHITIETHOADON.DataSource = busCHITIETHOADON.getCHITIETHOADON();
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DTO_CHITIETHOADON cthd = new DTO_CHITIETHOADON(comboBoxMASP.Text, comboBoxMAHD.Text, int.Parse(txtSOLUONG.Text), float.Parse(txtGIABAN.Text), dateTimePickerNGAYMUAHANG.Value);
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                if (busCHITIETHOADON.XoaCHITIETHOADON(cthd) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewDANHSACHCHITIETHOADON.DataSource = busCHITIETHOADON.getCHITIETHOADON();
                }
            }
            else
            {

            }
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm kiếm thành công");
            dataGridViewDANHSACHCHITIETHOADON.DataSource = busCHITIETHOADON.TimCHITIETHOADON(txtTIMKIEM.Text);

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

        private void txtSOLUONG_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra xem kí tự vừa nhập có phải số và các ký tự điều khiển hay k
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void txtGIABAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra xem kí tự vừa nhập có phải số và các ký tự điều khiển hay k
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void GUI_CHITIETHOADON_Load(object sender, EventArgs e)
        {
            dataGridViewDANHSACHCHITIETHOADON.DataSource = busCHITIETHOADON.getCHITIETHOADON();
            dataGridViewDANHSACHCHITIETHOADON.Columns[0].HeaderText = "Mã Sản Phẩm";
            dataGridViewDANHSACHCHITIETHOADON.Columns[1].HeaderText = "Mã Hóa Đơn";
            dataGridViewDANHSACHCHITIETHOADON.Columns[2].HeaderText = "Số Lượng";
            dataGridViewDANHSACHCHITIETHOADON.Columns[3].HeaderText = "Giá Bán";
            dataGridViewDANHSACHCHITIETHOADON.Columns[4].HeaderText = "Ngày Mua Hàng";
        }

        private void dataGridViewDANHSACHCHITIETHOADON_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy về hàng đang chọn
            int i = e.RowIndex;
            comboBoxMASP.Text = dataGridViewDANHSACHCHITIETHOADON.Rows[i].Cells[0].Value.ToString();
            comboBoxMAHD.Text = dataGridViewDANHSACHCHITIETHOADON[1, i].Value.ToString();
            txtSOLUONG.Text = dataGridViewDANHSACHCHITIETHOADON[2, i].Value.ToString();
            txtGIABAN.Text = dataGridViewDANHSACHCHITIETHOADON[3, i].Value.ToString();
            dateTimePickerNGAYMUAHANG.Text = dataGridViewDANHSACHCHITIETHOADON[4, i].Value.ToString();
            comboBoxMASP.Enabled = false;
            comboBoxMAHD.Enabled = false;
        }
    }
}
