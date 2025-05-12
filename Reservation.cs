using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace TourismManagementSystem
{
    public partial class Reservation : Form
    {
        string connectionString = "server=localhost;user id=root;password=lizzybabyd;database=tourism_dbb";
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void reservebtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Reservation (reservation_id, name, location, checkindate, checkoutdate, price)
                                 VALUES (@id, @name, @location, @checkin, @checkout, @price)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(reserveidtxt.Text));
                cmd.Parameters.AddWithValue("@name", nametxt.Text);
                cmd.Parameters.AddWithValue("@location", locationtxt.Text);
                cmd.Parameters.AddWithValue("@checkin", datein.Value.Date);
                cmd.Parameters.AddWithValue("@checkout", dateout.Value.Date);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(pricetxt.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation added successfully!");
            }
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Reservation SET name=@name, location=@location,
                                 checkindate=@checkin, checkoutdate=@checkout, price=@price
                                 WHERE reservation_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(reserveidtxt.Text));
                cmd.Parameters.AddWithValue("@name", nametxt.Text);
                cmd.Parameters.AddWithValue("@location", locationtxt.Text);
                cmd.Parameters.AddWithValue("@checkin", datein.Value.Date);
                cmd.Parameters.AddWithValue("@checkout", dateout.Value.Date);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(pricetxt.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation updated.");
            }
        }
    }
}
