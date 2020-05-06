namespace RIT_Menu
{
    partial class RestaurantList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantList));
            this.Rit = new System.Windows.Forms.Label();
            this.Favorites = new System.Windows.Forms.Label();
            this.suggestedGB = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.allGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openedLabel = new System.Windows.Forms.Label();
            this.dinnerLabel = new System.Windows.Forms.Label();
            this.lunchLabel = new System.Windows.Forms.Label();
            this.breakfastLabel = new System.Windows.Forms.Label();
            this.specialThree = new System.Windows.Forms.Label();
            this.specialTwo = new System.Windows.Forms.Label();
            this.SpecialOne = new System.Windows.Forms.Label();
            this.specialLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cashLabel = new System.Windows.Forms.Label();
            this.restLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.restCheck = new System.Windows.Forms.CheckedListBox();
            this.showOpen = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBT = new System.Windows.Forms.Button();
            this.suggestedGB.SuspendLayout();
            this.allGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rit
            // 
            this.Rit.BackColor = System.Drawing.Color.Black;
            this.Rit.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(105)))), ((int)(((byte)(2)))));
            this.Rit.Location = new System.Drawing.Point(0, -2);
            this.Rit.Name = "Rit";
            this.Rit.Size = new System.Drawing.Size(1188, 133);
            this.Rit.TabIndex = 0;
            this.Rit.Text = "RIT";
            this.Rit.Click += new System.EventHandler(this.Rit_Click);
            // 
            // Favorites
            // 
            this.Favorites.AutoSize = true;
            this.Favorites.BackColor = System.Drawing.Color.Transparent;
            this.Favorites.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Favorites.ForeColor = System.Drawing.Color.Black;
            this.Favorites.Location = new System.Drawing.Point(432, 176);
            this.Favorites.Name = "Favorites";
            this.Favorites.Size = new System.Drawing.Size(371, 59);
            this.Favorites.TabIndex = 2;
            this.Favorites.Text = "Your Favorites";
            this.Favorites.Click += new System.EventHandler(this.suggestedLabel_Click);
            // 
            // suggestedGB
            // 
            this.suggestedGB.BackColor = System.Drawing.Color.Transparent;
            this.suggestedGB.Controls.Add(this.flowLayoutPanel2);
            this.suggestedGB.Location = new System.Drawing.Point(50, 250);
            this.suggestedGB.Name = "suggestedGB";
            this.suggestedGB.Size = new System.Drawing.Size(1100, 327);
            this.suggestedGB.TabIndex = 3;
            this.suggestedGB.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1094, 306);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // allGroupBox
            // 
            this.allGroupBox.Controls.Add(this.panel1);
            this.allGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.allGroupBox.Location = new System.Drawing.Point(50, 650);
            this.allGroupBox.MaximumSize = new System.Drawing.Size(1100, 2000);
            this.allGroupBox.Name = "allGroupBox";
            this.allGroupBox.Size = new System.Drawing.Size(1100, 2000);
            this.allGroupBox.TabIndex = 5;
            this.allGroupBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.openedLabel);
            this.panel1.Controls.Add(this.dinnerLabel);
            this.panel1.Controls.Add(this.lunchLabel);
            this.panel1.Controls.Add(this.breakfastLabel);
            this.panel1.Controls.Add(this.specialThree);
            this.panel1.Controls.Add(this.specialTwo);
            this.panel1.Controls.Add(this.SpecialOne);
            this.panel1.Controls.Add(this.specialLabel);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.cashLabel);
            this.panel1.Controls.Add(this.restLabel);
            this.panel1.Location = new System.Drawing.Point(15, 21);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(400, 238);
            this.panel1.TabIndex = 0;
            // 
            // openedLabel
            // 
            this.openedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openedLabel.Location = new System.Drawing.Point(167, 13);
            this.openedLabel.Name = "openedLabel";
            this.openedLabel.Size = new System.Drawing.Size(100, 23);
            this.openedLabel.TabIndex = 10;
            this.openedLabel.Text = "Resturant";
            // 
            // dinnerLabel
            // 
            this.dinnerLabel.AutoSize = true;
            this.dinnerLabel.Location = new System.Drawing.Point(320, 202);
            this.dinnerLabel.Name = "dinnerLabel";
            this.dinnerLabel.Size = new System.Drawing.Size(50, 17);
            this.dinnerLabel.TabIndex = 9;
            this.dinnerLabel.Text = "Dinner";
            // 
            // lunchLabel
            // 
            this.lunchLabel.AutoSize = true;
            this.lunchLabel.Location = new System.Drawing.Point(320, 174);
            this.lunchLabel.Name = "lunchLabel";
            this.lunchLabel.Size = new System.Drawing.Size(47, 17);
            this.lunchLabel.TabIndex = 8;
            this.lunchLabel.Text = "Lunch";
            // 
            // breakfastLabel
            // 
            this.breakfastLabel.AutoSize = true;
            this.breakfastLabel.Location = new System.Drawing.Point(320, 141);
            this.breakfastLabel.Name = "breakfastLabel";
            this.breakfastLabel.Size = new System.Drawing.Size(68, 17);
            this.breakfastLabel.TabIndex = 7;
            this.breakfastLabel.Text = "Breakfast";
            // 
            // specialThree
            // 
            this.specialThree.AutoSize = true;
            this.specialThree.Location = new System.Drawing.Point(39, 209);
            this.specialThree.Name = "specialThree";
            this.specialThree.Size = new System.Drawing.Size(46, 17);
            this.specialThree.TabIndex = 6;
            this.specialThree.Text = "label8";
            // 
            // specialTwo
            // 
            this.specialTwo.AutoSize = true;
            this.specialTwo.Location = new System.Drawing.Point(39, 174);
            this.specialTwo.Name = "specialTwo";
            this.specialTwo.Size = new System.Drawing.Size(46, 17);
            this.specialTwo.TabIndex = 5;
            this.specialTwo.Text = "label7";
            // 
            // SpecialOne
            // 
            this.SpecialOne.AutoSize = true;
            this.SpecialOne.Location = new System.Drawing.Point(39, 140);
            this.SpecialOne.Name = "SpecialOne";
            this.SpecialOne.Size = new System.Drawing.Size(46, 17);
            this.SpecialOne.TabIndex = 4;
            this.SpecialOne.Text = "label6";
            // 
            // specialLabel
            // 
            this.specialLabel.AutoSize = true;
            this.specialLabel.Location = new System.Drawing.Point(39, 102);
            this.specialLabel.Name = "specialLabel";
            this.specialLabel.Size = new System.Drawing.Size(61, 17);
            this.specialLabel.TabIndex = 3;
            this.specialLabel.Text = "Specials";
            // 
            // addButton
            // 
            this.addButton.ImageList = this.imageList1;
            this.addButton.Location = new System.Drawing.Point(320, -2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(78, 66);
            this.addButton.TabIndex = 2;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "minus.gif");
            this.imageList1.Images.SetKeyName(1, "plus.gif");
            // 
            // cashLabel
            // 
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.Location = new System.Drawing.Point(167, 202);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(57, 27);
            this.cashLabel.TabIndex = 1;
            this.cashLabel.Text = "$$$";
            // 
            // restLabel
            // 
            this.restLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restLabel.Location = new System.Drawing.Point(-14, 13);
            this.restLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.restLabel.Name = "restLabel";
            this.restLabel.Size = new System.Drawing.Size(100, 23);
            this.restLabel.TabIndex = 0;
            this.restLabel.Text = "Resturant";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1094, 1979);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // restCheck
            // 
            this.restCheck.BackColor = System.Drawing.Color.Black;
            this.restCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.restCheck.CheckOnClick = true;
            this.restCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(105)))), ((int)(((byte)(2)))));
            this.restCheck.FormattingEnabled = true;
            this.restCheck.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Coffee",
            "Take-Out",
            "Dine-In",
            "All"});
            this.restCheck.Location = new System.Drawing.Point(1056, 9);
            this.restCheck.Name = "restCheck";
            this.restCheck.Size = new System.Drawing.Size(101, 119);
            this.restCheck.TabIndex = 6;
            this.restCheck.SelectedIndexChanged += new System.EventHandler(this.restCheck_SelectedIndexChanged);
            // 
            // showOpen
            // 
            this.showOpen.Appearance = System.Windows.Forms.Appearance.Button;
            this.showOpen.AutoSize = true;
            this.showOpen.BackColor = System.Drawing.Color.White;
            this.showOpen.Location = new System.Drawing.Point(956, 134);
            this.showOpen.Name = "showOpen";
            this.showOpen.Size = new System.Drawing.Size(201, 27);
            this.showOpen.TabIndex = 7;
            this.showOpen.Text = "Showing Opened and Closed";
            this.showOpen.UseVisualStyleBackColor = false;
            this.showOpen.CheckedChanged += new System.EventHandler(this.ShowClosed_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(349, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(557, 76);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Resturant Menus";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(442, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "All Locations";
            // 
            // exitBT
            // 
            this.exitBT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitBT.Location = new System.Drawing.Point(20, 134);
            this.exitBT.Name = "exitBT";
            this.exitBT.Size = new System.Drawing.Size(94, 48);
            this.exitBT.TabIndex = 10;
            this.exitBT.Text = "Exit";
            this.exitBT.UseVisualStyleBackColor = false;
            this.exitBT.Click += new System.EventHandler(this.exitBT_Click);
            // 
            // RestaurantList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.ControlBox = false;
            this.Controls.Add(this.exitBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.showOpen);
            this.Controls.Add(this.restCheck);
            this.Controls.Add(this.suggestedGB);
            this.Controls.Add(this.Favorites);
            this.Controls.Add(this.allGroupBox);
            this.Controls.Add(this.Rit);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "RestaurantList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RestaurantList_Load);
            this.suggestedGB.ResumeLayout(false);
            this.allGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rit;
        private System.Windows.Forms.Label Favorites;
        private System.Windows.Forms.GroupBox suggestedGB;
        private System.Windows.Forms.GroupBox allGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label openedLabel;
        private System.Windows.Forms.Label dinnerLabel;
        private System.Windows.Forms.Label lunchLabel;
        private System.Windows.Forms.Label breakfastLabel;
        private System.Windows.Forms.Label specialThree;
        private System.Windows.Forms.Label specialTwo;
        private System.Windows.Forms.Label SpecialOne;
        private System.Windows.Forms.Label specialLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label restLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckedListBox restCheck;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox showOpen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBT;
    }
}
