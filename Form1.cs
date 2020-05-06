using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using FoodClasses;
namespace RIT_Menu
{
    public partial class AddingEvent : Form
    {
        public AddingEvent(Resturants rest)
        {
            InitializeComponent();
            nameTB.Text = rest.Name;
            startTB.Text = DateTime.Now.ToString();
            endTB.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string name = nameTB.Text;
            DateTime start = DateTime.Parse(startTB.Text);
            DateTime end = DateTime.Parse(endTB.Text);

            RIT_Menu.AddToCal.addToCalendar(name,start,end);
            this.Close();
            
        }
    }
}
