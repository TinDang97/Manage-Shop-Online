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

namespace DXApplication1
{
    public partial class UpdateOrder : DevExpress.XtraEditors.XtraForm
    {
        private BusinessPlayer business;

        public String ID { get; set; }

        public String IDOrder { get; set; }
        public String Status { get; set; }
        public UpdateOrder()
        {
            InitializeComponent();
        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
            DataTable user = new DataTable();
            business.queryAllCustomer(user);

            chosseUser.Properties.DataSource = user;
            chosseUser.Properties.DisplayMember = "FirstName";
            chosseUser.Properties.ValueMember = "ID";
            chosseUser.Properties.KeyMember = "ID";

            chosseUser.EditValue = int.Parse(ID);

            foreach (String status in business.getStatus())
            {
                chosseStatus.Properties.Items.Add(status);
            }

            chosseStatus.Text = Status;
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(chosseUser.Text.Equals("") || chosseStatus.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn người dùng và trạng thái!");
                return;
            }

            DataRowView dataUser = (DataRowView)chosseUser.GetSelectedDataRow();
            String IDCustomer = dataUser["ID"].ToString();
            String statusChanged = chosseStatus.Text.ToString();

            if(business.updateOrder(IDOrder,IDCustomer, statusChanged) > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
