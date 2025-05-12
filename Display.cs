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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            displaycmb.Items.Add("Reservation");
            displaycmb.Items.Add("Tours");
            displaycmb.Items.Add("Bookings");
            displaycmb.Items.Add("Users");
            displaycmb.SelectedIndex = 0;
        }

        private void loadtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displaycmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = displaycmb.SelectedItem.ToString();
            LoadTableData(selectedTable);
        }

        private void LoadTableData(string tableName)
        {
            string connectionString = "server=localhost;user id=root;password=lizzybabyd;database=tourism_dbb";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM {tableName}";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    loadtable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }
    }
}
