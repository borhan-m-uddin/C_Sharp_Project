using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static CrystalOasis.Poplogin;

namespace CrystalOasis
{
    public partial class Payment : Form
    {
        int guestId;
        int reservationId;
        decimal totalAmount;

        public Payment(decimal totalAmount,int guestId, int reservationId)
        {
            this.totalAmount = totalAmount;
            this.guestId = guestId;
            this.reservationId = reservationId;
            InitializeComponent();
        }
        public Payment()
            {
                InitializeComponent();
            }

        private void Payment_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"Guest ID: {guestId}, Reservation ID: {reservationId}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void exit_btn_Click(object sender, EventArgs e)
            {
                Poplogin log = new Poplogin();
                log.Show();
                this.Close();
            }

            private string GetPaymentMethod()
            {
                if (checkBox1.Checked)
                {
                    return "Master Card";
                }
                else if (checkBox2.Checked)
                {
                    return "Visa Card";
                }
                else if (checkBox3.Checked)
                {
                    return "PayPal";
                }
                else
                {
                    return string.Empty; // If no payment method is selected
                }
            }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string paymentMethod = GetPaymentMethod();
            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select a payment method.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SavePaymentToDatabase(totalAmount, guestId);

            Conformation conformation = new Conformation();
            conformation.Show();
            this.Close();
        }

        private string GetGuestNameByID(int guestID)
        {
            string guestName = string.Empty;
            string query = "SELECT G_Name FROM Guest WHERE G_ID = @GuestID";

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@GuestID", guestID);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            guestName = result.ToString();
                            MessageBox.Show($"Guest Name Found: {guestName}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"No guest found with ID {guestID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving guest name: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return guestName;
        }



        private void SavePaymentToDatabase(decimal amount, int guestID)
        {
            string paymentMethod = GetPaymentMethod();
            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            string guestName = GetGuestNameByID(guestId);
            if (string.IsNullOrEmpty(guestName))
            {
                MessageBox.Show($"Guest name not found for ID: {guestId}. Payment cannot proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Payment (Amount, Payment_time, Payment_method, Reservation_ID, G_ID, G_Name) " +
                           "VALUES (@Amount, @PaymentTime, @PaymentMethod, @ReservationID, @GID, @GName)";

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@PaymentTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                        cmd.Parameters.AddWithValue("@GID", guestID);
                        cmd.Parameters.AddWithValue("@GName", guestName);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment successfully recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to record payment. Check database constraints.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }








        private bool ValidateInputs()
        {
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("Please select a payment method (MasterCard, Visa, or PayPal).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cardname.Text) || !IsAlpha(cardname.Text))
            {
                MessageBox.Show("Cardholder name must contain only letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!long.TryParse(cardnumber.Text, out _) || string.IsNullOrWhiteSpace(cardnumber.Text))
            {
                MessageBox.Show("Card number must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(Month.Text, out int month) || month < 1 || month > 12)
            {
                MessageBox.Show("Month must be an integer between 1 and 12.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(year1.Text, out int year) || year < DateTime.Now.Year || year > DateTime.Now.Year + 10)
            {
                MessageBox.Show($"Year must be between {DateTime.Now.Year} and {DateTime.Now.Year + 10}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidNumber(cvc1.Text) || !IsValidNumber(cvc2.Text) || !IsValidNumber(cvc3.Text))
            {
                MessageBox.Show("CVC must be integers between 000 and 999.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool IsAlpha(string input)
        {
            return input.All(char.IsLetter);
        }

        

            
        private bool IsValidNumber(string input)
        {
            if (int.TryParse(input, out int number))
            {
                return number >= 1 && number <= 9;
            }
            return false; 
        }

          
                private void textBox1_TextChanged(object sender, EventArgs e) { }
                private void textBox4_TextChanged(object sender, EventArgs e) { }
                private void textBox6_TextChanged(object sender, EventArgs e) { }
                private void textBox5_TextChanged(object sender, EventArgs e) { }
                private void textBox7_TextChanged(object sender, EventArgs e) { }
                private void textBox2_TextChanged(object sender, EventArgs e) { }
                private void textBox3_TextChanged(object sender, EventArgs e) { }
        }
    }
