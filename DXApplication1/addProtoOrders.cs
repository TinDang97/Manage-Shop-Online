///ádasdsdas
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Business;

namespace DXApplication1
{


    public partial class addProtoOrders : DevExpress.XtraEditors.XtraForm
    {
        private BusinessPlayer business;
        public String Id { get; set; }
        public String Quantity { get; set; }
        public String TypeWaranty { get; set; }
        public addProtoOrders()
        {
            InitializeComponent();
            
        }

        private void addProtoOrders_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
            DataTable table = new DataTable();
            business.queryAllProducts(table);

            txtedit.Properties.DataSource = table;
            txtedit.Properties.DisplayMember = "Name";
            txtedit.Properties.ValueMember = "ID";

            loadDataWaranty();
        }

        private void loadDataWaranty()
        {
            typeWBox.Properties.Items.Clear();
            List<String> listType = business.getWarranty();
            foreach(String type in listType)
            {
                typeWBox.Properties.Items.Add(type);
            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (txtedit.Text.Equals("") || textQuantity.Text.ToString().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng cần thêm!");
                return;
            }

            DataRowView row = (DataRowView) txtedit.GetSelectedDataRow();
            //MessageBox.Show(row["ID"].ToString());

            if(int.Parse( row["Quantity"].ToString()) < int.Parse(textQuantity.Text.ToString()))
            {
                MessageBox.Show("Số lượng vượt quá lượng hàng tồn!");
                return;
            }

            Id = row["ID"].ToString();
            Quantity = textQuantity.Text.ToString();
            TypeWaranty = typeWBox.Text.ToString();

            this.DialogResult = DialogResult.OK;

            
            this.Close();
        }

        private void textEdit1_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (typeWBox.Text.ToString().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập kiểu bảo hành cần thêm!");
                return;
            }

            business.addWarranty(typeWBox.Text.ToString());
            MessageBox.Show("Thêm thành công!");
            loadDataWaranty();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (typeWBox.Text.ToString().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn kiểu bảo hành cần xoá!");
                return;
            }          

            if(business.delWarranty(typeWBox.Text.ToString()) > 0)
            {
                MessageBox.Show("Xoá thành công!");
                loadDataWaranty();
            }
            else
            {
                MessageBox.Show("Xoá thất bại!");
                typeWBox.Text = "";
            }
        }

        private void textQuantity_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
