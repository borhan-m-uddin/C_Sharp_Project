using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CrystalOasis.Poplogin;

namespace CrystalOasis
{
    public partial class Manage_Staff : Form
    {
        private AllLoadData allLoadData;
        private DataDeleter dataDeleter;
        public Manage_Staff()
        {
            InitializeComponent();
            allLoadData = new AllLoadData();
            dataDeleter = new DataDeleter();
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    string query = @"
                SELECT 
                    s.S_ID, 
                    s.S_Name, 
                    s.Job_title, 
                    s.S_Phone, 
                    s.S_Mail, 
                    s.A_ID,
                    l.Username, 
                    l.Password, 
                    l.Status 
                FROM Staff s
                INNER JOIN Login l ON s.S_ID = l.S_ID"; // Joining Staff with Login Table

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    Staff_data_view.DataSource = table;

                    // Hide Password for Security
                    //Staff_data_view.Columns["Password"].Visible = false;

                    // Add Delete Button Column (if not already present)
                    if (!Staff_data_view.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                        {
                            Name = "Delete",
                            HeaderText = "Delete",
                            Text = "Delete",
                            UseColumnTextForButtonValue = true,
                            DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red, BackColor = Color.White }
                        };
                        Staff_data_view.Columns.Add(deleteButton);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff data: " + ex.Message);
            }
        }

