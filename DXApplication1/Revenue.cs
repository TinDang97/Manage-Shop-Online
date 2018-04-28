using DevExpress.XtraCharts;
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
    public partial class Revenue : Form
    {
        private DateTime date;
        private BusinessPlayer business;
        public Revenue()
        {
            InitializeComponent();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            business = new BusinessPlayer(Login.UserName, Login.Password);
            date = DateTime.Today;
            loadData();
        }

        private void dateEdit3_EditValueChanged(object sender, EventArgs e)
        {
            date = editDate.DateTime;
            loadData();
        }

        private void loadData()
        {
            Series month = chartControl1.Series["Trong tháng"];
            DataTable dataMonth = new DataTable();
            business.querOrdersByMonth(dataMonth, date);

            month.DataSource = dataMonth;

            month.ArgumentDataMember = "Timed";
            month.ValueScaleType = ScaleType.Numerical;
            month.ValueDataMembers.AddRange(new string[] {"Total"});
            month.SummaryFunction = "SUM([Total])";
          

            Series year = chartControl2.Series["Trong Năm"];
            DataTable dataYear = new DataTable();
            business.querOrdersByYear(dataYear, date);

            year.DataSource = dataYear;

            year.ArgumentDataMember = "Timed";
            year.ValueScaleType = ScaleType.Numerical;
            year.ValueDataMembers.AddRange(new string[] { "Total" });
            year.SummaryFunction = "SUM([Total])";
        }
    }
}
