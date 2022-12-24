using BookStore.Sys.Forms;
using BookStore.Sys.Forms.Book;
using Core;
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

        private void Order_Load(object sender, EventArgs e)
        {
            if (!Service.Instance.IsConnectedToInternet())
            {
                MessageBox.Show("Đã mất kết nối đến máy chủ, vui lòng kiểm tra đường truyền!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\BookStore.Sys";
           
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
        }

        private void btnAdd_Product_Click(object sender, EventArgs e)
        {
             frmAuthor _load = new frmAuthor();
            _load.Show();
        }

        private void btnDelete_Product_Click(object sender, EventArgs e)
        {

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

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            ConfirmDelete _load = new ConfirmDelete();
            _load.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
