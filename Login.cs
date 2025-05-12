using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TourismManagementSystem;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        private string connectionString = "server=localhost;user id=root;password=lizzybabyd;database=tourism_dbb";

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE username=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", Username.Text);
                cmd.Parameters.AddWithValue("@password", Password.Text);

                Username.Clear();
                Password.Clear();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string role = reader["role"].ToString();
                    //MessageBox.Show("Login Successful! Role: " + role);

                    if (role == "customer")
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    }
                    else
                    {
                        AdminHome adminhome = new AdminHome();
                        adminhome.Show();
                    }

                    this.Hide(); // Hide login form
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
                conn.Close();
            }
        }
    }
}
