namespace TourismManagementSystem
{
    partial class ManageTours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTours));
            Adminaddbtn = new Button();
            adminDelbtn = new Button();
            adminbackbtn = new Button();
            adminupdbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            touridtxt = new TextBox();
            locationtxt = new TextBox();
            transportxt = new TextBox();
            pricetxt = new TextBox();
            tourguidetxt = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tourdate = new DateTimePicker();
            tourtypecmb = new ComboBox();
            tournametxt = new TextBox();
            label9 = new Label();
            datedtp = new DateTimePicker();
            SuspendLayout();
            // 
            // Adminaddbtn
            // 
            Adminaddbtn.BackColor = Color.SteelBlue;
            Adminaddbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Adminaddbtn.Location = new Point(560, 183);
            Adminaddbtn.Name = "Adminaddbtn";
            Adminaddbtn.Size = new Size(91, 35);
            Adminaddbtn.TabIndex = 0;
            Adminaddbtn.Text = "Add";
            Adminaddbtn.UseVisualStyleBackColor = false;
            Adminaddbtn.Click += Adminaddbtn_Click;
            // 
            // adminDelbtn
            // 
            adminDelbtn.BackColor = Color.SteelBlue;
            adminDelbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminDelbtn.Location = new Point(560, 280);
            adminDelbtn.Name = "adminDelbtn";
            adminDelbtn.Size = new Size(91, 35);
            adminDelbtn.TabIndex = 1;
            adminDelbtn.Text = "Delete";
            adminDelbtn.UseVisualStyleBackColor = false;
            adminDelbtn.Click += adminDelbtn_Click;
            // 
            // adminbackbtn
            // 
            adminbackbtn.BackColor = Color.SteelBlue;
            adminbackbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminbackbtn.Location = new Point(701, 409);
            adminbackbtn.Name = "adminbackbtn";
            adminbackbtn.Size = new Size(75, 29);
            adminbackbtn.TabIndex = 2;
            adminbackbtn.Text = "Back";
            adminbackbtn.UseVisualStyleBackColor = false;
            adminbackbtn.Click += adminbackbtn_Click;
            // 
            // adminupdbtn
            // 
            adminupdbtn.BackColor = Color.SteelBlue;
            adminupdbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminupdbtn.Location = new Point(559, 227);
            adminupdbtn.Name = "adminupdbtn";
            adminupdbtn.Size = new Size(92, 35);
            adminupdbtn.TabIndex = 3;
            adminupdbtn.Text = "Update";
            adminupdbtn.UseVisualStyleBackColor = false;
            adminupdbtn.Click += adminupdbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 102);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 4;
            label1.Text = "Tourtypes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(116, 149);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Location:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(116, 198);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 6;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(116, 54);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 7;
            label4.Text = "TourID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(116, 239);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 8;
            label5.Text = "Transportation:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(121, 287);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 9;
            label6.Text = "Time:";
            // 
            // touridtxt
            // 
            touridtxt.Location = new Point(230, 51);
            touridtxt.Name = "touridtxt";
            touridtxt.Size = new Size(203, 23);
            touridtxt.TabIndex = 10;
            // 
            // locationtxt
            // 
            locationtxt.Location = new Point(230, 146);
            locationtxt.Name = "locationtxt";
            locationtxt.Size = new Size(203, 23);
            locationtxt.TabIndex = 12;
            // 
            // transportxt
            // 
            transportxt.Location = new Point(230, 239);
            transportxt.Name = "transportxt";
            transportxt.Size = new Size(203, 23);
            transportxt.TabIndex = 13;
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(230, 198);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(203, 23);
            pricetxt.TabIndex = 15;
            pricetxt.TextChanged += pricetxt_TextChanged;
            // 
            // tourguidetxt
            // 
            tourguidetxt.Location = new Point(230, 341);
            tourguidetxt.Name = "tourguidetxt";
            tourguidetxt.Size = new Size(203, 23);
            tourguidetxt.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(121, 340);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 17;
            label7.Text = "Tour Guide:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(116, 387);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 18;
            label8.Text = "Tour Date:";
            // 
            // tourdate
            // 
            tourdate.Location = new Point(230, 387);
            tourdate.Name = "tourdate";
            tourdate.Size = new Size(203, 23);
            tourdate.TabIndex = 19;
            // 
            // tourtypecmb
            // 
            tourtypecmb.FormattingEnabled = true;
            tourtypecmb.Location = new Point(230, 102);
            tourtypecmb.Name = "tourtypecmb";
            tourtypecmb.Size = new Size(203, 23);
            tourtypecmb.TabIndex = 20;
            // 
            // tournametxt
            // 
            tournametxt.Location = new Point(559, 51);
            tournametxt.Name = "tournametxt";
            tournametxt.Size = new Size(203, 23);
            tournametxt.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(468, 54);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 22;
            label9.Text = "Tour Name:";
            // 
            // datedtp
            // 
            datedtp.Location = new Point(230, 292);
            datedtp.Name = "datedtp";
            datedtp.Size = new Size(200, 23);
            datedtp.TabIndex = 23;
            // 
            // ManageTours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(datedtp);
            Controls.Add(label9);
            Controls.Add(tournametxt);
            Controls.Add(tourtypecmb);
            Controls.Add(tourdate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tourguidetxt);
            Controls.Add(pricetxt);
            Controls.Add(transportxt);
            Controls.Add(locationtxt);
            Controls.Add(touridtxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(adminupdbtn);
            Controls.Add(adminbackbtn);
            Controls.Add(adminDelbtn);
            Controls.Add(Adminaddbtn);
            DoubleBuffered = true;
            Name = "ManageTours";
            Text = "ManageTours";
            Load += ManageTours_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Adminaddbtn;
        private Button adminDelbtn;
        private Button adminbackbtn;
        private Button adminupdbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox touridtxt;
        private TextBox locationtxt;
        private TextBox transportxt;
        private TextBox pricetxt;
        private TextBox tourguidetxt;
        private Label label7;
        private Label label8;
        private DateTimePicker tourdate;
        private ComboBox tourtypecmb;
        private TextBox tournametxt;
        private Label label9;
        private DateTimePicker datedtp;
    }
}