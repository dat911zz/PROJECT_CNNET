using BookStore.Sys.Containers;
using BookStore.Sys.Forms;
using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        ServicesContainer sys;
        bool isAdd, isEdit = false;
        public frmCustomer()
        {
            sys = new ServicesContainer(
                Service.Instance,
                new DBHelper(),
                new DataSet(),
                new DataColumn[1]
                );
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
            sys.Ds.Reset();
            sys.Db.LoadDataIntoDgv(dgv, sys.Ds, "Customer");
            sys.Db.LoadDataIntoCbo(cboType, sys.Ds, "CustomerType", "Type", "Id");
            //Add header name
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "Loại Khách Hàng";
            dgv.Columns[2].HeaderText = "Tên Khách Hàng";
            dgv.Columns[3].HeaderText = "Giới Tính";
            dgv.Columns[4].HeaderText = "Ngày Sinh";
            dgv.Columns[5].HeaderText = "Địa Chỉ";
            dgv.Columns[6].HeaderText = "Email";
            dgv.Columns[7].HeaderText = "Số Điện Thoại";
            //
            DataBinding();

            //Thêm primary key
            sys.Ds.Tables["Customer"].PrimaryKey = new DataColumn[] { sys.Ds.Tables["Customer"].Columns[0] };
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                return;
            }
            DataRow dr = sys.Ds.Tables["Customer"].Rows.Find(txtID.Text.Trim());
            if (dr != null)
            {
                if (dr[2].ToString().Trim().Equals("Nam"))
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
            }
            this.Refresh();
        }
        private void DataBinding()
        {
            ClearAllBinding();
            txtID.DataBindings.Add("Text", sys.Ds.Tables[0], "Id");
            cboType.DataBindings.Add("SelectedValue", sys.Ds.Tables[0], "CustomerTypeId");
            txtName.DataBindings.Add("Text", sys.Ds.Tables[0], "FullName");
            txtPhone.DataBindings.Add("Text", sys.Ds.Tables[0], "Phone");
            txtAddress.DataBindings.Add("Text", sys.Ds.Tables[0], "Address");
            txtDateOfBirth.DataBindings.Add("Value", sys.Ds.Tables[0], "Birthday");
            txtEmail.DataBindings.Add("Text", sys.Ds.Tables[0], "Email");
 
        }
        private void ClearAllBinding()
        {
            panelInput.Controls.OfType<Control>().ToList().ForEach(x => x.DataBindings.Clear());
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            ClearAllBinding();
            SqlConnection con = new SqlConnection(@"Data Source=NQMINH;Initial Catalog=BookStore;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SP_ADD_CUSTOMER", con);
            cmd.CommandType = CommandType.StoredProcedure;



            cmd.Parameters.AddWithValue("@CustomerTypeId", this.cboType.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@FullName", this.txtName.Text);
            cmd.Parameters.AddWithValue("@Gender", radNam.Checked ? "Nam" : "Nu");
            cmd.Parameters.AddWithValue("@Birthday", this.txtDateOfBirth.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@Address", this.txtAddress.Text);
            cmd.Parameters.AddWithValue("@Email", this.txtEmail.Text);
            cmd.Parameters.AddWithValue("@Phone", this.txtPhone.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved");
        }

        private void Form_QL_KHACHHANG_Load(object sender, EventArgs e)
        {
            sys.Db.LoadDataIntoDgv(dgv, sys.Ds, "Customer");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=NQMINH;Initial Catalog=BookStore;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Customer where Id = '" + txtID.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAdd = true;
            isEdit = false;
            //Mở khóa các textbox (trừ mã sách)
            ClearAllBinding();
            ManageInput(true, false);
            btnDelete_Customer.Enabled = btnEdit_Customer.Enabled = txtID.Enabled = dgv.ReadOnly = false;
            btnSave.Enabled = dgv.AllowUserToAddRows = true;
            ClearInput();
            panelInput.Refresh();
            //Khóa tất cả các trường trong dgv trừ trường mới dc thêm
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                dgv.Rows[i].ReadOnly = true;
            }
            dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
            dgv.Rows[dgv.Rows.Count - 1].Selected = true;
            txtName.Focus();

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NQMINH;Initial Catalog=BookStore;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Customer set CustomerTypeId = '" + this.cboType.SelectedValue.ToString() + "',FullName = '" + txtName.Text + "'  where Id = '" + txtID.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Update Successfully!");
        }

        private void btnDelete_Product_Click(object sender, EventArgs e)
        {
            CustomerAdd _load = new CustomerAdd();
            _load.Show();
        }
        private void ManageInput(bool inputEnable, bool inputReadOnly)
        {
            foreach (Control item in panelInput.Controls)
            {
                if (item.GetType() != typeof(Label))
                {
                    if (item.GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                    {
                        //Phải convert qua Guna mới đổi text dc
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
            this.Validate();
        }
        private void ClearInput()
        {
            foreach (Control item in panelInput.Controls)
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
            dgv.Refresh();
        }

    }
}
