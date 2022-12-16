using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Sys.Forms
{
    public partial class RpDoanhThuTuan : Form
    {
        public RpDoanhThuTuan()
        {
            InitializeComponent();
            Reports.MoneyOfWeek rpt = new Reports.MoneyOfWeek();
            crystalReportViewer1.ReportSource = rpt;
            rpt.SetDatabaseLogon("db_a9156e_n8bookstore_admin", "ez4XqR6@QrhhzCu", "sql5080.site4now.net", "n8bookstore");
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}
