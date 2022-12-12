using Core;
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
            txtBox_Password.PasswordChar = '•';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            if (!Service.Instance.IsConnectedToInternet())
            {
                MessageBox.Show("Đã mất kết nối đến máy chủ, vui lòng kiểm tra đường truyền!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                if (!string.IsNullOrEmpty(txtBox_User.Text) && !string.IsNullOrEmpty(txtBox_Password.Text))
                {
                    if (Service.Instance.CheckAccount(txtBox_User.Text.Trim(), txtBox_Password.Text.Trim()))
                    {
                        Loading _load = new Loading();
                        ActiveForm.Hide();
                        _load.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }
        private void btn_Signup_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();         
            Register _load = new Register();
            if (!Service.Instance.CheckFormExist(_load.Name))
            {
                _load.Show();
            }
        }

        private void txtBox_User_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtBox_User.Text.Trim().Length == 0)
            {
                errorProvider1.SetError((Control)sender, "Vui lòng điền vào trường này!");
            }
            else {
                this.errorProvider1.Clear();
            } 
        }
        private void txtBox_Password_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtBox_Password.Text.Trim().Length == 0)
            {
                errorProvider1.SetError((Control)sender, "Vui lòng điền vào trường này!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
