namespace TourismManagementSystem
{
    partial class ManageBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBookings));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cancelbookingbtn = new Button();
            addbookingbtn = new Button();
            backbtn = new Button();
            bookingIdcmb = new ComboBox();
            useridcmb = new ComboBox();
            countrylabel = new Label();
            countrycomboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            reservescmb = new ComboBox();
            transportcmb = new ComboBox();
            tourcmb = new ComboBox();
            label6 = new Label();
            datescmb = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 82);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Booking ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 131);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "User ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 170);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Booked dates:";
            // 
            // cancelbookingbtn
            // 
            cancelbookingbtn.BackColor = Color.SteelBlue;
            cancelbookingbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelbookingbtn.Location = new Point(436, 370);
            cancelbookingbtn.Name = "cancelbookingbtn";
            cancelbookingbtn.Size = new Size(140, 33);
            cancelbookingbtn.TabIndex = 3;
            cancelbookingbtn.Text = "Cancel Booking";
            cancelbookingbtn.UseVisualStyleBackColor = false;
            cancelbookingbtn.Click += cancelbookingbtn_Click;
            // 
            // addbookingbtn
            // 
            addbookingbtn.BackColor = Color.SteelBlue;
            addbookingbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbookingbtn.Location = new Point(259, 370);
            addbookingbtn.Name = "addbookingbtn";
            addbookingbtn.Size = new Size(128, 33);
            addbookingbtn.TabIndex = 4;
            addbookingbtn.Text = "Add booking";
            addbookingbtn.UseVisualStyleBackColor = false;
            addbookingbtn.Click += addbookingbtn_Click;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.SteelBlue;
            backbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.Location = new Point(685, 405);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(94, 33);
            backbtn.TabIndex = 5;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // bookingIdcmb
            // 
            bookingIdcmb.FormattingEnabled = true;
            bookingIdcmb.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            bookingIdcmb.Location = new Point(226, 79);
            bookingIdcmb.Name = "bookingIdcmb";
            bookingIdcmb.Size = new Size(179, 23);
            bookingIdcmb.TabIndex = 6;
            // 
            // useridcmb
            // 
            useridcmb.FormattingEnabled = true;
            useridcmb.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            useridcmb.Location = new Point(226, 124);
            useridcmb.Name = "useridcmb";
            useridcmb.Size = new Size(179, 23);
            useridcmb.TabIndex = 7;
            // 
            // countrylabel
            // 
            countrylabel.AutoSize = true;
            countrylabel.BackColor = Color.Transparent;
            countrylabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countrylabel.Location = new Point(100, 211);
            countrylabel.Name = "countrylabel";
            countrylabel.Size = new Size(63, 20);
            countrylabel.TabIndex = 9;
            countrylabel.Text = "Country:";
            // 
            // countrycomboBox
            // 
            countrycomboBox.FormattingEnabled = true;
            countrycomboBox.Items.AddRange(new object[] { "Greece", "United states of America", "United Kingdom", "China", "Maldlives", "Thailand", "South Korea", "Singapore", "Brasil", "Portugese", "Australia", "India", "Japan", "Indonesia", "Morocco", "Egypt", "United Emirates", "New Zealand", "Turkey", "Cyprus" });
            countrycomboBox.Location = new Point(226, 212);
            countrycomboBox.Name = "countrycomboBox";
            countrycomboBox.Size = new Size(179, 23);
            countrycomboBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(436, 82);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 11;
            label4.Text = "Available reserves:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(439, 127);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 12;
            label5.Text = "Transportation:";
            // 
            // reservescmb
            // 
            reservescmb.FormattingEnabled = true;
            reservescmb.Items.AddRange(new object[] { "Hilton Garden Inn", "The Grand Hotel", "Sunset Resort", "Coastal Suites", "Mountain View Lodge" });
            reservescmb.Location = new Point(573, 79);
            reservescmb.Name = "reservescmb";
            reservescmb.Size = new Size(168, 23);
            reservescmb.TabIndex = 13;
            // 
            // transportcmb
            // 
            transportcmb.FormattingEnabled = true;
            transportcmb.Items.AddRange(new object[] { "Bus", "Flight", "Train", "Cruise ", "Taxi " });
            transportcmb.Location = new Point(573, 128);
            transportcmb.Name = "transportcmb";
            transportcmb.Size = new Size(168, 23);
            transportcmb.TabIndex = 14;
            // 
            // tourcmb
            // 
            tourcmb.FormattingEnabled = true;
            tourcmb.Items.AddRange(new object[] { "Bus", "Flight", "Train", "Cruise ", "Taxi " });
            tourcmb.Location = new Point(573, 172);
            tourcmb.Name = "tourcmb";
            tourcmb.Size = new Size(168, 23);
            tourcmb.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(439, 172);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 16;
            label6.Text = "Tour ID:";
            // 
            // datescmb
            // 
            datescmb.Location = new Point(226, 168);
            datescmb.Name = "datescmb";
            datescmb.Size = new Size(179, 23);
            datescmb.TabIndex = 17;
            // 
            // ManageBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(datescmb);
            Controls.Add(label6);
            Controls.Add(tourcmb);
            Controls.Add(transportcmb);
            Controls.Add(reservescmb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(countrycomboBox);
            Controls.Add(countrylabel);
            Controls.Add(useridcmb);
            Controls.Add(bookingIdcmb);
            Controls.Add(backbtn);
            Controls.Add(addbookingbtn);
            Controls.Add(cancelbookingbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "ManageBookings";
            Text = "ManageBookings";
            Load += ManageBookings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button cancelbookingbtn;
        private Button addbookingbtn;
        private Button backbtn;
        private ComboBox bookingIdcmb;
        private ComboBox useridcmb;
        private Label countrylabel;
        private ComboBox countrycomboBox;
        private Label label4;
        private Label label5;
        private ComboBox reservescmb;
        private ComboBox transportcmb;
        private ComboBox tourcmb;
        private Label label6;
        private DateTimePicker datescmb;
    }
}