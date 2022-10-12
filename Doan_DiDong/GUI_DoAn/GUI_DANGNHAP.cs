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
    public partial class GUI_DANGNHAP : MetroFramework.Forms.MetroForm
    {
        public GUI_DANGNHAP()
        {
            InitializeComponent();
        }
        private void DANGNHAP()
        {
            if (txtTENDANGNHAP.Text.Length == 0 && txtMATKHAU.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập và mật khẩu.");
            }
            else if (txtTENDANGNHAP.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập.");
            }
            else if (txtMATKHAU.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu.");
            }
            else
            {
                if (txtTENDANGNHAP.Text == "admin" && txtMATKHAU.Text == "admin")
                {
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng nhập lại!");
                }
            }
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtTENDANGNHAP.Text == "admin" && txtMATKHAU.Text == "admin")
            {
                GUI_TRANGCHU tc = new GUI_TRANGCHU();
                this.Hide();
                tc.ShowDialog();
                this.Show();
            }
            DANGNHAP();
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void txtMATKHAU_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTENDANGNHAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void hienpass_CheckedChanged(object sender, EventArgs e)
        {
            if(hienpass.Checked)
            {
                txtMATKHAU.UseSystemPasswordChar = true;
            }
            else
            {
                txtMATKHAU.UseSystemPasswordChar=false;
            }
        }

        private void GUI_DANGNHAP_Load(object sender, EventArgs e)
        {

        }
    }
}
