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
            this.label1 = new System.Windows.Forms.Label();
            this.openEventsButton = new System.Windows.Forms.Button();
            this.openFoodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to RIT Menu";
            // 
            // openEventsButton
            // 
            this.openEventsButton.Location = new System.Drawing.Point(262, 303);
            this.openEventsButton.Name = "openEventsButton";
            this.openEventsButton.Size = new System.Drawing.Size(358, 160);
            this.openEventsButton.TabIndex = 1;
            this.openEventsButton.Text = "Open Events Page";
            this.openEventsButton.UseVisualStyleBackColor = true;
            this.openEventsButton.Click += new System.EventHandler(this.openEventsButton_Click);
            // 
            // openFoodButton
            // 
            this.openFoodButton.Location = new System.Drawing.Point(798, 303);
            this.openFoodButton.Name = "openFoodButton";
            this.openFoodButton.Size = new System.Drawing.Size(424, 145);
            this.openFoodButton.TabIndex = 2;
            this.openFoodButton.Text = "Open Food Button";
            this.openFoodButton.UseVisualStyleBackColor = true;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 819);
            this.Controls.Add(this.openFoodButton);
            this.Controls.Add(this.openEventsButton);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeScreen";
            this.Text = "WelcomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openEventsButton;
        private System.Windows.Forms.Button openFoodButton;
    }
}

