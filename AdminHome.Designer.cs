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
            // 
            // detailsbtn
            // 
            detailsbtn.BackColor = Color.SteelBlue;
            detailsbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            detailsbtn.Location = new Point(202, 298);
            detailsbtn.Name = "detailsbtn";
            detailsbtn.Size = new Size(147, 48);
            detailsbtn.TabIndex = 3;
            detailsbtn.Text = "View Details";
            detailsbtn.UseVisualStyleBackColor = false;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.SteelBlue;
            logoutbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutbtn.Location = new Point(247, 375);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(147, 48);
            logoutbtn.TabIndex = 4;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 507);
            Controls.Add(logoutbtn);
            Controls.Add(detailsbtn);
            Controls.Add(Adminbookbtn);
            Controls.Add(Admintoursbtn);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "AdminHome";
            Text = "AdminHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Admintoursbtn;
        private Button Adminbookbtn;
        private Button detailsbtn;
        private Button logoutbtn;
    }
}