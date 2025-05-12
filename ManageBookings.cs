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
    public partial class ManageBookings : Form
    {
        string connectionString = "server=localhost;user id=root;password=lizzybabyd;database=tourism_dbb";
        public ManageBookings()
        {
            InitializeComponent();
            LoadUsers();
            LoadBookings();
            LoadTours();
            LoadReservations();
            LoadTransport();
        }
        private void LoadUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT user_id, username FROM Users";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                useridcmb.DataSource = dt;
                useridcmb.DisplayMember = "username";
                useridcmb.ValueMember = "user_id";
            }
        }
        private void LoadBookings()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT booking_id FROM Bookings";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                bookingIdcmb.DataSource = dt;
                bookingIdcmb.DisplayMember = "booking_id";
                bookingIdcmb.ValueMember = "booking_id";
            }
        }
        private void LoadTours()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT tour_id, name FROM Tours";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tourcmb.DataSource = dt;
                tourcmb.DisplayMember = "name";
                tourcmb.ValueMember = "tour_id";
            }
        }
        private void LoadReservations()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT reservation_id, name FROM Reservation";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                reservescmb.DataSource = dt;
                reservescmb.DisplayMember = "location";
                reservescmb.ValueMember = "reservation_id";
            }
        }
        private void LoadTransport()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT transport_id FROM Transportation ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                transportcmb.DataSource = dt;
                transportcmb.DisplayMember = "type";
                transportcmb.ValueMember = "transport_id";
            }
        }

        private void ManageBookings_Load(object sender, EventArgs e)
        {

        }

        private void addbookingbtn_Click(object sender, EventArgs e)
        {
            /*int userId = Convert.ToInt32(useridcmb.SelectedValue);
            int transportId = Convert.ToInt32(transportcmb.SelectedValue);
            int tourId = Convert.ToInt32(tourcmb.SelectedValue);
            int reservationId = Convert.ToInt32(reservescmb.SelectedValue);
            DateTime bookingDate = datescmb.Value.Date;
            //int totalAmount = noOfPeople * 500; // Adjust as needed or compute from tour/reservation price

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Bookings (user_id, transport_id, tour_id, reservation_id, booking_date)
                         VALUES (@user_id, @transport_id, @tour_id, @reservation_id, @booking_date)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.Parameters.AddWithValue("@transport_id", transportId);
                cmd.Parameters.AddWithValue("@tour_id", tourId);
                cmd.Parameters.AddWithValue("@reservation_id", reservationId);
                cmd.Parameters.AddWithValue("@booking_date", bookingDate);
                //cmd.Parameters.AddWithValue("@total_amount", totalAmount);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking added successfully!");
                LoadBookings();
            }*/
            Bookings bookings = new Bookings();
            bookings.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Close();

        }

        private void cancelbookingbtn_Click(object sender, EventArgs e)
        {
            if (bookingIdcmb.SelectedItem == null)
            {
                MessageBox.Show("Please select a booking to cancel.");
                return;
            }

            int bookingId = Convert.ToInt32(bookingIdcmb.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Bookings WHERE booking_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", bookingId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Booking cancelled successfully.");
                LoadBookings();

            }
        }
     }
}
