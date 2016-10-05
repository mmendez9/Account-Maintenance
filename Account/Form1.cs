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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string number;
                // Open the file
                StreamReader file = File.OpenText("Accounts.txt");
                while (!file.EndOfStream)
                {
                    number = file.ReadLine();
                    listAccounts.Items.Add(number); // Add the number in file to the list box
                }
                file.Close();
                Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("File doesn't found", "File Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btmAdd_Click(object sender, EventArgs e)
        {
            Form2 AddWin = new Form2();
            AddWin.Show();

        }

        private void btmClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure to CLEAR the list?", "Clear List", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            DialogResult result = new DialogResult();
            if (result == DialogResult.Yes)
            {
                StreamWriter file = File.CreateText("Accounts.txt");
                file.WriteLine("");
                file.Close();
                Refresh();
            }
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
