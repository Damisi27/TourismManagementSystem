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
            addtourbtn = new Button();
            admintourtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            adminlocationtxt = new TextBox();
            label3 = new Label();
            pricetxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Updtourbtn = new Button();
            deltourbtn = new Button();
            backbtn = new Button();
            avadateTimePicker = new DateTimePicker();
            tourtypcomboBox = new ComboBox();
            SuspendLayout();
            // 
            // addtourbtn
            // 
            addtourbtn.BackColor = Color.SteelBlue;
            addtourbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addtourbtn.Location = new Point(289, 254);
            addtourbtn.Name = "addtourbtn";
            addtourbtn.Size = new Size(97, 37);
            addtourbtn.TabIndex = 0;
            addtourbtn.Text = "Add";
            addtourbtn.UseVisualStyleBackColor = false;
            // 
            // admintourtxt
            // 
            admintourtxt.Location = new Point(166, 56);
            admintourtxt.Name = "admintourtxt";
            admintourtxt.Size = new Size(208, 23);
            admintourtxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 59);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 2;
            label1.Text = "Tour Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 113);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Location:";
            // 
            // adminlocationtxt
            // 
            adminlocationtxt.Location = new Point(166, 114);
            adminlocationtxt.Name = "adminlocationtxt";
            adminlocationtxt.Size = new Size(208, 23);
            adminlocationtxt.TabIndex = 4;
            adminlocationtxt.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 172);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Ticket Price:";
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(166, 169);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(208, 23);
            pricetxt.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(440, 55);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 10;
            label5.Text = "Tour Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(440, 111);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 11;
            label6.Text = "Available Date:";
            // 
            // Updtourbtn
            // 
            Updtourbtn.BackColor = Color.SteelBlue;
            Updtourbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Updtourbtn.Location = new Point(453, 254);
            Updtourbtn.Name = "Updtourbtn";
            Updtourbtn.Size = new Size(97, 37);
            Updtourbtn.TabIndex = 13;
            Updtourbtn.Text = "Update";
            Updtourbtn.UseVisualStyleBackColor = false;
            // 
            // deltourbtn
            // 
            deltourbtn.BackColor = Color.SteelBlue;
            deltourbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deltourbtn.Location = new Point(640, 254);
            deltourbtn.Name = "deltourbtn";
            deltourbtn.Size = new Size(97, 37);
            deltourbtn.TabIndex = 14;
            deltourbtn.Text = "Delete";
            deltourbtn.UseVisualStyleBackColor = false;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.SteelBlue;
            backbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backbtn.Location = new Point(615, 381);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(122, 37);
            backbtn.TabIndex = 15;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            // 
            // avadateTimePicker
            // 
            avadateTimePicker.Location = new Point(550, 111);
            avadateTimePicker.Name = "avadateTimePicker";
            avadateTimePicker.Size = new Size(216, 23);
            avadateTimePicker.TabIndex = 16;
            // 
            // tourtypcomboBox
            // 
            tourtypcomboBox.FormattingEnabled = true;
            tourtypcomboBox.Location = new Point(550, 55);
            tourtypcomboBox.Name = "tourtypcomboBox";
            tourtypcomboBox.Size = new Size(216, 23);
            tourtypcomboBox.TabIndex = 17;
            // 
            // ManageTours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tourtypcomboBox);
            Controls.Add(avadateTimePicker);
            Controls.Add(backbtn);
            Controls.Add(deltourbtn);
            Controls.Add(Updtourbtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pricetxt);
            Controls.Add(label3);
            Controls.Add(adminlocationtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(admintourtxt);
            Controls.Add(addtourbtn);
            DoubleBuffered = true;
            Name = "ManageTours";
            Text = "Adminadd";
            Load += this.ManageTours_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addtourbtn;
        private TextBox admintourtxt;
        private Label label1;
        private Label label2;
        private TextBox adminlocationtxt;
        private Label label3;
        private TextBox pricetxt;
        private Label label5;
        private Label label6;
        private Button Updtourbtn;
        private Button deltourbtn;
        private Button backbtn;
        private DateTimePicker avadateTimePicker;
        private ComboBox tourtypcomboBox;
    }
}