using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalOasis
{
    public partial class Poplogin : Form
    {
        private int guestId = 0;
        public static class DatabaseConfig
        {
            public static string connectionString = "Data Source=DESKTOP-9PIA8DC\\SQLEXPRESS;Initial Catalog=Hotel_management;Integrated Security=True;";
        }

        public Poplogin()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {
            SendCode sendCode = new SendCode();
            sendCode.Show();
            this.Hide(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register reg1 = new Register();
            reg1.ShowDialog();
            this.Hide();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private string GetUserName(string role, int userId)
        {
            string name = "User"; // Default value
            string query = "";

            if (role == "Admin")
            {
                query = "SELECT admin_name FROM Admin WHERE A_ID = @UserID";
            }
            else if (role == "Staff")
            {
                query = "SELECT S_Name FROM Staff WHERE S_ID = @UserID";
            }
            else if (role == "Guest")
            {
                query = "SELECT G_Name FROM Guest WHERE G_ID = @UserID";
            }
            else
            {
                return name; // Invalid role, return default name
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            name = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching user name: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return name;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = user1.Text.Trim();
            string password = password1.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
                {
                    conn.Open();

                    // Query to get role, status, and related ID (A_ID, S_ID, or G_ID)
                    string query = "SELECT Role, Status, A_ID, S_ID, G_ID FROM Login WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string role = reader["Role"].ToString();
                            int status = Convert.ToInt32(reader["Status"]);

                            // Check if the account is active (Status = 1)
                            if (status != 1)
                            {
                                MessageBox.Show("Your account is inactive. Please contact the administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Fetch the user ID from the correct column
                            int userId = 0;
                            if (role == "Admin") userId = reader["A_ID"] != DBNull.Value ? Convert.ToInt32(reader["A_ID"]) : 0;
                            else if (role == "Staff") userId = reader["S_ID"] != DBNull.Value ? Convert.ToInt32(reader["S_ID"]) : 0;
                            else if (role == "Guest")
                            {
                                userId = reader["G_ID"] != DBNull.Value ? Convert.ToInt32(reader["G_ID"]) : 0;
                                guestId = userId;
                            }

                                reader.Close(); // Close reader before executing another query

                            // Get user name based on role and userId
                            string userName = GetUserName(role, userId);

                            MessageBox.Show($"Welcome, {userName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open corresponding dashboard
                            if (role == "Admin")
                            {
                                AdminDashboard adminForm = new AdminDashboard();
                                adminForm.welcome_lbl.Text = "Welcome, " + userName;
                                adminForm.Show();
                                adminForm.BringToFront();
                                
                            }
                            else if (role == "Staff")
                            {
                                StaffDB staffForm = new StaffDB();
                                staffForm.Staff_hellolbl.Text = "Hello , " + userName;
                                staffForm.Show();
                            }
                            else if (role == "Guest")
                            {
                                CustomerDashboard guestForm = new CustomerDashboard(guestId);
                                Rooms rooms = new Rooms(guestId);
                                //Payment payment = new Payment(guestId);
                                guestForm.welcome_Guestlbl.Text = "Welcome, " + userName;
                                guestForm.Show();
                            }

                            this.Hide(); // Hide the login form
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                password1.UseSystemPasswordChar = false;
            }
            else
            {
                
                password1.UseSystemPasswordChar = true;
            }

        }





    }
}