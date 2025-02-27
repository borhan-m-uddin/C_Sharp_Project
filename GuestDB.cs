using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CrystalOasis.Poplogin;

namespace CrystalOasis
{
    public partial class CustomerDashboard : Form
    {
        private int guestID;

        public CustomerDashboard(int guestID)
        {
            this.guestID = guestID; // Store the Guest ID
            LoadGuestDetails();
            InitializeComponent();
        }
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void LoadGuestDetails()
        {
            //using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            //{
            //    conn.Open();
            //    string query = "SELECT G_Name, G_Phone, G_Mail FROM Guest WHERE G_ID = @GuestID";

            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@GuestID", guestID);
            //        SqlDataReader reader = cmd.ExecuteReader();

            //        if (reader.Read())
            //        {
            //            lblGuestName.Text = "Welcome, " + reader["G_Name"].ToString();
            //            lblPhone.Text = "Phone: " + reader["G_Phone"].ToString();
            //            lblEmail.Text = "Email: " + reader["G_Mail"].ToString();
            //        }
            //    }
            //}
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About_us about_Us = new About_us();
            about_Us.ShowDialog();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }


        

        private void button3_Click_1(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms(guestID);
            rooms.Show();
            this.Hide();
        }

        private void exit_btn_Click_2(object sender, EventArgs e)
        {
            Poplogin poplogin = new Poplogin();
            poplogin.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            About_us about_Us = new About_us();
            about_Us.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms(guestID);
            rooms.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms(guestID);
            rooms.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms(guestID);
            rooms.Show();
            this.Hide();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms(guestID);
            rooms.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms(guestID);
            rooms.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms(guestID);
            rooms.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms(guestID);
            rooms.Show();
            this.Hide();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
