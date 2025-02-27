using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CrystalOasis.Poplogin;

namespace CrystalOasis
{
    public partial class Rooms : Form
    {
        private int guestId;
        private decimal totalAmount;
        private Timer imageChangeTimer1;
        private Timer imageChangeTimer2; 
        private Timer imageChangeTimer3;
        private Timer imageChangeTimer4;
        private Timer imageChangeTimer5;
        private Timer imageChangeTimer6;

        private Image[] imageList1;
        private Image[] imageList2;
        private Image[] imageList3;
        private Image[] imageList4;
        private Image[] imageList5;
        private Image[] imageList6;

        private int currentImageIndex1;
        private int currentImageIndex2;
        private int currentImageIndex3;
        private int currentImageIndex4;
        private int currentImageIndex5;
        private int currentImageIndex6;


        public Rooms(int guestId)
        {
            this.guestId = guestId; // Store the Guest ID
            InitializeComponent();
            InitializeImageChanger();
        }
        public Rooms()
        {
            InitializeComponent();
            InitializeImageChanger();

        }

        private void InitializeImageChanger()
        {
           
            imageList1 = new Image[]
            {
                Resource8.room1,
                Resource8.rr2
            };

            
            imageList2 = new Image[]
            {
                Resource8.picturebox61,
                Resource8.picturebox62
            };
            imageList3 = new Image[]
            {
                Resource8.bus1,
                Resource8.bus2,
                Resource8.bus3,
                Resource8.bus4,
                Resource8.bus5
            };
            imageList4 = new Image[]
            {
                Resource8.singD1,
                Resource8.singD2
            };
            imageList5 = new Image[]
            {
                Resource8.stander11,
                Resource8.stander12
            };
            imageList6 = new Image[]
            {
                Resource8.dulex1,
                Resource8.dul1
            };

         
            InitializeImageForPictureBox1(pictureBox5, imageList1, ref imageChangeTimer1);
            InitializeImageForPictureBox2(pictureBox6, imageList2, ref imageChangeTimer2);
            InitializeImageForPictureBox3(pictureBox7, imageList3, ref imageChangeTimer3);
            InitializeImageForPictureBox4(pictureBox8, imageList4, ref imageChangeTimer4);
            InitializeImageForPictureBox5(pictureBox9, imageList5, ref imageChangeTimer5);
            InitializeImageForPictureBox6(pictureBox10, imageList6, ref imageChangeTimer6);
        }
        private void InitializeImageForPictureBox1(PictureBox pictureBox, Image[] images, ref Timer imageChangeTimer1)
        {
           
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = images[0];

            
            imageChangeTimer1 = new Timer
            {
                Interval =2000  
            };

           
            imageChangeTimer1.Tick += (sender, e) => ImageChangeTimer_Tick(sender, e);
        }
       
        private void InitializeImageForPictureBox2(PictureBox pictureBox, Image[] images, ref Timer imageChangeTimer2)
        {
            
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = images[0];

           
            imageChangeTimer2 = new Timer
            {
                Interval = 2000  
            };

        
            imageChangeTimer2.Tick += (sender, e) => ImageChangeTimer_Tick(sender, e);
        }
        private void InitializeImageForPictureBox3(PictureBox pictureBox, Image[] images, ref Timer imageChangeTimer3)
        {
           
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = images[0];

            
            imageChangeTimer3 = new Timer
            {
                Interval = 2000  
            };

           
            imageChangeTimer3.Tick += (sender, e) => ImageChangeTimer_Tick(sender, e);
        }
        
        private void InitializeImageForPictureBox4(PictureBox pictureBox, Image[] images, ref Timer imageChangeTimer4)
        {
            
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = images[0];

        
            imageChangeTimer4 = new Timer
            {
                Interval = 2000  
            };

           
            imageChangeTimer4.Tick += (sender, e) => ImageChangeTimer_Tick(sender, e);
        }
        private void InitializeImageForPictureBox5(PictureBox pictureBox, Image[] images, ref Timer imageChangeTimer5)
        {
           
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = images[0];

           
            imageChangeTimer5 = new Timer
            {
                Interval = 2000  
            };

          
            imageChangeTimer5.Tick += (sender, e) => ImageChangeTimer_Tick(sender, e);
        }
        
