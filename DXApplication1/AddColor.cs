//
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business;

namespace DXApplication1
{
    public partial class AddColor : DevExpress.XtraEditors.XtraForm
    {
        public String color { get; set; }
        public AddColor()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            String input = colorsBox.Text;
            BusinessPlayer business = new BusinessPlayer(Login.UserName, Login.Password);

            if (input.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập màu sắc!");
                return;
            }

            if(business.getColor(input) > 0)
            {
                MessageBox.Show("Màu đã tồn tại. Vui lòng nhập màu khác!");
                return;
            }

            if(business.addColor(input) > 0)
            {
                MessageBox.Show("Thêm thành công!");
                this.DialogResult = DialogResult.OK;
                this.color = input;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void AddColor_Load(object sender, EventArgs e)
        {
            getColor();
        }

        private void getColor()
        {
            BusinessPlayer business = new BusinessPlayer(Login.UserName, Login.Password);
            List<String> colors = business.getColor();

            foreach (String color in colors)
            {
                colorsBox.Items.Add(color);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            String input = colorsBox.Text;
            BusinessPlayer business = new BusinessPlayer(Login.UserName, Login.Password);

            if (MessageBox.Show("Bạn muốn xoá màu '" + input + "' !", "Bạn chắc chứ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(business.delColor(input) > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    colorsBox.Text = "";
                    colorsBox.Items.Clear();
                    getColor();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
                }
            }
        }

        private void colorsBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                simpleButton1_Click(sender, e);
            }
        }
    }
}
