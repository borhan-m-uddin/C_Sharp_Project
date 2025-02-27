namespace CrystalOasis
{
    partial class Vehicle
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
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.V_typetxt = new System.Windows.Forms.ComboBox();
            this.V_brandtxt = new System.Windows.Forms.ComboBox();
            this.V_numbertxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirm_resbtn = new System.Windows.Forms.Button();
            this.V_colortxt = new System.Windows.Forms.TextBox();
            this.V_colorlbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(214, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 32);
            this.label11.TabIndex = 4;
            this.label11.Text = "Vehicle Info :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.V_colortxt);
            this.panel2.Controls.Add(this.V_colorlbl);
            this.panel2.Controls.Add(this.V_typetxt);
            this.panel2.Controls.Add(this.V_brandtxt);
            this.panel2.Controls.Add(this.V_numbertxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(2, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 354);
            this.panel2.TabIndex = 14;
            // 
            // V_typetxt
            // 
            this.V_typetxt.BackColor = System.Drawing.Color.SkyBlue;
            this.V_typetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_typetxt.FormattingEnabled = true;
            this.V_typetxt.Items.AddRange(new object[] {
            "MicroBus",
            "miniBus",
            "Private Car",
            "Sports Car",
            "Bus",
            "Motorcycle"});
            this.V_typetxt.Location = new System.Drawing.Point(23, 172);
            this.V_typetxt.Name = "V_typetxt";
            this.V_typetxt.Size = new System.Drawing.Size(248, 30);
            this.V_typetxt.TabIndex = 22;
            this.V_typetxt.Text = "Select your Vahicle Type";
            this.V_typetxt.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // V_brandtxt
            // 
            this.V_brandtxt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.V_brandtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_brandtxt.FormattingEnabled = true;
            this.V_brandtxt.Items.AddRange(new object[] {
            "Ford",
            "BMW",
            "TOYOTA",
            "Mercedes Benz",
            "Tesla",
            "Honda",
            "Nissan",
            "Hyundai",
            "Volkswagen",
            "Kia",
            "Porsche",
            "Audi",
            "BYD",
            "Ferrari",
            "General Motors",
            "Stellantis",
            "Chevrolet",
            "Subaru",
            "Lexus",
            "Mazda",
            "Renault",
            "SAIC Motor",
            "Tata Motors",
            "Volvo"});
            this.V_brandtxt.Location = new System.Drawing.Point(23, 104);
            this.V_brandtxt.Name = "V_brandtxt";
            this.V_brandtxt.Size = new System.Drawing.Size(248, 30);
            this.V_brandtxt.TabIndex = 21;
            this.V_brandtxt.Text = "Select your Vehicle Brand";
            this.V_brandtxt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // V_numbertxt
            // 
            this.V_numbertxt.BackColor = System.Drawing.Color.SkyBlue;
            this.V_numbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_numbertxt.Location = new System.Drawing.Point(23, 52);
            this.V_numbertxt.Name = "V_numbertxt";
            this.V_numbertxt.Size = new System.Drawing.Size(251, 28);
            this.V_numbertxt.TabIndex = 20;
            this.V_numbertxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Vehicle Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Vehicle Brand :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vehicle Number:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CrystalOasis.Properties.Resources.parking22;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(305, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 291);
            this.panel1.TabIndex = 14;
            // 
            // confirm_resbtn
            // 
            this.confirm_resbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.confirm_resbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_resbtn.Location = new System.Drawing.Point(211, 416);
            this.confirm_resbtn.Name = "confirm_resbtn";
            this.confirm_resbtn.Size = new System.Drawing.Size(208, 49);
            this.confirm_resbtn.TabIndex = 15;
            this.confirm_resbtn.Text = "Confirm Reservation";
            this.confirm_resbtn.UseVisualStyleBackColor = false;
            this.confirm_resbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // V_colortxt
            // 
            this.V_colortxt.BackColor = System.Drawing.Color.SkyBlue;
            this.V_colortxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_colortxt.Location = new System.Drawing.Point(23, 238);
            this.V_colortxt.Name = "V_colortxt";
            this.V_colortxt.Size = new System.Drawing.Size(251, 28);
            this.V_colortxt.TabIndex = 24;
            // 
            // V_colorlbl
            // 
            this.V_colorlbl.AutoSize = true;
            this.V_colorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_colorlbl.Location = new System.Drawing.Point(20, 212);
            this.V_colorlbl.Name = "V_colorlbl";
            this.V_colorlbl.Size = new System.Drawing.Size(114, 18);
            this.V_colorlbl.TabIndex = 23;
            this.V_colorlbl.Text = "Vehicle Color:";
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 477);
            this.Controls.Add(this.confirm_resbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox V_numbertxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button confirm_resbtn;
        private System.Windows.Forms.ComboBox V_typetxt;
        private System.Windows.Forms.ComboBox V_brandtxt;
        private System.Windows.Forms.TextBox V_colortxt;
        private System.Windows.Forms.Label V_colorlbl;
    }
}