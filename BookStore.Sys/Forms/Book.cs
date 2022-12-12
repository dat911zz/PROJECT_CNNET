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
    public partial class frmBook : Form
    {
        Core.Service service;
        Core.DBHelper db;
        DataSet ds_Book;
        DataColumn[] key = new DataColumn[1];

        public frmBook()
        {
            service = Core.Service.Instance;
            db = new Core.DBHelper();
            ds_Book = new DataSet();
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
            db.LoadDataIntoDgv(dgvBook, ds_Book, "SELECT * FROM BooksView", "BooksView");
            //Add header name
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
            //Change size of col
            dgvBook.Columns[0].Width = 30;
            dgvBook.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewImageColumn a = new DataGridViewImageColumn();
            
            //= new DataGridViewCellStyle() { NullValue = Bitmap, Alignment = MiddleCenter };
            //Customize col value
            for (int i = 0; i < dgvBook.Rows.Count; i++)
            {
                //Use when column names known
                //dgvBook.Rows[i].Cells["Image"].Value.ToString().Trim()
                DataGridViewImageCell imageCell = new DataGridViewImageCell();
                imageCell.Value = Image.FromFile(service.RootPath + @"\Contents\Images\img-book\clean-code.png");
                dgvBook.Rows[i].Cells["Image"] = imageCell;
            }
        }
        private void frmBook_Load(object sender, EventArgs e)
        {
            dgvBook.MultiSelect = false;
            dgv_Load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BookAdd _load = new BookAdd();
            _load.Show();
        }

        private void btnAdd_Product_Click(object sender, EventArgs e)
        {
             BookAdd _load = new BookAdd();
            _load.Show();
        }

        private void btnDelete_Product_Click(object sender, EventArgs e)
        {
            ConfirmDelete _load = new ConfirmDelete();
            _load.Show();
        }
    }
}
