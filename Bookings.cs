using System.Data;
using MySql.Data.MySqlClient;

namespace TourismManagementSystem
{
    public partial class Bookings : Form

    {
        string connectionString = "server=localhost;user id=root;password=lizzybabyd;database=tourism_dbb";

        public Bookings()
        {
            InitializeComponent();
            LoadTourTypes();
            LoadTours();
            LoadUsers();
            LoadReservations();
            LoadTransport();
        }

        private void LoadTourTypes()
        {
            tourtypecmb.Items.Clear();
            tourtypecmb.Items.AddRange(new string[] { "Adventure", "Cruise", "Cultural", "Educational", "Religious" });
            tourtypecmb.SelectedIndex = 3; // Default: Educational
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
        private void LoadUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT user_id, username FROM Users";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                usercmb.DataSource = dt;
                usercmb.DisplayMember = "username";
                usercmb.ValueMember = "user_id";
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

                reservecmb.DataSource = dt;
                reservecmb.DisplayMember = "location";
                reservecmb.ValueMember = "reservation_id";
            }
        }
        private void LoadTransport()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT transport_id FROM Transportation";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                transportcmb.DataSource = dt;
                transportcmb.DisplayMember = "type";
                transportcmb.ValueMember = "transport_id";
            }
        }

        private void Bookings_Load(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Bookbtn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(usercmb.SelectedValue);
            int transportId = Convert.ToInt32(transportcmb.SelectedValue);
            int tourId = Convert.ToInt32(tourcmb.SelectedValue);
            int reservationId = Convert.ToInt32(reservecmb.SelectedValue);
            int noOfPeople = int.TryParse(noofpeopletxt.Text, out int p) ? p : 1;
            DateTime bookingDate = departdateTimePicker.Value.Date;
            int totalAmount = noOfPeople * 500; // or fetch tour/reservation price dynamically

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Bookings 
                            (user_id, transport_id, tour_id, reservation_id, booking_date, no_of_people, total_amount)
                            VALUES 
                            (@user_id, @transport_id, @tour_id, @reservation_id, @booking_date, @no_of_people, @total_amount)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.Parameters.AddWithValue("@transport_id", transportId);
                    cmd.Parameters.AddWithValue("@tour_id", tourId);
                    cmd.Parameters.AddWithValue("@reservation_id", reservationId);
                    cmd.Parameters.AddWithValue("@booking_date", bookingDate);
                    cmd.Parameters.AddWithValue("@no_of_people", noOfPeople);
                    cmd.Parameters.AddWithValue("@total_amount", totalAmount);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking created successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
