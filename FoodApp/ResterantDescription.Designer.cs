namespace FoodApp
{
    partial class ResterantDescription
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
            this.restName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Foods = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.favorite = new System.Windows.Forms.Button();
            this.descLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // restName
            // 
            this.restName.AutoSize = true;
            this.restName.Font = new System.Drawing.Font("Helvetica", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restName.Location = new System.Drawing.Point(467, 22);
            this.restName.Name = "restName";
            this.restName.Size = new System.Drawing.Size(203, 46);
            this.restName.TabIndex = 0;
            this.restName.Text = "Resturant";
            this.restName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1084, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1066, 526);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Foods
            // 
            this.Foods.AutoSize = true;
            this.Foods.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Foods.Location = new System.Drawing.Point(250, 250);
            this.Foods.Name = "Foods";
            this.Foods.Size = new System.Drawing.Size(104, 36);
            this.Foods.TabIndex = 3;
            this.Foods.Text = "Foods";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours.Location = new System.Drawing.Point(750, 250);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(100, 36);
            this.Hours.TabIndex = 4;
            this.Hours.Text = "Hours";
            // 
            // favorite
            // 
            this.favorite.FlatAppearance.BorderSize = 0;
            this.favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favorite.Image = global::FoodApp.Properties.Resources.star;
            this.favorite.Location = new System.Drawing.Point(676, 22);
            this.favorite.Name = "favorite";
            this.favorite.Size = new System.Drawing.Size(60, 60);
            this.favorite.TabIndex = 6;
            this.favorite.UseVisualStyleBackColor = false;
            this.favorite.Click += new System.EventHandler(this.favorite_Click);
            // 
            // descLB
            // 
            this.descLB.AutoSize = true;
            this.descLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLB.Location = new System.Drawing.Point(110, 89);
            this.descLB.Name = "descLB";
            this.descLB.Size = new System.Drawing.Size(109, 25);
            this.descLB.TabIndex = 8;
            this.descLB.Text = "Description";
            // 
            // ResterantDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 580);
            this.ControlBox = false;
            this.Controls.Add(this.descLB);
            this.Controls.Add(this.favorite);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.Foods);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.restName);
            this.Name = "ResterantDescription";
            this.ShowIcon = false;
            this.Text = "Resturant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label restName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Foods;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.Button favorite;
        private System.Windows.Forms.Label descLB;
    }
}