        private void InitializeImageForPictureBox6(PictureBox pictureBox, Image[] images, ref Timer imageChangeTimer6)
        {
           
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = images[0];

           
            imageChangeTimer6 = new Timer
            {
                Interval = 2000  
            };

           
            imageChangeTimer6.Tick += (sender, e) => ImageChangeTimer_Tick(sender, e);
        }
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            imageChangeTimer1.Start();
        }

        
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            imageChangeTimer1.Stop(); 
            pictureBox5.Image = imageList1[0]; 
        }


        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            imageChangeTimer2.Start();
        }

        
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            imageChangeTimer2.Stop(); 
            pictureBox6.Image = imageList2[0]; 
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            imageChangeTimer3.Start(); 
        }

       
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            imageChangeTimer3.Stop(); 
            pictureBox7.Image = imageList3[0]; 
        }

        
        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            imageChangeTimer4.Start(); 
        }

       
        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            imageChangeTimer4.Stop();
            pictureBox8.Image = imageList4[0]; 
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            imageChangeTimer5.Start(); 
        }

       
        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            imageChangeTimer5.Stop(); 
            pictureBox9.Image = imageList5[0]; 
        }

       
        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            imageChangeTimer6.Start(); 
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            imageChangeTimer6.Stop(); 
            pictureBox10.Image = imageList6[0]; 
        }



        private void ImageChangeTimer_Tick(object sender, EventArgs e)
        {
            Timer timer = sender as Timer; 

           
            if (timer == imageChangeTimer1)
            {
                
                currentImageIndex1++;
                if (currentImageIndex1 >= imageList1.Length) currentImageIndex1 = 0;
                pictureBox5.Image = imageList1[currentImageIndex1];


            }
            if (timer == imageChangeTimer2)
            {
                currentImageIndex2++;
                if (currentImageIndex2 >= imageList2.Length) currentImageIndex2 = 0;
                pictureBox6.Image = imageList2[currentImageIndex2];
            }
            if (timer == imageChangeTimer3)
            {
                currentImageIndex3++;
                if (currentImageIndex3 >= imageList3.Length) currentImageIndex3 = 0;
                pictureBox7.Image = imageList3[currentImageIndex3];
            }
            if (timer == imageChangeTimer4)
            {
                currentImageIndex4++;
                if (currentImageIndex4 >= imageList4.Length) currentImageIndex4 = 0;
                pictureBox8.Image = imageList4[currentImageIndex4];
            }
            if (timer == imageChangeTimer5)
            {
                currentImageIndex5++;
                if (currentImageIndex5 >= imageList5.Length) currentImageIndex5 = 0;
                pictureBox9.Image = imageList5[currentImageIndex5];
            }
            if (timer == imageChangeTimer6)
            {
                currentImageIndex6++;
                if (currentImageIndex6 >= imageList6.Length) currentImageIndex6 = 0;
                pictureBox10.Image = imageList6[currentImageIndex6];
            }
        }




        // database connection part
        
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Poplogin poplog = new Poplogin();
            poplog.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About_us about_Us = new About_us();
            about_Us.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (guestId == 0)
            {
                MessageBox.Show("Please log in to make a reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime checkInDate = dateCheckIn.Value;
            DateTime checkOutDate = dateCheckOut.Value;
            List<string> selectedRoomTypes = new List<string>();
            List<int> roomIds = new List<int>();
            List<decimal> roomRents = new List<decimal>();

            // Check which checkboxes are selected and set corresponding room details
            if (checkboxRoomType1.Checked)
            {
                selectedRoomTypes.Add("Single twin Bed");
                roomIds.Add(111);
                roomRents.Add(2500.00m);
            }
            if (checkboxRoomType2.Checked)
            {
                selectedRoomTypes.Add("Oasis Comfort Suite");
                roomIds.Add(112);
                roomRents.Add(3000.00m);
            }
            if (checkboxRoomType3.Checked)
            {
                selectedRoomTypes.Add("Deluxe room");
                roomIds.Add(113);
                roomRents.Add(2500.00m);
            }
            if (checkboxRoomType4.Checked)
            {
                selectedRoomTypes.Add("Presidential Suite");
                roomIds.Add(114);
                roomRents.Add(5000.00m);
            }
            if (checkboxRoomType5.Checked)
            {
                selectedRoomTypes.Add("Standard Room");
                roomIds.Add(115);
                roomRents.Add(3000.00m);
            }
            if (checkboxRoomType6.Checked)
            {
                selectedRoomTypes.Add("Suite");
                roomIds.Add(116);
                roomRents.Add(2000.00m);
            }

            // Check if at least one room type is selected
            if (selectedRoomTypes.Count != 1)
            {
                MessageBox.Show("Please select one room type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if check-in and check-out dates are valid
            if (checkInDate >= checkOutDate)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxVehicle.SelectedIndex == -1)  // No selection made
            {
                MessageBox.Show("Please select vehicle information (With or Without vehicle).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check room availability in the Room table for each selected room
            bool isRoomAvailable = true;
            totalAmount = 0;

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
            {
                conn.Open();

                foreach (var roomId in roomIds)
                {
                    int totalDays = (checkOutDate - checkInDate).Days; // Corrected calculation
                    if (totalDays <= 0)
                    {
                        MessageBox.Show("Invalid check-in/check-out dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Fetch room status & rent in one query
                    string query = "SELECT Status, Room_Rent FROM Room WHERE Room_ID = @RoomID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", roomId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string roomStatus = reader["Status"].ToString();
                                decimal roomRentPerDay = Convert.ToDecimal(reader["Room_Rent"]);

                                // If room is booked, mark as unavailable
                                if (roomStatus != "Available")
                                {
                                    isRoomAvailable = false;
                                    break;
                                }

                                // Calculate room cost
                                totalAmount += roomRentPerDay * totalDays;
                            }
                            reader.Close(); // Close reader before next iteration
                        }
                    }
                }
            }

            if (!isRoomAvailable)
            {
                MessageBox.Show("One or more selected rooms are not available.", "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Total Amount: {totalAmount}", "Booking Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Show message if any room is not available
            if (!isRoomAvailable)
            {
                MessageBox.Show("selected room are not available.", "Room Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<int> reservationIds = new List<int>();

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.connectionString))
                {
                    conn.Open();
                    for (int i = 0; i < selectedRoomTypes.Count; i++)
                    {
                        string reservationQuery = @"
                            INSERT INTO Reservation (Check_in, Check_out, Room_ID, G_ID) 
                            OUTPUT INSERTED.Reservation_ID 
                            VALUES (@CheckInDate, @CheckOutDate, @RoomID, @GuestID)";

                        using (SqlCommand reservationCmd = new SqlCommand(reservationQuery, conn))
                        {
                            reservationCmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                            reservationCmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                            reservationCmd.Parameters.AddWithValue("@RoomID", roomIds[i]);
                            reservationCmd.Parameters.AddWithValue("@GuestID", guestId);

                            object insertedIdObj = reservationCmd.ExecuteScalar(); // Retrieve Reservation_ID
                            if (insertedIdObj != null)
                            {
                                int insertedId = Convert.ToInt32(insertedIdObj);
                                reservationIds.Add(insertedId);
                            }
                            else
                            {
                                MessageBox.Show("Error retrieving reservation ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Update room status to 'Booked'
                        string updateRoomStatusQuery = "UPDATE Room SET Status = 'Booked' WHERE Room_ID = @RoomID";
                        using (SqlCommand updateRoomStatusCmd = new SqlCommand(updateRoomStatusQuery, conn))
                        {
                            updateRoomStatusCmd.Parameters.AddWithValue("@RoomID", roomIds[i]);
                            updateRoomStatusCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Rooms booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Ensure reservationIds is not empty before opening the next form
            if (reservationIds.Count > 0)
            {
                bool isWithVehicle = comboBoxVehicle.SelectedIndex == 0;

                // Open the Service form
                Service serviceForm = new Service(isWithVehicle, totalAmount, guestId, reservationIds[0]);
                serviceForm.Show();

            }

        }

        private void comboBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVehicle.SelectedIndex == 0)  // With Vehicle
            {
                
            }
            else if (comboBoxVehicle.SelectedIndex == 1)  // Without Vehicle
            {
                
            }
        }
    }

}
