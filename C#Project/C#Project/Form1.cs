namespace C_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text)||string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid number","Validation error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string correct_name = "admin";
            string correct_password = "admin";
            if(textBox1.Text==correct_name && textBox2.Text==correct_password)
            {
                Market mt = new Market();
                mt.Show();  
            }
            else
            {
                MessageBox.Show("Invalid Username/Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
