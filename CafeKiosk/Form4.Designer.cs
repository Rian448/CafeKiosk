namespace CafeKiosk
{
    partial class Form4
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
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            addOrder1 = new AllUserControl.AddOrder();
            welcome1 = new AllUserControl.Welcome();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 217);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "database";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(61, 450);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(0, 80);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(addOrder1);
            panel2.Controls.Add(welcome1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(61, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(739, 450);
            panel2.TabIndex = 3;
            // 
            // addOrder1
            // 
            addOrder1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addOrder1.Location = new Point(0, 3);
            addOrder1.Margin = new Padding(4, 3, 4, 3);
            addOrder1.Name = "addOrder1";
            addOrder1.Size = new Size(771, 450);
            addOrder1.TabIndex = 1;
            // 
            // welcome1
            // 
            welcome1.Location = new Point(0, 3);
            welcome1.Name = "welcome1";
            welcome1.Size = new Size(600, 450);
            welcome1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = panel2;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private AllUserControl.Welcome welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AllUserControl.AddOrder addOrder1;
    }
}