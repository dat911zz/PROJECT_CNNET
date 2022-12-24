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
        int movX, movY;
        bool isMoving;
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
            txtDateOfBirth.MaxDate = DateTime.Now;
            if (!Service.Instance.IsConnectedToInternet())
            {
                MessageBox.Show("Đã mất kết nối đến máy chủ, vui lòng kiểm tra đường truyền!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Load data
            sys.Db.LoadDataIntoDgv(dgv, sys.Ds, "Author");
            //Thay đổi kích thước cột
            dgv.Columns[0].Width = 30;
        }

        private void ClearAllBinding()
        {
            panelInput.Controls.OfType<Control>().ToList().ForEach(x => x.DataBindings.Clear());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
        }

        private void BookAdd_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            movX = e.X;
            movY = e.Y;
        }

        private void BookAdd_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void btnDelete_Product_Click(object sender, EventArgs e)
        {
            frmAuthor _load = new frmAuthor();
            _load.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

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

        private void BookAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            } 
        }
    }
}
