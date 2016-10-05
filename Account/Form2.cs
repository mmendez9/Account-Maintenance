using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btmAddNew_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int num1
        {
            get
            {
                int number = int.Parse(tbxNew.Text);
                return number;
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
