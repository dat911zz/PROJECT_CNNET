﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            Form1 _load = new Form1();
            _load.Show();
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            Form1 _load = new Form1();
            _load.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
