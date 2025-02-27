namespace CrystalOasis
{
    partial class Manage_Guest
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
            this.admin_footer = new System.Windows.Forms.Panel();
            this.btd_Guest_Update = new System.Windows.Forms.Button();
            this.guest_search_txt = new System.Windows.Forms.TextBox();
            this.guest_search_lbl = new System.Windows.Forms.Label();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.mng_guest_lbl = new System.Windows.Forms.Label();
            this.guestBack = new System.Windows.Forms.PictureBox();
            this.Guest_data_view = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mngGuest_txtID = new System.Windows.Forms.TextBox();
            this.mngGuest_ID = new System.Windows.Forms.Label();
            this.mngGuest_Statustxt = new System.Windows.Forms.ComboBox();
            this.mngGuest_memStatus = new System.Windows.Forms.Label();
            this.mngGuest_txtEmail = new System.Windows.Forms.TextBox();
            this.mngGuest_dateOfbirth = new System.Windows.Forms.DateTimePicker();
            this.mngGuest_txtgender = new System.Windows.Forms.ComboBox();
            this.mngGuest_txtnationality = new System.Windows.Forms.ComboBox();
            this.mngGuest_txtMobile = new System.Windows.Forms.TextBox();
            this.mngGuest_textName = new System.Windows.Forms.TextBox();
            this.mngGuest_maillbl = new System.Windows.Forms.Label();
            this.mngGuest_dob = new System.Windows.Forms.Label();
            this.mngGuest_genderlbl = new System.Windows.Forms.Label();
            this.mngGuest_nation = new System.Windows.Forms.Label();
            this.mngGuest_mobile = new System.Windows.Forms.Label();
            this.mngGuest_name = new System.Windows.Forms.Label();
            this.admin_footer.SuspendLayout();
            this.upper_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_data_view)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_footer
            // 
            this.admin_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.admin_footer.Controls.Add(this.btd_Guest_Update);
            this.admin_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.admin_footer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.admin_footer.Location = new System.Drawing.Point(0, 549);
            this.admin_footer.Margin = new System.Windows.Forms.Padding(0);
            this.admin_footer.Name = "admin_footer";
            this.admin_footer.Size = new System.Drawing.Size(1236, 48);
            this.admin_footer.TabIndex = 16;
            // 
            // btd_Guest_Update
            // 
            this.btd_Guest_Update.BackColor = System.Drawing.Color.Cyan;
            this.btd_Guest_Update.FlatAppearance.BorderSize = 0;
            this.btd_Guest_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btd_Guest_Update.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btd_Guest_Update.Location = new System.Drawing.Point(571, 0);
            this.btd_Guest_Update.Margin = new System.Windows.Forms.Padding(0);
            this.btd_Guest_Update.Name = "btd_Guest_Update";
            this.btd_Guest_Update.Size = new System.Drawing.Size(142, 39);
            this.btd_Guest_Update.TabIndex = 6;
            this.btd_Guest_Update.Text = "Update Guest";
            this.btd_Guest_Update.UseVisualStyleBackColor = false;
            this.btd_Guest_Update.Click += new System.EventHandler(this.btd_Guest_Update_Click);
            // 
            // guest_search_txt
            // 
            this.guest_search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guest_search_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_search_txt.Location = new System.Drawing.Point(663, 15);
            this.guest_search_txt.Name = "guest_search_txt";
            this.guest_search_txt.Size = new System.Drawing.Size(253, 34);
            this.guest_search_txt.TabIndex = 13;
            this.guest_search_txt.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guest_search_lbl
            // 
            this.guest_search_lbl.AutoSize = true;
            this.guest_search_lbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_search_lbl.Location = new System.Drawing.Point(530, 16);
            this.guest_search_lbl.Name = "guest_search_lbl";
            this.guest_search_lbl.Size = new System.Drawing.Size(103, 31);
            this.guest_search_lbl.TabIndex = 14;
            this.guest_search_lbl.Text = "Search";
            this.guest_search_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upper_panel
            // 
            this.upper_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.upper_panel.Controls.Add(this.mng_guest_lbl);
            this.upper_panel.Controls.Add(this.guestBack);
            this.upper_panel.Controls.Add(this.guest_search_lbl);
            this.upper_panel.Controls.Add(this.guest_search_txt);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.Location = new System.Drawing.Point(0, 0);
            this.upper_panel.Margin = new System.Windows.Forms.Padding(0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(1236, 61);
            this.upper_panel.TabIndex = 15;
            // 
            // mng_guest_lbl
            // 
            this.mng_guest_lbl.AutoSize = true;
            this.mng_guest_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mng_guest_lbl.Location = new System.Drawing.Point(12, 7);
            this.mng_guest_lbl.Name = "mng_guest_lbl";
            this.mng_guest_lbl.Size = new System.Drawing.Size(217, 41);
            this.mng_guest_lbl.TabIndex = 26;
            this.mng_guest_lbl.Text = "Manage Guest";
            this.mng_guest_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guestBack
            // 
            this.guestBack.Image = global::CrystalOasis.Properties.Resources.back2;
            this.guestBack.Location = new System.Drawing.Point(1172, 9);
            this.guestBack.Margin = new System.Windows.Forms.Padding(0);
            this.guestBack.Name = "guestBack";
            this.guestBack.Size = new System.Drawing.Size(44, 42);
            this.guestBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guestBack.TabIndex = 25;
            this.guestBack.TabStop = false;
            this.guestBack.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Guest_data_view
            // 
            this.Guest_data_view.AllowUserToAddRows = false;
            this.Guest_data_view.AllowUserToDeleteRows = false;
            this.Guest_data_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Guest_data_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Guest_data_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Guest_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Guest_data_view.Location = new System.Drawing.Point(0, 61);
            this.Guest_data_view.Margin = new System.Windows.Forms.Padding(0);
            this.Guest_data_view.Name = "Guest_data_view";
            this.Guest_data_view.ReadOnly = true;
            this.Guest_data_view.RowHeadersWidth = 51;
            this.Guest_data_view.RowTemplate.Height = 24;
            this.Guest_data_view.Size = new System.Drawing.Size(960, 488);
            this.Guest_data_view.TabIndex = 17;
            this.Guest_data_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Guest_data_view_CellClick);
            this.Guest_data_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuests_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mngGuest_txtID);
            this.panel1.Controls.Add(this.mngGuest_ID);
            this.panel1.Controls.Add(this.mngGuest_Statustxt);
            this.panel1.Controls.Add(this.mngGuest_memStatus);
            this.panel1.Controls.Add(this.mngGuest_txtEmail);
            this.panel1.Controls.Add(this.mngGuest_dateOfbirth);
            this.panel1.Controls.Add(this.mngGuest_txtgender);
            this.panel1.Controls.Add(this.mngGuest_txtnationality);
            this.panel1.Controls.Add(this.mngGuest_txtMobile);
            this.panel1.Controls.Add(this.mngGuest_textName);
            this.panel1.Controls.Add(this.mngGuest_maillbl);
            this.panel1.Controls.Add(this.mngGuest_dob);
            this.panel1.Controls.Add(this.mngGuest_genderlbl);
            this.panel1.Controls.Add(this.mngGuest_nation);
            this.panel1.Controls.Add(this.mngGuest_mobile);
            this.panel1.Controls.Add(this.mngGuest_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(960, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 488);
            this.panel1.TabIndex = 18;
            // 
            // mngGuest_txtID
            // 
            this.mngGuest_txtID.BackColor = System.Drawing.Color.SkyBlue;
            this.mngGuest_txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_txtID.Location = new System.Drawing.Point(24, 25);
            this.mngGuest_txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngGuest_txtID.Name = "mngGuest_txtID";
            this.mngGuest_txtID.Size = new System.Drawing.Size(240, 27);
            this.mngGuest_txtID.TabIndex = 39;
            // 
            // mngGuest_ID
            // 
            this.mngGuest_ID.AutoSize = true;
            this.mngGuest_ID.BackColor = System.Drawing.Color.Transparent;
            this.mngGuest_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_ID.Location = new System.Drawing.Point(24, 0);
            this.mngGuest_ID.Name = "mngGuest_ID";
            this.mngGuest_ID.Size = new System.Drawing.Size(83, 23);
            this.mngGuest_ID.TabIndex = 38;
            this.mngGuest_ID.Text = "Guest ID:";
            // 
            // mngGuest_Statustxt
            // 
            this.mngGuest_Statustxt.BackColor = System.Drawing.Color.SkyBlue;
            this.mngGuest_Statustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_Statustxt.FormattingEnabled = true;
            this.mngGuest_Statustxt.Items.AddRange(new object[] {
            "Inactive",
            "Active"});
            this.mngGuest_Statustxt.Location = new System.Drawing.Point(24, 400);
            this.mngGuest_Statustxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngGuest_Statustxt.Name = "mngGuest_Statustxt";
            this.mngGuest_Statustxt.Size = new System.Drawing.Size(240, 28);
            this.mngGuest_Statustxt.TabIndex = 37;
            this.mngGuest_Statustxt.Text = "Select status";
            // 
            // mngGuest_memStatus
            // 
            this.mngGuest_memStatus.AutoSize = true;
            this.mngGuest_memStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_memStatus.Location = new System.Drawing.Point(24, 375);
            this.mngGuest_memStatus.Name = "mngGuest_memStatus";
            this.mngGuest_memStatus.Size = new System.Drawing.Size(133, 23);
            this.mngGuest_memStatus.TabIndex = 36;
            this.mngGuest_memStatus.Text = "Member Status";
            // 
            // mngGuest_txtEmail
            // 
            this.mngGuest_txtEmail.BackColor = System.Drawing.Color.SkyBlue;
            this.mngGuest_txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_txtEmail.Location = new System.Drawing.Point(24, 187);
            this.mngGuest_txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngGuest_txtEmail.Name = "mngGuest_txtEmail";
            this.mngGuest_txtEmail.Size = new System.Drawing.Size(240, 27);
            this.mngGuest_txtEmail.TabIndex = 31;
            // 
            // mngGuest_dateOfbirth
            // 
            this.mngGuest_dateOfbirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_dateOfbirth.CalendarMonthBackground = System.Drawing.Color.White;
            this.mngGuest_dateOfbirth.CalendarTitleBackColor = System.Drawing.Color.White;
            this.mngGuest_dateOfbirth.CalendarTitleForeColor = System.Drawing.Color.White;
            this.mngGuest_dateOfbirth.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.mngGuest_dateOfbirth.Location = new System.Drawing.Point(24, 351);
            this.mngGuest_dateOfbirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngGuest_dateOfbirth.Name = "mngGuest_dateOfbirth";
            this.mngGuest_dateOfbirth.Size = new System.Drawing.Size(240, 22);
            this.mngGuest_dateOfbirth.TabIndex = 30;
            // 
            // mngGuest_txtgender
            // 
            this.mngGuest_txtgender.BackColor = System.Drawing.Color.SkyBlue;
            this.mngGuest_txtgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_txtgender.FormattingEnabled = true;
            this.mngGuest_txtgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.mngGuest_txtgender.Location = new System.Drawing.Point(24, 296);
            this.mngGuest_txtgender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngGuest_txtgender.Name = "mngGuest_txtgender";
            this.mngGuest_txtgender.Size = new System.Drawing.Size(240, 28);
            this.mngGuest_txtgender.TabIndex = 29;
            this.mngGuest_txtgender.Text = "Select Gander";
            // 
            // mngGuest_txtnationality
            // 
            this.mngGuest_txtnationality.BackColor = System.Drawing.Color.SkyBlue;
            this.mngGuest_txtnationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_txtnationality.FormattingEnabled = true;
            this.mngGuest_txtnationality.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe",
            "Load"});
            this.mngGuest_txtnationality.Location = new System.Drawing.Point(24, 241);
            this.mngGuest_txtnationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngGuest_txtnationality.Name = "mngGuest_txtnationality";
            this.mngGuest_txtnationality.Size = new System.Drawing.Size(240, 28);
            this.mngGuest_txtnationality.TabIndex = 28;
            this.mngGuest_txtnationality.Text = "Select Country";
            // 
            // mngGuest_txtMobile
            // 
            this.mngGuest_txtMobile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mngGuest_txtMobile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_txtMobile.Location = new System.Drawing.Point(24, 133);
            this.mngGuest_txtMobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngGuest_txtMobile.Name = "mngGuest_txtMobile";
            this.mngGuest_txtMobile.Size = new System.Drawing.Size(240, 27);
            this.mngGuest_txtMobile.TabIndex = 27;
            // 
            // mngGuest_textName
            // 
            this.mngGuest_textName.BackColor = System.Drawing.Color.SkyBlue;
            this.mngGuest_textName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_textName.Location = new System.Drawing.Point(24, 79);
            this.mngGuest_textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mngGuest_textName.Name = "mngGuest_textName";
            this.mngGuest_textName.Size = new System.Drawing.Size(240, 27);
            this.mngGuest_textName.TabIndex = 26;
            // 
            // mngGuest_maillbl
            // 
            this.mngGuest_maillbl.AutoSize = true;
            this.mngGuest_maillbl.BackColor = System.Drawing.Color.Transparent;
            this.mngGuest_maillbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_maillbl.Location = new System.Drawing.Point(24, 162);
            this.mngGuest_maillbl.Name = "mngGuest_maillbl";
            this.mngGuest_maillbl.Size = new System.Drawing.Size(133, 23);
            this.mngGuest_maillbl.TabIndex = 25;
            this.mngGuest_maillbl.Text = "Email Address :";
            // 
            // mngGuest_dob
            // 
            this.mngGuest_dob.AutoSize = true;
            this.mngGuest_dob.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_dob.Location = new System.Drawing.Point(24, 326);
            this.mngGuest_dob.Name = "mngGuest_dob";
            this.mngGuest_dob.Size = new System.Drawing.Size(125, 23);
            this.mngGuest_dob.TabIndex = 24;
            this.mngGuest_dob.Text = "Date of Birth :";
            // 
            // mngGuest_genderlbl
            // 
            this.mngGuest_genderlbl.AutoSize = true;
            this.mngGuest_genderlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_genderlbl.Location = new System.Drawing.Point(24, 271);
            this.mngGuest_genderlbl.Name = "mngGuest_genderlbl";
            this.mngGuest_genderlbl.Size = new System.Drawing.Size(78, 23);
            this.mngGuest_genderlbl.TabIndex = 23;
            this.mngGuest_genderlbl.Text = "Gander :";
            // 
            // mngGuest_nation
            // 
            this.mngGuest_nation.AutoSize = true;
            this.mngGuest_nation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_nation.Location = new System.Drawing.Point(24, 216);
            this.mngGuest_nation.Name = "mngGuest_nation";
            this.mngGuest_nation.Size = new System.Drawing.Size(109, 23);
            this.mngGuest_nation.TabIndex = 22;
            this.mngGuest_nation.Text = "Nationality :";
            // 
            // mngGuest_mobile
            // 
            this.mngGuest_mobile.AutoSize = true;
            this.mngGuest_mobile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_mobile.Location = new System.Drawing.Point(24, 108);
            this.mngGuest_mobile.Name = "mngGuest_mobile";
            this.mngGuest_mobile.Size = new System.Drawing.Size(147, 23);
            this.mngGuest_mobile.TabIndex = 21;
            this.mngGuest_mobile.Text = "Mobile Number :\r\n";
            // 
            // mngGuest_name
            // 
            this.mngGuest_name.AutoSize = true;
            this.mngGuest_name.BackColor = System.Drawing.Color.Transparent;
            this.mngGuest_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngGuest_name.Location = new System.Drawing.Point(24, 54);
            this.mngGuest_name.Name = "mngGuest_name";
            this.mngGuest_name.Size = new System.Drawing.Size(67, 23);
            this.mngGuest_name.TabIndex = 20;
            this.mngGuest_name.Text = "Name :";
            // 
            // Manage_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Guest_data_view);
            this.Controls.Add(this.admin_footer);
            this.Controls.Add(this.upper_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Guest";
            this.Text = "Manage_Guest";
            this.admin_footer.ResumeLayout(false);
            this.upper_panel.ResumeLayout(false);
            this.upper_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_data_view)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel admin_footer;
        private System.Windows.Forms.TextBox guest_search_txt;
        private System.Windows.Forms.Label guest_search_lbl;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.PictureBox guestBack;
        private System.Windows.Forms.Button btd_Guest_Update;
        private System.Windows.Forms.DataGridView Guest_data_view;
        private System.Windows.Forms.Label mng_guest_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox mngGuest_txtgender;
        private System.Windows.Forms.TextBox mngGuest_txtMobile;
        private System.Windows.Forms.TextBox mngGuest_textName;
        private System.Windows.Forms.Label mngGuest_genderlbl;
        private System.Windows.Forms.Label mngGuest_mobile;
        private System.Windows.Forms.Label mngGuest_name;
        private System.Windows.Forms.ComboBox mngGuest_Statustxt;
        private System.Windows.Forms.Label mngGuest_memStatus;
        public System.Windows.Forms.DateTimePicker mngGuest_dateOfbirth;
        private System.Windows.Forms.Label mngGuest_dob;
        private System.Windows.Forms.TextBox mngGuest_txtEmail;
        private System.Windows.Forms.ComboBox mngGuest_txtnationality;
        private System.Windows.Forms.Label mngGuest_maillbl;
        private System.Windows.Forms.Label mngGuest_nation;
        private System.Windows.Forms.TextBox mngGuest_txtID;
        private System.Windows.Forms.Label mngGuest_ID;
    }
}