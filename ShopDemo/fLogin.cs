using ShopDemo.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShopDemo
{
    public partial class fLogin : Form
    {       
        public fLogin()
        {
            InitializeComponent();         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(ServiceLogin.Login(txbUserName.Text, txbPassword.Text)) 
            {
                fManage fManage = new fManage();
                this.Hide();
                fManage.ShowDialog();
                this.Show();
                txbPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập", "Thông báo!!!");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo!!!", MessageBoxButtons.OKCancel) != DialogResult.OK )
            {
                e.Cancel = true;
            }
        }
    }
}
