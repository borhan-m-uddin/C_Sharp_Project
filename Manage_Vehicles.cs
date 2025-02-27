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
    public partial class Manage_Vehicles : Form
    {
        private AllLoadData allLoadData;
        private DataDeleter dataDeleter;
        public Manage_Vehicles()
        {
            InitializeComponent();
            allLoadData = new AllLoadData();
            dataDeleter = new DataDeleter();
            allLoadData.LoadData("Vehicles", Vehicles_data_view);
        }
        private void txtResSearch_TextChanged(object sender, EventArgs e)
        {
            allLoadData.SearchData("Vehicles", vehicles_search_txt.Text.Trim(), Vehicles_data_view);
        }
        private void mngStaffAdmin_txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Vehicles_data_view.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int guestId = Convert.ToInt32(Vehicles_data_view.Rows[e.RowIndex].Cells["Vehicle_ID"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this Vehicle?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    dataDeleter.DeleteRecord("Vehicles", "Vehicle_ID", guestId);
                    allLoadData.LoadData("Vehicles", Vehicles_data_view); // Reload data after deletion
                }
            }
        }

        private void dgvVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = Vehicles_data_view.Rows[e.RowIndex];

                    mngVehicle_textID.Text = row.Cells["Vehicle_ID"].Value?.ToString();
                    mngVehcicle_colortxt.Text = row.Cells["V_color"].Value?.ToString();

                    // Set the selected value for ComboBoxes
                    if (row.Cells["V_brand"].Value != null)
                    {
                        mngVehcicle_brandtxt.SelectedItem = row.Cells["V_brand"].Value.ToString();
                    }

                    if (row.Cells["V_type"].Value != null)
                    {
                        mngVehicle_typetxt.SelectedItem = row.Cells["V_type"].Value.ToString();
                    }

                    mngVehicle_allocatetxt.Text = row.Cells["V_allocated_space"].Value?.ToString();
                    mngStaffGuest_txtID.Text = row.Cells["G_ID"].Value?.ToString();
                    mngStaff_IDtxt.Text = row.Cells["S_ID"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting vehicle data: " + ex.Message, "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btd_vehicles_Update_Click(object sender, EventArgs e)
        {
            if (mngVehicle_textID.Text == "")
            {
                MessageBox.Show("Please select a vehicle to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int vehicleID = Convert.ToInt32(mngVehicle_textID.Text);
            string vehicleColor = mngVehcicle_colortxt.Text;
            string vehicleBrand = mngVehcicle_brandtxt.SelectedItem.ToString();
            string vehicleType = mngVehicle_typetxt.SelectedItem.ToString();
            int allocatedSpace = Convert.ToInt32(mngVehicle_allocatetxt.Text);
            int guestID = Convert.ToInt32(mngStaffGuest_txtID.Text);
            int staffID = Convert.ToInt32(mngStaff_IDtxt.Text);

            string query = "UPDATE Vehicles SET V_color = @color, V_brand = @brand, V_type = @type, " +
                           "V_allocated_space = @space, G_ID = @guestID, S_ID = @staffID WHERE Vehicle_ID = @vehicleID";

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@color", vehicleColor);
                        cmd.Parameters.AddWithValue("@brand", vehicleBrand);
                        cmd.Parameters.AddWithValue("@type", vehicleType);
                        cmd.Parameters.AddWithValue("@space", allocatedSpace);
                        cmd.Parameters.AddWithValue("@guestID", guestID);
                        cmd.Parameters.AddWithValue("@staffID", staffID);
                        cmd.Parameters.AddWithValue("@vehicleID", vehicleID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            allLoadData.LoadData("Vehicles", Vehicles_data_view); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update vehicle details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
