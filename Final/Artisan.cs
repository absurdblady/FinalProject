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
    public partial class Artisan : Form
    {
        public Artisan()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Upload upload = new Upload();
            upload.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Upload upload = new Upload();
            upload.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Upload upload = new Upload();
            upload.Show();
            this.Hide();
        }
    }
}
