using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static CrystalOasis.Poplogin;


namespace CrystalOasis
{
    public partial class Manage_Guest : Form
    {
        private AllLoadData allLoadData;
        private DataDeleter dataDeleter;

        public Manage_Guest()
        {
            InitializeComponent();
            allLoadData=new AllLoadData();
            dataDeleter = new DataDeleter();
            LoadGuestData();
        }


        private void LoadGuestData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    string query = @"SELECT G.G_ID, G.G_Name, G.G_phone, G.G_mail, G.Nationality, G.Gender, G.DOB, 
                                    L.Status 
                                    FROM Guest G 
                                    JOIN Login L ON G.G_ID = L.G_ID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    Guest_data_view.DataSource = table;

                    // Add Delete Button Column (if not already present)
                    if (!Guest_data_view.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                        {
                            Name = "Delete",
                            HeaderText = "Delete",
                            Text = "Delete",
                            UseColumnTextForButtonValue = true,
                            DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red, BackColor = Color.White }
                        };
                        Guest_data_view.Columns.Add(deleteButton);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Guest data: " + ex.Message);
            }
        }

        private void DeleteGuest(int guestID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Step 1: Delete from Login Table (if Guest is linked there)
                        string deleteLoginQuery = "DELETE FROM Login WHERE G_ID = @guestID";
                        using (SqlCommand cmd = new SqlCommand(deleteLoginQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@guestID", guestID);
                            cmd.ExecuteNonQuery();
                        }

                        // Step 2: Delete from Reservation Table (if there are any related reservations)
                        string deleteReservationQuery = "DELETE FROM Reservation WHERE G_ID = @guestID";
                        using (SqlCommand cmd = new SqlCommand(deleteReservationQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@guestID", guestID);
                            cmd.ExecuteNonQuery();
                        }

                        // Step 3: Delete from Guest Table
                        string deleteGuestQuery = "DELETE FROM Guest WHERE G_ID = @guestID";
                        using (SqlCommand cmd = new SqlCommand(deleteGuestQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@guestID", guestID);
                            cmd.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();
                        MessageBox.Show("Guest deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload Guest Data
                        LoadGuestData();
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



        private void dataGridViewGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is in a valid row and is the "Delete" button column
            if (e.RowIndex >= 0 && Guest_data_view.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && Guest_data_view.Columns[e.ColumnIndex].Name == "Delete")
            {
                int guestID = Convert.ToInt32(Guest_data_view.Rows[e.RowIndex].Cells["G_ID"].Value);

                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this guest?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteGuest(guestID);
                }
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //AdminDashboard adminDashboard = new AdminDashboard();
            //adminDashboard.Show();
            //this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            allLoadData.SearchData("Guest", guest_search_txt.Text.Trim(), Guest_data_view);
        }

        private void Guest_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is clicked
            {
                DataGridViewRow row = Guest_data_view.Rows[e.RowIndex];

                // Fill text fields
                mngGuest_txtID.Text = row.Cells["G_ID"].Value.ToString();
                mngGuest_textName.Text = row.Cells["G_Name"].Value.ToString();
                mngGuest_txtMobile.Text = row.Cells["G_phone"].Value.ToString();
                mngGuest_txtEmail.Text = row.Cells["G_mail"].Value.ToString();
                mngGuest_txtnationality.Text = row.Cells["Nationality"].Value.ToString();
                mngGuest_txtgender.Text = row.Cells["Gender"].Value.ToString();
                mngGuest_dateOfbirth.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                mngGuest_Statustxt.SelectedIndex = Convert.ToInt32(row.Cells["Status"].Value);
            }
        }




        private void bdt_Guest_add_Click(object sender, EventArgs e)
        {
            
        }

        private void btd_Guest_Update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(mngGuest_txtID.Text, out int guestID))
            {
                MessageBox.Show("Invalid Guest ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        string updateGuestQuery = @"UPDATE Guest 
                                                    SET G_Name = @Name, G_phone = @Phone, G_mail = @Email, 
                                                        Nationality = @Nationality, Gender = @Gender, DOB = @DOB
                                                    WHERE G_ID = @GuestID";

                        using (SqlCommand cmd = new SqlCommand(updateGuestQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@GuestID", guestID);
                            cmd.Parameters.AddWithValue("@Name", mngGuest_textName.Text.Trim());
                            cmd.Parameters.AddWithValue("@Phone", mngGuest_txtMobile.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", mngGuest_txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@Nationality", mngGuest_txtnationality.Text.Trim());
                            cmd.Parameters.AddWithValue("@Gender", mngGuest_txtgender.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@DOB", mngGuest_dateOfbirth.Value);
                            cmd.ExecuteNonQuery();
                        }

                        string updateLoginQuery = @"UPDATE Login SET Status = @Status WHERE G_ID = @GuestID";
                        using (SqlCommand cmd = new SqlCommand(updateLoginQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@GuestID", guestID);
                            cmd.Parameters.AddWithValue("@Status", mngGuest_Statustxt.SelectedIndex.ToString());
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Guest updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGuestData();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
