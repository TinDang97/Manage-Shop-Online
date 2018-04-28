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

namespace DXApplication1
{
    public partial class ProductShow : DevExpress.XtraEditors.XtraForm
    {
        private BusinessPlayer business;
        public ProductShow()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            
            DataTable dataTable = new DataTable();
            business.queryAllProducts(dataTable);

            gridView.DataSource = dataTable;
        }

        private void ProductShow_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
            loadData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.ShowDialog();
            if(add.DialogResult == DialogResult.OK)
            {
                loadData();
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
           if(grid.SelectedRowsCount < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xoá!");
                return;
            }
           
            DataRow row =  grid.GetDataRow(grid.GetSelectedRows()[0]);
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc sẽ xoá '" + row["name"].ToString() + "'!?", "Chắc chứ?", MessageBoxButtons.YesNoCancel))
            {
                int num = business.delProduct(row["id"].ToString());
                if(num > 0)
                {
                    MessageBox.Show("Xoá thành công '" + row["name"].ToString() + "'!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRowsCount < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            DataRow row = grid.GetDataRow(grid.GetSelectedRows()[0]);
            editProduct editProduct = new editProduct();
            editProduct.Id = row["id"].ToString();
            editProduct.ShowDialog();
            if(editProduct.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }
    }
}
