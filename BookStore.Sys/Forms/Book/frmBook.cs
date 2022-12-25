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

namespace BookStore.Sys.Forms.Book
{
    public partial class frmBook : Form
    {
        ServicesContainer sys;
        bool isAdd, isEdit = false;
        public frmBook()
        {
            sys = new ServicesContainer(
                Service.Instance,
                new DBHelper(),
                new DataSet(),
                new DataColumn[1]
                );
            InitializeComponent();
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
            sys.Db.LoadDataIntoDgv(dgvBook, sys.Ds, "Book");
            //Thêm primary key
            sys.Ds.Tables["Book"].PrimaryKey = new DataColumn[] { sys.Ds.Tables["Book"].Columns[0] };
            //Thêm tên cho các cột
            AddColName();
            //Thay đổi kích thước cột
            dgvBook.Columns[0].Width = 30;
            dgvBook.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Load combobox
            sys.Db.LoadDataIntoCbo(cboAuthor, sys.Ds, "Author", "Name", "Id");
            sys.Db.LoadDataIntoCbo(cboCategory, sys.Ds, "BookCategory", "Name", "Id");
            sys.Db.LoadDataIntoCbo(cboPublisher, sys.Ds, "Publisher", "Name", "Id");
        }
        private void frmBook_Load(object sender, EventArgs e)
        {
            dgvBook.MultiSelect = false;
            dgvBook.ReadOnly = true;
            txtImg.Text = "";
            string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\BookStore.Sys";
            dgv_Load();      
            //Load dữ liệu lên các input control
            DataBinding();
            txtImg.Text = txtImg.Text.Trim();
            dgvBook.Refresh();
            //Vô hiệu hóa các btn, control trừ các label
            ManageInput(false, true);
            btn_UploadImage.Enabled = btnEdit_Book.Enabled = btnDelete_Book.Enabled = btnSave_Book.Enabled = false;
            //Đếm sách
            lblBookCount.Text = dgvBook.Rows.Count.ToString();
            //Set cho trường ảnh bìa readonly
            txtImg.ReadOnly = true;
        }

