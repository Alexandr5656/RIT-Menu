using EventsLib;
using RIT_Menu;
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
            openEventsButton.Click += new EventHandler(openEventsScreen);
            openFoodButton.Click += new EventHandler(openFoodScreen);
            openCalendarButton.Click += new EventHandler(openCalendarScreen);
            ScrapeWeb sb = new ScrapeWeb();
        }

        private void openEventsScreen(object sender, EventArgs e)
        {

            EventsScreen ep = new EventsScreen();
            ep.ShowDialog();

        }

        private void openFoodScreen(object sender, EventArgs e)
        {

            RestaurantList ep = new RestaurantList();
            ep.ShowDialog();

        }

        private void openCalendarScreen(object sender, EventArgs e)
        {

            Calendar ep = new Calendar();
            ep.ShowDialog();

        }

        private void openEventsButton_Click(object sender, EventArgs e)
        {

        }

        private void Rit_Click(object sender, EventArgs e)
        {

        }

        private void openCalendarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
