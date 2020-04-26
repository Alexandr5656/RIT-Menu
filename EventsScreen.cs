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

            // FIXME: some demo events
            events.Add(new Event(
                "RIT Dance Festival",
                "Social events",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eleifend ullamcorper posuere. Donec velit nisi, tincidunt in placerat non, rutrum ut mi. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Donec blandit nibh libero, ut rhoncus massa elementum vitae. Praesent rhoncus feugiat nibh, a rutrum eros efficitur non.",
                new DateTime(2020, 5, 1, 8, 30, 0),
                new DateTime(2020, 5, 1, 12, 30, 0)
            ));

            events.Add(new Event(
                "RIT eSports Tournament",
                "Sports",
                "Lorem2 ipsum dolor sit amet, consectetur adipiscing elit. In eleifend ullamcorper posuere. Donec velit nisi, tincidunt in placerat non, rutrum ut mi. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Donec blandit nibh libero, ut rhoncus massa elementum vitae. Praesent rhoncus feugiat nibh, a rutrum eros efficitur non.",
                new DateTime(2020, 5, 5, 9, 30, 0),
                new DateTime(2020, 5, 5, 14, 25, 0)
            ));

            events.Add(new Event(
                "ASL Club Bake Sale",
                "Fundraising",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eleifend ullamcorper posuere. Donec velit nisi, tincidunt in placerat non, rutrum ut mi. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Donec blandit nibh libero, ut rhoncus massa elementum vitae. Praesent rhoncus feugiat nibh, a rutrum eros efficitur non.",
                new DateTime(2019, 5, 12, 15, 00, 0),
                new DateTime(2019, 5, 12, 19, 30, 0)
            ));

            // populate our category filter with all of the categories in the events list
            populateCategoryFilter();

            // make back button functional
            backButton.Click += new EventHandler(backHome);

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
