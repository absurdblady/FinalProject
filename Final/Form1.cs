using System;
using System.Windows.Forms;

namespace Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim().ToLower();
            string password = textBox2.Text.Trim().ToLower();

            User currentUser = null;

            if (username == "admin" && password == "admin")
            {
                currentUser = new AdminUser("Admin");
            }
            else if (username == "farmer" && password == "farmer")
            {
                currentUser = new FarmerUser("Farmer");
            }
            else if (username == "artisan" && password == "artisan")
            {
                currentUser = new ArtisanUser("Artisan");
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            currentUser.OpenDashboard();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
