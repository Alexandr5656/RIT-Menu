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
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxExample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventsTitle
            // 
            this.eventsTitle.AutoSize = true;
            this.eventsTitle.Font = new System.Drawing.Font("Arial", 27.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsTitle.Location = new System.Drawing.Point(27, 115);
            this.eventsTitle.Name = "eventsTitle";
            this.eventsTitle.Size = new System.Drawing.Size(734, 108);
            this.eventsTitle.TabIndex = 0;
            this.eventsTitle.Text = "Browse events:";
            this.eventsTitle.Click += new System.EventHandler(this.eventsTitle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBoxExample);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 282);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(1715, 818);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(1715, 818);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1715, 818);
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
            this.groupBoxExample.Location = new System.Drawing.Point(32, 33);
            this.groupBoxExample.Margin = new System.Windows.Forms.Padding(32, 33, 32, 33);
            this.groupBoxExample.Name = "groupBoxExample";
            this.groupBoxExample.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxExample.Size = new System.Drawing.Size(1619, 441);
            this.groupBoxExample.TabIndex = 0;
            this.groupBoxExample.TabStop = false;
            this.groupBoxExample.Text = "Event Name";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(395, 320);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(214, 39);
            this.time.TabIndex = 2;
            this.time.Text = "May 7, 2020";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addButton.Location = new System.Drawing.Point(1325, 79);
            this.addButton.Margin = new System.Windows.Forms.Padding(32, 50, 32, 33);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(232, 312);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "+ Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(395, 100);
            this.description.MaximumSize = new System.Drawing.Size(901, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(178, 32);
            this.description.TabIndex = 1;
            this.description.Text = "Lorem ipsum";
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.photo.Location = new System.Drawing.Point(35, 79);
            this.photo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(333, 312);
            this.photo.TabIndex = 0;
            this.photo.TabStop = false;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.saveEventsButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.mainToolStrip.Size = new System.Drawing.Size(1715, 52);
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
            this.backButton.Size = new System.Drawing.Size(112, 45);
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
            this.saveEventsButton.Size = new System.Drawing.Size(58, 45);
            this.saveEventsButton.Text = "toolStripButton1";
            // 
            // filter
            // 
            this.filter.DisplayMember = "All";
            this.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "All"});
            this.filter.Location = new System.Drawing.Point(811, 159);
            this.filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(385, 39);
            this.filter.TabIndex = 4;
            // 
            // EventsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 1105);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.eventsTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}
