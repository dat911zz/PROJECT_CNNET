using BookStore.Sys.Containers;
using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Sys.Forms.Book
{
    public partial class frmPulisher : Form
    {
        ServicesContainer sys;
        public frmPulisher()
        {
            sys = new ServicesContainer(
                Service.Instance,
                new DBHelper(),
                new DataSet(),
                new DataColumn[1]
                );
            InitializeComponent();
        }

        private void frmPulisher_Load(object sender, EventArgs e)
        {
            txtDateOfBirth.MaxDate = DateTime.Now;
            if (!Service.Instance.IsConnectedToInternet())
            {
                MessageBox.Show("Đã mất kết nối đến máy chủ, vui lòng kiểm tra đường truyền!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Load data
            sys.Db.LoadDataIntoDgv(dgv, sys.Ds, "Publisher");
            //Thay đổi kích thước cột
            dgv.Columns[0].Width = 30;
        }
    }
}
