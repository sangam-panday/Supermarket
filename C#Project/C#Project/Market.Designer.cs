namespace C_Project
{
    partial class Market
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 52);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(540, 35);
            label1.TabIndex = 0;
            label1.Text = "Super Market Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 549);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 286);
            button4.Name = "button4";
            button4.Size = new Size(281, 81);
            button4.TabIndex = 3;
            button4.Text = "Inventory";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 195);
            button3.Name = "button3";
            button3.Size = new Size(281, 85);
            button3.TabIndex = 2;
            button3.Text = "Order";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 103);
            button2.Name = "button2";
            button2.Size = new Size(281, 86);
            button2.TabIndex = 1;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 16);
            button1.Name = "button1";
            button1.Size = new Size(281, 81);
            button1.TabIndex = 0;
            button1.Text = "Product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Market
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_100618923_Fy0h3HKNfaPTlVBx54cgsRIKC2RaPW9U;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(941, 601);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Market";
            Text = "Market";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}