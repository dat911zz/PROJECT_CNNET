using BookStore.Sys.Containers;
using Core;
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
    public partial class Dashboard : Form
    {
        ServicesContainer sys;
        public Dashboard()
        {
            InitializeComponent();
            sys = new ServicesContainer(
                Service.Instance,
                new DBHelper(),
                new DataSet(),
                new DataColumn[1]
                );

            txtTotalBooks.Text = sys.Db.ExceuteScalar("Select count(*) from Book").ToString();
            txtTotalSales.Text = sys.Db.ExceuteScalar("select Sum(Quantity) from OrderDetail").ToString();
            lblAmount.Text = sys.Db.ExceuteScalarDouble("select Sum(Price) from OrderDetail").ToString("#,###.##đ", new System.Globalization.CultureInfo("en-US", false).NumberFormat);
        }

        private void btn_MoneySolvedTime_Click(object sender, EventArgs e)
        {
            RpDoanhThuTuan rpweek = new RpDoanhThuTuan();
            rpweek.Show();
        }
    }
}
