namespace CafeKiosk.AllUserControl
{
    partial class UpdateItems
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label2 = new Label();
            txtSearchItem = new Guna.UI2.WinForms.Guna2TextBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new Label();
            txtCategory = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Update Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 40);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Item Name";
            // 
            // txtSearchItem
            // 
            txtSearchItem.CustomizableEdges = customizableEdges11;
            txtSearchItem.DefaultText = "";
            txtSearchItem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchItem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchItem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchItem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchItem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchItem.Font = new Font("Segoe UI", 9F);
            txtSearchItem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchItem.Location = new Point(390, 58);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.PasswordChar = '\0';
            txtSearchItem.PlaceholderText = "";
            txtSearchItem.SelectedText = "";
            txtSearchItem.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtSearchItem.Size = new Size(197, 34);
            txtSearchItem.TabIndex = 2;
            txtSearchItem.TextChanged += txtSearchItem_TextChanged;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(23, 107);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(564, 119);
            guna2DataGridView1.TabIndex = 3;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellClick += guna2DataGridView1_CellClick;
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 244);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // txtCategory
            // 
            txtCategory.CustomizableEdges = customizableEdges9;
            txtCategory.DefaultText = "";
            txtCategory.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCategory.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCategory.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCategory.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategory.Font = new Font("Segoe UI", 9F);
            txtCategory.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategory.Location = new Point(23, 272);
            txtCategory.Name = "txtCategory";
            txtCategory.PasswordChar = '\0';
            txtCategory.PlaceholderText = "";
            txtCategory.SelectedText = "";
            txtCategory.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtCategory.Size = new Size(200, 36);
            txtCategory.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.CustomizableEdges = customizableEdges7;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(23, 348);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtName.Size = new Size(200, 36);
            txtName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 320);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 6;
            label4.Text = "Item Name";
            // 
            // txtPrice
            // 
            txtPrice.CustomizableEdges = customizableEdges5;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Segoe UI", 9F);
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(338, 272);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPrice.Size = new Size(200, 36);
            txtPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 244);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 25;
            btnUpdate.CustomizableEdges = customizableEdges3;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.Font = new Font("Segoe UI", 9F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(189, 402);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnUpdate.Size = new Size(175, 45);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.CustomizableEdges = customizableEdges1;
            txtQuantity.DefaultText = "";
            txtQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuantity.Font = new Font("Segoe UI", 9F);
            txtQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuantity.Location = new Point(338, 348);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '\0';
            txtQuantity.PlaceholderText = "";
            txtQuantity.SelectedText = "";
            txtQuantity.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtQuantity.Size = new Size(200, 36);
            txtQuantity.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 320);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 11;
            label6.Text = "Quantity";
            // 
            // UpdateItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtQuantity);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(txtCategory);
            Controls.Add(label3);
            Controls.Add(guna2DataGridView1);
            Controls.Add(txtSearchItem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateItems";
            Size = new Size(600, 450);
            Load += UpdateItems_Load;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchItem;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtCategory;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Label label6;
    }
}
