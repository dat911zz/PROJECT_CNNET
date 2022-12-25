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
using BookStore.Sys.Containers;

namespace BookStore
{
    public partial class BuyProduct : Form
    {
        ServicesContainer sys;
        Core.DBHelper db;
        DataSet ds_Order;
        DataColumn[] key = new DataColumn[1];
        public BuyProduct()
        {
            db = new Core.DBHelper();
            ds_Order = new DataSet();
            sys = new ServicesContainer(
                Service.Instance,
                new DBHelper(),
                new DataSet(),
                new DataColumn[1]
                );
            InitializeComponent();
        }
        private void BuyProduct_Load(object sender, EventArgs e)
        {
            dtgv_BuyProduct.MultiSelect = false;
            dtgv_BuyProduct.ReadOnly = true;
            string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\BookStore.Sys";
            dgv_Load();
            ManageInput(false, true);
        }
        private void dgv_Load()
        {
            if (!Service.Instance.IsConnectedToInternet())
            {
                MessageBox.Show("Đã mất kết nối đến máy chủ, vui lòng kiểm tra đường truyền!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Load data
            sys.Db.LoadDataIntoDgv(dtgv_BuyProduct, sys.Ds, "BuyProductView");
            DataBinding();
            //Thêm tên cho các cột
            AddColName();
            //Thay đổi kích thước cột
            dtgv_BuyProduct.Columns[0].Width = 100;
            dtgv_BuyProduct.Columns[6].Width = 120;

            //Load combobox
            sys.Db.LoadDataIntoCbo(cboBookID, sys.Ds, "Book", "Name", "BookID");
            sys.Db.LoadDataIntoCbo(cbx_Employee, sys.Ds, "Employee", "Name", "Id");
        }
        private void AddColName()
        {
            dtgv_BuyProduct.Columns[0].HeaderText = "Mã OrderID";
            dtgv_BuyProduct.Columns[1].HeaderText = "ID nhân viên";
            dtgv_BuyProduct.Columns[2].HeaderText = "Ngày giao dịch";
            dtgv_BuyProduct.Columns[3].HeaderText = "Mã khách hàng";
            dtgv_BuyProduct.Columns[4].HeaderText = "Mức khuyễn mãi";
            dtgv_BuyProduct.Columns[5].HeaderText = "Mã sách";
            dtgv_BuyProduct.Columns[6].HeaderText = "Tên sách";
            dtgv_BuyProduct.Columns[7].HeaderText = "Giảm giá";
            dtgv_BuyProduct.Columns[8].HeaderText = "Giá bán";
            dtgv_BuyProduct.Columns[9].HeaderText = "Số lượng";
        }
        private void DataBinding()
        {
            ClearAllBinding();
            txtBox_IdCus.DataBindings.Add("Text", sys.Ds.Tables[0], "OrderId");
            txtBox_DateBuy.DataBindings.Add("Text", sys.Ds.Tables[0], "OrderDate");
            cboBookID.DataBindings.Add("Text", sys.Ds.Tables[0], "OrderId");
            cbx_Employee.DataBindings.Add("Text", sys.Ds.Tables[0], "EmployeeId");
            txt_Idcus.DataBindings.Add("Text", sys.Ds.Tables[0], "CustomerID");
            txt_IdOrderDetail.DataBindings.Add("Text", sys.Ds.Tables[0], "OrderId");
            txt_Discount.DataBindings.Add("Text", sys.Ds.Tables[0], "Discount");
            txt_Price.DataBindings.Add("Text", sys.Ds.Tables[0], "Price");
            txt_Quantity.DataBindings.Add("Text", sys.Ds.Tables[0], "Quantity");
        }
        private void ClearAllBinding()
        {
            Panel_Order.Controls.OfType<Control>().ToList().ForEach(x => x.DataBindings.Clear());
        }
        private void ManageInput(bool inputEnable, bool inputReadOnly)
        {
            foreach (Control item in Panel_Order.Controls)
            {
                if (item.GetType() != typeof(Label))
                {
                    if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                    {
                        Guna.UI2.WinForms.Guna2TextBox txt = (Guna.UI2.WinForms.Guna2TextBox)item;
                        item.Enabled = inputEnable;
                    }
                    if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2ComboBox))
                    {
                        Guna.UI2.WinForms.Guna2ComboBox txt = (Guna.UI2.WinForms.Guna2ComboBox)item;

                    }
                    if (item.GetType() == typeof(RichTextBox))
                    {
                        RichTextBox txt = (RichTextBox)item;
                        txt.ReadOnly = inputReadOnly;
                    }
                }
            }
            foreach (Control item in Panel_OrderDetail.Controls)
            {
                if (item.GetType() != typeof(Label))
                {
                    if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                    {
                        Guna.UI2.WinForms.Guna2TextBox txt = (Guna.UI2.WinForms.Guna2TextBox)item;
                        item.Enabled = inputEnable;
                    }
                    if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2ComboBox))
                    {
                        Guna.UI2.WinForms.Guna2ComboBox txt = (Guna.UI2.WinForms.Guna2ComboBox)item;

                    }
                    if (item.GetType() == typeof(RichTextBox))
                    {
                        RichTextBox txt = (RichTextBox)item;
                        txt.ReadOnly = inputReadOnly;
                    }
                }
            }
            cboBookID.Enabled = cbx_Employee.Enabled = inputEnable;
            this.Validate();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_BuyProduct_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
