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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customerid = int.Parse(textBox1.Text);
            string customername = textBox2.Text;
            string phone = textBox3.Text;
            string address = textBox4.Text;

            string query = "INSERT INTO customer(CustomerID, CustomerName, Phone, Address) VALUES(@CustomerID, @CustomerName, @Phone, @Address)";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerid);
                    cmd.Parameters.AddWithValue("@CustomerName", customername);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Inserted Sucessfully");
            CustomerData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int customerid = int.Parse(textBox1.Text);
            string customername = textBox2.Text;
            string phone = textBox3.Text;
            string address = textBox4.Text;

            string query = "UPDATE customer set CustomerName = @CustomerName, Phone = @Phone, Address = @Address WHERE CustomerID = @CustomerID";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerid);
                    cmd.Parameters.AddWithValue("@CustomerName", customername);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Updated Sucessfully");
            CustomerData();
        }
        public void CustomerData()
        {
            string query = "SELECT * FROM customer";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int customerid = int.Parse(textBox1.Text);

            string query = "DELETE FROM customer WHERE   CustomerID = @CustomerID";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerid);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Deleted Sucessfully");
            CustomerData();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            CustomerData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
