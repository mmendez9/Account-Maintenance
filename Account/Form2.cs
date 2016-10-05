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
            // Open the file where the new number will be stored
            StreamWriter newAcct = File.AppendText("Accounts.txt");
            int newNumber = 0;
            if (int.TryParse(tbxNew.Text, out newNumber))// Convert the text(string) to number(int)
            {
                newAcct.WriteLine(newNumber); // Write the number to the file
                newAcct.Close();
                Form1 frm = new Form1();
                frm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Mising or Not numeric", "Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