        #region Các nút chức năng
        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    var fileName = Path.GetFileName(dialog.FileName);
                    var path = Path.Combine(sys.Service.RootPath + "/Contents/Images/img-book/", fileName);
                    txtImg.Text = fileName;
                    Image.FromFile(imageLocation).Save(path);
                    picBox_ImageProduct.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Book_Click(object sender, EventArgs e)
        {
            isAdd = true;
            isEdit = false;
            btnSave_Book.Enabled = btn_UploadImage.Enabled = true;
            btnDelete_Book.Enabled = btnEdit_Book.Enabled = false;
            //Mở khóa các textbox (trừ mã sách)
            ClearAllBinding();
            ManageInput(true, false);
            txtID.Enabled = false;
            dgvBook.AllowUserToAddRows = true;
            dgvBook.ReadOnly = false;
            ClearInput();
            panelInput.Refresh();
            //Khóa tất cả các trường trong dgv trừ trường mới dc thêm
            for (int i = 0; i < dgvBook.Rows.Count - 1; i++)
            {
                dgvBook.Rows[i].ReadOnly = true;
            }
            dgvBook.FirstDisplayedScrollingRowIndex = dgvBook.Rows.Count - 1;
            dgvBook.Rows[dgvBook.Rows.Count - 1].Selected = true;
            txtName.Focus();
        }
        private void btnDelete_Book_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (sys.Ds.Tables["OrderDetail"] == null)
                {
                    sys.Db.FillData(sys.Ds, "OrderDetail");
                }
                foreach (DataRow rowS in sys.Ds.Tables["OrderDetail"].Rows)
                {
                    if (rowS["BookID"].ToString().Equals(txtID.Text.Trim()))
                    {
                        MessageBox.Show("Đã tồn tại mã sách tại bảng chi tiết đơn hàng!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                DataRow row = sys.Ds.Tables["Book"].Rows.Find(txtID.Text.Trim());
                if (row != null)
                {
                    row.Delete();
                    MessageBox.Show("Xóa thành công!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sys.Db.Update(sys.Ds, "Book");
            }
        }
        private void btnEdit_Book_Click(object sender, EventArgs e)
        {
            isAdd = false;
            isEdit = true;
            btnSave_Book.Enabled = true;
            btnAdd_Book.Enabled = btnDelete_Book.Enabled = btnEdit_Book.Enabled = false;
            //Mở khóa các textbox (trừ mã sách)
            ManageInput(true, false);
            txtID.Enabled = false;
            dgvBook.AllowUserToAddRows = false;
            dgvBook.ReadOnly = false;
            //Khóa tất cả các trường trong dgv trừ trường mới dc thêm
            for (int i = 0; i < dgvBook.Rows.Count - 1; i++)
            {
                dgvBook.Rows[i].Cells[0].ReadOnly = true;
            }
        }
        private void btnSave_Book_Click(object sender, EventArgs e)
        {
            ManageInput(false, true);
            btnAdd_Book.Enabled = true;
            if (!IsFullFill())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEdit_Book_Click(sender, e);
                return;
            }
            if (isAdd)
            {
                DataRow newRow = sys.Ds.Tables["Book"].NewRow();
                if (newRow != null)
                {
                    //Lấy giá trị các trường input thêm vào newrow
                    newRow.ItemArray = new object[] {
                        0,
                        cboAuthor.SelectedValue.ToString(),
                        cboPublisher.SelectedValue.ToString(),
                        cboCategory.SelectedValue.ToString(),
                        txtName.Text.Trim(),
                        txtImportPrice.Text.Trim(),
                        txtPrice.Text.Trim(),
                        txtYearOfPublish.Text,
                        txtLang.Text.Trim(),
                        txtInventoryNum.Text.Trim(),
                        txtDescription.Text,
                        txtImg.Text
                    };
                    sys.Ds.Tables["Book"].Rows.Add(newRow);
                    Update("Thêm", "Book");
                    frmBook_Load(sender, e);
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
                    Update("Cập nhật", "Book");
                    btnSave_Book.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region Các nút khác
        private void btnAuthor_Click(object sender, EventArgs e)
        {
            new frmAuthor().ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            new frmCategory().ShowDialog();
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            new frmPulisher().ShowDialog();
        }

        #endregion
        #region Các phương thức hỗ trợ
        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            TrimAllTextBox();
            DataGridViewRow row = dgvBook.CurrentRow;
            if (row == null)
            {
                return;
            }
            picBox_ImageProduct.Image?.Dispose();
            if (!IsValidImg(sys.Service.RootPath + @"\Contents\Images\img-book\" + row.Cells["Image"].Value.ToString()))
            {
                picBox_ImageProduct.Image = null;
            }
            else
            {
                picBox_ImageProduct.Image = Image.FromFile(sys.Service.RootPath + @"\Contents\Images\img-book\" + row.Cells["Image"].Value.ToString());
            }
            picBox_ImageProduct.Refresh();
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
        /// Kiểm tra ảnh có hợp lệ hay không
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private bool IsValidImg(string filename)
        {
            try
            {
                using (Image newImg = Image.FromFile(filename))
                { }
            }
            catch (OutOfMemoryException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
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
            cboAuthor.Enabled = cboCategory.Enabled = cboPublisher.Enabled = inputEnable;
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
            dgvBook.Refresh();
        }
        /// <summary>
        /// Chỉnh sửa tên cột sang tiếng Việt
        /// </summary>
        private void AddColName()
        {
            dgvBook.Columns[0].HeaderText = "Mã sách";
            dgvBook.Columns[1].HeaderText = "Mã tác giả tham gia";
            dgvBook.Columns[2].HeaderText = "Mã người đăng";
            dgvBook.Columns[3].HeaderText = "Thể loại";
            dgvBook.Columns[4].HeaderText = "Tên sách";
            dgvBook.Columns[5].HeaderText = "Giá nhập";
            dgvBook.Columns[6].HeaderText = "Giá bán";
            dgvBook.Columns[7].HeaderText = "Năm xuất bản";
            dgvBook.Columns[8].HeaderText = "Ngôn ngữ";
            dgvBook.Columns[9].HeaderText = "Số lượng tồn";
            dgvBook.Columns[10].HeaderText = "Mô tả";
            dgvBook.Columns[11].HeaderText = "Ảnh bìa";
        }
        private void DataBinding()
        {
            ClearAllBinding();
            txtID.DataBindings.Add("Text", sys.Ds.Tables[0], "BookId");
            cboAuthor.DataBindings.Add("SelectedValue", sys.Ds.Tables[0], "AuthorId");
            txtName.DataBindings.Add("Text", sys.Ds.Tables[0], "BookName");
            cboPublisher.DataBindings.Add("SelectedValue", sys.Ds.Tables[0], "PublisherId");
            cboCategory.DataBindings.Add("SelectedValue", sys.Ds.Tables[0], "BookCategoryId");
            txtImportPrice.DataBindings.Add("Text", sys.Ds.Tables[0], "ImportPrice");
            txtPrice.DataBindings.Add("Text", sys.Ds.Tables[0], "Price");
            txtYearOfPublish.DataBindings.Add("Text", sys.Ds.Tables[0], "PublishYear");
            txtLang.DataBindings.Add("Text", sys.Ds.Tables[0], "Language");
            txtInventoryNum.DataBindings.Add("Text", sys.Ds.Tables[0], "InventoryNum");
            txtDescription.DataBindings.Add("Text", sys.Ds.Tables[0], "Description");
            txtImg.DataBindings.Add("Text", sys.Ds.Tables[0], "Image");
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
                btnSave_Book.Enabled = false;
                isEdit = isAdd = false;
            }
        }
        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Book.Enabled = btnDelete_Book.Enabled = true;
        }

        private void txtInventoryNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox ctr = (Guna2TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errProvider.SetError(ctr, "Chỉ được nhập số nguyên");
            }
            else
            {
                errProvider.SetError(ctr, "");
            }
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

        private void txtYearOfPublish_Leave(object sender, EventArgs e)
        {
            Guna2TextBox ctr = (Guna2TextBox)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                errProvider.SetError(ctr, "Vui lòng nhập trường này");
                return;
            }
            else
            {
                if (!new Regex(@"^(19[5-9]\d|20[0-4]\d|2050)$").IsMatch(ctr.Text.Trim()))
                {
                    errProvider.SetError(ctr, "Năm đã nhập không hợp lệ");
                }
                else
                {
                    errProvider.SetError(ctr, "");
                }
            }
        }

        private void cboAuthor_MouseHover(object sender, EventArgs e)
        {
            var cbo = (Guna.UI2.WinForms.Guna2ComboBox)sender;
            toolTip1.SetToolTip(cbo, cbo.Text);
        }     
        #endregion        
    }
}
