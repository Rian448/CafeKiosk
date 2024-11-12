namespace CafeKiosk.AllUserControl
{
    partial class UserControl1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            textBox3 = new TextBox();
            label5 = new Label();
            AddItems = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 43);
            label1.Name = "label1";
            label1.Size = new Size(178, 36);
            label1.TabIndex = 0;
            label1.Text = "Add Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label2.Location = new Point(108, 104);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label3.Location = new Point(108, 174);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 2;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label4.Location = new Point(108, 235);
            label4.Name = "label4";
            label4.Size = new Size(72, 32);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(363, 23);
            comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 23);
            textBox2.TabIndex = 7;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 25;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(204, 381);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "Add";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 340);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(363, 23);
            textBox3.TabIndex = 10;
            textBox3.Leave += textBox3_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label5.Location = new Point(108, 305);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 9;
            label5.Text = "Quantity";
            // 
            // AddItems
            // 
            AddItems.BorderRadius = 30;
            AddItems.TargetControl = this;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(guna2Button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(600, 450);
            Leave += UserControl1_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private TextBox textBox3;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Elipse AddItems;
    }
}
