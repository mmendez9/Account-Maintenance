﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> accounts = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btmAdd_Click(object sender, EventArgs e)
        {
            Form2 AddWin = new Form2();
            AddWin.Show();
        }
    }
}
