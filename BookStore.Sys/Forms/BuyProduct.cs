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
    public partial class BuyProduct : Form
    {
        Core.DBHelper db;
        DataSet ds_Order;
        DataColumn[] key = new DataColumn[1];
        public BuyProduct()
        {
            db = new Core.DBHelper();
            ds_Order = new DataSet();
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\BookStore.Sys";
           
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            BookUpdate _load = new BookUpdate();
            _load.Show();
        }

        private void btnAdd_Product_Click(object sender, EventArgs e)
        {
             BookAdd _load = new BookAdd();
            _load.Show();
        }

        private void btnDelete_Product_Click(object sender, EventArgs e)
        {
            ConfirmDelete _load = new ConfirmDelete();
            _load.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
