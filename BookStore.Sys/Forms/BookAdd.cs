using BookStore.Sys.Forms;
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
    public partial class BookAdd : Form
    {
        int movX, movY;
        bool isMoving;
        public BookAdd()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            string rootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\BookStore.Sys";
            guna2DataGridView1.Rows.Add(9);
            guna2DataGridView1.Rows[0].Cells[1].Value = Image.FromFile(rootPath + @"\Contents\Images\1.png");
            guna2DataGridView1.Rows[0].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[0].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[0].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[0].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[0].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[0].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[1].Cells[1].Value = Image.FromFile(rootPath + @"\Contents\Images\5.png");
            guna2DataGridView1.Rows[1].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[1].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[1].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[1].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[1].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[1].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[2].Cells[1].Value = Image.FromFile(rootPath + @"\Contents\Images\5.png");
            guna2DataGridView1.Rows[2].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[2].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[2].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[2].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[2].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[2].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[3].Cells[1].Value = Image.FromFile(rootPath + @"\Contents\Images\5.png");
            guna2DataGridView1.Rows[3].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[3].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[3].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[3].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[3].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[3].Cells[7].Value = "Jan 21,2020";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
        }

        private void btnAdd_Product_Click(object sender, EventArgs e)
        {
            BookAdd _load = new BookAdd();
            _load.Show();
        }

        private void btnDelete_Product_Click(object sender, EventArgs e)
        {
            BookAdd _load = new BookAdd();
            _load.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            ConfirmDelete _load = new ConfirmDelete();
            _load.Show();
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

        private void BookAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            } 
        }
    }
}
