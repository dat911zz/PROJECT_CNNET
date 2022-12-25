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
        bool isAdd, isEdit = false;
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
            DataBinding();
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
            //Thêm tên cho các cột
            sys.Db.LoadDataIntoDgv(dtgv_BuyProduct, sys.Ds, "OrderDetail");
            //Thêm primary key
            sys.Ds.Tables["OrderDetail"].PrimaryKey = new DataColumn[] {
                sys.Ds.Tables["OrderDetail"].Columns[0],
                sys.Ds.Tables["OrderDetail"].Columns[1]
            };
            sys.Db.FillData(sys.Ds, "OrderInfo");
            sys.Db.FillData(sys.Ds, "Book");
            sys.Db.FillData(sys.Ds, "OrderDetail");
            sys.Db.FillData(sys.Ds, "CustomerType");
            sys.Ds.Tables["OrderInfo"].PrimaryKey = new DataColumn[] {
                sys.Ds.Tables["OrderInfo"].Columns[0]};
            //Load combobox
            sys.Db.LoadDataIntoCbo(cboBookID, sys.Ds, "Book", "BookName", "BookID");
            sys.Db.LoadDataIntoCbo(cbx_Employee, sys.Ds, "Employee", "FullName", "Id");
            sys.Db.LoadDataIntoCbo(cbx_OrderID, sys.Ds, "OrderDetail", "OrderId", "OrderId");
        }
        private void DataBinding()
        {
            ClearAllBinding();
            cboBookID.DataBindings.Add("SelectedValue", sys.Ds.Tables["Book"], "BookID");
            cbx_OrderID.DataBindings.Add("SelectedValue", sys.Ds.Tables["OrderInfo"], "Id");
            txt_Discount.DataBindings.Add("Text", sys.Ds.Tables["CustomerType"], "Discount");
            txt_Price.DataBindings.Add("Text", sys.Ds.Tables["OrderDetail"], "Price");
            txt_Quantity.DataBindings.Add("Text", sys.Ds.Tables["OrderDetail"], "Quantity");
        }
        private void ClearAllBinding()
        {
            Panel_Order.Controls.OfType<Control>().ToList().ForEach(x => x.DataBindings.Clear());
            Panel_OrderDetail.Controls.OfType<Control>().ToList().ForEach(x => x.DataBindings.Clear());
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
            cboBookID.Enabled = cbx_OrderID.Enabled = cbx_Employee.Enabled = inputEnable;
            this.Validate();
        }
        private void TrimAllTextBox()
        {
            foreach (Control item in Panel_Order.Controls)
            {
                if (item.GetType() != typeof(Label))
                {
                    if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                    {
                        Guna.UI2.WinForms.Guna2TextBox txt = (Guna.UI2.WinForms.Guna2TextBox)item;
                        txt.Text = txt.Text.Trim();
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
                        txt.Text = txt.Text.Trim();
                    }
                }
            }
        }
        private void ClearInput()
        {
            foreach (Control item in Panel_Order.Controls)
            {
                if (item.GetType() != typeof(Label))
                {
                    if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                    {
                        //Phải convert qua Guna mới đổi text dc
                        Guna.UI2.WinForms.Guna2TextBox txt = (Guna.UI2.WinForms.Guna2TextBox)item;
                        txt.Text = "";
                    }
                    if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2ComboBox))
                    {
                        Guna.UI2.WinForms.Guna2ComboBox txt = (Guna.UI2.WinForms.Guna2ComboBox)item;
                        txt.SelectedIndex = 0;
                    }
                    if (item.GetType() == typeof(RichTextBox))
                    {
                        RichTextBox txt = (RichTextBox)item;
                        txt.Text = "";
                    }
                }
            }
            foreach (Control item in Panel_OrderDetail.Controls)
            {
                if (item.GetType() != typeof(Label))
                {
                    if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                    {
                        //Phải convert qua Guna mới đổi text dc
                        Guna.UI2.WinForms.Guna2TextBox txt = (Guna.UI2.WinForms.Guna2TextBox)item;
                        txt.Text = "";
                    }
                    if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2ComboBox))
                    {
                        Guna.UI2.WinForms.Guna2ComboBox txt = (Guna.UI2.WinForms.Guna2ComboBox)item;
                        txt.SelectedIndex = 0;
                    }
                    if (item.GetType() == typeof(RichTextBox))
                    {
                        RichTextBox txt = (RichTextBox)item;
                        txt.Text = "";
                    }
                }
            }
            dtgv_BuyProduct.Refresh();
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btn_AddOrd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            isEdit = false;
            btnSave_Product.Enabled = true;
            btnDelete_Product.Enabled = btnEdit_Product.Enabled = false;
            ClearAllBinding();
            ManageInput(true, false);
            cbx_OrderID.Enabled = false;
            txtBox_IdCus.Enabled = false;
            dtgv_BuyProduct.AllowUserToAddRows = true;
            dtgv_BuyProduct.ReadOnly = false;
            ClearInput();
            Panel_Order.Refresh();
            Panel_OrderDetail.Refresh();
            //Khóa tất cả các trường trong dgv trừ trường mới dc thêm
            for (int i = 0; i < dtgv_BuyProduct.Rows.Count - 1; i++)
            {
                dtgv_BuyProduct.Rows[i].ReadOnly = true;
            }
            dtgv_BuyProduct.FirstDisplayedScrollingRowIndex = dtgv_BuyProduct.Rows.Count - 1;
            dtgv_BuyProduct.Rows[dtgv_BuyProduct.Rows.Count - 1].Selected = true;
            txtBox_IdCus.Focus();
        }
        private void btnAdd_Product_Click(object sender, EventArgs e)
        {
            isAdd = true;
            isEdit = false;
            btnSave_Product.Enabled = true;
            btnDelete_Product.Enabled = btnEdit_Product.Enabled = false;
            ClearAllBinding();
            ManageInput(true, false);
            cbx_OrderID.Enabled = false;
            dtgv_BuyProduct.AllowUserToAddRows = true;
            dtgv_BuyProduct.ReadOnly = false;
            ClearInput();
            Panel_Order.Refresh();
            Panel_OrderDetail.Refresh();
            //Khóa tất cả các trường trong dgv trừ trường mới dc thêm
            for (int i = 0; i < dtgv_BuyProduct.Rows.Count - 1; i++)
            {
                dtgv_BuyProduct.Rows[i].ReadOnly = true;
            }
            dtgv_BuyProduct.FirstDisplayedScrollingRowIndex = dtgv_BuyProduct.Rows.Count - 1;
            dtgv_BuyProduct.Rows[dtgv_BuyProduct.Rows.Count - 1].Selected = true;
            txtBox_IdCus.Focus();
        }

        private void btnSave_Product_Click(object sender, EventArgs e)
        {
            ManageInput(false, true);
            btnAdd_Product.Enabled = true;
            if (!IsFullFill())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEdit_Product_Click(sender, e);
                return;
            }
            if (isAdd)
            {
                DataRow newRow = sys.Ds.Tables["OrderInfo"].NewRow();
                if (newRow != null)
                {
                    //Lấy giá trị các trường input thêm vào newrow
                    newRow.ItemArray = new object[] {
                        0,
                        cbx_Employee.SelectedValue.ToString(),
                        txtBox_DateBuy.Text.Trim(),
                        txt_Idcus.Text.Trim(),
                    };
                    sys.Ds.Tables["OrderDetail"].Rows.Add(newRow);
                    Update("Thêm");
                    BuyProduct_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (isEdit)
                {
                    Update("Cập nhật");
                    btnSave_Product.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Update(string actionName)
        {
            if (sys.Db.Update(sys.Ds, "OrderDetail") == 0)
            {
                MessageBox.Show("Thêm thất bại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm thành công!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave_Product.Enabled = false;
                isEdit = isAdd = false;
            }
        }

        private void dtgv_BuyProduct_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnEdit_Product_Click(object sender, EventArgs e)
        {

        }

        private void cbx_OrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataRow dr = sys.Ds.Tables["OrderInfo"].Rows.Find(cbx_OrderID.SelectedValue.ToString());
            //if (dr != null)
            //{
            //    txtBox_IdCus.Text = dr["OrderId"].ToString();
            //    txtBox_DateBuy.Text = DateTime.Parse(dr["OrderDate"].ToString()).ToString("dd/MM/yyyy");
            //    txt_Idcus.Text = dr["CustomerId"].ToString();
            //    string manv = dr["EmployeeId"].ToString();
            //    DataRow drmnv = sys.Ds.Tables["EmployeeId"].Rows.Find(manv);
            //    cbx_Employee.Text = drmnv["EmployeeId"].ToString();
            //}
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }


        private bool IsFullFill()
        {
            foreach (Control item in Panel_Order.Controls)
            {
                if (item.GetType() != typeof(Label))
                {
                    if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                    {
                        Guna.UI2.WinForms.Guna2TextBox txt = (Guna.UI2.WinForms.Guna2TextBox)item;
                        return !string.IsNullOrEmpty(txt.Text);
                    }
                    if (item.GetType() == typeof(RichTextBox))
                    {
                        RichTextBox txt = (RichTextBox)item;
                        return !string.IsNullOrEmpty(txt.Text);
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
                        return !string.IsNullOrEmpty(txt.Text);
                    }
                    if (item.GetType() == typeof(RichTextBox))
                    {
                        RichTextBox txt = (RichTextBox)item;
                        return !string.IsNullOrEmpty(txt.Text);
                    }
                }
            }
            return true;
        }
    }
}
