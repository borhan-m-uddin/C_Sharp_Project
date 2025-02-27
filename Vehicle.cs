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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrystalOasis
{
    public partial class Vehicle : Form
    {
        int guestId;
        int reservationId;
        decimal totalAmount;
        public Vehicle(decimal totalAmount, int guestId, int reservationId)
        {

            InitializeComponent();
            this.totalAmount = totalAmount;
            this.guestId = guestId;
            this.reservationId = reservationId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(V_numbertxt.Text) ||
                V_brandtxt.SelectedIndex == -1 ||
                V_typetxt.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(V_colortxt.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get values from form inputs
            string vehicleNumber = V_numbertxt.Text.Trim();
            string vehicleBrand = V_brandtxt.SelectedItem.ToString();
            string vehicleType = V_typetxt.SelectedItem.ToString();
            string vehicleColor = V_colortxt.Text.Trim();
            int allocatedSpace=0;


            int guestID = this.guestId;   // Guest ID (Passed to the form)
            int serviceID = 0;            // Update with actual Service ID if available

            // Database Insertion Query
            string query = "INSERT INTO Vehicles (Vehicle_ID, V_color, V_brand, V_type, V_allocated_space, G_ID, S_ID) " +
                           "VALUES (@Vehicle_ID, @V_color, @V_brand, @V_type, @V_allocated_space, @G_ID, @S_ID)";

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Vehicle_ID", vehicleNumber);
                        cmd.Parameters.AddWithValue("@V_color", vehicleColor);
                        cmd.Parameters.AddWithValue("@V_brand", vehicleBrand);
                        cmd.Parameters.AddWithValue("@V_type", vehicleType);
                        cmd.Parameters.AddWithValue("@V_allocated_space", allocatedSpace);
                        cmd.Parameters.AddWithValue("@G_ID", guestID);
                        cmd.Parameters.AddWithValue("@S_ID", serviceID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open the Payment form
                            Payment payment = new Payment(totalAmount, guestID, reservationId);
                            payment.totalAmountlbl.Text = "Total Amount to pay : " + totalAmount.ToString("F2");
                            payment.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save vehicle data.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting vehicle data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
