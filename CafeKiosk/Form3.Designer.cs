namespace CafeKiosk
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btnAddItems = new Button();
            button1 = new Button();
            panel2 = new Panel();
            userControl11 = new AllUserControl.UserControl1();
            AddItems = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnAddItems);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 452);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(0, 426);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(27, 145);
            button3.Name = "button3";
            button3.Size = new Size(165, 33);
            button3.TabIndex = 2;
            button3.Text = "View Inventory";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnAddItems
            // 
            btnAddItems.Location = new Point(27, 112);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.Size = new Size(165, 27);
            btnAddItems.TabIndex = 1;
            btnAddItems.Text = "Add Items";
            btnAddItems.UseVisualStyleBackColor = true;
            btnAddItems.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 76);
            button1.Name = "button1";
            button1.Size = new Size(165, 30);
            button1.TabIndex = 0;
            button1.Text = "View Orders";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(userControl11);
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 452);
            panel2.TabIndex = 1;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(3, 3);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(600, 450);
            userControl11.TabIndex = 0;
            // 
            // AddItems
            // 
            AddItems.BorderRadius = 30;
            AddItems.TargetControl = panel2;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button btnAddItems;
        private Button button1;
        private Guna.UI2.WinForms.Guna2Elipse AddItems;
        private AllUserControl.UserControl1 userControl11;
    }
}