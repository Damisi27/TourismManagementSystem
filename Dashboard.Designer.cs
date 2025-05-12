namespace TourismManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            packagesbtn = new Button();
            contactbtn = new Button();
            userlogout = new Button();
            paymentbtn = new Button();
            Hotelbtn = new Button();
            bookingsbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 50);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(packagesbtn);
            panel2.Controls.Add(contactbtn);
            panel2.Controls.Add(userlogout);
            panel2.Controls.Add(paymentbtn);
            panel2.Controls.Add(Hotelbtn);
            panel2.Controls.Add(bookingsbtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 563);
            panel2.TabIndex = 1;
            // 
            // packagesbtn
            // 
            packagesbtn.BackColor = Color.SteelBlue;
            packagesbtn.FlatStyle = FlatStyle.Popup;
            packagesbtn.Location = new Point(0, 16);
            packagesbtn.Name = "packagesbtn";
            packagesbtn.Size = new Size(187, 50);
            packagesbtn.TabIndex = 5;
            packagesbtn.Text = "Packages";
            packagesbtn.UseVisualStyleBackColor = false;
            // 
            // contactbtn
            // 
            contactbtn.BackColor = Color.SteelBlue;
            contactbtn.FlatStyle = FlatStyle.Popup;
            contactbtn.Location = new Point(-6, 309);
            contactbtn.Name = "contactbtn";
            contactbtn.Size = new Size(193, 50);
            contactbtn.TabIndex = 4;
            contactbtn.Text = "Contact Us";
            contactbtn.UseVisualStyleBackColor = false;
            // 
            // userlogout
            // 
            userlogout.BackColor = Color.SteelBlue;
            userlogout.FlatStyle = FlatStyle.Popup;
            userlogout.Location = new Point(-6, 388);
            userlogout.Name = "userlogout";
            userlogout.Size = new Size(193, 50);
            userlogout.TabIndex = 3;
            userlogout.Text = "Log out ";
            userlogout.UseVisualStyleBackColor = false;
            userlogout.Click += userlogout_Click;
            // 
            // paymentbtn
            // 
            paymentbtn.BackColor = Color.SteelBlue;
            paymentbtn.FlatStyle = FlatStyle.Popup;
            paymentbtn.Location = new Point(0, 228);
            paymentbtn.Name = "paymentbtn";
            paymentbtn.Size = new Size(187, 50);
            paymentbtn.TabIndex = 2;
            paymentbtn.Text = "Payment";
            paymentbtn.UseVisualStyleBackColor = false;
            // 
            // Hotelbtn
            // 
            Hotelbtn.BackColor = Color.SteelBlue;
            Hotelbtn.FlatStyle = FlatStyle.Popup;
            Hotelbtn.Location = new Point(0, 151);
            Hotelbtn.Name = "Hotelbtn";
            Hotelbtn.Size = new Size(187, 50);
            Hotelbtn.TabIndex = 1;
            Hotelbtn.Text = "Hotels";
            Hotelbtn.UseVisualStyleBackColor = false;
            Hotelbtn.Click += Hotelbtn_Click;
            // 
            // bookingsbtn
            // 
            bookingsbtn.BackColor = Color.SteelBlue;
            bookingsbtn.FlatStyle = FlatStyle.Popup;
            bookingsbtn.Location = new Point(0, 82);
            bookingsbtn.Name = "bookingsbtn";
            bookingsbtn.Size = new Size(187, 50);
            bookingsbtn.TabIndex = 0;
            bookingsbtn.Text = "Book Now";
            bookingsbtn.UseVisualStyleBackColor = false;
            bookingsbtn.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(560, 414);
            label2.Name = "label2";
            label2.Size = new Size(438, 152);
            label2.TabIndex = 1;
            label2.Text = "We provide you the best services,\r\n and ensure you have a smooth \r\nTourism vacation.\r\nMake your bookings now\r\n";
            label2.TextAlign = ContentAlignment.TopRight;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(325, 79);
            label3.Name = "label3";
            label3.Size = new Size(472, 84);
            label3.TabIndex = 2;
            label3.Text = "Welcome to Tourz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(383, 190);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(998, 613);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button userlogout;
        private Button paymentbtn;
        private Button Hotelbtn;
        private Button bookingsbtn;
        private Label label3;
        private Label label4;
        private Button contactbtn;
        private Button packagesbtn;
    }
}