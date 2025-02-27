namespace CrystalOasis
{
    partial class Manage_Reservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ResBack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mngResGuest_txtID = new System.Windows.Forms.TextBox();
            this.mngResGuest_ID = new System.Windows.Forms.Label();
            this.mngRes_checkouttxt = new System.Windows.Forms.DateTimePicker();
            this.mngRes_checkout = new System.Windows.Forms.Label();
            this.mngResRoom_textID = new System.Windows.Forms.TextBox();
            this.mngResRoom_ID = new System.Windows.Forms.Label();
            this.mngRes_checkintxt = new System.Windows.Forms.DateTimePicker();
            this.mngRes_textID = new System.Windows.Forms.TextBox();
            this.mngRes_checkin = new System.Windows.Forms.Label();
            this.mngRes_ID = new System.Windows.Forms.Label();
            this.Res_data_view = new System.Windows.Forms.DataGridView();
            this.btd_Res_Update = new System.Windows.Forms.Button();
            this.bdt_Res_add = new System.Windows.Forms.Button();
            this.res_search_lbl = new System.Windows.Forms.Label();
            this.res_search_txt = new System.Windows.Forms.TextBox();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.mng_res_lbl = new System.Windows.Forms.Label();
            this.admin_footer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ResBack)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Res_data_view)).BeginInit();
            this.upper_panel.SuspendLayout();
            this.admin_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResBack
            // 
            this.ResBack.Image = global::CrystalOasis.Properties.Resources.back2;
            this.ResBack.Location = new System.Drawing.Point(1172, 9);
            this.ResBack.Margin = new System.Windows.Forms.Padding(0);
            this.ResBack.Name = "ResBack";
            this.ResBack.Size = new System.Drawing.Size(44, 42);
            this.ResBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResBack.TabIndex = 25;
            this.ResBack.TabStop = false;
            this.ResBack.Click += new System.EventHandler(this.ResBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mngResGuest_txtID);
            this.panel1.Controls.Add(this.mngResGuest_ID);
            this.panel1.Controls.Add(this.mngRes_checkouttxt);
            this.panel1.Controls.Add(this.mngRes_checkout);
            this.panel1.Controls.Add(this.mngResRoom_textID);
            this.panel1.Controls.Add(this.mngResRoom_ID);
            this.panel1.Controls.Add(this.mngRes_checkintxt);
            this.panel1.Controls.Add(this.mngRes_textID);
            this.panel1.Controls.Add(this.mngRes_checkin);
            this.panel1.Controls.Add(this.mngRes_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(960, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 488);
            this.panel1.TabIndex = 27;
            // 
            // mngResGuest_txtID
            // 
            this.mngResGuest_txtID.BackColor = System.Drawing.Color.SkyBlue;
            this.mngResGuest_txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngResGuest_txtID.Location = new System.Drawing.Point(14, 263);
            this.mngResGuest_txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngResGuest_txtID.Name = "mngResGuest_txtID";
            this.mngResGuest_txtID.Size = new System.Drawing.Size(240, 27);
            this.mngResGuest_txtID.TabIndex = 52;
            // 
            // mngResGuest_ID
            // 
            this.mngResGuest_ID.AutoSize = true;
            this.mngResGuest_ID.BackColor = System.Drawing.Color.Transparent;
            this.mngResGuest_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngResGuest_ID.Location = new System.Drawing.Point(14, 237);
            this.mngResGuest_ID.Name = "mngResGuest_ID";
            this.mngResGuest_ID.Size = new System.Drawing.Size(83, 23);
            this.mngResGuest_ID.TabIndex = 51;
            this.mngResGuest_ID.Text = "Guest ID:";
            // 
            // mngRes_checkouttxt
            // 
            this.mngRes_checkouttxt.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mngRes_checkouttxt.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mngRes_checkouttxt.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mngRes_checkouttxt.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mngRes_checkouttxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRes_checkouttxt.Location = new System.Drawing.Point(14, 185);
            this.mngRes_checkouttxt.Name = "mngRes_checkouttxt";
            this.mngRes_checkouttxt.Size = new System.Drawing.Size(240, 30);
            this.mngRes_checkouttxt.TabIndex = 50;
            // 
            // mngRes_checkout
            // 
            this.mngRes_checkout.AutoSize = true;
            this.mngRes_checkout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRes_checkout.Location = new System.Drawing.Point(14, 159);
            this.mngRes_checkout.Name = "mngRes_checkout";
            this.mngRes_checkout.Size = new System.Drawing.Size(98, 23);
            this.mngRes_checkout.TabIndex = 49;
            this.mngRes_checkout.Text = "Check Out:";
            // 
            // mngResRoom_textID
            // 
            this.mngResRoom_textID.BackColor = System.Drawing.Color.SkyBlue;
            this.mngResRoom_textID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngResRoom_textID.Location = new System.Drawing.Point(14, 334);
            this.mngResRoom_textID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngResRoom_textID.Name = "mngResRoom_textID";
            this.mngResRoom_textID.Size = new System.Drawing.Size(240, 27);
            this.mngResRoom_textID.TabIndex = 48;
            // 
            // mngResRoom_ID
            // 
            this.mngResRoom_ID.AutoSize = true;
            this.mngResRoom_ID.BackColor = System.Drawing.Color.Transparent;
            this.mngResRoom_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngResRoom_ID.Location = new System.Drawing.Point(14, 304);
            this.mngResRoom_ID.Name = "mngResRoom_ID";
            this.mngResRoom_ID.Size = new System.Drawing.Size(134, 23);
            this.mngResRoom_ID.TabIndex = 47;
            this.mngResRoom_ID.Text = "Room Number:";
            // 
            // mngRes_checkintxt
            // 
            this.mngRes_checkintxt.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mngRes_checkintxt.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mngRes_checkintxt.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mngRes_checkintxt.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mngRes_checkintxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRes_checkintxt.Location = new System.Drawing.Point(14, 116);
            this.mngRes_checkintxt.Name = "mngRes_checkintxt";
            this.mngRes_checkintxt.Size = new System.Drawing.Size(240, 30);
            this.mngRes_checkintxt.TabIndex = 46;
            // 
            // mngRes_textID
            // 
            this.mngRes_textID.BackColor = System.Drawing.Color.SkyBlue;
            this.mngRes_textID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRes_textID.Location = new System.Drawing.Point(14, 54);
            this.mngRes_textID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngRes_textID.Name = "mngRes_textID";
            this.mngRes_textID.Size = new System.Drawing.Size(240, 27);
            this.mngRes_textID.TabIndex = 41;
            // 
            // mngRes_checkin
            // 
            this.mngRes_checkin.AutoSize = true;
            this.mngRes_checkin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRes_checkin.Location = new System.Drawing.Point(14, 90);
            this.mngRes_checkin.Name = "mngRes_checkin";
            this.mngRes_checkin.Size = new System.Drawing.Size(83, 23);
            this.mngRes_checkin.TabIndex = 39;
            this.mngRes_checkin.Text = "Check In:";
            // 
            // mngRes_ID
            // 
            this.mngRes_ID.AutoSize = true;
            this.mngRes_ID.BackColor = System.Drawing.Color.Transparent;
            this.mngRes_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRes_ID.Location = new System.Drawing.Point(14, 24);
            this.mngRes_ID.Name = "mngRes_ID";
            this.mngRes_ID.Size = new System.Drawing.Size(132, 23);
            this.mngRes_ID.TabIndex = 38;
            this.mngRes_ID.Text = "Reservation ID:";
            // 
            // Res_data_view
            // 
            this.Res_data_view.AllowUserToAddRows = false;
            this.Res_data_view.AllowUserToDeleteRows = false;
            this.Res_data_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Res_data_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Res_data_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Res_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Res_data_view.Location = new System.Drawing.Point(0, 61);
            this.Res_data_view.Margin = new System.Windows.Forms.Padding(0);
            this.Res_data_view.Name = "Res_data_view";
            this.Res_data_view.ReadOnly = true;
            this.Res_data_view.RowHeadersWidth = 51;
            this.Res_data_view.RowTemplate.Height = 24;
            this.Res_data_view.Size = new System.Drawing.Size(960, 488);
            this.Res_data_view.TabIndex = 26;
            this.Res_data_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellClick);
            this.Res_data_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellContentClick);
            // 
            // btd_Res_Update
            // 
            this.btd_Res_Update.BackColor = System.Drawing.Color.Cyan;
            this.btd_Res_Update.FlatAppearance.BorderSize = 0;
            this.btd_Res_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btd_Res_Update.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btd_Res_Update.Location = new System.Drawing.Point(678, 3);
            this.btd_Res_Update.Margin = new System.Windows.Forms.Padding(0);
            this.btd_Res_Update.Name = "btd_Res_Update";
            this.btd_Res_Update.Size = new System.Drawing.Size(194, 39);
            this.btd_Res_Update.TabIndex = 6;
            this.btd_Res_Update.Text = "Update Reservation";
            this.btd_Res_Update.UseVisualStyleBackColor = false;
            this.btd_Res_Update.Click += new System.EventHandler(this.btd_Res_Update_Click);
            // 
            // bdt_Res_add
            // 
            this.bdt_Res_add.BackColor = System.Drawing.Color.Cyan;
            this.bdt_Res_add.FlatAppearance.BorderSize = 0;
            this.bdt_Res_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bdt_Res_add.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdt_Res_add.Location = new System.Drawing.Point(454, 3);
            this.bdt_Res_add.Margin = new System.Windows.Forms.Padding(0);
            this.bdt_Res_add.Name = "bdt_Res_add";
            this.bdt_Res_add.Size = new System.Drawing.Size(179, 39);
            this.bdt_Res_add.TabIndex = 3;
            this.bdt_Res_add.Text = "Add Reservation";
            this.bdt_Res_add.UseVisualStyleBackColor = false;
            this.bdt_Res_add.Click += new System.EventHandler(this.bdt_Res_add_Click);
            // 
            // res_search_lbl
            // 
            this.res_search_lbl.AutoSize = true;
            this.res_search_lbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_search_lbl.Location = new System.Drawing.Point(530, 16);
            this.res_search_lbl.Name = "res_search_lbl";
            this.res_search_lbl.Size = new System.Drawing.Size(103, 31);
            this.res_search_lbl.TabIndex = 14;
            this.res_search_lbl.Text = "Search";
            this.res_search_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // res_search_txt
            // 
            this.res_search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.res_search_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_search_txt.Location = new System.Drawing.Point(663, 15);
            this.res_search_txt.Name = "res_search_txt";
            this.res_search_txt.Size = new System.Drawing.Size(253, 34);
            this.res_search_txt.TabIndex = 13;
            this.res_search_txt.TextChanged += new System.EventHandler(this.txtResSearch_TextChanged);
            // 
            // upper_panel
            // 
            this.upper_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.upper_panel.Controls.Add(this.mng_res_lbl);
            this.upper_panel.Controls.Add(this.ResBack);
            this.upper_panel.Controls.Add(this.res_search_lbl);
            this.upper_panel.Controls.Add(this.res_search_txt);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(0, 0);
            this.upper_panel.Margin = new System.Windows.Forms.Padding(0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(1236, 61);
            this.upper_panel.TabIndex = 24;
            // 
            // mng_res_lbl
            // 
            this.mng_res_lbl.AutoSize = true;
            this.mng_res_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mng_res_lbl.Location = new System.Drawing.Point(12, 7);
            this.mng_res_lbl.Name = "mng_res_lbl";
            this.mng_res_lbl.Size = new System.Drawing.Size(299, 41);
            this.mng_res_lbl.TabIndex = 26;
            this.mng_res_lbl.Text = "Manage Reservation";
            this.mng_res_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // admin_footer
            // 
            this.admin_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.admin_footer.Controls.Add(this.btd_Res_Update);
            this.admin_footer.Controls.Add(this.bdt_Res_add);
            this.admin_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.admin_footer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.admin_footer.Location = new System.Drawing.Point(0, 549);
            this.admin_footer.Margin = new System.Windows.Forms.Padding(0);
            this.admin_footer.Name = "admin_footer";
            this.admin_footer.Size = new System.Drawing.Size(1236, 48);
            this.admin_footer.TabIndex = 25;
            // 
            // Manage_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Res_data_view);
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.admin_footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Reservation";
            this.Text = "Manage_Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.ResBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Res_data_view)).EndInit();
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            this.admin_footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ResBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox mngRes_textID;
        private System.Windows.Forms.Label mngRes_checkin;
        private System.Windows.Forms.Label mngRes_ID;
        private System.Windows.Forms.DataGridView Res_data_view;
        private System.Windows.Forms.Button btd_Res_Update;
        private System.Windows.Forms.Button bdt_Res_add;
        private System.Windows.Forms.Label res_search_lbl;
        private System.Windows.Forms.TextBox res_search_txt;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.Label mng_res_lbl;
        private System.Windows.Forms.Panel admin_footer;
        private System.Windows.Forms.DateTimePicker mngRes_checkintxt;
        private System.Windows.Forms.DateTimePicker mngRes_checkouttxt;
        private System.Windows.Forms.Label mngRes_checkout;
        private System.Windows.Forms.TextBox mngResRoom_textID;
        private System.Windows.Forms.Label mngResRoom_ID;
        private System.Windows.Forms.TextBox mngResGuest_txtID;
        private System.Windows.Forms.Label mngResGuest_ID;
    }
}