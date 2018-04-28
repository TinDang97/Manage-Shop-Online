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
    public partial class DetailOrder : DevExpress.XtraEditors.XtraForm
    {
        public String Id { get; set; }
        private BusinessPlayer business;
        public DetailOrder()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(grid.SelectedRowsCount <= 0)
            {
                MessageBox.Show("Chọn sản phẩm cần xoá");
                return;
            }

            if(MessageBox.Show("Bạn muốn xoá chứ?", "Bạn chắc chứ?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            DataRow row = grid.GetDataRow(grid.GetSelectedRows()[0]);
                        
            if (business.delOrdersDetail(row["ID"].ToString()) > 0)
            {
                MessageBox.Show("Xoá thành công!");
                loadData();
            }
            else
            {
                MessageBox.Show("Xoá thất bại!");
            }
        }

        private void DetailOrder_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
            loadData();
        }

        private void loadData()
        {
            DataTable dataTable = new DataTable();
            business.queryOrdersDetail(Id, dataTable);

            gridControl.DataSource = dataTable;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            addProtoOrders add = new addProtoOrders();
            add.ShowDialog();

            if(add.DialogResult == DialogResult.OK)
            {
                if(business.InsertOrdersDetail(Id, add.Id, add.Quantity, add.TypeWaranty) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }
    }
}
