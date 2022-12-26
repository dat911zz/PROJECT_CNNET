using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Sys.Forms.Report
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
            Reports.Bill rpt = new Reports.Bill();
            crystalReportViewer1.ReportSource = rpt;
            rpt.SetDatabaseLogon("db_a9156e_n8bookstore_admin", "ez4XqR6@QrhhzCu", "sql5080.site4now.net", "n8bookstore");
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
