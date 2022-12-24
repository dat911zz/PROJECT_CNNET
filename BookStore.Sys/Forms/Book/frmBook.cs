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
    public partial class frmBook : Form
    {
        ServicesContainer sys;
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
            //Load data
            sys.Db.LoadDataIntoDgv(dgvBook, sys.Ds, "BooksView");
            //Thêm tên cho các cột
            AddColName();
            //Thay đổi kích thước cột
            dgvBook.Columns[0].Width = 30;
            dgvBook.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
        }
        
        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvBook.CurrentRow;
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
        private void ManageInput(bool inputEnable, bool inputReadOnly)
        {
            foreach (Control item in panelInput.Controls)
            {
                if (!item.Name.Equals("txtDescription"))
                {
                    if (item.GetType() != typeof(Label))
                    {
                        item.Enabled = inputEnable;
                    }
                }
                else
                {
                    RichTextBox txt = (RichTextBox)item;
                    txt.ReadOnly = inputReadOnly;
                }

            }
        }
        private void ClearInput()
        {
            foreach (Control item in panelInput.Controls)
            {
                if (!item.Name.Equals("txtDescription"))
                {
                    if (item.GetType() != typeof(Label))
                    {
                        //Phải convert qua Guna mới đổi text dc
                        Guna.UI2.WinForms.Guna2TextBox txt = (Guna.UI2.WinForms.Guna2TextBox)item;
                        txt.Text = "";
                    }
                }
                else
                {
                    RichTextBox txt = (RichTextBox)item;
                    txt.Text = "";
                }
            }
            dgvBook.Refresh();
        }
        private void AddColName()
        {
            dgvBook.Columns[0].HeaderText = "Mã sách";
            dgvBook.Columns[1].HeaderText = "Tên tác giả";
            dgvBook.Columns[2].HeaderText = "Người đăng";
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
            txtID.DataBindings.Add("Text", sys.Ds.Tables[0], "Id");
            txtName.DataBindings.Add("Text", sys.Ds.Tables[0], "Name");
            txtAuthor.DataBindings.Add("Text", sys.Ds.Tables[0], "Author");
            txtPublisher.DataBindings.Add("Text", sys.Ds.Tables[0], "Publisher");
            txtCategory.DataBindings.Add("Text", sys.Ds.Tables[0], "Category");
            txtImportPrice.DataBindings.Add("Text", sys.Ds.Tables[0], "ImportPrice");
            txtPrice.DataBindings.Add("Text", sys.Ds.Tables[0], "Price");
            txtYearOfPublish.DataBindings.Add("Text", sys.Ds.Tables[0], "PublishYear");
            txtLang.DataBindings.Add("Text", sys.Ds.Tables[0], "Language");
            txtInventoryNum.DataBindings.Add("Text", sys.Ds.Tables[0], "InventoryNum");
            txtDescription.DataBindings.Add("Text", sys.Ds.Tables[0], "Description");
            txtImg.DataBindings.Add("Text", sys.Ds.Tables[0], "Image");
        }
        private void ClearAllBinding()
        {
            panelInput.Controls.OfType<Control>().ToList().ForEach(x => x.DataBindings.Clear());
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
                    txtImg.Text = dialog.FileName;
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
            btnSave_Book.Enabled = true;
            //Mở khóa các textbox (trừ mã sách)
            ClearAllBinding();
            ManageInput(true, false);
            txtID.Enabled = false;
            dgvBook.AllowUserToAddRows = true;
            dgvBook.AllowUserToAddRows = true;
            dgvBook.ReadOnly = false;
            ClearInput();
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

        }

        private void btnEdit_Book_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Book_Click(object sender, EventArgs e)
        {

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

        
    }
}
