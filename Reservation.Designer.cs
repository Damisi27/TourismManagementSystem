namespace TourismManagementSystem
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            reserveidcmb = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            updatebtn = new Button();
            reservebtn = new Button();
            backbtn = new Button();
            datein = new DateTimePicker();
            dateout = new DateTimePicker();
            locationtxt = new TextBox();
            pricetxt = new TextBox();
            label5 = new Label();
            reserveidtxt = new TextBox();
            label1 = new Label();
            nametxt = new TextBox();
            SuspendLayout();
            // 
            // reserveidcmb
            // 
            reserveidcmb.AutoSize = true;
            reserveidcmb.BackColor = Color.Transparent;
            reserveidcmb.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reserveidcmb.Location = new Point(170, 118);
            reserveidcmb.Name = "reserveidcmb";
            reserveidcmb.Size = new Size(82, 20);
            reserveidcmb.TabIndex = 0;
            reserveidcmb.Text = "Reserve ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 190);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Location:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(170, 231);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Date in:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 270);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Date out:";
            // 
            // updatebtn
            // 
            updatebtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.Location = new Point(438, 374);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(130, 32);
            updatebtn.TabIndex = 4;
            updatebtn.Text = "Update Reserve";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += paymentbtn_Click;
            // 
            // reservebtn
            // 
            reservebtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reservebtn.ImageAlign = ContentAlignment.BottomLeft;
            reservebtn.Location = new Point(260, 374);
            reservebtn.Name = "reservebtn";
            reservebtn.Size = new Size(119, 32);
            reservebtn.TabIndex = 5;
            reservebtn.Text = "Add Reserve";
            reservebtn.UseVisualStyleBackColor = true;
            reservebtn.Click += reservebtn_Click;
            // 
            // backbtn
            // 
            backbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.Location = new Point(690, 400);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(80, 28);
            backbtn.TabIndex = 6;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // datein
            // 
            datein.Location = new Point(276, 228);
            datein.Name = "datein";
            datein.Size = new Size(200, 23);
            datein.TabIndex = 7;
            // 
            // dateout
            // 
            dateout.Location = new Point(276, 270);
            dateout.Name = "dateout";
            dateout.Size = new Size(200, 23);
            dateout.TabIndex = 8;
            // 
            // locationtxt
            // 
            locationtxt.Location = new Point(276, 187);
            locationtxt.Name = "locationtxt";
            locationtxt.Size = new Size(200, 23);
            locationtxt.TabIndex = 11;
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(276, 309);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(200, 23);
            pricetxt.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(170, 312);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 13;
            label5.Text = "Price:";
            // 
            // reserveidtxt
            // 
            reserveidtxt.Location = new Point(276, 115);
            reserveidtxt.Name = "reserveidtxt";
            reserveidtxt.Size = new Size(200, 23);
            reserveidtxt.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 160);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 15;
            label1.Text = "Client name:";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(276, 148);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(200, 23);
            nametxt.TabIndex = 16;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(877, 456);
            Controls.Add(nametxt);
            Controls.Add(label1);
            Controls.Add(reserveidtxt);
            Controls.Add(label5);
            Controls.Add(pricetxt);
            Controls.Add(locationtxt);
            Controls.Add(dateout);
            Controls.Add(datein);
            Controls.Add(backbtn);
            Controls.Add(reservebtn);
            Controls.Add(updatebtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(reserveidcmb);
            DoubleBuffered = true;
            Name = "Reservation";
            Text = "Reservation";
            Load += Reservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label reserveidcmb;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button updatebtn;
        private Button reservebtn;
        private Button backbtn;
        private DateTimePicker datein;
        private DateTimePicker dateout;
        private ComboBox comboBox1;
        private TextBox locationtxt;
        private TextBox pricetxt;
        private Label label5;
        private TextBox reserveidtxt;
        private Label label1;
        private TextBox nametxt;
    }
}