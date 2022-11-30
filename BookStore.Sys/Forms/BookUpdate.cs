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
    public partial class BookUpdate : Form
    {
        public BookUpdate()
        {
            InitializeComponent();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            Login _load = new Login();
            _load.Show();
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            Login _load = new Login();
            _load.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
