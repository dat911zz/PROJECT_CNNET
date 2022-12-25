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
        bool isAdd, isEdit = false;
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
        private void frmAuthor_Load(object sender, EventArgs e)
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
            dgv.Refresh();
            //Khóa tất cả input
            ManageInput(false, true);
            btnEdit.Enabled = btnDelete.Enabled = btnSave.Enabled = false;
            dgv.ReadOnly = true;
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
            sys.Ds.Reset();
            //Load data
            sys.Db.LoadDataIntoDgv(dgv, sys.Ds, "Author");
            //Thêm primary key
            sys.Ds.Tables["Author"].PrimaryKey = new DataColumn[] { sys.Ds.Tables["Author"].Columns[0] };
            ////Thêm tên cho các cột
            //AddColName();
            //Thay đổi kích thước cột
            dgv.Columns[0].Width = 30;
        }
        #region Các nút chức năng
        private void btnClose_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
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
            btnSave.Enabled = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (sys.Ds.Tables["Book"] == null)
                {
                    sys.Db.FillData(sys.Ds, "Book");
                }
                foreach (DataRow rowS in sys.Ds.Tables["Book"].Rows)
                {
                    if (rowS["AuthorId"].ToString().Equals(txtID.Text.Trim()))
                    {
                        MessageBox.Show("Đã tồn tại mã sách tại bảng chi tiết đơn hàng!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                DataRow row = sys.Ds.Tables["Author"].Rows.Find(txtID.Text.Trim());
                if (row != null)
                {
                    row.Delete();
                    MessageBox.Show("Xóa thành công!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sys.Db.Update(sys.Ds, "Author");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAdd = false;
            isEdit = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            //Mở khóa các textbox (trừ mã sách)
            ManageInput(true, false);
            txtID.Enabled = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = false;
            //Khóa tất cả các trường trong dgv trừ trường mới dc thêm
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                dgv.Rows[i].Cells[0].ReadOnly = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            TrimAllTextBox();
            dgv.Refresh();
            ManageInput(false, true);
            btnAdd.Enabled = true;
            if (!IsFullFill())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEdit_Click(sender, e);
                return;
            }
            if (isAdd)
            {
                DataRow newRow = sys.Ds.Tables["Author"].NewRow();
                if (newRow != null)
                {
                    //Lấy giá trị các trường input thêm vào newrow
                    newRow.ItemArray = new object[] {
                        0,
                        txtName.Text,
                        txtDateOfBirth.Value,
                        txtEmail.Text,
                        txtPhone.Text,
                    };
                    sys.Ds.Tables["Author"].Rows.Add(newRow);
                    Update("Thêm", "Author");
                    frmAuthor_Load(sender, e);
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
                    Update("Cập nhật", "Author");
                    btnSave.Enabled = false;
                    dgv.ReadOnly = true;//Lưu xong khóa các trường trong dgv
                    ManageInput(false, true);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        #endregion
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
        private bool IsFullFill()
        {
            foreach (Control item in panelInput.Controls)
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
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = btnDelete.Enabled = true;
        }
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            TrimAllTextBox();
        }
        private void Update(string actionName, string tableName)
        {
            if (sys.Db.Update(sys.Ds, tableName) == 0)
            {
                MessageBox.Show(actionName + " thất bại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(actionName + " thành công!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                isEdit = isAdd = false;
            }
        }

        #endregion
    }
}
