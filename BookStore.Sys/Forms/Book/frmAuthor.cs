using BookStore.Sys.Containers;
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

namespace BookStore.Sys.Forms.Book
{
    public partial class frmAuthor : Form
    {
        ServicesContainer sys;
        public frmAuthor()
        {
            sys = new ServicesContainer(
                Service.Instance,
                new DBHelper(),
                new DataSet(),
                new DataColumn[1]
                );
            InitializeComponent();
        }

        private void frmBookAdd_Load(object sender, EventArgs e)
        {
            if (!Service.Instance.IsConnectedToInternet())
            {
                MessageBox.Show("Đã mất kết nối đến máy chủ, vui lòng kiểm tra đường truyền!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtDateOfBirth.MaxDate = DateTime.Now;
            txtDateOfBirth.MinDate.AddYears(0);
            txtDateOfBirth.MaxDate = DateTime.Now;
            //Load data
            dgv_Load();
            DataBinding();
            //Khóa tất cả input
            ManageInput(false, true);

        }

        private void ClearAllBinding()
        {
            panelInput.Controls.OfType<Control>().ToList().ForEach(x => x.DataBindings.Clear());
        }
        private void DataBinding()
        {
            ClearAllBinding();
            txtID.DataBindings.Add("Text", sys.Ds.Tables[0], "Id");
            txtName.DataBindings.Add("Text", sys.Ds.Tables[0], "Name");
            txtEmail.DataBindings.Add("Text", sys.Ds.Tables[0], "Email");
            txtPhone.DataBindings.Add("Text", sys.Ds.Tables[0], "Phone");
            txtDateOfBirth.DataBindings.Add("Value", sys.Ds.Tables[0], "BirthDay");
        }
        private void dgv_Load()
        {
            //Reset dataset
            sys.Ds.Clear();
            //Load data
            sys.Db.LoadDataIntoDgv(dgv, sys.Ds, "Author");
            //Thêm primary key
            sys.Ds.Tables["Author"].PrimaryKey = new DataColumn[] { sys.Ds.Tables["Author"].Columns[0] };
            ////Thêm tên cho các cột
            //AddColName();
            //Thay đổi kích thước cột
            dgv.Columns[0].Width = 30;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Mở khóa các textbox (trừ mã sách)
            ClearAllBinding();
            ManageInput(true, false);
            txtID.Enabled = false;
            dgv.AllowUserToAddRows = true;
            dgv.ReadOnly = false;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        #region Các phương thức hỗ trợ
        private void TrimAllTextBox()
        {
            foreach (Control item in panelInput.Controls)
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
        /// <summary>
        /// Thay đổi trạng thái các control trong PanelInput
        /// </summary>
        /// <param name="inputEnable"></param>
        /// <param name="inputReadOnly"></param>
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
                    if (item.GetType() == typeof(Guna.UI.WinForms.GunaDateTimePicker))
                    {
                        Guna.UI.WinForms.GunaDateTimePicker txt = (Guna.UI.WinForms.GunaDateTimePicker)item;
                        item.Enabled = inputEnable;
                    }
                }
            }
            this.Validate();
        }
        /// <summary>
        /// Xóa hết input text
        /// </summary>
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
        #endregion
    }
}
