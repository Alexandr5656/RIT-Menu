using EventsLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIT_Menu
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            openEventsButton.Click += new EventHandler(openEventsPage);
        }

        private void openEventsPage(object sender, EventArgs e)
        {

            EventsPage ep = new EventsPage();
            ep.Show();

        }

        private void openEventsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
