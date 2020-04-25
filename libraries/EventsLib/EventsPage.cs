using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsLib
{
    public partial class EventsPage : Form
    {
        List<Event> events = new List<Event>();

        public EventsPage()
        {
            InitializeComponent();

            // TODO: Pull events data from JSON and add to array.
            // more info in CodeStream

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void eventsTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
