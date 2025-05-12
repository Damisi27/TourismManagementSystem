namespace TourismManagementSystem
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            label1 = new Label();
            Admintoursbtn = new Button();
            Adminbookbtn = new Button();
            detailsbtn = new Button();
            logoutbtn = new Button();
            managereservebtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 53);
            label1.Name = "label1";
            label1.Size = new Size(271, 57);
            label1.TabIndex = 0;
            label1.Text = "Welome Admin";
            // 
            // Admintoursbtn
            // 
            Admintoursbtn.BackColor = Color.SteelBlue;
            Admintoursbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admintoursbtn.Location = new Point(84, 144);
            Admintoursbtn.Name = "Admintoursbtn";
            Admintoursbtn.Size = new Size(147, 48);
            Admintoursbtn.TabIndex = 1;
            Admintoursbtn.Text = "Manage Tours";
            Admintoursbtn.UseVisualStyleBackColor = false;
            Admintoursbtn.Click += Admintoursbtn_Click;
            // 
            // Adminbookbtn
            // 
            Adminbookbtn.BackColor = Color.SteelBlue;
            Adminbookbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Adminbookbtn.Location = new Point(157, 223);
            Adminbookbtn.Name = "Adminbookbtn";
            Adminbookbtn.Size = new Size(147, 48);
            Adminbookbtn.TabIndex = 2;
            Adminbookbtn.Text = "Manage Bookings";
            Adminbookbtn.UseVisualStyleBackColor = false;
            Adminbookbtn.Click += Adminbookbtn_Click;
            // 
            // detailsbtn
            // 
            detailsbtn.BackColor = Color.SteelBlue;
            detailsbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            detailsbtn.Location = new Point(307, 365);
            detailsbtn.Name = "detailsbtn";
            detailsbtn.Size = new Size(147, 48);
            detailsbtn.TabIndex = 3;
            detailsbtn.Text = "View Details";
            detailsbtn.UseVisualStyleBackColor = false;
            detailsbtn.Click += detailsbtn_Click;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.SteelBlue;
            logoutbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutbtn.Location = new Point(395, 435);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(147, 48);
            logoutbtn.TabIndex = 4;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // managereservebtn
            // 
            managereservebtn.BackColor = Color.SteelBlue;
            managereservebtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managereservebtn.Location = new Point(227, 297);
            managereservebtn.Name = "managereservebtn";
            managereservebtn.Size = new Size(147, 48);
            managereservebtn.TabIndex = 5;
            managereservebtn.Text = "Manage Reserves";
            managereservebtn.UseVisualStyleBackColor = false;
            managereservebtn.Click += button1_Click;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 507);
            Controls.Add(managereservebtn);
            Controls.Add(logoutbtn);
            Controls.Add(detailsbtn);
            Controls.Add(Adminbookbtn);
            Controls.Add(Admintoursbtn);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "AdminHome";
            Text = "AdminHome";
            Load += AdminHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Admintoursbtn;
        private Button Adminbookbtn;
        private Button detailsbtn;
        private Button logoutbtn;
        private Button managereservebtn;
    }
}