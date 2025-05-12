using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TourismManagementSystem
{
    public partial class ManageTours : Form
    {
        string connectionString = "server=localhost;user id=root;password=lizzybabyd;database=tourism_dbb";
        public ManageTours()
        {
            InitializeComponent();
            LoadTourTypes();
        }
        private void LoadTourTypes()
        {
            tourtypecmb.Items.Clear();
            tourtypecmb.Items.AddRange(new string[] { "Adventure", "Cruise", "Cultural", "Educational", "Religious" });
            tourtypecmb.SelectedIndex = 3; // Default: Educational
        }


        private void ManageTours_Load(object sender, EventArgs e)
        {

        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminbackbtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void Adminaddbtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Tours (tour_id, name, location, tour_date, tour_time, type, tour_guide, price)
                                     VALUES (@id, @name, @location, @date, @time, @type, @guide, @price)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(touridtxt.Text));
                    cmd.Parameters.AddWithValue("@name", tournametxt.Text); // You might want to use a separate txtName
                    cmd.Parameters.AddWithValue("@location", locationtxt.Text);
                    cmd.Parameters.AddWithValue("@date", tourdate.Value.Date);
                    cmd.Parameters.AddWithValue("@time", DateTime.Now.TimeOfDay); // Can be customized
                    cmd.Parameters.AddWithValue("@type", tourtypecmb.Text);
                    cmd.Parameters.AddWithValue("@guide", tourguidetxt.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(pricetxt.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tour added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void adminupdbtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Tours SET name=@name, location=@loc, tour_date=@date, tour_time=@time,
                                     type=@type, tour_guide=@guide, price=@price WHERE tour_id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(touridtxt.Text));
                    cmd.Parameters.AddWithValue("@name", tournametxt.Text); // Same as above
                    cmd.Parameters.AddWithValue("@loc", locationtxt.Text);
                    cmd.Parameters.AddWithValue("@date", tourdate.Value.Date);
                    cmd.Parameters.AddWithValue("@time", DateTime.Now.TimeOfDay);
                    cmd.Parameters.AddWithValue("@type", tourtypecmb.Text);
                    cmd.Parameters.AddWithValue("@guide", tourguidetxt.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(pricetxt.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tour updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }

        private void adminDelbtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Tours WHERE tour_id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(touridtxt.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tour deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed: " + ex.Message);
                }
            }
        }
    }
}
