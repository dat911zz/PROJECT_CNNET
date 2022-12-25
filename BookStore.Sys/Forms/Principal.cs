using BookStore.Sys.Forms.Admin;
using BookStore.Sys.Forms.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Sys.Forms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Dashboard Book Shop";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            label_val.Text = "Book Shop";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }
        private void container(object _form)
        {

            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            label_val.Text = "Quản Lý Khách Hàng";
            container(new frmCustomer());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            label_val.Text = "Quản Lý Hàng Hóa";
            container(new frmBook());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            label_val.Text = "Báo Cáo & Thống Kê";
            container(new Report());
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban có muốn thoát?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.OpenForms["Login"].Close();
                e.Cancel = false;
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            label_val.Text = "Mua Hàng";
            container(new BuyProduct());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            label_val.Text = "Quản trị hệ thống";
            container(new frmAdmin());
        }
    }
}
