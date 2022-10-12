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
    public partial class GUI_SANPHAM : Form
    {
        public GUI_SANPHAM()
        {
            InitializeComponent();
        }

        BUS_SANPHAM busSANPHAM = new BUS_SANPHAM();
        private void lblNGAYSINH_Click(object sender, EventArgs e)
        {

        }

        

        
        
        
        private void btnMOI_Click(object sender, EventArgs e)
        {
            txtMSP.Enabled = true;
            txtMSP.Text = "";
            txtTENSP.Text = "";
            txtXUATXU.Text = "";
            comboBoxNHACUNGCAP.Text = "";
            comboBoxMALOAISP.Text = "";
            txtDVT.Text = "";
            txtDONGIA.Text = "";
            txtSOLUONG.Text = "";
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            DTO_SANPHAM sp = new DTO_SANPHAM(txtMSP.Text, txtTENSP.Text, txtXUATXU.Text, comboBoxNHACUNGCAP.Text, comboBoxMALOAISP.Text, txtDVT.Text, float.Parse(txtDONGIA.Text), int.Parse(txtSOLUONG.Text));

            if (busSANPHAM.kiemtramatrung(txtMSP.Text) == 1)
                MessageBox.Show("Mã sản phẩm này đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else
            {
                if (busSANPHAM.ThemSANPHAM(sp) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewDANHSACHSANPHAM.DataSource = busSANPHAM.getSANPHAM();
                }
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            DTO_SANPHAM sp = new DTO_SANPHAM(txtMSP.Text, txtTENSP.Text, txtXUATXU.Text, comboBoxNHACUNGCAP.Text, comboBoxMALOAISP.Text, txtDVT.Text, float.Parse(txtDONGIA.Text), int.Parse(txtSOLUONG.Text));

            if (busSANPHAM.SuaSANPHAM(sp) == true)
            {
                MessageBox.Show("Sửa thành công");
                dataGridViewDANHSACHSANPHAM.DataSource = busSANPHAM.getSANPHAM();
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DTO_SANPHAM sp = new DTO_SANPHAM(txtMSP.Text, txtTENSP.Text, txtXUATXU.Text, comboBoxNHACUNGCAP.Text, comboBoxMALOAISP.Text, txtDVT.Text, float.Parse(txtDONGIA.Text), int.Parse(txtSOLUONG.Text));

            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                if (busSANPHAM.XoaSANPHAM(sp) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewDANHSACHSANPHAM.DataSource = busSANPHAM.getSANPHAM();
                }
            }
            else
            {

            }
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm kiếm thành công");
            dataGridViewDANHSACHSANPHAM.DataSource = busSANPHAM.TimSANPHAM(txtTIMKIEM.Text);
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

        private void txtDONGIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDONGIA_Click(object sender, EventArgs e)
        {

        }

        private void lblSOLUONG_Click(object sender, EventArgs e)
        {

        }

        private void txtSOLUONG_TextChanged(object sender, EventArgs e)
        {
            
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

        private void txtDONGIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra xem kí tự vừa nhập có phải số và các ký tự điều khiển hay k
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }

        }

        private void GUI_SANPHAM_Load(object sender, EventArgs e)
        {
            dataGridViewDANHSACHSANPHAM.DataSource = busSANPHAM.getSANPHAM();
            dataGridViewDANHSACHSANPHAM.Columns[0].HeaderText = "Mã Sản Phẩm";
            dataGridViewDANHSACHSANPHAM.Columns[1].HeaderText = "Tên Sản Phẩm";
            dataGridViewDANHSACHSANPHAM.Columns[2].HeaderText = "Xuất Xứ";
            dataGridViewDANHSACHSANPHAM.Columns[3].HeaderText = "Mã Nhà Cung Cấp";
            dataGridViewDANHSACHSANPHAM.Columns[4].HeaderText = "Mã Loại Sản Phẩm";
            dataGridViewDANHSACHSANPHAM.Columns[5].HeaderText = "Đơn Vị Tính";
            dataGridViewDANHSACHSANPHAM.Columns[6].HeaderText = "Đơn Giá";
            dataGridViewDANHSACHSANPHAM.Columns[7].HeaderText = "Số Lượng";
        }

        private void dataGridViewDANHSACHSANPHAM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy về hàng đang chọn
            int i = e.RowIndex;
            txtMSP.Text = dataGridViewDANHSACHSANPHAM.Rows[i].Cells[0].Value.ToString();
            txtTENSP.Text = dataGridViewDANHSACHSANPHAM[1, i].Value.ToString();
            txtXUATXU.Text = dataGridViewDANHSACHSANPHAM[2, i].Value.ToString();
            comboBoxNHACUNGCAP.Text = dataGridViewDANHSACHSANPHAM[3, i].Value.ToString();
            comboBoxMALOAISP.Text = dataGridViewDANHSACHSANPHAM[4, i].Value.ToString();
            txtDVT.Text = dataGridViewDANHSACHSANPHAM[5, i].Value.ToString();
            txtDONGIA.Text = dataGridViewDANHSACHSANPHAM[6, i].Value.ToString();
            txtSOLUONG.Text = dataGridViewDANHSACHSANPHAM[7, i].Value.ToString();
            txtMSP.Enabled = false;
        }
    }
}
