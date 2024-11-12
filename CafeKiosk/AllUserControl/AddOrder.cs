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
    public partial class AddOrder : UserControl
    {
        Functions fn = new Functions();
        String query;
        public AddOrder()
        {
            InitializeComponent();
            ItemsAdd();
        }

        public void ItemsAdd()
        {
            guna2ComboBox1.Items.Add("Cone");
            guna2ComboBox1.Items.Add("Flavors");
            guna2ComboBox1.Items.Add("Addons");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//getting data in database and putting selected category items in the listbox
            listBox1.Items.Clear();
            String category = guna2ComboBox1.Text;
            query = "Select name from items where Category = '" + category + "'";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {//SearchBar
            listBox1.Items.Clear();
            String category = guna2ComboBox1.Text;
            query = "Select name from items where Category = '" + category + "'and ItemName like '" + guna2TextBox1.Text + "%'";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2TextBox4.Clear();
            guna2NumericUpDown1.ResetText();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            guna2TextBox2.Text = text;

            query = "select Price from items where ItemName = '" + text + "'";
            DataSet ds = fn.getData(query);

            try
            {
                guna2TextBox3.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }

        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Int64 quantity = Int64.Parse(guna2NumericUpDown1.Value.ToString());
            Int64 price = Int64.Parse(guna2TextBox3.Text);

            guna2TextBox4.Text = (quantity * price).ToString();
        }
    }
}
