namespace TourismManagementSystem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            signbtn = new Button();
            nametxt = new TextBox();
            emailtxt = new TextBox();
            newusernametxt = new TextBox();
            passwordtxt = new TextBox();
            label6 = new Label();
            phonetxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 185);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 224);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 1;
            label2.Text = "Password: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(133, 110);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(133, 147);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Calligraphy", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(129, 42);
            label5.Name = "label5";
            label5.Size = new Size(286, 36);
            label5.TabIndex = 4;
            label5.Text = "Create an Acount";
            // 
            // signbtn
            // 
            signbtn.BackColor = Color.LightSlateGray;
            signbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signbtn.Location = new Point(133, 298);
            signbtn.Name = "signbtn";
            signbtn.Size = new Size(257, 41);
            signbtn.TabIndex = 6;
            signbtn.Text = "Login";
            signbtn.UseVisualStyleBackColor = false;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(218, 110);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(172, 23);
            nametxt.TabIndex = 7;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(218, 147);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(172, 23);
            emailtxt.TabIndex = 8;
            // 
            // newusernametxt
            // 
            newusernametxt.Location = new Point(218, 185);
            newusernametxt.Name = "newusernametxt";
            newusernametxt.Size = new Size(172, 23);
            newusernametxt.TabIndex = 9;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(218, 222);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(172, 23);
            passwordtxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(129, 262);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 11;
            label6.Text = "Phone No: ";
            // 
            // phonetxt
            // 
            phonetxt.Location = new Point(218, 257);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(172, 23);
            phonetxt.TabIndex = 12;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(656, 420);
            Controls.Add(phonetxt);
            Controls.Add(label6);
            Controls.Add(passwordtxt);
            Controls.Add(newusernametxt);
            Controls.Add(emailtxt);
            Controls.Add(nametxt);
            Controls.Add(signbtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button signbtn;
        private TextBox nametxt;
        private TextBox emailtxt;
        private TextBox newusernametxt;
        private TextBox passwordtxt;
        private Label label6;
        private TextBox phonetxt;
    }
}