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
    public partial class UpdateItems : UserControl
    {
        Functions fn = new Functions();
        String query;
        public UpdateItems()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateItems_Load(object sender, EventArgs e)
        {

            loadData();
        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where ItemName like '" + txtSearchItem.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int Id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String ItemName = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int Price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            int InStock = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtCategory.Text = Category;
            txtName.Text = ItemName;
            txtPrice.Text = Price.ToString();
            txtQuantity.Text = InStock.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update items set ItemName = '" + txtName.Text + "', Category = '" + txtCategory.Text + "',InStock=" + txtQuantity.Text + ",Price=" + txtPrice.Text + " where id = " + Id + "";
            fn.setData(query);
            loadData();
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtSearchItem.Clear();
        }
    }
}
