using BookStore.Sys.Containers;
using BookStore.Sys.Forms;
using Core;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Sys.Forms.Admin
{
    public partial class frmAdmin : Form
    {
        ServicesContainer sys;
        bool isAdd, isEdit = false;
        public frmAdmin()
        {
            sys = new ServicesContainer(
                Service.Instance,
                new DBHelper(),
                new DataSet(),
                new DataColumn[1]
                );
            InitializeComponent();
            txtSalary.Maximum = 99999999;
        }
        private void dgv_Load()
        {
            if (!Service.Instance.IsConnectedToInternet())
            {
                MessageBox.Show("Đã mất kết nối đến máy chủ, vui lòng kiểm tra đường truyền!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Reset dataset
            sys.Ds.Clear();
            //Load data
            sys.Db.LoadDataIntoDgv(dgv, sys.Ds, "Employee");
            //Thêm primary key
            sys.Ds.Tables["Employee"].PrimaryKey = new DataColumn[] { sys.Ds.Tables["Employee"].Columns[0] };
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\EmployeeStore.Sys";
            dgv_Load();      
            //Load dữ liệu lên các input control
            DataBinding();
            dgv.Refresh();
            //Vô hiệu hóa các btn, control trừ các label
            ManageInput(false, true);
            btnEdit.Enabled = btnDelete.Enabled = btnSave.Enabled = false;
            //Đếm sách
            lblBookCount.Text = dgv.Rows.Count.ToString();

        }

        #region Các nút chức năng
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            isEdit = false;
            //Mở khóa các textbox (trừ mã sách)
            ClearAllBinding();
            ManageInput(true, false);
            btnDelete.Enabled = btnEdit.Enabled = txtID.Enabled = dgv.ReadOnly = false;
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (sys.Ds.Tables["AccountEmployee"] == null)
                {
                    sys.Db.FillData(sys.Ds, "AccountEmployee");
                }
                foreach (DataRow rowS in sys.Ds.Tables["AccountEmployee"].Rows)
                {
                    if (rowS["EmployeeId"].ToString().Equals(txtID.Text.Trim()))
                    {
                        MessageBox.Show("Đã tồn tại mã sách tại bảng chi tiết đơn hàng!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                DataRow row = sys.Ds.Tables["Employee"].Rows.Find(txtID.Text.Trim());
                if (row != null)
                {
                    row.Delete();
                    MessageBox.Show("Xóa thành công!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sys.Db.Update(sys.Ds, "Employee");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAdd = false;
            isEdit = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            //Mở khóa các textbox
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
            ManageInput(false, true);
            btnAdd.Enabled = true;
            if (!IsFullFill())
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (isAdd)
                {
                    btnAdd_Click(sender, e);
                }
                else
                {
                    if (isEdit)
                    {
                        btnEdit_Click(sender, e);
                    }
                }
                return;
            }
            if (isAdd)
            {
                DataRow newRow = sys.Ds.Tables["Employee"].NewRow();
                if (newRow != null)
                {
                    //Lấy giá trị các trường input thêm vào newrow
                    newRow.ItemArray = new object[] {
                        0,
                        txtName.Text.Trim(),
                        radNam.Checked ? "Nam" : "Nu",
                        txtDateOfBirth.Value.ToShortDateString(),
                        txtAddress.Text.Trim(),
                        txtMission.Text.Trim(),
                        txtEmail.Text.Trim(),
                        txtPhone.Text.Trim(),
                        txtSalary.Value.ToString()
                    };
                    sys.Ds.Tables["Employee"].Rows.Add(newRow);
                    Update("Thêm", "Employee");
                    frmEmployee_Load(sender, e);
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
                    Update("Cập nhật", "Employee");
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region Các phương thức hỗ trợ
        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            TrimAllTextBox();
        }
        /// <summary>
        /// Bắt buộc phải có hàm này trước khi lưu chỉnh sửa, nếu không sẽ xảy ra lỗi cập nhật
        /// </summary>
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
                }
            }
            txtSalary.Enabled = inputEnable;
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
        private void DataBinding()
        {
            ClearAllBinding();
            txtID.DataBindings.Add("Text", sys.Ds.Tables[0], "Id");
            txtName.DataBindings.Add("Text", sys.Ds.Tables[0], "FullName");
            txtPhone.DataBindings.Add("Text", sys.Ds.Tables[0], "Phone");
            txtAddress.DataBindings.Add("Text", sys.Ds.Tables[0], "Address");
            txtSalary.DataBindings.Add("Value", sys.Ds.Tables[0], "Salary");
            txtMission.DataBindings.Add("Text", sys.Ds.Tables[0], "Mission");
            txtDateOfBirth.DataBindings.Add("Value", sys.Ds.Tables[0], "Birthday");
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
        private void ClearAllBinding()
        {
            panelInput.Controls.OfType<Control>().ToList().ForEach(x => x.DataBindings.Clear());
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
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = btnDelete.Enabled = true;
        }

        private void txtInputs_Leave(object sender, EventArgs e)
        {
            Guna2TextBox ctr = (Guna2TextBox)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                errProvider.SetError(ctr, "Vui lòng nhập trường này");
            }
            else
            {
                errProvider.SetError(ctr, "");
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                return;
            }
            DataRow dr = sys.Ds.Tables["Employee"].Rows.Find(txtID.Text.Trim());
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
        #endregion        
    }
}
