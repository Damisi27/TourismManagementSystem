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

namespace TourismManagementSystem
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void Admintoursbtn_Click(object sender, EventArgs e)
        {
            ManageTours manageTours = new ManageTours();
            manageTours.Show();
            this.Hide();
        }

        private void Adminbookbtn_Click(object sender, EventArgs e)
        {
            ManageBookings bookings = new ManageBookings();
            bookings.Show();
            this.Hide();
        }

        private void detailsbtn_Click(object sender, EventArgs e)
        {
            Display ds = new Display();
            ds.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation rs = new Reservation(); 
            rs.Show();
            this.Hide();
        }
    }
}
