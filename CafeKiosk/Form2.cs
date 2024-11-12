using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKiosk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Manager" && txtPassword.Text == "Password")
            { //Log in Function and show new form
                Form3 form3 = new Form3();
                form3.Show(); this.Hide();
            }
            else
            {
                txtPassword.PlaceholderText = "Invalid Username or Password";
                txtUsername.PlaceholderText = "Invalid Username or Password";
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); this.Hide();
        }
    }
}
