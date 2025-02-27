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
    public partial class Manage_Room : Form
    {
        private AllLoadData allLoadData;
        private DataDeleter dataDeleter;
        public Manage_Room()
        {
            InitializeComponent();
            allLoadData = new AllLoadData();
            dataDeleter = new DataDeleter();
            allLoadData.LoadData("Room", Room_data_view);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            allLoadData.SearchData("Room", room_search_txt.Text.Trim(), Room_data_view);
        }

        private void Room_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure a valid row is clicked and avoid clicking on the header row
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow row = Room_data_view.Rows[e.RowIndex];

                    // Safely retrieve values from the selected row
                    mngRoom_textID.Text = row.Cells["Room_ID"].Value != null ? row.Cells["Room_ID"].Value.ToString() : "";
                    mngRoom_txtrent.Text = row.Cells["Room_rent"].Value != null ? row.Cells["Room_rent"].Value.ToString() : "";
                    mngRoom_typetxt.Text = row.Cells["Room_type"].Value != null ? row.Cells["Room_type"].Value.ToString() : "";
                    mngRoom_statustxt.Text = row.Cells["Status"].Value != null ? row.Cells["Status"].Value.ToString() : "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting the room details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Room_data_view.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int guestId = Convert.ToInt32(Room_data_view.Rows[e.RowIndex].Cells["Room_ID"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this room?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    dataDeleter.DeleteRecord("Room", "Room_ID", guestId);
                    allLoadData.LoadData("Room", Room_data_view); // Reload data after deletion
                }
            }
        }

        private bool RoomExists(string roomId)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
            {
                string query = "SELECT COUNT(*) FROM Room WHERE Room_ID = @Room_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Room_ID", roomId);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        private void bdt_Room_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mngRoom_textID.Text) || string.IsNullOrWhiteSpace(mngRoom_txtrent.Text) || mngRoom_typetxt.SelectedIndex == -1 || mngRoom_statustxt.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all fields before adding a room.");
                    return;
                }

                if (RoomExists(mngRoom_textID.Text))
                {
                    MessageBox.Show("Room already exists! Please enter a different Room Number.");
                    return;
                }

                Dictionary<string, object> roomData = new Dictionary<string, object>
                {
                    { "Room_ID", mngRoom_textID.Text },
                    { "Room_rent", decimal.TryParse(mngRoom_txtrent.Text, out decimal rent) ? rent : (object)DBNull.Value },
                    { "Room_type", mngRoom_typetxt.SelectedItem?.ToString() },
                    { "Status", mngRoom_statustxt.SelectedItem?.ToString() }
                };

                bool isInserted = allLoadData.InsertData("Room", roomData);
                if (isInserted)
                {
                    MessageBox.Show("Room added successfully!");
                    allLoadData.LoadData("Room", Room_data_view); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to add the room.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void RoomBack_Click(object sender, EventArgs e)
        {

        }

        private void btd_Room_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mngRoom_textID.Text))
                {
                    MessageBox.Show("Please enter a Room Number to update.");
                    return;
                }

                if (!RoomExists(mngRoom_textID.Text))
                {
                    MessageBox.Show("Room does not exist! Please check the Room Number.");
                    return;
                }

                Dictionary<string, object> updateData = new Dictionary<string, object>
                {
                    { "Room_rent", decimal.TryParse(mngRoom_txtrent.Text, out decimal rent) ? rent : (object)DBNull.Value },
                    { "Room_type", mngRoom_typetxt.SelectedItem?.ToString() },
                    { "Status", mngRoom_statustxt.SelectedItem?.ToString() }
                };

                Dictionary<string, object> condition = new Dictionary<string, object>
                {
                    { "Room_ID", mngRoom_textID.Text }
                };

                bool isUpdated = allLoadData.UpdateData("Room", updateData, condition);
                if (isUpdated)
                {
                    MessageBox.Show("Room updated successfully!");
                    allLoadData.LoadData("Room", Room_data_view); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update the room.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
