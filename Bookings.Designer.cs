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
            toutypecomboBox = new ComboBox();
            countrycomboBox = new ComboBox();
            noofpeopletxt = new TextBox();
            departdateTimePicker = new DateTimePicker();
            noofdaystxt = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 111);
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
            label2.Location = new Point(159, 163);
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
            label3.Location = new Point(159, 207);
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
            Bookbtn.Location = new Point(466, 359);
            Bookbtn.Name = "Bookbtn";
            Bookbtn.Size = new Size(96, 33);
            Bookbtn.TabIndex = 5;
            Bookbtn.Text = "Book ";
            Bookbtn.UseVisualStyleBackColor = false;
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.SteelBlue;
            Backbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.Location = new Point(282, 359);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(89, 33);
            Backbtn.TabIndex = 6;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            // 
            // toutypecomboBox
            // 
            toutypecomboBox.FormattingEnabled = true;
            toutypecomboBox.Items.AddRange(new object[] { "Adventure", "Historical", "Academic", "Sight seeing", "Cruise", "Speciaty" });
            toutypecomboBox.Location = new Point(312, 109);
            toutypecomboBox.Name = "toutypecomboBox";
            toutypecomboBox.Size = new Size(250, 23);
            toutypecomboBox.TabIndex = 7;
            // 
            // countrycomboBox
            // 
            countrycomboBox.FormattingEnabled = true;
            countrycomboBox.Items.AddRange(new object[] { "Greece", "United states of America", "United Kingdom", "China", "Maldlives", "Thailand", "South Korea", "Singapore", "Brasil", "Portugese", "Australia", "India", "Japan", "Indonesia", "Morocco", "Egypt", "United Emirates", "New Zealand", "Turkey", "Cyprus" });
            countrycomboBox.Location = new Point(312, 161);
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
            noofdaystxt.Location = new Point(312, 205);
            noofdaystxt.Name = "noofdaystxt";
            noofdaystxt.Size = new Size(250, 23);
            noofdaystxt.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(159, 25);
            label6.Name = "label6";
            label6.Size = new Size(264, 43);
            label6.TabIndex = 12;
            label6.Text = "Make your Bookings";
            // 
            // Bookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(noofdaystxt);
            Controls.Add(departdateTimePicker);
            Controls.Add(noofpeopletxt);
            Controls.Add(countrycomboBox);
            Controls.Add(toutypecomboBox);
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
        private ComboBox toutypecomboBox;
        private ComboBox countrycomboBox;
        private TextBox noofpeopletxt;
        private DateTimePicker departdateTimePicker;
        private TextBox noofdaystxt;
        private Label label6;
    }
}