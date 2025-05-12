using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TourismManagementSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            string user = nametxt.Text;
            string username = newusernametxt.Text;
            string PassWord = passwordtxt.Text;
            string Email = emailtxt.Text;
            string Phone = phonetxt.Text;
            string address = addresstxt.Text;

            if (phonetxt.Text.Count() != 11)
            {
                MessageBox.Show("Phone number must be 11 digits.");
                return;
            }

            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=lizzybabyd;database=tourism_dbb");
            if (string.IsNullOrEmpty(nametxt.Text) || string.IsNullOrEmpty(passwordtxt.Text) || string.IsNullOrEmpty(emailtxt.Text) || string.IsNullOrEmpty(phonetxt.Text) || string.IsNullOrEmpty(newusernametxt.Text))
                MessageBox.Show("Empty fields are not allowed.");

            conn.Open();
            string query = "INSERT INTO Users (username, password, name, email, address, phone) VALUES (@username, @password, @name, @email, @address, @phone)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", PassWord); // Note: No hashing here, for demo only
            cmd.Parameters.AddWithValue("@name", user);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", Phone);
            cmd.ExecuteNonQuery();

            nametxt.Clear();
            newusernametxt.Clear();
            passwordtxt.Clear();
            emailtxt.Clear();
            phonetxt.Clear();
            addresstxt.Clear();

            /*MySqlCommand comand = new MySqlCommand("select username from Users", conn);
            MySqlDataReader rdr = comand.ExecuteReader();

            while (rdr.Read())
            {
                if (username == rdr["username"].ToString())
                {
                    MessageBox.Show("This Username is Already taken.", "Change Username!");
                    rdr.Close();
                    conn.Close();
                    return;
                }
            }

            rdr.Close();
            comand.ExecuteNonQuery();*/
            conn.Close();
            MessageBox.Show("Welcome!", "New User");

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
