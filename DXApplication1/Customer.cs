using System;
using System.Data;
using System.Windows.Forms;
using Business;

namespace DXApplication1
{
    public partial class Customer : Form
    {
        private BusinessPlayer business;
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
            loadData();
        }

        private void loadData()
        {
            DataTable data = new DataTable();
            business.queryCustomerWithAccount(data);

            gridControl1.DataSource = data;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.ShowDialog();

            if(add.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(gridView1.SelectedRowsCount <= 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xoá!");
                return;
            }

            if(MessageBox.Show("Lưu ý: Khi xoá tài khoản, các giao dịch trước đó sẽ bị mất?", "Bạn chắc xoá chứ?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            DataRow row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if(business.delCustomer(row["CustomerID"].ToString()) > 0)
            {
                MessageBox.Show("Xoá thành công!");
                loadData();
            }
            else
            {
                MessageBox.Show("Xoá thất bại!");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount <= 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để chỉnh sửa!");
                return;
            }

            DataRow row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            EditCustomer edit = new EditCustomer();
            edit.ID = row["CustomerID"].ToString();
            edit.ShowDialog();
            loadData();
        }
    }
}
