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
    public partial class CustomerAdd : Form
    {
        DBHelper db;
        DataSet ds_Cus;
        DataColumn[] key = new DataColumn[1];
        int movX, movY;
        bool isMoving;
        public CustomerAdd()
        {
            db = new Core.DBHelper();
            ds_Cus = new DataSet();
            InitializeComponent();
        }

        private void CustomerAdd_Load(object sender, EventArgs e)
        {
            string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\BookStore.Sys";
            db.FillData(ds_Cus, "Customer");
            dtgv_CustomerAdd.DataSource = ds_Cus.Tables["Customer"];
            //Add header name
            dtgv_CustomerAdd.Columns[0].HeaderText = "ID";
            dtgv_CustomerAdd.Columns[1].HeaderText = "Loại Khách Hàng";
            dtgv_CustomerAdd.Columns[2].HeaderText = "Tên Khách Hàng";
            dtgv_CustomerAdd.Columns[3].HeaderText = "Giới Tính";
            dtgv_CustomerAdd.Columns[4].HeaderText = "Ngày Sinh";
            dtgv_CustomerAdd.Columns[5].HeaderText = "Địa Chỉ";
            dtgv_CustomerAdd.Columns[6].HeaderText = "Email";
            dtgv_CustomerAdd.Columns[7].HeaderText = "Số Điện Thoại";
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

        private void CustomerAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void CustomerAdd_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void CustomerAdd_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            movX = e.X;
            movY = e.Y;
        }

        private void CustomerAdd_MouseHover(object sender, EventArgs e)
        {
            isMoving = true;
        }

        private void guna2Button4_Click_2(object sender, EventArgs e)
        {
            ConfirmDelete _load = new ConfirmDelete();
            _load.Show();
        }
    }
}
