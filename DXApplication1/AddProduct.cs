using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Business;
using System.IO;

namespace DXApplication1
{
    public partial class AddProduct : Form
    {
        private String color = "";
        private String size = "";
        private String category = "";
        private String madein = "";
        private String image = "";

        public AddProduct()
        {
            InitializeComponent();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BusinessPlayer business = new BusinessPlayer(Login.UserName, Login.Password);
            int row = business.addProducts(name.Text, price.EditValue.ToString(), quantity.Text, content.Text, color, size, category, madein);
            if(row > 0)
            {
                MessageBox.Show("Thêm '" + name.Text + "' thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            getColor();
            getSize();
            getCatogories();
            getMadeIn();
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

        private void getSize()
        {
            BusinessPlayer business = new BusinessPlayer(Login.UserName, Login.Password);
            List<String> sizes = business.getSize();
            
            foreach (String size in sizes)
            {
                sizeBox.Items.Add(size);
            }
        }
        private void getCatogories()
        {
            BusinessPlayer business = new BusinessPlayer(Login.UserName, Login.Password);
            List<String> Catogories = business.GetCategories();

            foreach (String Catogory in Catogories)
            {
                CatogoryBox.Items.Add(Catogory);
            }
        }

        private void getMadeIn()
        {
            BusinessPlayer business = new BusinessPlayer(Login.UserName, Login.Password);
            List<String> MadeIns = business.GetMadeIn();

            foreach (String Country in MadeIns)
            {
                Countrybox.Items.Add(Country);
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void colorsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            color = (String) comboBox.SelectedItem;
        }

        private void sizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            size = (String)comboBox.SelectedItem;
        }

        private void CatogoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            category = (String)comboBox.SelectedItem;
        }

        private void Countrybox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            madein = (String)comboBox.SelectedItem;
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AddColor addColor = new AddColor();
            addColor.ShowDialog();
            color = addColor.color;
            colorsBox.Items.Clear();
            getColor();
            colorsBox.Text = color;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
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
                            pictureBox.Image = Image.FromStream(myStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
