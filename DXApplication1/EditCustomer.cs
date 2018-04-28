using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using System.IO;

namespace DXApplication1
{
    public partial class EditCustomer : Form
    {
        private BusinessPlayer business;
        private String image;
        public String ID;
        public EditCustomer()
        {
            InitializeComponent();
        }
        

        private void loadData()
        {
            DataTable data = new DataTable();
            business.queryCustomerWithAccountByID(data, ID);

            loadDataGender();
            loadDataCountry();


            DataRow row = data.Rows[0];

            username.Text = row["UserName"].ToString().Trim();
            firstname.Text = row["FirstName"].ToString().Trim();
            lastname.Text = row["LastName"].ToString().Trim();
            email.Text = row["Email"].ToString().Trim();
            birth.Text = row["Birthday"].ToString().Trim();
            gender.Text = row["Sex"].ToString().Trim();
            phone.Text = row["Phone"].ToString().Trim();
            country.Text = row["Country"].ToString().Trim();
            province.Text = row["Province"].ToString().Trim();
            district.Text = row["District"].ToString().Trim();
            addess.Text = row["Location"].ToString().Trim();
            image = row["Avatar"].ToString().Trim();
            try
            {
                avatar.Image = Image.FromFile(image);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }

        private void loadDataGender()
        {
            gender.Properties.Items.Clear();
            foreach (String x in business.GetSex())
            {
                gender.Properties.Items.Add(x);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void loadDataCountry()
        {
            country.Properties.Items.Clear();
            foreach (String x in business.GetMadeIn())
            {
                country.Properties.Items.Add(x);
            }
        }

        private void province_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataDistrict();
        }

        private void loadDataDistrict()
        {
            district.Properties.Items.Clear();
            foreach (String x in business.GetDistricts(province.Text))
            {
                district.Properties.Items.Add(x);
            }
        }

        private void country_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataProvice();
        }

        private void loadDataProvice()
        {
            province.Properties.Items.Clear();
            foreach (String x in business.GetProvinces(country.Text))
            {
                province.Properties.Items.Add(x);
            }
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "PNG files (*.PNG)|*.PNG";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = openFileDialog1.FileName;
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            avatar.Image = Image.FromStream(myStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

            if (firstname.Text.Equals("") || lastname.Text.Equals("") || username.Text.Equals("") ||
                password.Text.Equals("") || phone.Text.Equals("") || birth.Text.Equals("") ||
                gender.Text.Equals("") || country.Text.Equals("") || province.Text.Equals("") ||
                district.Text.Equals("") || addess.Text.Equals("")
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (username.Text.Contains(" "))
            {
                MessageBox.Show("Tài khoản không được chứa khoảng trắng!");
                return;
            }

            if (password.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất 6 ký tự!");
                return;
            }

            if (password.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng!");
                return;
            }

            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Email sai định dạng!");
                this.ActiveControl = email;
                return;
            }

            if (business.delCustomer(ID) > 0)
            {
                Console.WriteLine("Xoá thành công!");
            }
            else
            {
                Console.WriteLine("Xoá thất bại!");
            }

            int idAdress = business.addAddress(country.Text, province.Text, district.Text, addess.Text);

            if (idAdress <= 0)
            {
                MessageBox.Show("Thêm địa chỉ lỗi!");
                return;
            }

            int idCustomer = business.AddCustomer(firstname.Text, lastname.Text,
                image, email.Text, phone.Text, birth.Text, gender.Text, idAdress.ToString());

            if (idCustomer <= 0)
            {
                MessageBox.Show("Thêm người dùng lỗi!");
                if (business.delAddress(idAdress.ToString()) <= 0)
                {
                    Console.WriteLine("Xoá địa chỉ lỗi!");
                }
                return;
            }

            int idAccount = business.AddAccount(username.Text, password.Text, idCustomer.ToString());

            if (idAccount <= 0)
            {
                MessageBox.Show("Thêm tài khoản lỗi!");
                if (business.delAddress(idAdress.ToString()) <= 0)
                {
                    Console.WriteLine("Xoá địa chỉ lỗi!");
                }

                if (business.delCustomer(idCustomer.ToString()) <= 0)
                {
                    Console.WriteLine("Xoá người dùng lỗi!");
                }
                return;
            }

            

            MessageBox.Show("Chỉnh sửa thành công!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textEdit1_Properties_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Email sai định dạng!");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gender.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng điền giới tính cần thêm!");
                return;
            }

            if (business.addSex(gender.Text) > 0)
            {
                MessageBox.Show("Thêm thành công!");
                loadDataGender();
            }
            else
            {
                MessageBox.Show("Đã tồn tại!");
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (gender.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn giới tính cần xoá!");
                return;
            }

            if (MessageBox.Show("Bạn muốn xoá?", "Bạn chắc chứ?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (business.delSex(gender.Text) > 0)
            {
                MessageBox.Show("Xoá thành công!");
                gender.Text = "";
                loadDataGender();
            }
            else
            {
                MessageBox.Show("Không tồn tại!");
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (district.Text.Equals("") || province.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng điền quận (huyện) và thành phố (tỉnh) cần thêm!");
                return;
            }

            if (business.addDistricts(district.Text, province.Text) > 0)
            {
                MessageBox.Show("Thêm thành công!");
                loadDataDistrict();
            }
            else
            {
                MessageBox.Show("Đã tồn tại!");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (country.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng điền quốc gia cần thêm!");
                return;
            }

            if (business.addMadeIn(country.Text) > 0)
            {
                MessageBox.Show("Thêm thành công!");
                loadDataCountry();
            }
            else
            {
                MessageBox.Show("Đã tồn tại!");
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (country.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn quốc gia cần xoá!");
                return;
            }

            if (MessageBox.Show("Bạn muốn xoá?", "Bạn chắc chứ?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (business.delMadeIn(country.Text) > 0)
            {
                MessageBox.Show("Xoá thành công!");
                country.Text = "";
                loadDataCountry();
            }
            else
            {
                MessageBox.Show("Không tồn tại!");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            if (province.Text.Equals("") || country.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng điền thành phố (tỉnh) và quôc gia cần thêm!");
                return;
            }

            if (business.addProvince(province.Text, country.Text) > 0)
            {
                MessageBox.Show("Thêm thành công!");
                loadDataProvice();
            }
            else
            {
                MessageBox.Show("Đã tồn tại!");
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (province.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn thành phố (tỉnh) cần xoá!");
                return;
            }

            if (MessageBox.Show("Bạn muốn xoá?", "Bạn chắc chứ?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (business.delProvince(province.Text) > 0)
            {
                MessageBox.Show("Xoá thành công!");
                province.Text = "";
                loadDataProvice();
            }
            else
            {
                MessageBox.Show("Không tồn tại!");
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (district.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn quận (huyện) cần xoá!");
                return;
            }

            if (MessageBox.Show("Bạn muốn xoá?", "Bạn chắc chứ?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (business.delDistricts(district.Text) > 0)
            {
                MessageBox.Show("Xoá thành công!");
                district.Text = "";
                loadDataDistrict();
            }
            else
            {
                MessageBox.Show("Không tồn tại!");
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ContainsUnicodeCharacter(e.KeyChar.ToString()))
            {
                e.Handled = false;
            }
        }

        public bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;

            return input.ToCharArray().Any(c => c > MaxAnsiCode);
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ContainsUnicodeCharacter(e.KeyChar.ToString()))
            {
                e.Handled = false;
            }
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
            loadData();
        }
    }
}