        private void DeleteStaff(int staffID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Step 1: Delete from Login Table (if Staff is linked there)
                        string deleteLoginQuery = "DELETE FROM Login WHERE S_ID = @staffID";
                        using (SqlCommand cmd = new SqlCommand(deleteLoginQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@staffID", staffID);
                            cmd.ExecuteNonQuery();
                        }

                        // Step 2: Delete from Staff Table
                        string deleteStaffQuery = "DELETE FROM Staff WHERE S_ID = @staffID";
                        using (SqlCommand cmd = new SqlCommand(deleteStaffQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@staffID", staffID);
                            cmd.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();
                        MessageBox.Show("Staff deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload Staff Data
                        LoadStaffData();
                    }
                    catch (SqlException sqlEx)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is in a valid row and is the "Delete" button column
            if (e.RowIndex >= 0 && Staff_data_view.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && Staff_data_view.Columns[e.ColumnIndex].Name == "Delete")
            {
                int staffID = Convert.ToInt32(Staff_data_view.Rows[e.RowIndex].Cells["S_ID"].Value);

                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this staff member?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteStaff(staffID);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchValue = staff_search_txt.Text.Trim();
                (Staff_data_view.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("Convert(S_ID, 'System.String') LIKE '%{0}%' OR S_Name LIKE '%{0}%' OR S_Phone LIKE '%{0}%' OR S_Mail LIKE '%{0}%'", searchValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in search: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = Staff_data_view.Rows[e.RowIndex];

                    mngStaff_textID.Text = row.Cells["S_ID"].Value.ToString();
                    mngStaff_txtName.Text = row.Cells["S_Name"].Value.ToString();
                    mngStaff_jobTitletxt.Text = row.Cells["Job_title"].Value.ToString();
                    mngStaff_txtMobile.Text = row.Cells["S_Phone"].Value.ToString();
                    mngStaff_mailtxt.Text = row.Cells["S_Mail"].Value.ToString();
                    mngStaffAdmin_txtID.Text = row.Cells["A_ID"].Value.ToString();
                    mngStaff_txtUsername.Text = row.Cells["Username"].Value.ToString();
                    mngStaff_txtPassword.Text = row.Cells["Password"].Value.ToString();
                    // Handle Status (0 = Inactive, 1 = Active)
                    mngStaff_txtstatus.SelectedIndex = Convert.ToInt32(row.Cells["Status"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message, "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mngRoom_typetxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mngRoom_type_Click(object sender, EventArgs e)
        {

        }

        private bool UsernameExists(string username)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Login WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Returns true if username exists
            }
        }

        private void bdt_Staff_add_Click(object sender, EventArgs e)
        {

        }

        private void bdt_Staff_add_Click_1(object sender, EventArgs e)
        {
            // Validate Admin ID
            if (!int.TryParse(mngStaffAdmin_txtID.Text.Trim(), out int adminId))
            {
                MessageBox.Show("Invalid Admin ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = mngStaff_txtName.Text.Trim();
            string phone = mngStaff_txtMobile.Text.Trim();
            string email = mngStaff_mailtxt.Text.Trim();
            string jobTitle = mngStaff_jobTitletxt.SelectedItem?.ToString();
            string username = mngStaff_txtUsername.Text.Trim();
            string password = mngStaff_txtPassword.Text.Trim();
            int status = mngStaff_txtstatus.SelectedIndex; // 0 or 1

            // Validate required fields
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(jobTitle) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields must be filled!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password length
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate phone number (only digits allowed)
            if (!long.TryParse(phone, out _))
            {
                MessageBox.Show("Phone number must contain only digits!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if username already exists
            if (UsernameExists(username))
            {
                MessageBox.Show("Username already exists! Choose a different username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insert into Staff table
                    string insertStaffQuery = "INSERT INTO Staff (S_Name, Job_title, S_Phone, S_Mail, A_ID) OUTPUT INSERTED.S_ID VALUES (@Name, @JobTitle, @Phone, @Email, @AdminID)";
                    int staffId;

                    using (SqlCommand cmdStaff = new SqlCommand(insertStaffQuery, conn, transaction))
                    {
                        cmdStaff.Parameters.AddWithValue("@Name", name);
                        cmdStaff.Parameters.AddWithValue("@JobTitle", jobTitle);
                        cmdStaff.Parameters.AddWithValue("@Phone", phone);
                        cmdStaff.Parameters.AddWithValue("@Email", email);
                        cmdStaff.Parameters.AddWithValue("@AdminID", adminId);

                        staffId = (int)cmdStaff.ExecuteScalar();
                    }

                    // Insert into Login table
                    string insertLoginQuery = "INSERT INTO Login (Username, Password, Role, Status, S_ID) VALUES (@Username, @Password, @Role, @Status, @S_ID)";
                    using (SqlCommand cmdLogin = new SqlCommand(insertLoginQuery, conn, transaction))
                    {
                        cmdLogin.Parameters.AddWithValue("@Username", username);
                        cmdLogin.Parameters.AddWithValue("@Password", password);
                        cmdLogin.Parameters.AddWithValue("@Role", "Staff");
                        cmdLogin.Parameters.AddWithValue("@Status", status);
                        cmdLogin.Parameters.AddWithValue("@S_ID", staffId);

                        cmdLogin.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStaffData();
                }
                catch (SqlException sqlEx)
                {
                    transaction.Rollback();
                    MessageBox.Show("Database error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btd_Staff_Update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(mngStaff_textID.Text.Trim(), out int staffId))
            {
                MessageBox.Show("Invalid Staff ID. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(mngStaffAdmin_txtID.Text.Trim(), out int adminId))
            {
                MessageBox.Show("Invalid Admin ID. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = mngStaff_txtName.Text.Trim();
            string phone = mngStaff_txtMobile.Text.Trim();
            string email = mngStaff_mailtxt.Text.Trim();
            string jobTitle = mngStaff_jobTitletxt.SelectedItem?.ToString() ?? ""; // Handle null case
            string username = mngStaff_txtUsername.Text.Trim();
            string password = mngStaff_txtPassword.Text.Trim();
            int status = mngStaff_txtstatus.SelectedIndex; // 0 or 1

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Update Staff
                    string updateStaffQuery = @"
                        UPDATE Staff 
                        SET S_Name = @Name, Job_title = @JobTitle, S_Phone = @Phone, S_Mail = @Email, A_ID = @AdminID 
                        WHERE S_ID = @S_ID";

                    using (SqlCommand cmdStaff = new SqlCommand(updateStaffQuery, conn, transaction))
                    {
                        cmdStaff.Parameters.AddWithValue("@Name", name);
                        cmdStaff.Parameters.AddWithValue("@JobTitle", jobTitle);
                        cmdStaff.Parameters.AddWithValue("@Phone", phone);
                        cmdStaff.Parameters.AddWithValue("@Email", email);
                        cmdStaff.Parameters.AddWithValue("@AdminID", adminId);
                        cmdStaff.Parameters.AddWithValue("@S_ID", staffId);
                        cmdStaff.ExecuteNonQuery();
                    }

                    // Update Login
                    string updateLoginQuery = @"
                        UPDATE Login 
                        SET Username = @Username, Password = @Password, Status = @Status 
                        WHERE S_ID = @S_ID";

                    using (SqlCommand cmdLogin = new SqlCommand(updateLoginQuery, conn, transaction))
                    {
                        cmdLogin.Parameters.AddWithValue("@Username", username);
                        cmdLogin.Parameters.AddWithValue("@Password", password);
                        cmdLogin.Parameters.AddWithValue("@Status", status);
                        cmdLogin.Parameters.AddWithValue("@S_ID", staffId);
                        cmdLogin.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Staff updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStaffData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error updating staff: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
