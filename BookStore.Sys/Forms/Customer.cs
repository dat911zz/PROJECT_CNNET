using BookStore.Sys.Forms;
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
            if (!Service.Instance.IsConnectedToInternet())
            {
                MessageBox.Show("Đã mất kết nối đến máy chủ, vui lòng kiểm tra đường truyền!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\BookStore.Sys";
            db.FillData(ds_Cus, "Select * from Customer", "Customer");
            dgvCus.DataSource = ds_Cus.Tables["Customer"];
            //Add header name
            dgvCus.Columns[0].HeaderText = "ID";
            dgvCus.Columns[1].HeaderText = "Loại Khách Hàng";
            dgvCus.Columns[2].HeaderText = "Tên Khách Hàng";
            dgvCus.Columns[3].HeaderText = "Giới Tính";
            dgvCus.Columns[4].HeaderText = "Ngày Sinh";
            dgvCus.Columns[5].HeaderText = "Địa Chỉ";
            dgvCus.Columns[6].HeaderText = "Email";
            dgvCus.Columns[7].HeaderText = "Số Điện Thoại";
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

        private void btnUpdate_Product_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ConfirmDelete _load = new ConfirmDelete();
            _load.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CustomerAdd _load = new CustomerAdd();
            _load.Show();
        }

        private void btnDelete_Product_Click(object sender, EventArgs e)
        {
            CustomerAdd _load = new CustomerAdd();
            _load.Show();
        }
    }
}
