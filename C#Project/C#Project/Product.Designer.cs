namespace C_Project
{
    partial class Product
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 20);
            label1.Name = "label1";
            label1.Size = new Size(130, 35);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(638, 252);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(351, 191);
            button3.Name = "button3";
            button3.Size = new Size(115, 43);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(209, 191);
            button2.Name = "button2";
            button2.Size = new Size(115, 43);
            button2.TabIndex = 9;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(59, 191);
            button1.Name = "button1";
            button1.Size = new Size(115, 43);
            button1.TabIndex = 8;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(209, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(396, 30);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(209, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(396, 30);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(209, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(396, 30);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(209, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 30);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 149);
            label5.Name = "label5";
            label5.Size = new Size(63, 23);
            label5.TabIndex = 3;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 107);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 2;
            label4.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 67);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 1;
            label3.Text = "ProductName:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 18);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 0;
            label2.Text = "ProductId:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 358);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(638, 188);
            dataGridView1.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(490, 191);
            button4.Name = "button4";
            button4.Size = new Size(115, 43);
            button4.TabIndex = 11;
            button4.Text = "New";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(662, 561);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}