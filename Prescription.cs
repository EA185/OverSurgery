﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_1
{
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu page = new Menu();
            page.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
