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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CrystalOasis
{
    public partial class Resetpassword : Form
    {
        private string userEmail;

        public Resetpassword(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private int? GetUserIDFromEmail(string email, out string userType)
        {
            int? userId = null;
            userType = null; // To store user type (Admin, Staff, or Guest)

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                conn.Open();

                // Dictionary with table names, email columns, and corresponding ID columns
                Dictionary<string, (string emailColumn, string idColumn)> tables = new Dictionary<string, (string, string)>
                {
                    { "Admin", ("admin_mail", "A_ID") },
                    { "Staff", ("S_Mail", "S_ID") },
                    { "Guest", ("G_mail", "G_ID") }
                };

                foreach (var table in tables)
                {
                    string query = $"SELECT {table.Value.idColumn} FROM {table.Key} WHERE {table.Value.emailColumn} = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                            userType = table.Key; // Store user type (Admin, Staff, or Guest)
                            break; // Stop searching once we find the user
                        }
                    }
                }
            }

            return userId; // Return the found User ID or null if not found
        }



        private bool UpdatePassword(int userId, string userType, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                conn.Open();

                // Determine the correct column name in Login table
                string idColumn = null;

                if (userType == "Admin")
                {
                    idColumn = "A_ID";
                }
                else if (userType == "Staff")
                {
                    idColumn = "S_ID";
                }
                else if (userType == "Guest")
                {
                    idColumn = "G_ID";
                }

                if (idColumn == null)
                {
                    MessageBox.Show("Invalid user type. Password update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Update password in Login table
                string query = $"UPDATE Login SET Password = @Password WHERE {idColumn} = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if the update was successful
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string newPassword = new_pass_txt.Text.Trim();
            string confirmPassword = confirm_pass_txt.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm your new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get User ID and User Type from email
            string userType;
            int? userId = GetUserIDFromEmail(userEmail, out userType);

            if (userId == null)
            {
                MessageBox.Show("Email not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update password in the Login table
            bool success = UpdatePassword(userId.Value, userType, newPassword);

            if (success)
            {
                MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login login = new login();
                login.Show();
                this.Hide(); // Close the form after successful reset
            }
            else
            {
                MessageBox.Show("Failed to reset password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login login = new login();
                login.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendCode sendCode = new SendCode();
            this.Hide();
            sendCode.Show();
        }
    }
}
