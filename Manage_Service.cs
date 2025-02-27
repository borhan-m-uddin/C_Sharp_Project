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
    public partial class Manage_Service : Form
    {
        private AllLoadData allLoadData;
        private DataDeleter dataDeleter;
        public Manage_Service()
        {
            InitializeComponent();
            allLoadData = new AllLoadData();
            dataDeleter = new DataDeleter();
            allLoadData.LoadData("Service", Service_data_view);
        }

        private void dataGridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Service_data_view.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int guestId = Convert.ToInt32(Service_data_view.Rows[e.RowIndex].Cells["Booking_ID"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this service?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    dataDeleter.DeleteRecord("Service", "Booking_ID", guestId);
                    allLoadData.LoadData("Service", Service_data_view);// Reload data after deletion
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            allLoadData.SearchData("Service", admin_service_txt.Text.Trim(), Service_data_view);
        }

        private bool ServiceExists(string serviceName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Service WHERE Service_Name = @Service_Name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Service_Name", serviceName);
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking service existence: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void bdt_service_add_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(mngBooking_txtID.Text) || string.IsNullOrWhiteSpace(mngService_txtname.Text))
                {
                    MessageBox.Show("Booking ID and Service Name are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(mngBooking_txtID.Text, out int bookingID))
                {
                    MessageBox.Show("Invalid Booking ID! Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ServiceExists(mngService_txtname.Text))
                {
                    MessageBox.Show("Service name already exists! Please enter a unique Service Name.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal servicePrice = 0;
                if (!decimal.TryParse(mngService_txtprice.Text, out servicePrice))
                {
                    MessageBox.Show("Invalid Service Price! Please enter a valid decimal value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Dictionary<string, object> serviceData = new Dictionary<string, object>
                {
                    { "Booking_ID", bookingID },
                    { "Service_Name", mngService_txtname.Text },
                    { "Description", string.IsNullOrWhiteSpace(mngService_txtdescription.Text) ? (object)DBNull.Value : mngService_txtdescription.Text },
                    { "Service_price", servicePrice }
                };

                bool isInserted = allLoadData.InsertData("Service", serviceData);
                if (isInserted)
                {
                    MessageBox.Show("Service added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    allLoadData.LoadData("Service", Service_data_view); // Reload data in DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to add service. Please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding service: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Service_data_view.Rows[e.RowIndex];

                mngBooking_txtID.Text = row.Cells["Booking_ID"].Value.ToString();
                mngService_txtname.Text = row.Cells["Service_name"].Value.ToString();
                mngService_txtprice.Text = row.Cells["Service_price"].Value.ToString();
                mngService_txtdescription.Text = row.Cells["Description"].Value.ToString();
                mngServiceRes_txtID.Text = row.Cells["Reservation_ID"].Value.ToString();
            }
        }

        private void btd_service_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mngBooking_txtID.Text) || string.IsNullOrWhiteSpace(mngService_txtname.Text))
                {
                    MessageBox.Show("Booking ID and Service Name are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(mngBooking_txtID.Text, out int bookingID))
                {
                    MessageBox.Show("Invalid Booking ID! Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal servicePrice = 0;
                if (!decimal.TryParse(mngService_txtprice.Text, out servicePrice))
                {
                    MessageBox.Show("Invalid Service Price! Please enter a valid decimal value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Dictionary<string, object> updateData = new Dictionary<string, object>
                {
                    { "Booking_ID", bookingID },
                    { "Service_Name", mngService_txtname.Text },
                    { "Description", string.IsNullOrWhiteSpace(mngService_txtdescription.Text) ? (object)DBNull.Value : mngService_txtdescription.Text },
                    { "Service_price", servicePrice }
                };

                Dictionary<string, object> condition = new Dictionary<string, object> { { "@Booking_ID", mngBooking_txtID.Text } };

                bool isUpdated = allLoadData.UpdateData("Service", updateData, condition);
                if (isUpdated)
                {
                    MessageBox.Show("Service updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    allLoadData.LoadData("Service", Service_data_view); // Reload data in DataGridView
                }
                else
                {
                    MessageBox.Show("No records updated. Please check the service name.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating service: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
