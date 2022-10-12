
namespace GUI_DoAn
{
    partial class GUI_DANGNHAP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DANGNHAP));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMATKHAU = new System.Windows.Forms.TextBox();
            this.txtTENDANGNHAP = new System.Windows.Forms.TextBox();
            this.hienpass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(420, 172);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "ĐĂNG NHẬP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMATKHAU.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtMATKHAU.HideSelection = false;
            this.txtMATKHAU.Location = new System.Drawing.Point(193, 173);
            this.txtMATKHAU.Margin = new System.Windows.Forms.Padding(2);
            this.txtMATKHAU.Multiline = true;
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.PasswordChar = '*';
            this.txtMATKHAU.Size = new System.Drawing.Size(210, 30);
            this.txtMATKHAU.TabIndex = 10;
            this.txtMATKHAU.Text = "Mật khẩu";
            this.txtMATKHAU.TextChanged += new System.EventHandler(this.txtMATKHAU_TextChanged);
            // 
            // txtTENDANGNHAP
            // 
            this.txtTENDANGNHAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENDANGNHAP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTENDANGNHAP.Location = new System.Drawing.Point(193, 100);
            this.txtTENDANGNHAP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTENDANGNHAP.Multiline = true;
            this.txtTENDANGNHAP.Name = "txtTENDANGNHAP";
            this.txtTENDANGNHAP.Size = new System.Drawing.Size(210, 30);
            this.txtTENDANGNHAP.TabIndex = 8;
            this.txtTENDANGNHAP.Text = "Tài khoản";
            this.txtTENDANGNHAP.TextChanged += new System.EventHandler(this.txtTENDANGNHAP_TextChanged);
            // 
            // hienpass
            // 
            this.hienpass.AutoSize = true;
            this.hienpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienpass.Location = new System.Drawing.Point(198, 234);
            this.hienpass.Name = "hienpass";
            this.hienpass.Size = new System.Drawing.Size(141, 22);
            this.hienpass.TabIndex = 15;
            this.hienpass.Text = "Hiển thị mật khẩu\r\n";
            this.hienpass.UseVisualStyleBackColor = true;
            this.hienpass.CheckedChanged += new System.EventHandler(this.hienpass_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // GUI_DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hienpass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMATKHAU);
            this.Controls.Add(this.txtTENDANGNHAP);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_DANGNHAP";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.GUI_DANGNHAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMATKHAU;
        private System.Windows.Forms.TextBox txtTENDANGNHAP;
        private System.Windows.Forms.CheckBox hienpass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}