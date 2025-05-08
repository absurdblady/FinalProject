﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();

            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Farmer Farmer = new Farmer();
            Farmer.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Artisan artisan = new Artisan();
            artisan.Show();

            this.Hide();
        }
    }
}
