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
    public partial class OrderView : DevExpress.XtraEditors.XtraForm
    {
        private BusinessPlayer business;
        public OrderView()
        {
            InitializeComponent();
        }

        private void orderView_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
            loadData();
        }

        public void loadData()
        {
            DataTable dataTable = new DataTable();
            business.queryAllOrders(dataTable);
            gridControl1.DataSource = dataTable;            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {

            if (grid.SelectedRowsCount < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xoá!");
                return;
            }

            String id = grid.GetDataRow(grid.GetSelectedRows()[0])["ID"].ToString();

            if(MessageBox.Show("Bạn muốn xoá đơn hàng '" + id + "'?", "Bạn chắc chứ?", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                if (business.delOrders(id) > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
                }
            }
            
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            if (grid.SelectedRowsCount < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xem!");
                return;
            }

            DetailOrder detail = new DetailOrder();
            detail.Id = grid.GetDataRow(grid.GetSelectedRows()[0])["ID"].ToString();

            detail.ShowDialog();
            loadData();
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            addOrder.ShowDialog();
            if(addOrder.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRowsCount < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xem!");
                return;
            }

            UpdateOrder update = new UpdateOrder();
            update.ID = grid.GetDataRow(grid.GetSelectedRows()[0])["IDCustomer"].ToString();
            update.IDOrder = grid.GetDataRow(grid.GetSelectedRows()[0])["ID"].ToString();
            update.Status = grid.GetDataRow(grid.GetSelectedRows()[0])["Status"].ToString();

            update.ShowDialog();
            loadData();
        }
    }
}
