using System;
using System.Data;
using System.Windows.Forms;
using Business;

namespace DXApplication1
{
    public partial class AddOrder : DevExpress.XtraEditors.XtraForm
    {
        private BusinessPlayer business;
        public AddOrder()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
            loadData();
        }

        private void loadData()
        {
            DataTable data = new DataTable();
            business.queryAllCustomer(data);

            chosseUser.Properties.DataSource = data;
            chosseUser.Properties.DisplayMember = "FirstName";
            chosseUser.Properties.ValueMember = "ID";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (chosseUser.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn tài khoản người dùng!");
                return;
            }

            DataRowView data = (DataRowView) chosseUser.GetSelectedDataRow();
            String idCustomer = data["ID"].ToString();
            int idOrder = business.InsertOrders(idCustomer);

            if (idOrder > 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm!");
                addProtoOrders addProto = new addProtoOrders();
                addProto.ShowDialog();

                if (addProto.DialogResult == DialogResult.OK)
                {
                    if (business.InsertOrdersDetail(idOrder.ToString(), addProto.Id, addProto.Quantity, addProto.TypeWaranty) > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            loadData();
        }
    }
}
