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

        Form2 frm = new Form2();
        List<int> accounts = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string n;
                // Open the file to set it in the list box
                StreamReader input = File.OpenText("accts.txt");
                
                while (!input.EndOfStream)
                {
                    n = input.ReadLine();
                    listAccounts.Items.Add(n);
                }
                input.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("File doesn't found", "File Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            accounts.Add(nu);
            accounts.Sort();
        }

        public int nu
        {
            get
            {
                int num = frm.num1;
                return num;
            }
        }

        private void btmAdd_Click(object sender, EventArgs e)
        {
            frm.Show();
            
        }

        private void btmClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure to CLEAR the list?", "Clear List", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            DialogResult result = new DialogResult();
            if (result == DialogResult.Yes)
            {
                StreamWriter file = File.CreateText("accts.txt");
                file.WriteLine("");
                file.Close();
                Refresh();
            }
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            //Write the new accounts added to the file
            StreamWriter file = File.AppendText("accts.txt");
            foreach (int n in accounts)
            {
                file.WriteLine(n);
            }
            file.Close();
            Close();
        }       
    }
}
