namespace CrystalOasis
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.nation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtnationality = new System.Windows.Forms.ComboBox();
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.dateOfbirth = new System.Windows.Forms.DateTimePicker();
            this.reg_submit_btn = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.reg_user_txt = new System.Windows.Forms.TextBox();
            this.reg_user_lbl = new System.Windows.Forms.Label();
            this.reg_pass_lbl = new System.Windows.Forms.Label();
            this.reg_pass_txt = new System.Windows.Forms.TextBox();
            this.reg_Confirmpass_txt = new System.Windows.Forms.TextBox();
            this.reg_Confirmpass_lbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(17, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(67, 23);
            this.name.TabIndex = 1;
            this.name.Text = "Name :";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.Location = new System.Drawing.Point(17, 134);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(147, 23);
            this.mobile.TabIndex = 2;
            this.mobile.Text = "Mobile Number :\r\n";
            this.mobile.Click += new System.EventHandler(this.label2_Click);
            // 
            // nation
            // 
            this.nation.AutoSize = true;
            this.nation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nation.Location = new System.Drawing.Point(20, 254);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(109, 23);
            this.nation.TabIndex = 3;
            this.nation.Text = "Nationality :";
            this.nation.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gander :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date of Birth :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email Address :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(376, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 50);
            this.label7.TabIndex = 7;
            this.label7.Text = "CrystalOasis ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.SkyBlue;
            this.textName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(22, 99);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(240, 27);
            this.textName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(188, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 41);
            this.label8.TabIndex = 9;
            this.label8.Text = "Guest Registration";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(22, 159);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(240, 27);
            this.txtMobile.TabIndex = 10;
            // 
            // txtnationality
            // 
            this.txtnationality.BackColor = System.Drawing.Color.SkyBlue;
            this.txtnationality.FormattingEnabled = true;
            this.txtnationality.Items.AddRange(new object[] {
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
            this.txtnationality.Location = new System.Drawing.Point(22, 279);
            this.txtnationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnationality.Name = "txtnationality";
            this.txtnationality.Size = new System.Drawing.Size(240, 24);
            this.txtnationality.TabIndex = 11;
            this.txtnationality.Text = "Select Country";
            this.txtnationality.SelectedIndexChanged += new System.EventHandler(this.nationality_SelectedIndexChanged);
            // 
            // txtgender
            // 
            this.txtgender.BackColor = System.Drawing.Color.SkyBlue;
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.txtgender.Location = new System.Drawing.Point(22, 329);
            this.txtgender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(240, 24);
            this.txtgender.TabIndex = 12;
            this.txtgender.Text = "Select Gander";
            // 
            // dateOfbirth
            // 
            this.dateOfbirth.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateOfbirth.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateOfbirth.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateOfbirth.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dateOfbirth.Location = new System.Drawing.Point(22, 378);
            this.dateOfbirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateOfbirth.Name = "dateOfbirth";
            this.dateOfbirth.Size = new System.Drawing.Size(240, 22);
            this.dateOfbirth.TabIndex = 13;
            // 
            // reg_submit_btn
            // 
            this.reg_submit_btn.BackColor = System.Drawing.Color.SkyBlue;
            this.reg_submit_btn.Location = new System.Drawing.Point(370, 516);
            this.reg_submit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg_submit_btn.Name = "reg_submit_btn";
            this.reg_submit_btn.Size = new System.Drawing.Size(196, 46);
            this.reg_submit_btn.TabIndex = 14;
            this.reg_submit_btn.Text = "Submit";
            this.reg_submit_btn.UseVisualStyleBackColor = false;
            this.reg_submit_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.SkyBlue;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(20, 219);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 27);
            this.txtEmail.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CrystalOasis.Properties.Resources.back2;
            this.pictureBox2.Location = new System.Drawing.Point(596, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // reg_user_txt
            // 
            this.reg_user_txt.BackColor = System.Drawing.Color.SkyBlue;
            this.reg_user_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_user_txt.Location = new System.Drawing.Point(20, 427);
            this.reg_user_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg_user_txt.Name = "reg_user_txt";
            this.reg_user_txt.Size = new System.Drawing.Size(240, 27);
            this.reg_user_txt.TabIndex = 18;
            // 
            // reg_user_lbl
            // 
            this.reg_user_lbl.AutoSize = true;
            this.reg_user_lbl.BackColor = System.Drawing.Color.Transparent;
            this.reg_user_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_user_lbl.Location = new System.Drawing.Point(18, 402);
            this.reg_user_lbl.Name = "reg_user_lbl";
            this.reg_user_lbl.Size = new System.Drawing.Size(89, 23);
            this.reg_user_lbl.TabIndex = 19;
            this.reg_user_lbl.Text = "Username";
            // 
            // reg_pass_lbl
            // 
            this.reg_pass_lbl.AutoSize = true;
            this.reg_pass_lbl.BackColor = System.Drawing.Color.Transparent;
            this.reg_pass_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_pass_lbl.Location = new System.Drawing.Point(20, 457);
            this.reg_pass_lbl.Name = "reg_pass_lbl";
            this.reg_pass_lbl.Size = new System.Drawing.Size(85, 23);
            this.reg_pass_lbl.TabIndex = 20;
            this.reg_pass_lbl.Text = "Password";
            // 
            // reg_pass_txt
            // 
            this.reg_pass_txt.BackColor = System.Drawing.Color.SkyBlue;
            this.reg_pass_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_pass_txt.Location = new System.Drawing.Point(22, 481);
            this.reg_pass_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg_pass_txt.Name = "reg_pass_txt";
            this.reg_pass_txt.PasswordChar = '*';
            this.reg_pass_txt.Size = new System.Drawing.Size(240, 27);
            this.reg_pass_txt.TabIndex = 21;
            // 
            // reg_Confirmpass_txt
            // 
            this.reg_Confirmpass_txt.BackColor = System.Drawing.Color.SkyBlue;
            this.reg_Confirmpass_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Confirmpass_txt.Location = new System.Drawing.Point(20, 535);
            this.reg_Confirmpass_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg_Confirmpass_txt.Name = "reg_Confirmpass_txt";
            this.reg_Confirmpass_txt.PasswordChar = '*';
            this.reg_Confirmpass_txt.Size = new System.Drawing.Size(240, 27);
            this.reg_Confirmpass_txt.TabIndex = 22;
            // 
            // reg_Confirmpass_lbl
            // 
            this.reg_Confirmpass_lbl.AutoSize = true;
            this.reg_Confirmpass_lbl.BackColor = System.Drawing.Color.Transparent;
            this.reg_Confirmpass_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_Confirmpass_lbl.Location = new System.Drawing.Point(20, 510);
            this.reg_Confirmpass_lbl.Name = "reg_Confirmpass_lbl";
            this.reg_Confirmpass_lbl.Size = new System.Drawing.Size(157, 23);
            this.reg_Confirmpass_lbl.TabIndex = 23;
            this.reg_Confirmpass_lbl.Text = "Confirm password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 590);
            this.Controls.Add(this.reg_Confirmpass_lbl);
            this.Controls.Add(this.reg_Confirmpass_txt);
            this.Controls.Add(this.reg_pass_txt);
            this.Controls.Add(this.reg_pass_lbl);
            this.Controls.Add(this.reg_user_lbl);
            this.Controls.Add(this.reg_user_txt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.reg_submit_btn);
            this.Controls.Add(this.dateOfbirth);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtnationality);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nation);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label nation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.ComboBox txtnationality;
        private System.Windows.Forms.ComboBox txtgender;
        private System.Windows.Forms.Button reg_submit_btn;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DateTimePicker dateOfbirth;
        private System.Windows.Forms.TextBox reg_user_txt;
        private System.Windows.Forms.Label reg_user_lbl;
        private System.Windows.Forms.Label reg_pass_lbl;
        private System.Windows.Forms.TextBox reg_pass_txt;
        private System.Windows.Forms.TextBox reg_Confirmpass_txt;
        private System.Windows.Forms.Label reg_Confirmpass_lbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}