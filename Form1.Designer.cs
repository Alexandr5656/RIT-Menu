namespace RIT_Menu
{
    partial class AddingEvent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.startTB = new System.Windows.Forms.TextBox();
            this.endTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Time Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event Time End";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(202, 93);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(165, 22);
            this.nameTB.TabIndex = 3;
            // 
            // startTB
            // 
            this.startTB.Location = new System.Drawing.Point(202, 145);
            this.startTB.Name = "startTB";
            this.startTB.Size = new System.Drawing.Size(165, 22);
            this.startTB.TabIndex = 4;
            // 
            // endTB
            // 
            this.endTB.Location = new System.Drawing.Point(202, 201);
            this.endTB.Name = "endTB";
            this.endTB.Size = new System.Drawing.Size(165, 22);
            this.endTB.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddingEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 379);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endTB);
            this.Controls.Add(this.startTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddingEvent";
            this.Text = "Add Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox startTB;
        private System.Windows.Forms.TextBox endTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}