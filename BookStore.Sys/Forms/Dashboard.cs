﻿using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_MoneySolvedTime_Click(object sender, EventArgs e)
        {
            RpDoanhThuTuan rpweek = new RpDoanhThuTuan();
            rpweek.Show();
        }
    }
}
