//sdasdassdas
using System;
using System.Windows.Forms;
using Business;

namespace DXApplication1
{
    public partial class ChangePassword : Form
    {
        private BusinessPlayer business;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals("") || txtPass.Text.Length < 6)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu ít nhất 6 kí tự!");
                return;
            }

            if(business.ChangePassWord(Login.UserName,Login.Password, txtPass.Text) > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.DialogResult = DialogResult.OK;
                
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!");
                this.DialogResult = DialogResult.No;
            }
            this.Close();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                simpleButton1_Click(sender, e);
            }
        }
    }
}
