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
    public partial class Status : DevExpress.XtraEditors.XtraForm
    {
        private BusinessPlayer business;
        public Status()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if(business.addStatus(editStatus.Text) > 0)
            {
                MessageBox.Show("Thêm thành công!");
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
            
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            if (business.delStatus(editStatus.Text) > 0)
            {
                MessageBox.Show("Thêm thành công!");
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
            loadData();
        }

        private void loadData()
        {
            editStatus.Properties.Items.Clear();
            foreach (String status in business.getStatus())
            {
                editStatus.Properties.Items.Add(status);
            }
        }
    }
}
