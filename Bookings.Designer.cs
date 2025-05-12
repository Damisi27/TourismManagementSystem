namespace TourismManagementSystem
{
    partial class Bookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookings));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Bookbtn = new Button();
            Backbtn = new Button();
            tourtypecmb = new ComboBox();
            countrycomboBox = new ComboBox();
            noofpeopletxt = new TextBox();
            departdateTimePicker = new DateTimePicker();
            noofdaystxt = new TextBox();
            label6 = new Label();
            reservecmb = new ComboBox();
            transportcmb = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            usercmb = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            tourcmb = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 133);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 0;
            label1.Text = "Tour Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 168);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Country:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(159, 217);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 2;
            label3.Text = "No of Days:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(159, 298);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 3;
            label4.Text = "Number of People:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(159, 253);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 4;
            label5.Text = "Departure Date:";
            // 
            // Bookbtn
            // 
            Bookbtn.BackColor = Color.SteelBlue;
            Bookbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bookbtn.Location = new Point(635, 156);
            Bookbtn.Name = "Bookbtn";
            Bookbtn.Size = new Size(96, 33);
            Bookbtn.TabIndex = 5;
            Bookbtn.Text = "Book ";
            Bookbtn.UseVisualStyleBackColor = false;
            Bookbtn.Click += Bookbtn_Click;
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.SteelBlue;
            Backbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.Location = new Point(642, 215);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(89, 33);
            Backbtn.TabIndex = 6;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // tourtypecmb
            // 
            tourtypecmb.FormattingEnabled = true;
            tourtypecmb.Items.AddRange(new object[] { "Adventure", "Historical", "Educational", "Sight seeing", "Religious", "Cultural" });
            tourtypecmb.Location = new Point(312, 135);
            tourtypecmb.Name = "tourtypecmb";
            tourtypecmb.Size = new Size(250, 23);
            tourtypecmb.TabIndex = 7;
            // 
            // countrycomboBox
            // 
            countrycomboBox.FormattingEnabled = true;
            countrycomboBox.Items.AddRange(new object[] { "Greece", "United states of America", "United Kingdom", "China", "Maldlives", "Thailand", "South Korea", "Singapore", "Brasil", "Portugese", "Australia", "India", "Japan", "Indonesia", "Morocco", "Egypt", "United Emirates", "New Zealand", "Turkey", "Cyprus" });
            countrycomboBox.Location = new Point(312, 170);
            countrycomboBox.Name = "countrycomboBox";
            countrycomboBox.Size = new Size(250, 23);
            countrycomboBox.TabIndex = 8;
            // 
            // noofpeopletxt
            // 
            noofpeopletxt.Location = new Point(312, 296);
            noofpeopletxt.Name = "noofpeopletxt";
            noofpeopletxt.Size = new Size(250, 23);
            noofpeopletxt.TabIndex = 9;
            // 
            // departdateTimePicker
            // 
            departdateTimePicker.AllowDrop = true;
            departdateTimePicker.Location = new Point(312, 252);
            departdateTimePicker.Name = "departdateTimePicker";
            departdateTimePicker.Size = new Size(250, 23);
            departdateTimePicker.TabIndex = 10;
            // 
            // noofdaystxt
            // 
            noofdaystxt.Location = new Point(312, 215);
            noofdaystxt.Name = "noofdaystxt";
            noofdaystxt.Size = new Size(250, 23);
            noofdaystxt.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 9);
            label6.Name = "label6";
            label6.Size = new Size(264, 43);
            label6.TabIndex = 12;
            label6.Text = "Make your Bookings";
            // 
            // reservecmb
            // 
            reservecmb.FormattingEnabled = true;
            reservecmb.Items.AddRange(new object[] { "Greece", "United states of America", "United Kingdom", "China", "Maldlives", "Thailand", "South Korea", "Singapore", "Brasil", "Portugese", "Australia", "India", "Japan", "Indonesia", "Morocco", "Egypt", "United Emirates", "New Zealand", "Turkey", "Cyprus" });
            reservecmb.Location = new Point(312, 339);
            reservecmb.Name = "reservecmb";
            reservecmb.Size = new Size(250, 23);
            reservecmb.TabIndex = 13;
            // 
            // transportcmb
            // 
            transportcmb.FormattingEnabled = true;
            transportcmb.Location = new Point(312, 380);
            transportcmb.Name = "transportcmb";
            transportcmb.Size = new Size(250, 23);
            transportcmb.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(159, 339);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 15;
            label7.Text = "Reservation:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(159, 380);
            label8.Name = "label8";
            label8.Size = new Size(114, 21);
            label8.TabIndex = 16;
            label8.Text = "Transportation:";
            // 
            // usercmb
            // 
            usercmb.FormattingEnabled = true;
            usercmb.Location = new Point(312, 69);
            usercmb.Name = "usercmb";
            usercmb.Size = new Size(250, 23);
            usercmb.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(159, 71);
            label9.Name = "label9";
            label9.Size = new Size(45, 21);
            label9.TabIndex = 18;
            label9.Text = "User:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(159, 100);
            label10.Name = "label10";
            label10.Size = new Size(60, 21);
            label10.TabIndex = 19;
            label10.Text = "Tour id:";
            // 
            // tourcmb
            // 
            tourcmb.FormattingEnabled = true;
            tourcmb.Location = new Point(312, 98);
            tourcmb.Name = "tourcmb";
            tourcmb.Size = new Size(250, 23);
            tourcmb.TabIndex = 20;
            // 
            // Bookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tourcmb);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(usercmb);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(transportcmb);
            Controls.Add(reservecmb);
            Controls.Add(label6);
            Controls.Add(noofdaystxt);
            Controls.Add(departdateTimePicker);
            Controls.Add(noofpeopletxt);
            Controls.Add(countrycomboBox);
            Controls.Add(tourtypecmb);
            Controls.Add(Backbtn);
            Controls.Add(Bookbtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Bookings";
            Text = "Bookings";
            Load += Bookings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Bookbtn;
        private Button Backbtn;
        private ComboBox tourtypecmb;
        private ComboBox countrycomboBox;
        private TextBox noofpeopletxt;
        private DateTimePicker departdateTimePicker;
        private TextBox noofdaystxt;
        private Label label6;
        private ComboBox reservecmb;
        private ComboBox transportcmb;
        private Label label7;
        private Label label8;
        private ComboBox usercmb;
        private Label label9;
        private Label label10;
        private ComboBox tourcmb;
    }
}