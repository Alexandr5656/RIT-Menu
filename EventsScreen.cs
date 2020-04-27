using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventsLib;
using Newtonsoft.Json;

namespace RIT_Menu
{
    public partial class EventsScreen : Form
    {
        List<Event> events = new List<Event>();

        public EventsScreen()
        {
            InitializeComponent();

            // hide our example group box
            this.groupBoxExample.Visible = false;

            // load events from JSON & set it as the events list
            string eventsJSON = System.IO.File.ReadAllText(@"../../events.json");
            events = JsonConvert.DeserializeObject<List<Event>>(eventsJSON);

            // populate our category filter with all of the categories in the events list
            populateCategoryFilter();

            // make back button functional
            backButton.Click += new EventHandler(backHome);

            // event handler for plus button
            addEventButton.Click += new EventHandler(newEventClick);

            // event handler for file save
            saveEventsButton.Click += new EventHandler(saveEvents);

            // display the events in the FlowLayoutPanel
            foreach (Event thisEvent in events)
            {

                addEventToList(thisEvent);

            }

        }

        private void populateCategoryFilter()
        {

            // make "All" the default selected item
            filter.SelectedItem = "All";

            // make a new list of categories
            List<string> eventTypes = new List<string>();

            foreach (Event thisEvent in events)
            {

                // check if this category hasn't been added to the filter
                if (!eventTypes.Contains(thisEvent.type))
                {

                    // add to the list for the dropdown
                    eventTypes.Add(thisEvent.type);

                }

            }

            // order alphabetically
            eventTypes.Sort();

            // add each item in list to filter
            filter.Items.AddRange(eventTypes.ToArray());

        }

        private void backHome(object sender, EventArgs e)
        {

            // i guess we will just close this window for now
            this.Close();

        }

        private void newEventClick(object sender, EventArgs e)
        {

            MessageBox.Show("This feature is coming soon :)");

        }

        private void saveEvents(object sender, EventArgs e)
        {

            string eventsJSON = JsonConvert.SerializeObject(events);

            System.IO.File.WriteAllText(@"../../events.json", eventsJSON);

            MessageBox.Show("Saved!");

        }

        private void addEventToList(Event thisEvent)
        {

            // make a new GroupBox by cloning of our demo one. thanks ControlFactory!
            Control newControl = ControlFactory.CloneCtrl(groupBoxExample);

            GroupBox thisGroupBox = (GroupBox)newControl;

            // show the GroupBox
            thisGroupBox.Show();

            // add our new GroupBox to the FlowLayoutPanel
            this.flowLayoutPanel1.Controls.Add(thisGroupBox);
            this.flowLayoutPanel1.Controls.SetChildIndex(thisGroupBox, flowLayoutPanel1.Controls.Count);

            // set the name to the event title
            thisGroupBox.Text = thisEvent.name;

            // copy the controls from the example GroupBox
            foreach (Control childControl in groupBoxExample.Controls)
            {

                Control newChildControl = ControlFactory.CloneCtrl(childControl);

                // show control & add to the groupbox
                newChildControl.Show();
                thisGroupBox.Controls.Add(newChildControl);
                thisGroupBox.Controls.SetChildIndex(newChildControl, thisGroupBox.Controls.Count);

            }

            // set the description
            Label description = (Label)thisGroupBox.Controls.Find("description", false)[0];
            description.Text = thisEvent.description;

            Console.WriteLine("imageURL is " + thisEvent.imageURL);

            // set the image URL if possible
            if (thisEvent.imageURL != null)
            {
                PictureBox photo = (PictureBox)thisGroupBox.Controls.Find("photo", false)[0];
                photo.ImageLocation = thisEvent.imageURL;
                photo.BackColor = Color.Blue;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void eventsTitle_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Rit_Click(object sender, EventArgs e)
        {

        }
    }
}
