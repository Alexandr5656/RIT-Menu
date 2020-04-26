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
    public partial class EventsScreen : Form
    {
        List<Event> events = new List<Event>();

        public EventsScreen()
        {
            InitializeComponent();

            // TODO: Pull events data from JSON and add to array.
            // more info in CodeStream

            // make back button functional
            backButton.Click += new EventHandler(backHome);

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
