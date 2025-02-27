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
using System.Xml.Linq;
using static CrystalOasis.Poplogin;

namespace CrystalOasis
{
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
           

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

          
        private void nationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string phone = txtMobile.Text.Trim();
            string email = txtEmail.Text.Trim();
            string nationality = txtnationality.Text.Trim();
            string gender = txtgender.SelectedItem?.ToString(); // Assuming ComboBox for Gender
            DateTime dob = dateOfbirth.Value;

            string username = reg_user_txt.Text.Trim();
            string password = reg_pass_txt.Text.Trim();
            string confirmPassword = reg_Confirmpass_txt.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nationality) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Email Format
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Phone Number (Only digits, min 10 digits)
            if (!Regex.IsMatch(phone, @"^\d{10,15}$"))
            {
                MessageBox.Show("Invalid phone number! It should contain only digits and be at least 10 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Password Length
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Password Match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString)) // Use your connection string
                {
                    conn.Open();

                    // Check if Username is Unique
                    string checkUserQuery = "SELECT COUNT(*) FROM Login WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int userExists = (int)checkCmd.ExecuteScalar();
                        if (userExists > 0)
                        {
                            MessageBox.Show("Username already exists! Please choose another username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert Guest Details
                    string guestQuery = "INSERT INTO Guest (G_Name, G_phone, G_mail, Nationality, Gender, DOB) " +
                                        "OUTPUT INSERTED.G_ID " +
                                        "VALUES (@Name, @Phone, @Email, @Nationality, @Gender, @DOB)";
                    int guestId;
                    using (SqlCommand guestCmd = new SqlCommand(guestQuery, conn))
                    {
                        guestCmd.Parameters.AddWithValue("@Name", name);
                        guestCmd.Parameters.AddWithValue("@Phone", phone);
                        guestCmd.Parameters.AddWithValue("@Email", email);
                        guestCmd.Parameters.AddWithValue("@Nationality", nationality);
                        guestCmd.Parameters.AddWithValue("@Gender", gender);
                        guestCmd.Parameters.AddWithValue("@DOB", dob);

                        guestId = (int)guestCmd.ExecuteScalar();
                    }

                    // Insert Login Details
                    string loginQuery = "INSERT INTO Login (Username, Password, Role, Status, G_ID) " +
                                        "VALUES (@Username, @Password, @Role, @Status, @G_ID)";
                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, conn))
                    {
                        loginCmd.Parameters.AddWithValue("@Username", username);
                        loginCmd.Parameters.AddWithValue("@Password", password); // ⚠️ Consider Hashing Passwords!
                        loginCmd.Parameters.AddWithValue("@Role", "Guest");
                        loginCmd.Parameters.AddWithValue("@Status", 0);
                        loginCmd.Parameters.AddWithValue("@G_ID", guestId);

                        loginCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Guest registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(); // Clear input fields
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close(); // Close the form
        }

        private void ClearFields()
        {
            textName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtnationality.SelectedIndex=-1;
            txtgender.SelectedIndex = -1;
            dateOfbirth.Value = DateTime.Now;
            reg_user_txt.Clear();
            reg_pass_txt.Clear();
            reg_Confirmpass_txt.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
