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
    public partial class GUI_CTHOADONNHAP : Form
    {
        BUS_CTHOADONNHAP busCTHOADONNHAP = new BUS_CTHOADONNHAP();
        BUS_SANPHAM busSP = new BUS_SANPHAM();
        public GUI_CTHOADONNHAP()
        {
            InitializeComponent();
            comboBoxSANPHAM.DataSource = busCTHOADONNHAP.getSANPHAM();
            comboBoxSANPHAM.DisplayMember = "MASP";
            comboBoxMAHDNHAP.DataSource = busCTHOADONNHAP.getHOADONNHAP();
            comboBoxMAHDNHAP.DisplayMember = "MAHOADONNHAP";
        }

        private void btnMOI_Click(object sender, EventArgs e)
        {
            txtMAPHIEUNHAP.Enabled = true;
            txtMAPHIEUNHAP.Text = "";
            comboBoxMAHDNHAP.Text= "";
            comboBoxSANPHAM.Text = "";
            txtSOLUONG.Text = "";
            txtGIANHAP.Text = "";
          
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            DTO_CTHOADONNHAP cthd = new DTO_CTHOADONNHAP(txtMAPHIEUNHAP.Text, comboBoxMAHDNHAP.Text, comboBoxSANPHAM.Text, int.Parse(txtSOLUONG.Text), float.Parse(txtGIANHAP.Text));
            
            if (busCTHOADONNHAP.kiemtramatrung(txtMAPHIEUNHAP.Text) == 1)
                MessageBox.Show("Phiếu chi tiết hóa đơn nhập này đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else
            {
                if (busCTHOADONNHAP.ThemCTHOADONNHAP(cthd) == true && busSP.congSLSANPHAM(comboBoxSANPHAM.Text, int.Parse(txtSOLUONG.Text)))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewDANHSACHCTHOADONNHAP.DataSource = busCTHOADONNHAP.getCTHOADONNHAP();
                }
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            DTO_CTHOADONNHAP cthd = new DTO_CTHOADONNHAP(txtMAPHIEUNHAP.Text, comboBoxMAHDNHAP.Text, comboBoxSANPHAM.Text, int.Parse(txtSOLUONG.Text), float.Parse(txtGIANHAP.Text));

            if (busCTHOADONNHAP.SuaCTHOADONNHAP(cthd) == true && busSP.congSLSANPHAM(comboBoxSANPHAM.Text, int.Parse(txtSOLUONG.Text)))
            {
                MessageBox.Show("Sửa thành công");
                dataGridViewDANHSACHCTHOADONNHAP.DataSource = busCTHOADONNHAP.getCTHOADONNHAP();
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DTO_CTHOADONNHAP cthd = new DTO_CTHOADONNHAP(txtMAPHIEUNHAP.Text, comboBoxMAHDNHAP.Text, comboBoxSANPHAM.Text, int.Parse(txtSOLUONG.Text), float.Parse(txtGIANHAP.Text));

            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                if (busCTHOADONNHAP.XoaCTHOADONNHAP(cthd) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewDANHSACHCTHOADONNHAP.DataSource = busCTHOADONNHAP.getCTHOADONNHAP();
                }
            }
            else
            {

            }
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm kiếm thành công");
            dataGridViewDANHSACHCTHOADONNHAP.DataSource = busCTHOADONNHAP.TimCTHOADONNHAP(txtTIMKIEM.Text);

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

        private void GUI_CTHOADONNHAP_Load(object sender, EventArgs e)
        {
            dataGridViewDANHSACHCTHOADONNHAP.DataSource = busCTHOADONNHAP.getCTHOADONNHAP();
            dataGridViewDANHSACHCTHOADONNHAP.Columns[0].HeaderText = "Mã Phiếu Nhập";
            dataGridViewDANHSACHCTHOADONNHAP.Columns[1].HeaderText = "Mã Hóa Đơn Nhập";
            dataGridViewDANHSACHCTHOADONNHAP.Columns[2].HeaderText = "Mã Hóa Sản Phẩm";
            dataGridViewDANHSACHCTHOADONNHAP.Columns[3].HeaderText = "Số Lượng";
            dataGridViewDANHSACHCTHOADONNHAP.Columns[4].HeaderText = "Giá Nhập";
      
        }

        private void dataGridViewDANHSACHCTHOADONNHAP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy về hàng đang chọn
            int i = e.RowIndex;
            txtMAPHIEUNHAP.Text = dataGridViewDANHSACHCTHOADONNHAP.Rows[i].Cells[0].Value.ToString();
            comboBoxMAHDNHAP.Text = dataGridViewDANHSACHCTHOADONNHAP[1, i].Value.ToString();
            comboBoxSANPHAM.Text = dataGridViewDANHSACHCTHOADONNHAP[2, i].Value.ToString();
            txtSOLUONG.Text = dataGridViewDANHSACHCTHOADONNHAP[3, i].Value.ToString();
            txtGIANHAP.Text = dataGridViewDANHSACHCTHOADONNHAP[4, i].Value.ToString();

            txtMAPHIEUNHAP.Enabled = false;
            
        }
    }
}
