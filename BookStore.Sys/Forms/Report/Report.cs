using BookStore.Sys.Forms;
using BookStore.Sys.Forms.Book;
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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {           
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Product_Click(object sender, EventArgs e)
        {
             frmAuthor _load = new frmAuthor();
            _load.Show();
        }

        private void btnDelete_Product_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }

        private void btn_MoneyOfWeek_Click(object sender, EventArgs e)
        {
            RpDoanhThuTuan rpweek = new RpDoanhThuTuan();
            rpweek.Show();
        }
    }
}
