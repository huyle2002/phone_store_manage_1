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
    public partial class GUI_LOAISANPHAM : Form
    {
        public GUI_LOAISANPHAM()
        {
            InitializeComponent();
        }

        BUS_LOAISANPHAM busLOAISANPHAM = new BUS_LOAISANPHAM();

        

       

        private void btnMOI_Click(object sender, EventArgs e)
        {
            txtMLSP.Enabled = true;
            txtMLSP.Text = "";
            txtTENLOAISP.Text = "";
            txtMOTA.Text = "";
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            DTO_LOAISANPHAM loaisanpham = new DTO_LOAISANPHAM(txtMLSP.Text, txtTENLOAISP.Text, txtMOTA.Text);

            if (busLOAISANPHAM.kiemtramatrung(txtMLSP.Text) == 1)
                MessageBox.Show("Mã loại sản phẩm đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else
            {
                if (busLOAISANPHAM.ThemLOAISANPHAM(loaisanpham) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewDANHSACHLOAISANPHAM.DataSource = busLOAISANPHAM.getLOAISANPHAM();
                }
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            DTO_LOAISANPHAM loaisanpham = new DTO_LOAISANPHAM(txtMLSP.Text, txtTENLOAISP.Text, txtMOTA.Text);

            if (busLOAISANPHAM.SuaLOAISANPHAM(loaisanpham) == true)
            {
                MessageBox.Show("Sửa thành công");
                dataGridViewDANHSACHLOAISANPHAM.DataSource = busLOAISANPHAM.getLOAISANPHAM();
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            DTO_LOAISANPHAM loaisanpham = new DTO_LOAISANPHAM(txtMLSP.Text, txtTENLOAISP.Text, txtMOTA.Text);

            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                if (busLOAISANPHAM.XoaLOAISANPHAM(loaisanpham) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewDANHSACHLOAISANPHAM.DataSource = busLOAISANPHAM.getLOAISANPHAM();
                }
            }
            else
            {

            }
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm kiếm thành công");
            dataGridViewDANHSACHLOAISANPHAM.DataSource = busLOAISANPHAM.TimLOAISANPHAM(txtTIMKIEM.Text);

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

        private void GUI_LOAISANPHAM_Load(object sender, EventArgs e)
        {
            dataGridViewDANHSACHLOAISANPHAM.DataSource = busLOAISANPHAM.getLOAISANPHAM();
            dataGridViewDANHSACHLOAISANPHAM.Columns[0].HeaderText = "Mã Loại Sản Phẩm";
            dataGridViewDANHSACHLOAISANPHAM.Columns[1].HeaderText = "Tên Loại Sản Phẩm";
            dataGridViewDANHSACHLOAISANPHAM.Columns[2].HeaderText = "Mô Tả";
        }

        private void dataGridViewDANHSACHLOAISANPHAM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy về hàng đang chọn
            int i = e.RowIndex;
            txtMLSP.Text = dataGridViewDANHSACHLOAISANPHAM.Rows[i].Cells[0].Value.ToString();
            txtTENLOAISP.Text = dataGridViewDANHSACHLOAISANPHAM[1, i].Value.ToString();
            txtMOTA.Text = dataGridViewDANHSACHLOAISANPHAM[2, i].Value.ToString();
            txtMLSP.Enabled = false;
        }

        private void groupBoxLUACHONCONGVIEC_Enter(object sender, EventArgs e)
        {

        }

        private void panelQLLSP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
