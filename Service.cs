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
    public partial class Service : Form
    {
        int guestId;
        int reservationId;
        public bool IsWithVehicle { get; set; }
        decimal totalAmount;

        public Service(bool isWithVehicle, decimal totalAmount,int guestId, int reservationId)
        {
            InitializeComponent();
            IsWithVehicle = isWithVehicle;
            this.totalAmount = totalAmount;
            this.guestId = guestId;
            this.reservationId = reservationId;
        }
        

        private decimal CalculateServiceCharges(List<int> selectedServiceIDs)
        {
            decimal totalServiceCost = 0;

            if (selectedServiceIDs.Count == 0)
            {
                return 0; // No services selected
            }

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(Service_Price) FROM Service WHERE Booking_ID IN (" + string.Join(",", selectedServiceIDs) + ")";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        totalServiceCost = (decimal)result;
                    }
                }
            }

            return totalServiceCost;
        }

        private decimal CalculateTotalAmount(List<int> selectedServiceIDs)
        {
            decimal roomRent = totalAmount;
            decimal serviceCharges = CalculateServiceCharges(selectedServiceIDs);
            return roomRent + serviceCharges;
        }

        private void UpdateServiceDatabase(List<int> selectedServiceIDs)
        {
            // Validate that at least one service is selected
            //if (selectedServiceIDs.Count == 0)
            //{
            //    MessageBox.Show("Please select at least one service.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // Insert selected services into the database
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
                {
                    conn.Open();

                    foreach (int serviceID in selectedServiceIDs)
                    {
                        // Get the service details (name, price, description) from the database
                        string serviceQuery = "SELECT Service_Name, Service_Price, Description FROM Service WHERE Booking_ID = @Booking_ID";

                        // Using separate SqlCommand for ExecuteReader and ExecuteNonQuery to avoid conflicts
                        using (SqlCommand serviceCmd = new SqlCommand(serviceQuery, conn))
                        {
                            serviceCmd.Parameters.AddWithValue("@Booking_ID", serviceID);

                            using (SqlDataReader reader = serviceCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string serviceName = reader["Service_Name"].ToString();
                                    decimal servicePrice = Convert.ToDecimal(reader["Service_Price"]);
                                    string description = reader["Description"].ToString();

                                    // Close the reader before executing the next command
                                    reader.Close();

                                    // Now, insert the service into the service table
                                    string insertQuery = "INSERT INTO Service (Service_Name, Service_Price, Description, Reservation_ID) " +
                                                         "VALUES (@Service_Name, @Service_Price, @Description, @Reservation_ID)";

                                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                                    {
                                        insertCmd.Parameters.AddWithValue("@Service_Name", serviceName);
                                        insertCmd.Parameters.AddWithValue("@Service_Price", servicePrice);
                                        insertCmd.Parameters.AddWithValue("@Description", description);
                                        insertCmd.Parameters.AddWithValue("@Reservation_ID", reservationId); // Also associating with Reservation ID

                                        insertCmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Booking ID not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Service_Load(object sender, EventArgs e)
        {

        }
        private List<int> GetSelectedServiceIDs()
        {
            List<int> selectedServiceIDs = new List<int>();

            // Assuming you have checkboxes or any other control that represents services
            // Example for CheckBoxes:
            if (checkBox1.Checked) selectedServiceIDs.Add(1); // Add the ID of the selected service
            if (checkBox2.Checked) selectedServiceIDs.Add(2);
            if (checkBox3.Checked) selectedServiceIDs.Add(3); // Add the ID of another selected service
                                                              // Add more services as per your form controls...

            return selectedServiceIDs;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> selectedServiceIDs = GetSelectedServiceIDs();

            // First, update the service database
            UpdateServiceDatabase(selectedServiceIDs);

            // Then, calculate the total amount including selected services
            decimal totalAmount = CalculateTotalAmount(selectedServiceIDs);

            if (IsWithVehicle)
            {
                // If "With Vehicle" is selected, show the Vehicle form
                Vehicle vehicle = new Vehicle(totalAmount, guestId, reservationId);
                vehicle.Show();
                this.Close(); // Close the Service form
            }
            else
            {
                // If "Without Vehicle" is selected, show the Payment form
                Payment payment = new Payment(totalAmount, guestId, reservationId);
                payment.totalAmountlbl.Text = "Total Amount to pay : " + totalAmount.ToString("F2");

                payment.Show();
                this.Close(); // Close the Service form
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}