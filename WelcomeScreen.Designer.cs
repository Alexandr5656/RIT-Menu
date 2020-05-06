namespace RIT_Menu
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.openEventsButton = new System.Windows.Forms.Button();
            this.mainImages = new System.Windows.Forms.ImageList(this.components);
            this.openFoodButton = new System.Windows.Forms.Button();
            this.openCalendarButton = new System.Windows.Forms.Button();
            this.Rit = new System.Windows.Forms.Label();
            this.welcomeRITMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openEventsButton
            // 
            this.openEventsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openEventsButton.ImageKey = "pencil.png";
            this.openEventsButton.ImageList = this.mainImages;
            this.openEventsButton.Location = new System.Drawing.Point(232, 133);
            this.openEventsButton.Margin = new System.Windows.Forms.Padding(1);
            this.openEventsButton.Name = "openEventsButton";
            this.openEventsButton.Size = new System.Drawing.Size(161, 161);
            this.openEventsButton.TabIndex = 1;
            this.openEventsButton.Text = "Open Events Page";
            this.openEventsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openEventsButton.UseVisualStyleBackColor = true;
            this.openEventsButton.Click += new System.EventHandler(this.openEventsButton_Click);
            // 
            // mainImages
            // 
            this.mainImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainImages.ImageStream")));
            this.mainImages.TransparentColor = System.Drawing.Color.Transparent;
            this.mainImages.Images.SetKeyName(0, "food.png");
            this.mainImages.Images.SetKeyName(1, "calendar.png");
            this.mainImages.Images.SetKeyName(2, "pencil.png");
            // 
            // openFoodButton
            // 
            this.openFoodButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openFoodButton.ImageKey = "food.png";
            this.openFoodButton.ImageList = this.mainImages;
            this.openFoodButton.Location = new System.Drawing.Point(43, 133);
            this.openFoodButton.Margin = new System.Windows.Forms.Padding(1);
            this.openFoodButton.Name = "openFoodButton";
            this.openFoodButton.Size = new System.Drawing.Size(161, 161);
            this.openFoodButton.TabIndex = 2;
            this.openFoodButton.Text = "Food";
            this.openFoodButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openFoodButton.UseVisualStyleBackColor = true;
            // 
            // openCalendarButton
            // 
            this.openCalendarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openCalendarButton.ImageKey = "calendar.png";
            this.openCalendarButton.ImageList = this.mainImages;
            this.openCalendarButton.Location = new System.Drawing.Point(420, 133);
            this.openCalendarButton.Margin = new System.Windows.Forms.Padding(1);
            this.openCalendarButton.Name = "openCalendarButton";
            this.openCalendarButton.Size = new System.Drawing.Size(161, 161);
            this.openCalendarButton.TabIndex = 3;
            this.openCalendarButton.Text = "Open Calendar Page";
            this.openCalendarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openCalendarButton.UseVisualStyleBackColor = true;
            this.openCalendarButton.Click += new System.EventHandler(this.openCalendarButton_Click);
            // 
            // Rit
            // 
            this.Rit.BackColor = System.Drawing.Color.Black;
            this.Rit.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(105)))), ((int)(((byte)(2)))));
            this.Rit.Location = new System.Drawing.Point(0, 0);
            this.Rit.Name = "Rit";
            this.Rit.Size = new System.Drawing.Size(718, 103);
            this.Rit.TabIndex = 6;
            this.Rit.Text = "RIT";
            this.Rit.Click += new System.EventHandler(this.Rit_Click);
            // 
            // welcomeRITMenu
            // 
            this.welcomeRITMenu.AutoSize = true;
            this.welcomeRITMenu.BackColor = System.Drawing.SystemColors.ControlText;
            this.welcomeRITMenu.Font = new System.Drawing.Font("Arial", 27.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeRITMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.welcomeRITMenu.Location = new System.Drawing.Point(165, 31);
            this.welcomeRITMenu.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.welcomeRITMenu.Name = "welcomeRITMenu";
            this.welcomeRITMenu.Size = new System.Drawing.Size(416, 45);
            this.welcomeRITMenu.TabIndex = 7;
            this.welcomeRITMenu.Text = "Welcome to RIT Menu";
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 343);
            this.Controls.Add(this.welcomeRITMenu);
            this.Controls.Add(this.Rit);
            this.Controls.Add(this.openCalendarButton);
            this.Controls.Add(this.openFoodButton);
            this.Controls.Add(this.openEventsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "WelcomeScreen";
            this.Text = " RIT Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openEventsButton;
        private System.Windows.Forms.Button openFoodButton;
        private System.Windows.Forms.Button openCalendarButton;
        private System.Windows.Forms.Label Rit;
        private System.Windows.Forms.ImageList mainImages;
        private System.Windows.Forms.Label welcomeRITMenu;
    }
}

