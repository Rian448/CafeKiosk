using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKiosk.AllUserControl
{
    public partial class UserControl1 : UserControl
    {
        Functions fn = new Functions();
        String query;
        public UserControl1()
        {
            InitializeComponent();
            itemsAdd();
        }

        public void itemsAdd()
        {
            comboBox1.Items.Add("Cone");
            comboBox1.Items.Add("Flavors");
            comboBox1.Items.Add("Addons");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "insert into items (ItemName, Category, InStock, Price) values ('" + textBox1.Text + "','" + comboBox1.Text + "', " + textBox3.Text + "," + textBox2.Text + ")";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

        }

        private void UserControl1_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
