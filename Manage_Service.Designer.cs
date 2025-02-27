namespace CrystalOasis
{
    partial class Manage_Service
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AdminBack = new System.Windows.Forms.PictureBox();
            this.mngServiceRes_txtID = new System.Windows.Forms.TextBox();
            this.mngServiceRse_ID = new System.Windows.Forms.Label();
            this.mngService_txtprice = new System.Windows.Forms.TextBox();
            this.mngService_price = new System.Windows.Forms.Label();
            this.admin_service_lbl = new System.Windows.Forms.Label();
            this.btd_service_Update = new System.Windows.Forms.Button();
            this.bdt_service_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mngService_txtname = new System.Windows.Forms.TextBox();
            this.mngService_name = new System.Windows.Forms.Label();
            this.mngService_txtdescription = new System.Windows.Forms.TextBox();
            this.mngService_description = new System.Windows.Forms.Label();
            this.mngBooking_txtID = new System.Windows.Forms.TextBox();
            this.mngBooking_ID = new System.Windows.Forms.Label();
            this.Service_data_view = new System.Windows.Forms.DataGridView();
            this.mng_service_lbl = new System.Windows.Forms.Label();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.admin_service_txt = new System.Windows.Forms.TextBox();
            this.admin_footer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AdminBack)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Service_data_view)).BeginInit();
            this.upper_panel.SuspendLayout();
            this.admin_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminBack
            // 
            this.AdminBack.Image = global::CrystalOasis.Properties.Resources.back2;
            this.AdminBack.Location = new System.Drawing.Point(1172, 9);
            this.AdminBack.Margin = new System.Windows.Forms.Padding(0);
            this.AdminBack.Name = "AdminBack";
            this.AdminBack.Size = new System.Drawing.Size(44, 42);
            this.AdminBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminBack.TabIndex = 25;
            this.AdminBack.TabStop = false;
            // 
            // mngServiceRes_txtID
            // 
            this.mngServiceRes_txtID.BackColor = System.Drawing.Color.SkyBlue;
            this.mngServiceRes_txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngServiceRes_txtID.Location = new System.Drawing.Point(14, 405);
            this.mngServiceRes_txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngServiceRes_txtID.Name = "mngServiceRes_txtID";
            this.mngServiceRes_txtID.Size = new System.Drawing.Size(240, 27);
            this.mngServiceRes_txtID.TabIndex = 58;
            // 
            // mngServiceRse_ID
            // 
            this.mngServiceRse_ID.AutoSize = true;
            this.mngServiceRse_ID.BackColor = System.Drawing.Color.Transparent;
            this.mngServiceRse_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngServiceRse_ID.Location = new System.Drawing.Point(14, 375);
            this.mngServiceRse_ID.Name = "mngServiceRse_ID";
            this.mngServiceRse_ID.Size = new System.Drawing.Size(132, 23);
            this.mngServiceRse_ID.TabIndex = 57;
            this.mngServiceRse_ID.Text = "Reservation ID:";
            // 
            // mngService_txtprice
            // 
            this.mngService_txtprice.BackColor = System.Drawing.Color.SkyBlue;
            this.mngService_txtprice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngService_txtprice.Location = new System.Drawing.Point(14, 202);
            this.mngService_txtprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngService_txtprice.Name = "mngService_txtprice";
            this.mngService_txtprice.Size = new System.Drawing.Size(240, 27);
            this.mngService_txtprice.TabIndex = 54;
            // 
            // mngService_price
            // 
            this.mngService_price.AutoSize = true;
            this.mngService_price.BackColor = System.Drawing.Color.Transparent;
            this.mngService_price.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngService_price.Location = new System.Drawing.Point(14, 172);
            this.mngService_price.Name = "mngService_price";
            this.mngService_price.Size = new System.Drawing.Size(117, 23);
            this.mngService_price.TabIndex = 53;
            this.mngService_price.Text = "Service Price:";
            // 
            // admin_service_lbl
            // 
            this.admin_service_lbl.AutoSize = true;
            this.admin_service_lbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_service_lbl.Location = new System.Drawing.Point(530, 16);
            this.admin_service_lbl.Name = "admin_service_lbl";
            this.admin_service_lbl.Size = new System.Drawing.Size(103, 31);
            this.admin_service_lbl.TabIndex = 14;
            this.admin_service_lbl.Text = "Search";
            this.admin_service_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btd_service_Update
            // 
            this.btd_service_Update.BackColor = System.Drawing.Color.Cyan;
            this.btd_service_Update.FlatAppearance.BorderSize = 0;
            this.btd_service_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btd_service_Update.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btd_service_Update.Location = new System.Drawing.Point(678, 3);
            this.btd_service_Update.Margin = new System.Windows.Forms.Padding(0);
            this.btd_service_Update.Name = "btd_service_Update";
            this.btd_service_Update.Size = new System.Drawing.Size(194, 39);
            this.btd_service_Update.TabIndex = 6;
            this.btd_service_Update.Text = "Update Service";
            this.btd_service_Update.UseVisualStyleBackColor = false;
            this.btd_service_Update.Click += new System.EventHandler(this.btd_service_Update_Click);
            // 
            // bdt_service_add
            // 
            this.bdt_service_add.BackColor = System.Drawing.Color.Cyan;
            this.bdt_service_add.FlatAppearance.BorderSize = 0;
            this.bdt_service_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bdt_service_add.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdt_service_add.Location = new System.Drawing.Point(454, 3);
            this.bdt_service_add.Margin = new System.Windows.Forms.Padding(0);
            this.bdt_service_add.Name = "bdt_service_add";
            this.bdt_service_add.Size = new System.Drawing.Size(179, 39);
            this.bdt_service_add.TabIndex = 3;
            this.bdt_service_add.Text = "Add Service";
            this.bdt_service_add.UseVisualStyleBackColor = false;
            this.bdt_service_add.Click += new System.EventHandler(this.bdt_service_add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mngServiceRes_txtID);
            this.panel1.Controls.Add(this.mngServiceRse_ID);
            this.panel1.Controls.Add(this.mngService_txtprice);
            this.panel1.Controls.Add(this.mngService_price);
            this.panel1.Controls.Add(this.mngService_txtname);
            this.panel1.Controls.Add(this.mngService_name);
            this.panel1.Controls.Add(this.mngService_txtdescription);
            this.panel1.Controls.Add(this.mngService_description);
            this.panel1.Controls.Add(this.mngBooking_txtID);
            this.panel1.Controls.Add(this.mngBooking_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(960, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 488);
            this.panel1.TabIndex = 35;
            // 
            // mngService_txtname
            // 
            this.mngService_txtname.BackColor = System.Drawing.Color.SkyBlue;
            this.mngService_txtname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngService_txtname.Location = new System.Drawing.Point(14, 133);
            this.mngService_txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngService_txtname.Name = "mngService_txtname";
            this.mngService_txtname.Size = new System.Drawing.Size(240, 27);
            this.mngService_txtname.TabIndex = 52;
            // 
            // mngService_name
            // 
            this.mngService_name.AutoSize = true;
            this.mngService_name.BackColor = System.Drawing.Color.Transparent;
            this.mngService_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngService_name.Location = new System.Drawing.Point(14, 99);
            this.mngService_name.Name = "mngService_name";
            this.mngService_name.Size = new System.Drawing.Size(125, 23);
            this.mngService_name.TabIndex = 51;
            this.mngService_name.Text = "Service Name:";
            // 
            // mngService_txtdescription
            // 
            this.mngService_txtdescription.BackColor = System.Drawing.Color.SkyBlue;
            this.mngService_txtdescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngService_txtdescription.Location = new System.Drawing.Point(14, 277);
            this.mngService_txtdescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngService_txtdescription.Multiline = true;
            this.mngService_txtdescription.Name = "mngService_txtdescription";
            this.mngService_txtdescription.Size = new System.Drawing.Size(240, 77);
            this.mngService_txtdescription.TabIndex = 48;
            // 
            // mngService_description
            // 
            this.mngService_description.AutoSize = true;
            this.mngService_description.BackColor = System.Drawing.Color.Transparent;
            this.mngService_description.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngService_description.Location = new System.Drawing.Point(14, 247);
            this.mngService_description.Name = "mngService_description";
            this.mngService_description.Size = new System.Drawing.Size(107, 23);
            this.mngService_description.TabIndex = 47;
            this.mngService_description.Text = "Description:";
            // 
            // mngBooking_txtID
            // 
            this.mngBooking_txtID.BackColor = System.Drawing.Color.SkyBlue;
            this.mngBooking_txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngBooking_txtID.Location = new System.Drawing.Point(14, 54);
            this.mngBooking_txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngBooking_txtID.Name = "mngBooking_txtID";
            this.mngBooking_txtID.Size = new System.Drawing.Size(240, 27);
            this.mngBooking_txtID.TabIndex = 41;
            // 
            // mngBooking_ID
            // 
            this.mngBooking_ID.AutoSize = true;
            this.mngBooking_ID.BackColor = System.Drawing.Color.Transparent;
            this.mngBooking_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngBooking_ID.Location = new System.Drawing.Point(14, 24);
            this.mngBooking_ID.Name = "mngBooking_ID";
            this.mngBooking_ID.Size = new System.Drawing.Size(105, 23);
            this.mngBooking_ID.TabIndex = 38;
            this.mngBooking_ID.Text = "Booking ID:";
            // 
            // Service_data_view
            // 
            this.Service_data_view.AllowUserToAddRows = false;
            this.Service_data_view.AllowUserToDeleteRows = false;
            this.Service_data_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Service_data_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Service_data_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Service_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Service_data_view.Location = new System.Drawing.Point(0, 61);
            this.Service_data_view.Margin = new System.Windows.Forms.Padding(0);
            this.Service_data_view.Name = "Service_data_view";
            this.Service_data_view.ReadOnly = true;
            this.Service_data_view.RowHeadersWidth = 51;
            this.Service_data_view.RowTemplate.Height = 24;
            this.Service_data_view.Size = new System.Drawing.Size(960, 488);
            this.Service_data_view.TabIndex = 34;
            this.Service_data_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            this.Service_data_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewService_CellContentClick);
            // 
            // mng_service_lbl
            // 
            this.mng_service_lbl.AutoSize = true;
            this.mng_service_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mng_service_lbl.Location = new System.Drawing.Point(12, 7);
            this.mng_service_lbl.Name = "mng_service_lbl";
            this.mng_service_lbl.Size = new System.Drawing.Size(235, 41);
            this.mng_service_lbl.TabIndex = 26;
            this.mng_service_lbl.Text = "Manage Service";
            this.mng_service_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upper_panel
            // 
            this.upper_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.upper_panel.Controls.Add(this.mng_service_lbl);
            this.upper_panel.Controls.Add(this.AdminBack);
            this.upper_panel.Controls.Add(this.admin_service_lbl);
            this.upper_panel.Controls.Add(this.admin_service_txt);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(0, 0);
            this.upper_panel.Margin = new System.Windows.Forms.Padding(0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(1236, 61);
            this.upper_panel.TabIndex = 32;
            // 
            // admin_service_txt
            // 
            this.admin_service_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admin_service_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_service_txt.Location = new System.Drawing.Point(663, 15);
            this.admin_service_txt.Name = "admin_service_txt";
            this.admin_service_txt.Size = new System.Drawing.Size(253, 34);
            this.admin_service_txt.TabIndex = 13;
            this.admin_service_txt.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // admin_footer
            // 
            this.admin_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.admin_footer.Controls.Add(this.btd_service_Update);
            this.admin_footer.Controls.Add(this.bdt_service_add);
            this.admin_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.admin_footer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.admin_footer.Location = new System.Drawing.Point(0, 549);
            this.admin_footer.Margin = new System.Windows.Forms.Padding(0);
            this.admin_footer.Name = "admin_footer";
            this.admin_footer.Size = new System.Drawing.Size(1236, 48);
            this.admin_footer.TabIndex = 33;
            // 
            // Manage_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Service_data_view);
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.admin_footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Service";
            this.Text = "Manage_Service";
            ((System.ComponentModel.ISupportInitialize)(this.AdminBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Service_data_view)).EndInit();
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            this.admin_footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AdminBack;
        private System.Windows.Forms.TextBox mngServiceRes_txtID;
        private System.Windows.Forms.Label mngServiceRse_ID;
        private System.Windows.Forms.TextBox mngService_txtprice;
        private System.Windows.Forms.Label mngService_price;
        private System.Windows.Forms.Label admin_service_lbl;
        private System.Windows.Forms.Button btd_service_Update;
        private System.Windows.Forms.Button bdt_service_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox mngService_txtname;
        private System.Windows.Forms.Label mngService_name;
        private System.Windows.Forms.TextBox mngService_txtdescription;
        private System.Windows.Forms.Label mngService_description;
        private System.Windows.Forms.TextBox mngBooking_txtID;
        private System.Windows.Forms.Label mngBooking_ID;
        private System.Windows.Forms.DataGridView Service_data_view;
        private System.Windows.Forms.Label mng_service_lbl;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.TextBox admin_service_txt;
        private System.Windows.Forms.Panel admin_footer;
    }
}