﻿using BookStore.Sys.Forms;
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
    public partial class Customer : Form
    {
        public Customer()
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

            guna2DataGridView1.Rows[2].Cells[1].Value = Image.FromFile(rootPath + @"\Contents\Images\3.png");
            guna2DataGridView1.Rows[2].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[2].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[2].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[2].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[2].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[2].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[3].Cells[1].Value = Image.FromFile(rootPath + @"\Contents\Images\4.png");
            guna2DataGridView1.Rows[3].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[3].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[3].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[3].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[3].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[3].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[4].Cells[1].Value = Image.FromFile(rootPath + @"\Contents\Images\5.png");
            guna2DataGridView1.Rows[4].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[4].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[4].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[4].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[4].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[4].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[5].Cells[1].Value = Image.FromFile(rootPath + @"\Contents\Images\6.png");
            guna2DataGridView1.Rows[5].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[5].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[5].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[5].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[5].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[5].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[6].Cells[1].Value = Image.FromFile(rootPath + @"\Contents\Images\5.png");
            guna2DataGridView1.Rows[6].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[6].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[6].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[6].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[6].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[6].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[7].Cells[1].Value = Image.FromFile(rootPath + @"\Contents\Images\1.png");
            guna2DataGridView1.Rows[7].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[7].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[7].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[7].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[7].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[7].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[8].Cells[1].Value = Image.FromFile(rootPath + @"\Contents\Images\1.png");
            guna2DataGridView1.Rows[8].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[8].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[8].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[8].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[8].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[8].Cells[7].Value = "Jan 21,2020";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CustomerUpdate _load = new CustomerUpdate();
            _load.Show();
        }

        private void btnAdd_Customer_Click(object sender, EventArgs e)
        {
            CustomerAdd _load = new CustomerAdd();
            _load.Show();
        }

        private void btnDelete_Customer_Click(object sender, EventArgs e)
        {
            ConfirmDelete _load = new ConfirmDelete();
            _load.Show();
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
        private void Test()
        {
            ComboboxItem item = new ComboboxItem();
            item.Text = "Theo Tháng";
            cbBox_SearchCustomer.Items.Add(item);

            cbBox_SearchCustomer.SelectedIndex = 0;

            MessageBox.Show((cbBox_SearchCustomer.SelectedItem as ComboboxItem).ToString());
        }
        private void cbBox_SearchCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}