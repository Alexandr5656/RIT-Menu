using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            // TODO: Pull events data from JSON and add to array.
            // more info in CodeStream

            // load events from JSON & set it as the events list
            string eventsJSON = System.IO.File.ReadAllText(@"../../events.json");
            events = JsonConvert.DeserializeObject<List<Event>>(eventsJSON);

            // populate our category filter with all of the categories in the events list
            populateCategoryFilter();

            // make back button functional
            backButton.Click += new EventHandler(backHome);

            // event handler for file save
            saveEventsButton.Click += new EventHandler(saveEvents);

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

        private void saveEvents(object sender, EventArgs e)
        {

            string eventsJSON = JsonConvert.SerializeObject(events);

            System.IO.File.WriteAllText(@"../../events.json", eventsJSON);

            MessageBox.Show("Saved!");

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
    }
}
