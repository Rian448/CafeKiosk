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
            comboCategory.Items.Add("Cone");
            comboCategory.Items.Add("Flavors");
            comboCategory.Items.Add("Addons");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//getting data in database and putting selected category items in the listbox
            String category = comboCategory.Text;
            query = "Select ItemName from items where Category = '" + category + "'";
            showItemList(query);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "Select ItemName from items where Category = '" + category + "'and ItemName like '" + txtSearch.Text + "%'";
            showItemList(query);
        }
        private void showItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtQuantityUpDown.ResetText();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;

            query = "select Price from items where ItemName = '" + text + "'";
            DataSet ds = fn.getData(query);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }

        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Int64 quantity = Int64.Parse(txtQuantityUpDown.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);

            txtTotal.Text = (quantity * price).ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        protected int n, total = 0;
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {

            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txtQuantityUpDown.Value;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total = total + int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "Php " + total;

                txtItemName.Clear();
                txtPrice.Clear();
                txtTotal.Clear();
            }
            else
            {
                MessageBox.Show("Quantity is needed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        int amount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            labelTotalAmount.Text = "Php " + total;
        }
    }
}
