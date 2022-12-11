using BookStore.Sys.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmCustomer : Form
    {
        Core.Service service;
        Core.DBHelper db;
        DataSet ds_Cus;
        DataColumn[] key = new DataColumn[1];
        public frmCustomer()
        {
            service = Core.Service.Instance;
            db = new Core.DBHelper();
            ds_Cus = new DataSet();
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\BookStore.Sys";
            db.FillData(ds_Cus, "Select * from Customer", "Customer");
            dgvCus.DataSource = ds_Cus.Tables["Customer"];
        }

        private void dgvCus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Customer_Click(object sender, EventArgs e)
        {
            CustomerAdd _load = new CustomerAdd();
            _load.Show();
        }

        private void btnDelete_Customer_Click(object sender, EventArgs e)
        {
            ConfirmDelete _load = new ConfirmDelete();
            _load.Show();
        }
        private void cbBox_SearchCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
