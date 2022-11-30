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

namespace BookStore.Sys.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            Loading _load = new Loading();
            _load.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Validator()
        {
            label9.Text = "Please enter user name";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            Register _load = new Register();
            _load.Show();
        }

        private void txtBox_User_Leave(object sender, EventArgs e)
        {
            label9.Hide();
            if (txtBox_User.Text.Trim().Length == 0)
            {
                label9.Show();
                Validator();
            }
            else {
                this.errorProvider1.Clear();
            } 
        }
        private void txtBox_Password_Leave(object sender, EventArgs e)
        {
            label10.Hide();
            if (txtBox_Password.Text.Trim().Length == 0)
            {
                label10.Show();
                Validator();
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
