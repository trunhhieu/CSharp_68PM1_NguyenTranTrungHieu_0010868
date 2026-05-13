using System;
using System.Windows.Forms;

namespace DangNhapSinhVien
{
    public partial class Form1 : Form
    {
        Label lblEmail;
        Label lblPass;
        TextBox txtEmail;
        TextBox txtPass;
        Button btnDangNhap;

        public Form1()
        {
            InitializeComponent();
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            this.Text = "Đăng nhập";
            this.Width = 400;
            this.Height = 250;

            lblEmail = new Label();
            lblEmail.Text = "Email";
            lblEmail.Left = 30;
            lblEmail.Top = 30;
            lblEmail.Width = 100;

            txtEmail = new TextBox();
            txtEmail.Left = 140;
            txtEmail.Top = 30;
            txtEmail.Width = 180;

            lblPass = new Label();
            lblPass.Text = "Mật khẩu";
            lblPass.Left = 30;
            lblPass.Top = 80;
            lblPass.Width = 100;

            txtPass = new TextBox();
            txtPass.Left = 140;
            txtPass.Top = 80;
            txtPass.Width = 180;
            txtPass.PasswordChar = '*';

            btnDangNhap = new Button();
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.Left = 140;
            btnDangNhap.Top = 130;
            btnDangNhap.Width = 120;

            btnDangNhap.Click += BtnDangNhap_Click;

            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);
            this.Controls.Add(lblPass);
            this.Controls.Add(txtPass);
            this.Controls.Add(btnDangNhap);
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string email = "sv001@sv.edu.vn";
            string mssv = "22123456";

            if (txtEmail.Text == email && txtPass.Text == mssv)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}