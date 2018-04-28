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
using System.Data.SqlClient;
using System.IO;

namespace DXApplication1
{
    public partial class editProduct : DevExpress.XtraEditors.XtraForm
    {
        public String Id { get; set; }
        private String img { get; set; }
        private BusinessPlayer business;

        public editProduct()
        {
            InitializeComponent();
        }

        private void editProduct_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
            DataTable dataTable = new DataTable();
            business.queryProductsByID(Id, dataTable);

            getColor();
            getSize();
            getCatogories();
            getMadeIn();

            name.Text = dataTable.Rows[0]["Name"].ToString();
            price.Text = dataTable.Rows[0]["Price"].ToString();
            quantity.Text = dataTable.Rows[0]["Quantity"].ToString();
            content.Text = dataTable.Rows[0]["Content"].ToString();
            colorsBox.Text = dataTable.Rows[0]["Color"].ToString();
            sizeBox.Text = dataTable.Rows[0]["Size"].ToString();
            CatogoryBox.Text = dataTable.Rows[0]["Category"].ToString();
            Countrybox.Text = dataTable.Rows[0]["MadeIn"].ToString();
            img = dataTable.Rows[0]["Image"].ToString();
            try
            {
                pictureBox.Image = Image.FromFile(img);
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                        
        }

        private void getColor()
        {
            List<String> colors = business.getColor();

            foreach (String color in colors)
            {
                colorsBox.Items.Add(color);
            }
        }

        private void getSize()
        {
            List<String> sizes = business.getSize();

            foreach (String size in sizes)
            {
                sizeBox.Items.Add(size);
            }
        }
        private void getCatogories()
        {
            List<String> Catogories = business.GetCategories();

            foreach (String Catogory in Catogories)
            {
                CatogoryBox.Items.Add(Catogory);
            }
        }

        private void getMadeIn()
        {
            List<String> MadeIns = business.GetMadeIn();

            foreach (String Country in MadeIns)
            {
                Countrybox.Items.Add(Country);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int row = business.updateProducts(Id, name.Text, price.EditValue.ToString(), quantity.Text, img, content.Text, colorsBox.Text, sizeBox.Text, CatogoryBox.Text, Countrybox.Text);
            if (row > 0)
            {
                MessageBox.Show("Cập nhật '" + name.Text + "' thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
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
                img = openFileDialog1.FileName;
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AddColor addColor = new AddColor();
            addColor.ShowDialog();
            colorsBox.Items.Clear();
            getColor();
            colorsBox.Text = addColor.color;
        }
    }
}
