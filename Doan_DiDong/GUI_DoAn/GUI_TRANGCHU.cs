using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_DoAn
{
    public partial class GUI_TRANGCHU : MetroFramework.Forms.MetroForm
    {
        public GUI_TRANGCHU()
        {
            InitializeComponent();
        }

        private void btnQLLOAISANPHAM_Click(object sender, EventArgs e)
        {
            GUI_LOAISANPHAM lsp = new GUI_LOAISANPHAM();
            this.Hide();
            lsp.ShowDialog();
            this.Show();
        }

        private void btnQLSANPHAM_Click(object sender, EventArgs e)
        {
            GUI_SANPHAM sp = new GUI_SANPHAM();
            this.Hide();
            sp.ShowDialog();
            this.Show();
        }

        private void btnQLNHACUNGCAP_Click(object sender, EventArgs e)
        {
            GUI_NHACUNGCAP ncc = new GUI_NHACUNGCAP();
            this.Hide();
            ncc.ShowDialog();
            this.Show();
        }

        private void btnQLKHACHHANG_Click(object sender, EventArgs e)
        {
            GUI_KHACHHANG kh = new GUI_KHACHHANG();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GUI_NHANVIEN nv = new GUI_NHANVIEN();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUI_HOADON hd = new GUI_HOADON();
            this.Hide();
            hd.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_HOADONNHAP hd = new GUI_HOADONNHAP();
            this.Hide();
            hd.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_TRANGCHU_Load(object sender, EventArgs e)
        {

        }

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    GUI_CHITIETHOADON cthd = new GUI_CHITIETHOADON();
        //    this.Hide();
        //    cthd.ShowDialog();
        //    this.Show();
        //}
    }
}
