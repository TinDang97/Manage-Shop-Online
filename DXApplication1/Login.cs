using System;
using System.Windows.Forms;
using Business;

namespace DXApplication1
{
    public partial class Login : Form
    {
        public static String UserName { get; set; }
        public static String Password { get; set; }
        
        public Login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String user = username.Text;
            String pass = password.Text;

            BusinessPlayer business = new BusinessPlayer();
            business.SetUserPass(user, pass);

            try
            {
                business.Connection();
                UserName = user;
                Password = pass;
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                if(main.DialogResult == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản, mật khẩu không đúng hoặc máy chủ không phản hổi!", "Kết nối lỗi");
                Console.WriteLine("Loi cmnr: " + ex.ToString());
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            username.Text = "admin";
            password.Text = "123456";
        }
    }
}
