using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static CrystalOasis.Poplogin;
using System.Data.SqlClient;

namespace CrystalOasis
{
    public partial class SendCode : Form
    {
        private string email;
        private string tempCode;  
        public static string to;
        public SendCode()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poplogin poplogin = new Poplogin();
            this.Hide();
            poplogin.Show();
        }

        private string GetUserRoleAndValidateEmail(string email)
        {
            string query = @"SELECT 'Admin' AS Role FROM Admin WHERE admin_mail = @Email
                     UNION ALL
                     SELECT 'Staff' AS Role FROM Staff WHERE S_Mail = @Email
                     UNION ALL
                     SELECT 'Guest' AS Role FROM Guest WHERE G_mail = @Email";

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString(); // Returns "Admin", "Staff", or "Guest" if found, otherwise null
                }
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            email = email_txt.Text.Trim();

            // Check if email exists in any of the tables
            string userRole = GetUserRoleAndValidateEmail(email);
            if (userRole == null)
            {
                MessageBox.Show("Email not found. Please enter a registered email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate verification code
            string verificationCode = GenerateVerificationCode();
            tempCode = verificationCode;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com"); // Replace with your SMTP server
                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("merintaj50865@gmail.com", "ygaj baro fbil sdfz "); // Replace with your credentials
                smtpServer.EnableSsl = true;

                mail.From = new MailAddress("merintaj50865@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Password Reset Code";
                mail.Body = $"Hello sir ,Your password reset code is: {verificationCode}";

                smtpServer.Send(mail);

                MessageBox.Show("Verification code sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateVerificationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); // 6-digit code
        }

    private void button2_Click(object sender, EventArgs e)
        {
            if (Forgot_code_txt.Text == tempCode)
            {
                // Open the ResetPassword form and pass the email
                Resetpassword resetForm = new Resetpassword(email);
                resetForm.Show();
                this.Hide(); // Close the current form
            }
            else
            {
                MessageBox.Show("Invalid verification code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendCode_Load(object sender, EventArgs e)
        {
        }
    }
}
