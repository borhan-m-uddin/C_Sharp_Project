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
    public partial class Manage_Admin : Form
    {
        private AllLoadData allLoadData;
        private DataDeleter dataDeleter;
        public Manage_Admin()
        {
            InitializeComponent();
            allLoadData = new AllLoadData();
            dataDeleter = new DataDeleter();
            LoadAdminData();
        }

        private void LoadAdminData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    string query = @"
                                    SELECT 
                                        a.A_ID, 
                                        a.admin_name, 
                                        a.admin_mail, 
                                        a.admin_phone, 
                                        l.Username, 
                                        l.Password, 
                                        l.Status 
                                    FROM Admin a
                                    INNER JOIN Login l ON a.A_ID = l.A_ID"; // Joining Admin with Login Table

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    Admin_data_view.DataSource = table;

                    // Formatting Columns
                    //Admin_data_view.Columns["Password"].Visible = false; // Hide Password Column for Security

                    // Add Delete Button Column (if not already present)
                    if (!Admin_data_view.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                        {
                            Name = "Delete",
                            HeaderText = "Delete",
                            Text = "Delete",
                            UseColumnTextForButtonValue = true,
                            DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red, BackColor = Color.White }
                        };
                        Admin_data_view.Columns.Add(deleteButton);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin data: " + ex.Message);
            }
        }

        private void DeleteAdmin(int adminID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Step 1: Delete from Login Table (to avoid foreign key issues)
                        string deleteLoginQuery = "DELETE FROM Login WHERE A_ID = @adminID";
                        using (SqlCommand cmd = new SqlCommand(deleteLoginQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@adminID", adminID);
                            cmd.ExecuteNonQuery();
                        }

                        // Step 2: Delete from Admin Table
                        string deleteAdminQuery = "DELETE FROM Admin WHERE A_ID = @adminID";
                        using (SqlCommand cmd = new SqlCommand(deleteAdminQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@adminID", adminID);
                            cmd.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();
                        MessageBox.Show("Admin deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload Data
                        LoadAdminData();
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


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            allLoadData.SearchData("Admin", admin_search_txt.Text.Trim(), Admin_data_view);
        }

        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Admin_data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is in a valid row and is the "Delete" button column
            if (e.RowIndex >= 0 && Admin_data_view.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && Admin_data_view.Columns[e.ColumnIndex].Name == "Delete")
            {
                int adminID = Convert.ToInt32(Admin_data_view.Rows[e.RowIndex].Cells["A_ID"].Value);

                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this admin?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteAdmin(adminID);
                }
            }
        }


        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow row = Admin_data_view.Rows[e.RowIndex];

                mngAdmin_textID.Text = row.Cells["A_ID"].Value.ToString();
                mngAdmin_txtname.Text = row.Cells["admin_name"].Value.ToString();
                mngAdmin_txtmail.Text = row.Cells["admin_mail"].Value.ToString();
                mngAdmin_txtphone.Text = row.Cells["admin_phone"].Value.ToString();
                mngAdmin_txtUsername.Text = row.Cells["Username"].Value.ToString();
                mngAdmin_txtPassword.Text = row.Cells["Password"].Value.ToString();
                mngAdmin_Statustxt.SelectedIndex = Convert.ToInt32(row.Cells["Status"].Value);
            }
        }

        private bool UsernameExists(string username)
        {
            using (SqlConnection con = new SqlConnection(DatabaseConfig.connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Login WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Default return in case of SQL error
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }

        private void bdt_Admin_add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (UsernameExists(mngAdmin_txtUsername.Text))
            {
                MessageBox.Show("Username already exists! Please enter a unique username.");
                return;
            }

            using (SqlConnection con = new SqlConnection(DatabaseConfig.connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Insert into Admin Table
                    string insertAdminQuery = @"
                        INSERT INTO Admin (admin_name, admin_mail, admin_phone) 
                        OUTPUT INSERTED.A_ID 
                        VALUES (@AdminName, @AdminMail, @AdminPhone)";

                    SqlCommand cmdAdmin = new SqlCommand(insertAdminQuery, con, transaction);
                    cmdAdmin.Parameters.AddWithValue("@AdminName", mngAdmin_txtname.Text);
                    cmdAdmin.Parameters.AddWithValue("@AdminMail", mngAdmin_txtmail.Text);
                    cmdAdmin.Parameters.AddWithValue("@AdminPhone", mngAdmin_txtphone.Text);

                    int adminId = (int)cmdAdmin.ExecuteScalar();

                    // Insert into Login Table
                    string insertLoginQuery = @"
                        INSERT INTO Login (Username, Password, Role, Status, A_ID) 
                        VALUES (@Username, @Password, @Role, @Status, @A_ID)";

                    SqlCommand cmdLogin = new SqlCommand(insertLoginQuery, con, transaction);
                    cmdLogin.Parameters.AddWithValue("@Username", mngAdmin_txtUsername.Text);
                    cmdLogin.Parameters.AddWithValue("@Password", mngAdmin_txtPassword.Text);
                    cmdLogin.Parameters.AddWithValue("@Role", "Admin");
                    cmdLogin.Parameters.AddWithValue("@Status", mngAdmin_Statustxt.SelectedIndex == 0 ? "0" : "1");
                    cmdLogin.Parameters.AddWithValue("@A_ID", adminId);

                    cmdLogin.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Admin added successfully!");
                    LoadAdminData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void upper_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manage_Admin_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(mngAdmin_name.Text) ||
                string.IsNullOrWhiteSpace(mngAdmin_txtmail.Text) ||
                string.IsNullOrWhiteSpace(mngAdmin_txtphone.Text) ||
                string.IsNullOrWhiteSpace(mngAdmin_txtUsername.Text) ||
                string.IsNullOrWhiteSpace(mngAdmin_txtPassword.Text))
            {
                MessageBox.Show("All fields are required.");
                return false;
            }

            // Validate email format
            if (!Regex.IsMatch(mngAdmin_txtmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }

            // Validate phone number (only digits, 10-15 characters)
            if (!Regex.IsMatch(mngAdmin_txtphone.Text, @"^\d{10,15}$"))
            {
                MessageBox.Show("Invalid phone number. Must be 10-15 digits.");
                return false;
            }

            // Validate password length
            if (mngAdmin_txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return false;
            }

            return true;
        }

        private void btd_Admin_Update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(mngAdmin_textID.Text, out int adminID))
            {
                MessageBox.Show("Invalid Admin ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
            {
                return;
            }

            string name = mngAdmin_txtname.Text.Trim();
            string email = mngAdmin_txtmail.Text.Trim();
            string phone = mngAdmin_txtphone.Text.Trim();
            string username = mngAdmin_txtUsername.Text.Trim();
            string password = mngAdmin_txtPassword.Text.Trim();
            int status = mngAdmin_Statustxt.SelectedIndex; // 0 = Inactive, 1 = Active

            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Update Admin Table
                        string updateAdminQuery = @"UPDATE Admin 
                                            SET admin_name = @name, 
                                                admin_mail = @mail, 
                                                admin_phone = @phone 
                                            WHERE A_ID = @adminID";

                        using (SqlCommand cmd = new SqlCommand(updateAdminQuery, connection, transaction))
                        {
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                            cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
                            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
                            cmd.Parameters.Add("@adminID", SqlDbType.Int).Value = adminID;
                            cmd.ExecuteNonQuery();
                        }

                        // Update Login Table (Status as 0 or 1)
                        string updateLoginQuery = @"UPDATE Login 
                                            SET Username = @username, 
                                                Password = @password, 
                                                Status = @status 
                                            WHERE A_ID = @adminID";

                        using (SqlCommand cmd = new SqlCommand(updateLoginQuery, connection, transaction))
                        {
                            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                            cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;
                            cmd.Parameters.Add("@adminID", SqlDbType.Int).Value = adminID;
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit(); // Save Changes
                        MessageBox.Show("Admin updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadAdminData(); // Refresh DataGridView
                    }
                    catch (SqlException sqlEx)
                    {
                        transaction.Rollback(); // Undo changes if error occurs
                        MessageBox.Show("Database error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }


}
