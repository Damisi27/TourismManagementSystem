namespace LibraryManagementSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Usernlabel = new Label();
            Passwrdlabel = new Label();
            Username = new TextBox();
            Password = new TextBox();
            Loginbtn = new Button();
            Registerbtn = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Usernlabel
            // 
            Usernlabel.AutoSize = true;
            Usernlabel.BackColor = Color.Transparent;
            Usernlabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Usernlabel.Location = new Point(222, 180);
            Usernlabel.Name = "Usernlabel";
            Usernlabel.Size = new Size(88, 20);
            Usernlabel.TabIndex = 0;
            Usernlabel.Text = "Username: ";
            Usernlabel.Click += label1_Click;
            // 
            // Passwrdlabel
            // 
            Passwrdlabel.AutoSize = true;
            Passwrdlabel.BackColor = Color.Transparent;
            Passwrdlabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Passwrdlabel.Location = new Point(222, 231);
            Passwrdlabel.Name = "Passwrdlabel";
            Passwrdlabel.Size = new Size(84, 20);
            Passwrdlabel.TabIndex = 1;
            Passwrdlabel.Text = "Password: ";
            // 
            // Username
            // 
            Username.Location = new Point(344, 181);
            Username.Name = "Username";
            Username.Size = new Size(161, 23);
            Username.TabIndex = 2;
            Username.TextChanged += textBox1_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(344, 231);
            Password.Name = "Password";
            Password.Size = new Size(161, 23);
            Password.TabIndex = 3;
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.SteelBlue;
            Loginbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbtn.Location = new Point(240, 284);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(265, 38);
            Loginbtn.TabIndex = 4;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // Registerbtn
            // 
            Registerbtn.BackColor = Color.SteelBlue;
            Registerbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registerbtn.Location = new Point(155, 449);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(148, 36);
            Registerbtn.TabIndex = 5;
            Registerbtn.Text = "Sign Up";
            Registerbtn.UseVisualStyleBackColor = false;
            Registerbtn.Click += Registerbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(318, 119);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 7;
            label2.Text = "Sign in";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 458);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 8;
            label1.Text = "Create an account:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Calligraphy", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(189, 49);
            label3.Name = "label3";
            label3.Size = new Size(372, 45);
            label3.TabIndex = 9;
            label3.Text = "Welcome to Tourz";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(768, 488);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(Registerbtn);
            Controls.Add(Loginbtn);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(Passwrdlabel);
            Controls.Add(Usernlabel);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Usernlabel;
        private Label Passwrdlabel;
        private TextBox Username;
        private TextBox Password;
        private Button Loginbtn;
        private Button Registerbtn;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
