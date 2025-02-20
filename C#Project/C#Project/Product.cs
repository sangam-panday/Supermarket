using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productid = int.Parse(textBox1.Text);
            string productname = textBox2.Text;
            string category = textBox3.Text;
            decimal price = decimal.Parse(textBox4.Text);

            string query = "INSERT INTO products(ProductID, ProductName, Category, Price) VALUES(@ProductID, @ProductName, @Category, @Price";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productid);
                    cmd.Parameters.AddWithValue("@ProductName", productname);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Inserted Sucessfully");
        }
    }
}
