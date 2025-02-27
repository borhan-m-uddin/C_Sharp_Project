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
    public partial class AdminDashboard : Form
    {
        private Form currentForm = null; // Track the currently open form
        public AdminDashboard()
        {
            InitializeComponent();
            LoadDashboardData();
            LoadPaymentDetails();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void LoadDashboardData()
        {
            string query = @"
            SELECT 
            (SELECT COUNT(*) FROM Staff) AS TotalStaff,
            (SELECT COUNT(*) FROM Guest) AS TotalGuests,
            (SELECT COUNT(*) FROM Vehicles) AS TotalVehicles,
            (SELECT COUNT(*) FROM Room) AS TotalRooms";

            using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    total_staff_lbl.Text = "Total Staff: " + reader["TotalStaff"].ToString();
                    total_Guest_lbl.Text = "Total Guest: " + reader["TotalGuests"].ToString();
                    total_Vehicle_lbl.Text = "Total Vehicle parked: " + reader["TotalVehicles"].ToString();
                    total_Room_lbl.Text = "Total Room: " + reader["TotalRooms"].ToString();
                }
            }
        }
        private void LoadPaymentDetails()
        {
            string query = "SELECT Invoice_ID, Reservation_ID, G_ID, G_Name, Amount, Payment_time, Payment_method FROM Payment";

            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();

                    // Fill the DataTable with data from the database
                    adapter.Fill(dt);

                    // Set the DataGridView's DataSource to the DataTable
                    payment_data.DataSource = dt;
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-specific errors here
                MessageBox.Show("A database error occurred: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other general exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void LoadFormInPanel(Form childForm)
        {
            // If the same form is clicked again, hide it and show the main content
            if (currentForm != null && currentForm.GetType() == childForm.GetType())
            {
                currentForm.Hide();
                currentForm = null;
                return;
            }

            // Hide previous form (if any)
            if (currentForm != null)
                currentForm.Hide();

            // Set up the new form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add it to the main panel (only once)
            if (!main_panel.Controls.Contains(childForm))
            {
                main_panel.Controls.Add(childForm);
            }

            childForm.BringToFront();
            childForm.Show();

            // Update the currently displayed form
            currentForm = childForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Hide();
                currentForm = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Manage_Staff());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Poplogin poplogin = new Poplogin();
            poplogin.Show();
        }

        private void btnManageVehicle_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Manage_Vehicles());
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Manage_Room());
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Manage_Reservation());
        }

        private void btnManagePayments_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Manage_Service());
        }

        private void btnManageGuests_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Manage_Guest());
        }

        private void upper_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void left_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_footer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManageAdmin_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Manage_Admin());
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
