namespace RIT_Menu
{
    partial class EventsScreen
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
            this.eventsTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxExample = new System.Windows.Forms.GroupBox();
            this.time = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.PictureBox();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.saveEventsButton = new System.Windows.Forms.ToolStripButton();
            this.filter = new System.Windows.Forms.ComboBox();
            this.Rit = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxExample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventsTitle
            // 
            this.eventsTitle.AutoSize = true;
            this.eventsTitle.BackColor = System.Drawing.SystemColors.ControlText;
            this.eventsTitle.Font = new System.Drawing.Font("Arial", 27.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.eventsTitle.Location = new System.Drawing.Point(157, 67);
            this.eventsTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.eventsTitle.Name = "eventsTitle";
            this.eventsTitle.Size = new System.Drawing.Size(287, 45);
            this.eventsTitle.TabIndex = 0;
            this.eventsTitle.Text = "Browse events";
            this.eventsTitle.Click += new System.EventHandler(this.eventsTitle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBoxExample);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 150);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(643, 343);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(643, 343);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(643, 343);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // groupBoxExample
            // 
            this.groupBoxExample.Controls.Add(this.time);
            this.groupBoxExample.Controls.Add(this.addButton);
            this.groupBoxExample.Controls.Add(this.description);
            this.groupBoxExample.Controls.Add(this.photo);
            this.groupBoxExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExample.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBoxExample.Location = new System.Drawing.Point(12, 14);
            this.groupBoxExample.Margin = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.groupBoxExample.Name = "groupBoxExample";
            this.groupBoxExample.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBoxExample.Size = new System.Drawing.Size(607, 185);
            this.groupBoxExample.TabIndex = 0;
            this.groupBoxExample.TabStop = false;
            this.groupBoxExample.Text = "Event Name";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(148, 134);
            this.time.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(97, 17);
            this.time.TabIndex = 2;
            this.time.Text = "May 7, 2020";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(105)))), ((int)(((byte)(2)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addButton.Location = new System.Drawing.Point(497, 33);
            this.addButton.Margin = new System.Windows.Forms.Padding(12, 21, 12, 14);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 131);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "+ Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(148, 42);
            this.description.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.description.MaximumSize = new System.Drawing.Size(338, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(66, 13);
            this.description.TabIndex = 1;
            this.description.Text = "Lorem ipsum";
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.photo.Location = new System.Drawing.Point(13, 33);
            this.photo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(125, 131);
            this.photo.TabIndex = 0;
            this.photo.TabStop = false;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.saveEventsButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.mainToolStrip.Size = new System.Drawing.Size(671, 27);
            this.mainToolStrip.TabIndex = 3;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(47, 44);
            this.backButton.Text = "< Back";
            this.backButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // saveEventsButton
            // 
            this.saveEventsButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveEventsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveEventsButton.Image = global::RIT_Menu.Properties.Resources.new_save;
            this.saveEventsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveEventsButton.Name = "saveEventsButton";
            this.saveEventsButton.Size = new System.Drawing.Size(24, 24);
            this.saveEventsButton.Text = "toolStripButton1";
            // 
            // filter
            // 
            this.filter.DisplayMember = "All";
            this.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "All"});
            this.filter.Location = new System.Drawing.Point(508, 91);
            this.filter.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(147, 21);
            this.filter.TabIndex = 4;
            // 
            // Rit
            // 
            this.Rit.BackColor = System.Drawing.Color.Black;
            this.Rit.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(105)))), ((int)(((byte)(2)))));
            this.Rit.Location = new System.Drawing.Point(0, 27);
            this.Rit.Name = "Rit";
            this.Rit.Size = new System.Drawing.Size(671, 103);
            this.Rit.TabIndex = 5;
            this.Rit.Text = "RIT";
            this.Rit.Click += new System.EventHandler(this.Rit_Click);
            // 
            // EventsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 502);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.eventsTitle);
            this.Controls.Add(this.Rit);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "EventsScreen";
            this.Text = "EventsScreen";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxExample.ResumeLayout(false);
            this.groupBoxExample.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventsTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxExample;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.ToolStripButton saveEventsButton;
        private System.Windows.Forms.Label Rit;
    }
}
