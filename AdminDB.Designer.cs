namespace CrystalOasis
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.left_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManageRooms = new System.Windows.Forms.Button();
            this.btnManageReservations = new System.Windows.Forms.Button();
            this.btnManageService = new System.Windows.Forms.Button();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.btnManageVehicle = new System.Windows.Forms.Button();
            this.btnManageAdmin = new System.Windows.Forms.Button();
            this.btnManageGuests = new System.Windows.Forms.Button();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.admin_logout = new System.Windows.Forms.Button();
            this.admin_footer = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.payment_data = new System.Windows.Forms.DataGridView();
            this.total_Room_lbl = new System.Windows.Forms.Label();
            this.total_Vehicle_lbl = new System.Windows.Forms.Label();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.total_Guest_lbl = new System.Windows.Forms.Label();
            this.total_staff_lbl = new System.Windows.Forms.Label();
            this.left_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.upper_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_data)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.left_panel.Controls.Add(this.panel1);
            this.left_panel.Controls.Add(this.btnDashboard);
            this.left_panel.Controls.Add(this.btnManageRooms);
            this.left_panel.Controls.Add(this.btnManageReservations);
            this.left_panel.Controls.Add(this.btnManageService);
            this.left_panel.Controls.Add(this.btnManageStaff);
            this.left_panel.Controls.Add(this.btnManageVehicle);
            this.left_panel.Controls.Add(this.btnManageAdmin);
            this.left_panel.Controls.Add(this.btnManageGuests);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Margin = new System.Windows.Forms.Padding(0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(190, 693);
            this.left_panel.TabIndex = 2;
            this.left_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.left_panel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 94);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CrystalOasis.Properties.Resources.logo21;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(39, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 97);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.Cyan;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(0, 94);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(190, 50);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.BackColor = System.Drawing.Color.Cyan;
            this.btnManageRooms.FlatAppearance.BorderSize = 0;
            this.btnManageRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRooms.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRooms.Location = new System.Drawing.Point(0, 144);
            this.btnManageRooms.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Size = new System.Drawing.Size(190, 50);
            this.btnManageRooms.TabIndex = 6;
            this.btnManageRooms.Text = "Manage Room";
            this.btnManageRooms.UseVisualStyleBackColor = false;
            this.btnManageRooms.Click += new System.EventHandler(this.btnManageRooms_Click);
            // 
            // btnManageReservations
            // 
            this.btnManageReservations.BackColor = System.Drawing.Color.Cyan;
            this.btnManageReservations.FlatAppearance.BorderSize = 0;
            this.btnManageReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageReservations.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageReservations.Location = new System.Drawing.Point(0, 194);
            this.btnManageReservations.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageReservations.Name = "btnManageReservations";
            this.btnManageReservations.Size = new System.Drawing.Size(190, 50);
            this.btnManageReservations.TabIndex = 7;
            this.btnManageReservations.Text = "Manage Reservation";
            this.btnManageReservations.UseVisualStyleBackColor = false;
            this.btnManageReservations.Click += new System.EventHandler(this.btnManageReservations_Click);
            // 
            // btnManageService
            // 
            this.btnManageService.BackColor = System.Drawing.Color.Cyan;
            this.btnManageService.FlatAppearance.BorderSize = 0;
            this.btnManageService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageService.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageService.Location = new System.Drawing.Point(0, 244);
            this.btnManageService.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageService.Name = "btnManageService";
            this.btnManageService.Size = new System.Drawing.Size(190, 50);
            this.btnManageService.TabIndex = 8;
            this.btnManageService.Text = "Manage Service";
            this.btnManageService.UseVisualStyleBackColor = false;
            this.btnManageService.Click += new System.EventHandler(this.btnManagePayments_Click);
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.BackColor = System.Drawing.Color.Cyan;
            this.btnManageStaff.FlatAppearance.BorderSize = 0;
            this.btnManageStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStaff.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStaff.Location = new System.Drawing.Point(0, 294);
            this.btnManageStaff.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(190, 50);
            this.btnManageStaff.TabIndex = 9;
            this.btnManageStaff.Text = "Manage Staff";
            this.btnManageStaff.UseVisualStyleBackColor = false;
            this.btnManageStaff.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnManageVehicle
            // 
            this.btnManageVehicle.BackColor = System.Drawing.Color.Cyan;
            this.btnManageVehicle.FlatAppearance.BorderSize = 0;
            this.btnManageVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageVehicle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageVehicle.Location = new System.Drawing.Point(0, 344);
            this.btnManageVehicle.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageVehicle.Name = "btnManageVehicle";
            this.btnManageVehicle.Size = new System.Drawing.Size(190, 50);
            this.btnManageVehicle.TabIndex = 10;
            this.btnManageVehicle.Text = "Manage Vehicle";
            this.btnManageVehicle.UseVisualStyleBackColor = false;
            this.btnManageVehicle.Click += new System.EventHandler(this.btnManageVehicle_Click);
            // 
            // btnManageAdmin
            // 
            this.btnManageAdmin.BackColor = System.Drawing.Color.Cyan;
            this.btnManageAdmin.FlatAppearance.BorderSize = 0;
            this.btnManageAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAdmin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAdmin.Location = new System.Drawing.Point(0, 394);
            this.btnManageAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageAdmin.Name = "btnManageAdmin";
            this.btnManageAdmin.Size = new System.Drawing.Size(190, 50);
            this.btnManageAdmin.TabIndex = 11;
            this.btnManageAdmin.Text = "Manage Admin";
            this.btnManageAdmin.UseVisualStyleBackColor = false;
            this.btnManageAdmin.Click += new System.EventHandler(this.btnManageAdmin_Click);
            // 
            // btnManageGuests
            // 
            this.btnManageGuests.BackColor = System.Drawing.Color.Cyan;
            this.btnManageGuests.FlatAppearance.BorderSize = 0;
            this.btnManageGuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageGuests.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageGuests.Location = new System.Drawing.Point(0, 444);
            this.btnManageGuests.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageGuests.Name = "btnManageGuests";
            this.btnManageGuests.Size = new System.Drawing.Size(190, 50);
            this.btnManageGuests.TabIndex = 13;
            this.btnManageGuests.Text = "Manage Guest";
            this.btnManageGuests.UseVisualStyleBackColor = false;
            this.btnManageGuests.Click += new System.EventHandler(this.btnManageGuests_Click);
            // 
            // upper_panel
            // 
            this.upper_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.upper_panel.Controls.Add(this.label5);
            this.upper_panel.Controls.Add(this.label6);
            this.upper_panel.Controls.Add(this.admin_logout);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(190, 0);
            this.upper_panel.Margin = new System.Windows.Forms.Padding(0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(1236, 73);
            this.upper_panel.TabIndex = 4;
            this.upper_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.upper_panel_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(24, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Where Elegance Meets Comfort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(-6, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 33);
            this.label6.TabIndex = 23;
            this.label6.Text = "CrystalOasis";
            // 
            // admin_logout
            // 
            this.admin_logout.BackColor = System.Drawing.Color.Cyan;
            this.admin_logout.FlatAppearance.BorderSize = 0;
            this.admin_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_logout.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_logout.Location = new System.Drawing.Point(1095, 9);
            this.admin_logout.Margin = new System.Windows.Forms.Padding(0);
            this.admin_logout.Name = "admin_logout";
            this.admin_logout.Size = new System.Drawing.Size(123, 50);
            this.admin_logout.TabIndex = 11;
            this.admin_logout.Text = "Log out";
            this.admin_logout.UseVisualStyleBackColor = false;
            this.admin_logout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // admin_footer
            // 
            this.admin_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.admin_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.admin_footer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.admin_footer.Location = new System.Drawing.Point(190, 670);
            this.admin_footer.Margin = new System.Windows.Forms.Padding(0);
            this.admin_footer.Name = "admin_footer";
            this.admin_footer.Size = new System.Drawing.Size(1236, 23);
            this.admin_footer.TabIndex = 6;
            this.admin_footer.Paint += new System.Windows.Forms.PaintEventHandler(this.admin_footer_Paint);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.payment_data);
            this.main_panel.Controls.Add(this.total_Room_lbl);
            this.main_panel.Controls.Add(this.total_Vehicle_lbl);
            this.main_panel.Controls.Add(this.welcome_lbl);
            this.main_panel.Controls.Add(this.total_Guest_lbl);
            this.main_panel.Controls.Add(this.total_staff_lbl);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(190, 73);
            this.main_panel.Margin = new System.Windows.Forms.Padding(0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1236, 597);
            this.main_panel.TabIndex = 7;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // payment_data
            // 
            this.payment_data.AllowUserToAddRows = false;
            this.payment_data.AllowUserToDeleteRows = false;
            this.payment_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payment_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.payment_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.payment_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment_data.Location = new System.Drawing.Point(0, 200);
            this.payment_data.Margin = new System.Windows.Forms.Padding(0);
            this.payment_data.Name = "payment_data";
            this.payment_data.ReadOnly = true;
            this.payment_data.RowHeadersWidth = 51;
            this.payment_data.RowTemplate.Height = 24;
            this.payment_data.Size = new System.Drawing.Size(1236, 397);
            this.payment_data.TabIndex = 19;
            this.payment_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // total_Room_lbl
            // 
            this.total_Room_lbl.AutoSize = true;
            this.total_Room_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Room_lbl.Location = new System.Drawing.Point(547, 142);
            this.total_Room_lbl.Name = "total_Room_lbl";
            this.total_Room_lbl.Size = new System.Drawing.Size(220, 50);
            this.total_Room_lbl.TabIndex = 17;
            this.total_Room_lbl.Text = "Total Room:";
            // 
            // total_Vehicle_lbl
            // 
            this.total_Vehicle_lbl.AutoSize = true;
            this.total_Vehicle_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Vehicle_lbl.Location = new System.Drawing.Point(27, 142);
            this.total_Vehicle_lbl.Name = "total_Vehicle_lbl";
            this.total_Vehicle_lbl.Size = new System.Drawing.Size(364, 50);
            this.total_Vehicle_lbl.TabIndex = 16;
            this.total_Vehicle_lbl.Text = "Total vehicle parked:";
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.Location = new System.Drawing.Point(20, 12);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(0, 38);
            this.welcome_lbl.TabIndex = 18;
            this.welcome_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_Guest_lbl
            // 
            this.total_Guest_lbl.AutoSize = true;
            this.total_Guest_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Guest_lbl.Location = new System.Drawing.Point(547, 71);
            this.total_Guest_lbl.Name = "total_Guest_lbl";
            this.total_Guest_lbl.Size = new System.Drawing.Size(218, 50);
            this.total_Guest_lbl.TabIndex = 15;
            this.total_Guest_lbl.Text = "Total Guest:";
            // 
            // total_staff_lbl
            // 
            this.total_staff_lbl.AutoSize = true;
            this.total_staff_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_staff_lbl.Location = new System.Drawing.Point(27, 71);
            this.total_staff_lbl.Name = "total_staff_lbl";
            this.total_staff_lbl.Size = new System.Drawing.Size(199, 50);
            this.total_staff_lbl.TabIndex = 14;
            this.total_staff_lbl.Text = "Total Staff:";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 693);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.admin_footer);
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.left_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.left_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel left_panel;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManageRooms;
        private System.Windows.Forms.Button btnManageReservations;
        private System.Windows.Forms.Button btnManageService;
        private System.Windows.Forms.Button btnManageStaff;
        private System.Windows.Forms.Button btnManageVehicle;
        private System.Windows.Forms.Button admin_logout;
        private System.Windows.Forms.Panel admin_footer;
        private System.Windows.Forms.Button btnManageAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnManageGuests;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.DataGridView payment_data;
        private System.Windows.Forms.Label total_Room_lbl;
        private System.Windows.Forms.Label total_Vehicle_lbl;
        private System.Windows.Forms.Label total_Guest_lbl;
        private System.Windows.Forms.Label total_staff_lbl;
        public System.Windows.Forms.Label welcome_lbl;
    }
}