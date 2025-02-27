namespace CrystalOasis
{
    partial class Manage_Room
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mngRoom_typetxt = new System.Windows.Forms.ComboBox();
            this.mngRoom_type = new System.Windows.Forms.Label();
            this.mngRoom_statustxt = new System.Windows.Forms.ComboBox();
            this.mngRoom_txtrent = new System.Windows.Forms.TextBox();
            this.mngRoom_textID = new System.Windows.Forms.TextBox();
            this.mngRoom_status = new System.Windows.Forms.Label();
            this.mngRoom_rent = new System.Windows.Forms.Label();
            this.mngRoom_ID = new System.Windows.Forms.Label();
            this.mng_room_lbl = new System.Windows.Forms.Label();
            this.Room_data_view = new System.Windows.Forms.DataGridView();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.RoomBack = new System.Windows.Forms.PictureBox();
            this.room_search_lbl = new System.Windows.Forms.Label();
            this.room_search_txt = new System.Windows.Forms.TextBox();
            this.btd_Room_Update = new System.Windows.Forms.Button();
            this.bdt_Room_add = new System.Windows.Forms.Button();
            this.admin_footer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Room_data_view)).BeginInit();
            this.upper_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBack)).BeginInit();
            this.admin_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mngRoom_typetxt);
            this.panel1.Controls.Add(this.mngRoom_type);
            this.panel1.Controls.Add(this.mngRoom_statustxt);
            this.panel1.Controls.Add(this.mngRoom_txtrent);
            this.panel1.Controls.Add(this.mngRoom_textID);
            this.panel1.Controls.Add(this.mngRoom_status);
            this.panel1.Controls.Add(this.mngRoom_rent);
            this.panel1.Controls.Add(this.mngRoom_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(960, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 488);
            this.panel1.TabIndex = 23;
            // 
            // mngRoom_typetxt
            // 
            this.mngRoom_typetxt.BackColor = System.Drawing.Color.SkyBlue;
            this.mngRoom_typetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRoom_typetxt.FormattingEnabled = true;
            this.mngRoom_typetxt.Items.AddRange(new object[] {
            "Deluxe room",
            "Suite",
            "Presidential Suite",
            "Single twin Bed",
            "Standard Room",
            "Oasis Comfort Suite"});
            this.mngRoom_typetxt.Location = new System.Drawing.Point(14, 206);
            this.mngRoom_typetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngRoom_typetxt.Name = "mngRoom_typetxt";
            this.mngRoom_typetxt.Size = new System.Drawing.Size(240, 28);
            this.mngRoom_typetxt.TabIndex = 45;
            this.mngRoom_typetxt.Text = "Select type";
            // 
            // mngRoom_type
            // 
            this.mngRoom_type.AutoSize = true;
            this.mngRoom_type.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRoom_type.Location = new System.Drawing.Point(14, 170);
            this.mngRoom_type.Name = "mngRoom_type";
            this.mngRoom_type.Size = new System.Drawing.Size(100, 23);
            this.mngRoom_type.TabIndex = 44;
            this.mngRoom_type.Text = "Room Type";
            // 
            // mngRoom_statustxt
            // 
            this.mngRoom_statustxt.BackColor = System.Drawing.Color.SkyBlue;
            this.mngRoom_statustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRoom_statustxt.FormattingEnabled = true;
            this.mngRoom_statustxt.Items.AddRange(new object[] {
            "Available",
            "Booked"});
            this.mngRoom_statustxt.Location = new System.Drawing.Point(14, 292);
            this.mngRoom_statustxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngRoom_statustxt.Name = "mngRoom_statustxt";
            this.mngRoom_statustxt.Size = new System.Drawing.Size(240, 28);
            this.mngRoom_statustxt.TabIndex = 43;
            this.mngRoom_statustxt.Text = "Select status";
            // 
            // mngRoom_txtrent
            // 
            this.mngRoom_txtrent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mngRoom_txtrent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRoom_txtrent.Location = new System.Drawing.Point(14, 117);
            this.mngRoom_txtrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngRoom_txtrent.Name = "mngRoom_txtrent";
            this.mngRoom_txtrent.Size = new System.Drawing.Size(240, 27);
            this.mngRoom_txtrent.TabIndex = 42;
            // 
            // mngRoom_textID
            // 
            this.mngRoom_textID.BackColor = System.Drawing.Color.SkyBlue;
            this.mngRoom_textID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRoom_textID.Location = new System.Drawing.Point(14, 54);
            this.mngRoom_textID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngRoom_textID.Name = "mngRoom_textID";
            this.mngRoom_textID.Size = new System.Drawing.Size(240, 27);
            this.mngRoom_textID.TabIndex = 41;
            // 
            // mngRoom_status
            // 
            this.mngRoom_status.AutoSize = true;
            this.mngRoom_status.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRoom_status.Location = new System.Drawing.Point(13, 255);
            this.mngRoom_status.Name = "mngRoom_status";
            this.mngRoom_status.Size = new System.Drawing.Size(109, 23);
            this.mngRoom_status.TabIndex = 40;
            this.mngRoom_status.Text = "Room status";
            // 
            // mngRoom_rent
            // 
            this.mngRoom_rent.AutoSize = true;
            this.mngRoom_rent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRoom_rent.Location = new System.Drawing.Point(14, 90);
            this.mngRoom_rent.Name = "mngRoom_rent";
            this.mngRoom_rent.Size = new System.Drawing.Size(104, 23);
            this.mngRoom_rent.TabIndex = 39;
            this.mngRoom_rent.Text = "Room Rent:";
            // 
            // mngRoom_ID
            // 
            this.mngRoom_ID.AutoSize = true;
            this.mngRoom_ID.BackColor = System.Drawing.Color.Transparent;
            this.mngRoom_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRoom_ID.Location = new System.Drawing.Point(14, 24);
            this.mngRoom_ID.Name = "mngRoom_ID";
            this.mngRoom_ID.Size = new System.Drawing.Size(134, 23);
            this.mngRoom_ID.TabIndex = 38;
            this.mngRoom_ID.Text = "Room Number:";
            // 
            // mng_room_lbl
            // 
            this.mng_room_lbl.AutoSize = true;
            this.mng_room_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mng_room_lbl.Location = new System.Drawing.Point(12, 7);
            this.mng_room_lbl.Name = "mng_room_lbl";
            this.mng_room_lbl.Size = new System.Drawing.Size(219, 41);
            this.mng_room_lbl.TabIndex = 26;
            this.mng_room_lbl.Text = "Manage Room";
            this.mng_room_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Room_data_view
            // 
            this.Room_data_view.AllowUserToAddRows = false;
            this.Room_data_view.AllowUserToDeleteRows = false;
            this.Room_data_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Room_data_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Room_data_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Room_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_data_view.Location = new System.Drawing.Point(0, 61);
            this.Room_data_view.Margin = new System.Windows.Forms.Padding(0);
            this.Room_data_view.Name = "Room_data_view";
            this.Room_data_view.ReadOnly = true;
            this.Room_data_view.RowHeadersWidth = 51;
            this.Room_data_view.RowTemplate.Height = 24;
            this.Room_data_view.Size = new System.Drawing.Size(960, 488);
            this.Room_data_view.TabIndex = 22;
            this.Room_data_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Room_data_view_CellClick);
            this.Room_data_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellContentClick);
            // 
            // upper_panel
            // 
            this.upper_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.upper_panel.Controls.Add(this.mng_room_lbl);
            this.upper_panel.Controls.Add(this.RoomBack);
            this.upper_panel.Controls.Add(this.room_search_lbl);
            this.upper_panel.Controls.Add(this.room_search_txt);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(0, 0);
            this.upper_panel.Margin = new System.Windows.Forms.Padding(0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(1236, 61);
            this.upper_panel.TabIndex = 20;
            // 
            // RoomBack
            // 
            this.RoomBack.Image = global::CrystalOasis.Properties.Resources.back2;
            this.RoomBack.Location = new System.Drawing.Point(1172, 9);
            this.RoomBack.Margin = new System.Windows.Forms.Padding(0);
            this.RoomBack.Name = "RoomBack";
            this.RoomBack.Size = new System.Drawing.Size(44, 42);
            this.RoomBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomBack.TabIndex = 25;
            this.RoomBack.TabStop = false;
            this.RoomBack.Click += new System.EventHandler(this.RoomBack_Click);
            // 
            // room_search_lbl
            // 
            this.room_search_lbl.AutoSize = true;
            this.room_search_lbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_search_lbl.Location = new System.Drawing.Point(530, 16);
            this.room_search_lbl.Name = "room_search_lbl";
            this.room_search_lbl.Size = new System.Drawing.Size(103, 31);
            this.room_search_lbl.TabIndex = 14;
            this.room_search_lbl.Text = "Search";
            this.room_search_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // room_search_txt
            // 
            this.room_search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.room_search_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_search_txt.Location = new System.Drawing.Point(663, 15);
            this.room_search_txt.Name = "room_search_txt";
            this.room_search_txt.Size = new System.Drawing.Size(253, 34);
            this.room_search_txt.TabIndex = 13;
            this.room_search_txt.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btd_Room_Update
            // 
            this.btd_Room_Update.BackColor = System.Drawing.Color.Cyan;
            this.btd_Room_Update.FlatAppearance.BorderSize = 0;
            this.btd_Room_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btd_Room_Update.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btd_Room_Update.Location = new System.Drawing.Point(678, 3);
            this.btd_Room_Update.Margin = new System.Windows.Forms.Padding(0);
            this.btd_Room_Update.Name = "btd_Room_Update";
            this.btd_Room_Update.Size = new System.Drawing.Size(142, 39);
            this.btd_Room_Update.TabIndex = 6;
            this.btd_Room_Update.Text = "Update Room";
            this.btd_Room_Update.UseVisualStyleBackColor = false;
            this.btd_Room_Update.Click += new System.EventHandler(this.btd_Room_Update_Click);
            // 
            // bdt_Room_add
            // 
            this.bdt_Room_add.BackColor = System.Drawing.Color.Cyan;
            this.bdt_Room_add.FlatAppearance.BorderSize = 0;
            this.bdt_Room_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bdt_Room_add.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdt_Room_add.Location = new System.Drawing.Point(470, 3);
            this.bdt_Room_add.Margin = new System.Windows.Forms.Padding(0);
            this.bdt_Room_add.Name = "bdt_Room_add";
            this.bdt_Room_add.Size = new System.Drawing.Size(136, 39);
            this.bdt_Room_add.TabIndex = 3;
            this.bdt_Room_add.Text = "Add Room";
            this.bdt_Room_add.UseVisualStyleBackColor = false;
            this.bdt_Room_add.Click += new System.EventHandler(this.bdt_Room_add_Click);
            // 
            // admin_footer
            // 
            this.admin_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.admin_footer.Controls.Add(this.btd_Room_Update);
            this.admin_footer.Controls.Add(this.bdt_Room_add);
            this.admin_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.admin_footer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.admin_footer.Location = new System.Drawing.Point(0, 549);
            this.admin_footer.Margin = new System.Windows.Forms.Padding(0);
            this.admin_footer.Name = "admin_footer";
            this.admin_footer.Size = new System.Drawing.Size(1236, 48);
            this.admin_footer.TabIndex = 21;
            // 
            // Manage_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Room_data_view);
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.admin_footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Room";
            this.Text = "Manage_Room";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Room_data_view)).EndInit();
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBack)).EndInit();
            this.admin_footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mng_room_lbl;
        private System.Windows.Forms.PictureBox RoomBack;
        private System.Windows.Forms.DataGridView Room_data_view;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.Label room_search_lbl;
        private System.Windows.Forms.TextBox room_search_txt;
        private System.Windows.Forms.Button btd_Room_Update;
        private System.Windows.Forms.Button bdt_Room_add;
        private System.Windows.Forms.Panel admin_footer;
        private System.Windows.Forms.ComboBox mngRoom_typetxt;
        private System.Windows.Forms.Label mngRoom_type;
        private System.Windows.Forms.ComboBox mngRoom_statustxt;
        private System.Windows.Forms.TextBox mngRoom_txtrent;
        private System.Windows.Forms.TextBox mngRoom_textID;
        private System.Windows.Forms.Label mngRoom_status;
        private System.Windows.Forms.Label mngRoom_rent;
        private System.Windows.Forms.Label mngRoom_ID;
    }
}