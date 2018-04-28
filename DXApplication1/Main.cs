using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace DXApplication1
{
    public partial class Main : RibbonForm
    {
        public Main()
        {
            InitializeComponent();
           
        }
        Color UnreadTextColor = Color.FromArgb(248, 124, 50);
        

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Revenue revenue = new Revenue();
            ViewChildForm(revenue);
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void orders_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OrderView order = new OrderView();
            ViewChildForm(order);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ProductShow productShow = new ProductShow();
            ViewChildForm(productShow);
        }

        public void ViewChildForm(Form _form)
        {
            //Check before open
            IsFormActived(_form);
            _form.MdiParent = this;
            _form.Show();
        }

        private bool IsFormActived(Form form)
        {
            bool IsOpenend = false;
            //If there is more than one form opened
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        //Active this form
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Close();
                        IsOpenend = true;
                    }

                }
            }
            return IsOpenend;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Status status = new Status();
            status.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Customer customer = new Customer();
            ViewChildForm(customer);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.ShowDialog();
            if(change.DialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            Revenue revenue = new Revenue();
            ViewChildForm(revenue);
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewChildForm(new About());
        }
    }
}
