using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CrystalOasis.Poplogin;

namespace CrystalOasis
{
    public class AllLoadData
    {
        public void LoadData(string tableName, DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    string query = $"SELECT * FROM {tableName}";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView.DataSource = table;

                    // Add Delete Button Column (if not already present)
                    if (!dataGridView.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                        {
                            Name = "Delete",
                            HeaderText = "Delete",
                            Text = "Delete",
                            UseColumnTextForButtonValue = true
                        };

                        dataGridView.Columns.Add(deleteButton);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        public bool UpdateData(string tableName, Dictionary<string, object> updateData, Dictionary<string, object> condition)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    connection.Open();

                    // Construct the SET part of the query dynamically
                    string setClause = string.Join(", ", updateData.Keys.Select(key => $"{key} = @{key}"));

                    // Construct the WHERE part of the query dynamically
                    string whereClause = string.Join(" AND ", condition.Keys.Select(key => $"{key} = @cond_{key}"));

                    string query = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters for SET clause
                        foreach (var pair in updateData)
                        {
                            command.Parameters.AddWithValue($"@{pair.Key}", pair.Value ?? DBNull.Value);
                        }

                        // Add parameters for WHERE clause (conditions)
                        foreach (var pair in condition)
                        {
                            command.Parameters.AddWithValue($"@cond_{pair.Key}", pair.Value);
                        }

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating data: " + ex.Message);
                return false;
            }
        }



        public void SearchData(string tableName, string searchText, DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    string query = "";

                    // Define the query based on the table name
                    if (tableName == "Admin")
                    {
                        query = @"SELECT 
                            Admin.A_ID, Admin.admin_name, Admin.admin_mail, Admin.admin_phone, 
                            Login.Username, Login.Password, Login.Status 
                          FROM Admin 
                          INNER JOIN Login ON Admin.A_ID = Login.A_ID
                          WHERE Admin.admin_name LIKE @search 
                             OR Admin.admin_mail LIKE @search 
                             OR Admin.admin_phone LIKE @search 
                             OR Login.Username LIKE @search";
                    }
                    else if (tableName == "Guest")
                    {
                        query = @"SELECT G.G_ID, G.G_Name, G.G_phone, G.G_mail, G.Nationality, G.Gender, G.DOB, 
                                    L.Status 
                                    FROM Guest G 
                                    JOIN Login L ON G.G_ID = L.G_ID
                                    WHERE G.G_Name LIKE @search 
                                         OR G.G_mail LIKE @search 
                                         OR G.G_phone LIKE @search 
                                         OR G.Gender LIKE @search
                                         OR G.Nationality LIKE @search 
                                         OR G.G_ID LIKE @search ";
                    }
                    else if (tableName == "Staff")
                    {
                        query = @"SELECT * FROM Staff 
                          WHERE S_Name LIKE @search 
                             OR Job_title LIKE @search 
                             OR S_Phone LIKE @search 
                             OR S_Mail LIKE @search";
                    }
                    else if (tableName == "Service")
                    {
                        query = @"SELECT * FROM Service 
                          WHERE Service_name LIKE @search 
                             OR Booking_ID LIKE @search
                             OR Description LIKE @search 
                             OR Service_price LIKE @search";
                    }
                    else if (tableName == "Reservation")
                    {
                        query = @"SELECT * FROM Reservation 
                          WHERE Reservation_ID LIKE @search 
                             OR G_ID LIKE @search 
                             OR Room_ID LIKE @search 
                             OR Check_In LIKE @search
                             OR Check_Out LIKE @search";
                    }
                    else if (tableName == "Payment")
                    {
                        query = @"SELECT * FROM Payment 
                          WHERE Payment_ID LIKE @search 
                             OR Amount LIKE @search 
                             OR Payment_Method LIKE @search 
                             OR G_ID LIKE @search";
                    }
                    else if (tableName == "Room")
                    {
                        query = @"SELECT * FROM Room 
                          WHERE Room_ID LIKE @search 
                             OR Room_Type LIKE @search 
                             OR Room_rent LIKE @search 
                             OR Status LIKE @search";
                    }
                    else if (tableName == "Vehicles")
                    {
                        query = @"SELECT * FROM Vehicles 
                          WHERE Vehicle_ID LIKE @search 
                             OR V_color LIKE @search 
                             OR V_brand LIKE @search
                             OR G_ID LIKE @search
                             OR V_type LIKE @search";
                    }
                    else
                    {
                        MessageBox.Show("Invalid table name!");
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message);
            }
        }



        public bool InsertData(string tableName, Dictionary<string, object> data)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    connection.Open();

                    // Generate column names and values dynamically
                    string columns = string.Join(", ", data.Keys);
                    string parameters = string.Join(", ", data.Keys.Select(k => "@" + k));

                    string query = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        foreach (var entry in data)
                        {
                            command.Parameters.AddWithValue("@" + entry.Key, entry.Value ?? DBNull.Value);
                        }

                        int result = command.ExecuteNonQuery();
                        return result > 0; // Returns true if insertion was successful
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }

    public class DataDeleter
    {
        public void DeleteRecord(string tableName, string columnName, int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConfig.connectionString))
                {
                    connection.Open();
                    string query = $"DELETE FROM {tableName} WHERE {columnName} = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show($"{tableName} record deleted successfully.");
            }
            catch (SqlException sqlEx) when (sqlEx.Number == 547) // Foreign key constraint error
            {
                MessageBox.Show("Error: This record cannot be deleted because it is referenced in another table.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
