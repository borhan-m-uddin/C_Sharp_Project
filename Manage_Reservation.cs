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
    public partial class Manage_Reservation : Form
    {
        private AllLoadData allLoadData;
        private DataDeleter dataDeleter;
        public Manage_Reservation()
        {
            InitializeComponent();
            allLoadData = new AllLoadData();
            dataDeleter = new DataDeleter();
            allLoadData.LoadData("Reservation", Res_data_view);
        }

        private void txtResSearch_TextChanged(object sender, EventArgs e)
        {
            allLoadData.SearchData("Reservation", res_search_txt.Text.Trim(), Res_data_view);
        }

        private void dataGridViewReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Res_data_view.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int guestId = Convert.ToInt32(Res_data_view.Rows[e.RowIndex].Cells["Reservation_ID"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this Reservation?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    dataDeleter.DeleteRecord("Reservation", "Reservation_ID", guestId);
                    allLoadData.LoadData("Reservation", Res_data_view); // Reload data after deletion
                }
            }
        }

        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Res_data_view.Rows[e.RowIndex];

                mngRes_textID.Text = row.Cells["Reservation_ID"].Value.ToString();
                mngRes_checkintxt.Value = Convert.ToDateTime(row.Cells["Check_in"].Value);
                mngRes_checkouttxt.Value = Convert.ToDateTime(row.Cells["Check_out"].Value);
                mngResGuest_txtID.Text = row.Cells["G_ID"].Value.ToString();
                mngResRoom_textID.Text = row.Cells["Room_ID"].Value.ToString();
            }
        }
        private void ResBack_Click(object sender, EventArgs e)
        {

        }
        private bool GuestExists(int guestID)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Guest WHERE G_ID = @G_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@G_ID", guestID);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private bool RoomExists(int roomID)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Room WHERE Room_ID = @Room_ID AND Status = 'Available'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Room_ID", roomID);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }


        private void bdt_Res_add_Click(object sender, EventArgs e)
        {
            // Validate Guest ID
            if (!int.TryParse(mngResGuest_txtID.Text, out int guestID) || !GuestExists(guestID))
            {
                MessageBox.Show("Guest ID does not exist! Please enter a valid Guest ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Room ID
            if (!int.TryParse(mngResRoom_textID.Text, out int roomID) || !RoomExists(roomID))
            {
                MessageBox.Show("Room ID does not exist or is unavailable! Please select a valid room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Check-In & Check-Out Dates
            if (mngRes_checkouttxt.Value <= mngRes_checkintxt.Value)
            {
                MessageBox.Show("Check-Out date must be later than Check-In date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepare Reservation Data
            Dictionary<string, object> reservationData = new Dictionary<string, object>
            {
                { "G_ID", guestID },
                { "Room_ID", roomID },
                { "Check_In", mngRes_checkintxt.Value },
                { "Check_Out", mngRes_checkouttxt.Value },
                // { "Payment_Status", cmbPaymentStatus.SelectedItem?.ToString() } // Uncomment if Payment Status exists
            };

            try
            {
                bool isInserted = allLoadData.InsertData("Reservation", reservationData);

                if (isInserted)
                {
                    MessageBox.Show("Reservation added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    allLoadData.LoadData("Reservation", Res_data_view); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to add reservation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database Error: " + sqlEx.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btd_Res_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mngRes_textID.Text) ||
                    string.IsNullOrWhiteSpace(mngResGuest_txtID.Text) ||
                    string.IsNullOrWhiteSpace(mngResRoom_textID.Text))
                {
                    MessageBox.Show("All fields are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int reservationID = int.TryParse(mngRes_textID.Text, out int resID) ? resID : 0;
                int guestID = int.TryParse(mngResGuest_txtID.Text, out int gID) ? gID : 0;
                int roomID = int.TryParse(mngResRoom_textID.Text, out int rID) ? rID : 0;
                DateTime checkIn = mngRes_checkintxt.Value;
                DateTime checkOut = mngRes_checkouttxt.Value;

                if (reservationID == 0 || guestID == 0 || roomID == 0)
                {
                    MessageBox.Show("Invalid Reservation ID, Guest ID, or Room Number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
                {
                    conn.Open();

                    // Check if Guest Exists
                    using (SqlCommand checkGuestCmd = new SqlCommand("SELECT COUNT(*) FROM Guest WHERE G_ID = @GuestID", conn))
                    {
                        checkGuestCmd.Parameters.AddWithValue("@GuestID", guestID);
                        int guestExists = Convert.ToInt32(checkGuestCmd.ExecuteScalar());

                        if (guestExists == 0)
                        {
                            MessageBox.Show("Guest ID does not exist! Please enter a valid Guest ID.", "Guest Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Update Reservation if Guest Exists
                    using (SqlCommand cmd = new SqlCommand(@"
                        UPDATE Reservation SET 
                        Check_in = @CheckIn, 
                        Check_out = @CheckOut, 
                        Room_ID = @RoomID, 
                        G_ID = @GuestID
                        WHERE Reservation_ID = @ReservationID", conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        cmd.Parameters.AddWithValue("@CheckIn", checkIn);
                        cmd.Parameters.AddWithValue("@CheckOut", checkOut);
                        cmd.Parameters.AddWithValue("@RoomID", roomID);
                        cmd.Parameters.AddWithValue("@GuestID", guestID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Reservation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                allLoadData.LoadData("Reservation", Res_data_view);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating reservation: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
