namespace TourismManagementSystem
{
    partial class Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            label1 = new Label();
            displaycmb = new ComboBox();
            loadtable = new DataGridView();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)loadtable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 81);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Display:";
            // 
            // displaycmb
            // 
            displaycmb.FormattingEnabled = true;
            displaycmb.Location = new Point(223, 78);
            displaycmb.Name = "displaycmb";
            displaycmb.Size = new Size(214, 23);
            displaycmb.TabIndex = 1;
            displaycmb.SelectedIndexChanged += displaycmb_SelectedIndexChanged;
            // 
            // loadtable
            // 
            loadtable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loadtable.Location = new Point(129, 141);
            loadtable.Name = "loadtable";
            loadtable.Size = new Size(505, 266);
            loadtable.TabIndex = 2;
            loadtable.CellContentClick += loadtable_CellContentClick;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.SteelBlue;
            backbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.Location = new Point(692, 403);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(79, 35);
            backbtn.TabIndex = 3;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // Display
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(backbtn);
            Controls.Add(loadtable);
            Controls.Add(displaycmb);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Display";
            Text = "Display";
            Load += Display_Load;
            ((System.ComponentModel.ISupportInitialize)loadtable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox displaycmb;
        private DataGridView loadtable;
        private Button backbtn;
    }
}