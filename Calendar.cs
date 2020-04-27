using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Scheduele
{
    public partial class Form1 : Form
    {
        public EventClasses.EventsClass events = new EventClasses.EventsClass();
        public List<EventClasses.Events> evnts = new List<EventClasses.Events>();
        public Form1()
        {
            InitializeComponent();
            this.radioButton1.Click += new EventHandler(RadioButton24__Click);
            //this.radioButton2.Click += new EventHandler(RadioButton12__Click);
            this.saveButton.Click += new EventHandler(SaveButton__Click);
            this.openButton.Click += new EventHandler(OpenButton__Click);
        }

        private void RadioButton24__Click(object sender, EventArgs e)
        {

        }
        private void SaveButton__Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
                if (sunday12aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday12a = new EventClasses.Events();
                        sunday12a.Day = "Sunday";
                        sunday12a.Time = 0000;
                        sunday12a.Event = this.sunday12aTextBox.Text;
                        evnts.Add(sunday12a);
                    }
                }
                if (sunday1230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday1230a = new EventClasses.Events();
                        sunday1230a.Day = "Sunday";
                        sunday1230a.Time = 0030;
                        sunday1230a.Event = this.sunday1230aTextBox.Text;
                        evnts.Add(sunday1230a);
                    }
                }
                if (sunday1aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday1a = new EventClasses.Events();
                        sunday1a.Day = "Sunday";
                        sunday1a.Time = 0100;
                        sunday1a.Event = this.sunday1aTextBox.Text;
                        evnts.Add(sunday1a);
                    }
                }
                if (sunday130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday130a = new EventClasses.Events();
                        sunday130a.Day = "Sunday";
                        sunday130a.Time = 0130;
                        sunday130a.Event = this.sunday130aTextBox.Text;
                        evnts.Add(sunday130a);
                    }
                }
                if (sunday2aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday2a = new EventClasses.Events();
                        sunday2a.Day = "Sunday";
                        sunday2a.Time = 0200;
                        sunday2a.Event = this.sunday2aTextBox.Text;
                        evnts.Add(sunday2a);
                    }
                }
                if (sunday230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday230a = new EventClasses.Events();
                        sunday230a.Day = "Sunday";
                        sunday230a.Time = 0230;
                        sunday230a.Event = this.sunday230aTextBox.Text;
                        evnts.Add(sunday230a);
                    }
                }
                if (sunday3aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday3a = new EventClasses.Events();
                        sunday3a.Day = "Sunday";
                        sunday3a.Time = 0300;
                        sunday3a.Event = this.sunday3aTextBox.Text;
                        evnts.Add(sunday3a);
                    }
                }
                if (sunday330aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday330a = new EventClasses.Events();
                        sunday330a.Day = "Sunday";
                        sunday330a.Time = 0330;
                        sunday330a.Event = this.sunday330aTextBox.Text;
                        evnts.Add(sunday330a);
                    }
                }
                if (sunday4aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday4a = new EventClasses.Events();
                        sunday4a.Day = "Sunday";
                        sunday4a.Time = 0400;
                        sunday4a.Event = this.sunday4aTextBox.Text;
                        evnts.Add(sunday4a);
                    }
                }
                if (sunday430aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday430a = new EventClasses.Events();
                        sunday430a.Day = "Sunday";
                        sunday430a.Time = 0430;
                        sunday430a.Event = this.sunday430aTextBox.Text;
                        evnts.Add(sunday430a);
                    }
                }
                if (sunday5aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday5a = new EventClasses.Events();
                        sunday5a.Day = "Sunday";
                        sunday5a.Time = 0500;
                        sunday5a.Event = this.sunday5aTextBox.Text;
                        evnts.Add(sunday5a);
                    }
                }
                if (sunday530aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday530a = new EventClasses.Events();
                        sunday530a.Day = "Sunday";
                        sunday530a.Time = 0530;
                        sunday530a.Event = this.sunday530aTextBox.Text;
                        evnts.Add(sunday530a);
                    }
                }
                if (sunday6aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday6a = new EventClasses.Events();
                        sunday6a.Day = "Sunday";
                        sunday6a.Time = 0600;
                        sunday6a.Event = this.sunday6aTextBox.Text;
                        evnts.Add(sunday6a);
                    }
                }
                if (sunday630aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday630a = new EventClasses.Events();
                        sunday630a.Day = "Sunday";
                        sunday630a.Time = 0630;
                        sunday630a.Event = this.sunday630aTextBox.Text;
                        evnts.Add(sunday630a);
                    }
                }
                if (sunday7aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday7a = new EventClasses.Events();
                        sunday7a.Day = "Sunday";
                        sunday7a.Time = 0700;
                        sunday7a.Event = this.sunday7aTextBox.Text;
                        evnts.Add(sunday7a);
                    }
                }
                if (sunday730aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday730a = new EventClasses.Events();
                        sunday730a.Day = "Sunday";
                        sunday730a.Time = 0730;
                        sunday730a.Event = this.sunday730aTextBox.Text;
                        evnts.Add(sunday730a);
                    }
                }
                if (sunday8aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday8a = new EventClasses.Events();
                        sunday8a.Day = "Sunday";
                        sunday8a.Time = 0800;
                        sunday8a.Event = this.sunday8aTextBox.Text;
                        evnts.Add(sunday8a);
                    }
                }
                if (sunday830aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday830a = new EventClasses.Events();
                        sunday830a.Day = "Sunday";
                        sunday830a.Time = 0830;
                        sunday830a.Event = this.sunday830aTextBox.Text;
                        evnts.Add(sunday830a);
                    }
                }
                if (sunday9aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday9a = new EventClasses.Events();
                        sunday9a.Day = "Sunday";
                        sunday9a.Time = 0900;
                        sunday9a.Event = this.sunday9aTextBox.Text;
                        evnts.Add(sunday9a);
                    }
                }
                if (sunday930aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday930a = new EventClasses.Events();
                        sunday930a.Day = "Sunday";
                        sunday930a.Time = 0930;
                        sunday930a.Event = this.sunday930aTextBox.Text;
                        evnts.Add(sunday930a);
                    }
                }
                if (sunday10aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday10a = new EventClasses.Events();
                        sunday10a.Day = "Sunday";
                        sunday10a.Time = 1000;
                        sunday10a.Event = this.sunday10aTextBox.Text;
                        evnts.Add(sunday10a);
                    }
                }
                if (sunday1030aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday1030a = new EventClasses.Events();
                        sunday1030a.Day = "Sunday";
                        sunday1030a.Time = 1030;
                        sunday1030a.Event = this.sunday1030aTextBox.Text;
                        evnts.Add(sunday1030a);
                    }
                }
                if (sunday11aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday11a = new EventClasses.Events();
                        sunday11a.Day = "Sunday";
                        sunday11a.Time = 1100;
                        sunday11a.Event = this.sunday11aTextBox.Text;
                        evnts.Add(sunday11a);
                    }
                }
                if (sunday1130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday1130a = new EventClasses.Events();
                        sunday1130a.Day = "Sunday";
                        sunday1130a.Time = 1130;
                        sunday1130a.Event = this.sunday1130aTextBox.Text;
                        evnts.Add(sunday1130a);
                    }
                }
                if (sunday12pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday12p = new EventClasses.Events();
                        sunday12p.Day = "Sunday";
                        sunday12p.Time = 1200;
                        sunday12p.Event = this.sunday12pTextBox.Text;
                        evnts.Add(sunday12p);
                    }
                }
                if (sunday1230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday1230p = new EventClasses.Events();
                        sunday1230p.Day = "Sunday";
                        sunday1230p.Time = 1230;
                        sunday1230p.Event = this.sunday1230pTextBox.Text;
                        evnts.Add(sunday1230p);
                    }
                }
                if (sunday1pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday1p = new EventClasses.Events();
                        sunday1p.Day = "Sunday";
                        sunday1p.Time = 1300;
                        sunday1p.Event = this.sunday1pTextBox.Text;
                        evnts.Add(sunday1p);
                    }
                }
                if (sunday130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday130p = new EventClasses.Events();
                        sunday130p.Day = "Sunday";
                        sunday130p.Time = 1330;
                        sunday130p.Event = this.sunday130pTextBox.Text;
                        evnts.Add(sunday130p);
                    }
                }
                if (sunday2pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday2p = new EventClasses.Events();
                        sunday2p.Day = "Sunday";
                        sunday2p.Time = 1400;
                        sunday2p.Event = this.sunday2pTextBox.Text;
                        evnts.Add(sunday2p);
                    }
                }
                if (sunday230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday230p = new EventClasses.Events();
                        sunday230p.Day = "Sunday";
                        sunday230p.Time = 1430;
                        sunday230p.Event = this.sunday230pTextBox.Text;
                        evnts.Add(sunday230p);
                    }
                }
                if (sunday3pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday3p = new EventClasses.Events();
                        sunday3p.Day = "Sunday";
                        sunday3p.Time = 1500;
                        sunday3p.Event = this.sunday3pTextBox.Text;
                        evnts.Add(sunday3p);
                    }
                }
                if (sunday330pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday330p = new EventClasses.Events();
                        sunday330p.Day = "Sunday";
                        sunday330p.Time = 1530;
                        sunday330p.Event = this.sunday330pTextBox.Text;
                        evnts.Add(sunday330p);
                    }
                }
                if (sunday4pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday4p = new EventClasses.Events();
                        sunday4p.Day = "Sunday";
                        sunday4p.Time = 1600;
                        sunday4p.Event = this.sunday4pTextBox.Text;
                        evnts.Add(sunday4p);
                    }
                }
                if (sunday430pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday430p = new EventClasses.Events();
                        sunday430p.Day = "Sunday";
                        sunday430p.Time = 1630;
                        sunday430p.Event = this.sunday430pTextBox.Text;
                        evnts.Add(sunday430p);
                    }
                }
                if (sunday5pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday5p = new EventClasses.Events();
                        sunday5p.Day = "Sunday";
                        sunday5p.Time = 1700;
                        sunday5p.Event = this.sunday5pTextBox.Text;
                        evnts.Add(sunday5p);
                    }
                }
                if (sunday530pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday530p = new EventClasses.Events();
                        sunday530p.Day = "Sunday";
                        sunday530p.Time = 1730;
                        sunday530p.Event = this.sunday530pTextBox.Text;
                        evnts.Add(sunday530p);
                    }
                }
                if (sunday6pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday6p = new EventClasses.Events();
                        sunday6p.Day = "Sunday";
                        sunday6p.Time = 1800;
                        sunday6p.Event = this.sunday6pTextBox.Text;
                        evnts.Add(sunday6p);
                    }
                }
                if (sunday630pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday630p = new EventClasses.Events();
                        sunday630p.Day = "Sunday";
                        sunday630p.Time = 1830;
                        sunday630p.Event = this.sunday630pTextBox.Text;
                        evnts.Add(sunday630p);
                    }
                }
                if (sunday7pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday7p = new EventClasses.Events();
                        sunday7p.Day = "Sunday";
                        sunday7p.Time = 1900;
                        sunday7p.Event = this.sunday7pTextBox.Text;
                        evnts.Add(sunday7p);
                    }
                }
                if (sunday730pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday730p = new EventClasses.Events();
                        sunday730p.Day = "Sunday";
                        sunday730p.Time = 1930;
                        sunday730p.Event = this.sunday730pTextBox.Text;
                        evnts.Add(sunday730p);
                    }
                }
                if (sunday8pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday8p = new EventClasses.Events();
                        sunday8p.Day = "Sunday";
                        sunday8p.Time = 2000;
                        sunday8p.Event = this.sunday8pTextBox.Text;
                        evnts.Add(sunday8p);
                    }
                }
                if (sunday830pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday830p = new EventClasses.Events();
                        sunday830p.Day = "Sunday";
                        sunday830p.Time = 2030;
                        sunday830p.Event = this.sunday830pTextBox.Text;
                        evnts.Add(sunday830p);
                    }
                }
                if (sunday9pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday9p = new EventClasses.Events();
                        sunday9p.Day = "Sunday";
                        sunday9p.Time = 2100;
                        sunday9p.Event = this.sunday9pTextBox.Text;
                        evnts.Add(sunday9p);
                    }
                }
                if (sunday930pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday930p = new EventClasses.Events();
                        sunday930p.Day = "Sunday";
                        sunday930p.Time = 2130;
                        sunday930p.Event = this.sunday930pTextBox.Text;
                        evnts.Add(sunday930p);
                    }
                }
                if (sunday10pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday10p = new EventClasses.Events();
                        sunday10p.Day = "Sunday";
                        sunday10p.Time = 2200;
                        sunday10p.Event = this.sunday10pTextBox.Text;
                        evnts.Add(sunday10p);
                    }
                }
                if (sunday1030pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday1030p = new EventClasses.Events();
                        sunday1030p.Day = "Sunday";
                        sunday1030p.Time = 2230;
                        sunday1030p.Event = this.sunday1030pTextBox.Text;
                        evnts.Add(sunday1030p);
                    }
                }
                if (sunday11pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday11p = new EventClasses.Events();
                        sunday11p.Day = "Sunday";
                        sunday11p.Time = 2300;
                        sunday11p.Event = this.sunday11pTextBox.Text;
                        evnts.Add(sunday11p);
                    }
                }
                if (sunday1130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sunday1130p = new EventClasses.Events();
                        sunday1130p.Day = "Sunday";
                        sunday1130p.Time = 2330;
                        sunday1130p.Event = this.sunday1130pTextBox.Text;
                        evnts.Add(sunday1130p);
                    }

                }
                if (monday12aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday12a = new EventClasses.Events();
                        monday12a.Day = "Monday";
                        monday12a.Time = 0000;
                        monday12a.Event = this.monday12aTextBox.Text;
                        evnts.Add(monday12a);
                    }
                }
                if (monday1230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday1230a = new EventClasses.Events();
                        monday1230a.Day = "Monday";
                        monday1230a.Time = 0030;
                        monday1230a.Event = this.monday1230aTextBox.Text;
                        evnts.Add(monday1230a);
                    }
                }
                if (monday1aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday1a = new EventClasses.Events();
                        monday1a.Day = "Monday";
                        monday1a.Time = 0100;
                        monday1a.Event = this.monday1aTextBox.Text;
                        evnts.Add(monday1a);
                    }
                }
                if (monday130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday130a = new EventClasses.Events();
                        monday130a.Day = "Monday";
                        monday130a.Time = 0130;
                        monday130a.Event = this.monday130aTextBox.Text;
                        evnts.Add(monday130a);
                    }
                }
                if (monday2aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday2a = new EventClasses.Events();
                        monday2a.Day = "Monday";
                        monday2a.Time = 0200;
                        monday2a.Event = this.monday2aTextBox.Text;
                        evnts.Add(monday2a);
                    }
                }
                if (monday230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday230a = new EventClasses.Events();
                        monday230a.Day = "Monday";
                        monday230a.Time = 0230;
                        monday230a.Event = this.monday230aTextBox.Text;
                        evnts.Add(monday230a);
                    }
                }
                if (monday3aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday3a = new EventClasses.Events();
                        monday3a.Day = "Monday";
                        monday3a.Time = 0300;
                        monday3a.Event = this.monday3aTextBox.Text;
                        evnts.Add(monday3a);
                    }
                }
                if (monday330aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday330a = new EventClasses.Events();
                        monday330a.Day = "Monday";
                        monday330a.Time = 0330;
                        monday330a.Event = this.monday330aTextBox.Text;
                        evnts.Add(monday330a);
                    }
                }
                if (monday4aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday4a = new EventClasses.Events();
                        monday4a.Day = "Monday";
                        monday4a.Time = 0400;
                        monday4a.Event = this.monday4aTextBox.Text;
                        evnts.Add(monday4a);
                    }
                }
                if (monday430aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday430a = new EventClasses.Events();
                        monday430a.Day = "Monday";
                        monday430a.Time = 0430;
                        monday430a.Event = this.monday430aTextBox.Text;
                        evnts.Add(monday430a);
                    }
                }
                if (monday5aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday5a = new EventClasses.Events();
                        monday5a.Day = "Monday";
                        monday5a.Time = 0500;
                        monday5a.Event = this.monday5aTextBox.Text;
                        evnts.Add(monday5a);
                    }
                }
                if (monday530aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday530a = new EventClasses.Events();
                        monday530a.Day = "Monday";
                        monday530a.Time = 0530;
                        monday530a.Event = this.monday530aTextBox.Text;
                        evnts.Add(monday530a);
                    }
                }
                if (monday6aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday6a = new EventClasses.Events();
                        monday6a.Day = "Monday";
                        monday6a.Time = 0600;
                        monday6a.Event = this.monday6aTextBox.Text;
                        evnts.Add(monday6a);
                    }
                }
                if (monday630aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday630a = new EventClasses.Events();
                        monday630a.Day = "Monday";
                        monday630a.Time = 0630;
                        monday630a.Event = this.monday630aTextBox.Text;
                        evnts.Add(monday630a);
                    }
                }
                if (monday7aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday7a = new EventClasses.Events();
                        monday7a.Day = "Monday";
                        monday7a.Time = 0700;
                        monday7a.Event = this.monday7aTextBox.Text;
                        evnts.Add(monday7a);
                    }
                }
                if (monday730aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday730a = new EventClasses.Events();
                        monday730a.Day = "Monday";
                        monday730a.Time = 0730;
                        monday730a.Event = this.monday730aTextBox.Text;
                        evnts.Add(monday730a);
                    }
                }
                if (monday8aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday8a = new EventClasses.Events();
                        monday8a.Day = "Monday";
                        monday8a.Time = 0800;
                        monday8a.Event = this.monday8aTextBox.Text;
                        evnts.Add(monday8a);
                    }
                }
                if (monday830aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday830a = new EventClasses.Events();
                        monday830a.Day = "Monday";
                        monday830a.Time = 0830;
                        monday830a.Event = this.monday830aTextBox.Text;
                        evnts.Add(monday830a);
                    }
                }
                if (monday9aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday9a = new EventClasses.Events();
                        monday9a.Day = "Monday";
                        monday9a.Time = 0900;
                        monday9a.Event = this.monday9aTextBox.Text;
                        evnts.Add(monday9a);
                    }
                }
                if (monday930aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday930a = new EventClasses.Events();
                        monday930a.Day = "Monday";
                        monday930a.Time = 0930;
                        monday930a.Event = this.monday930aTextBox.Text;
                        evnts.Add(monday930a);
                    }
                }
                if (monday10aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday10a = new EventClasses.Events();
                        monday10a.Day = "Monday";
                        monday10a.Time = 1000;
                        monday10a.Event = this.monday10aTextBox.Text;
                        evnts.Add(monday10a);
                    }
                }
                if (monday1030aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday1030a = new EventClasses.Events();
                        monday1030a.Day = "Monday";
                        monday1030a.Time = 1030;
                        monday1030a.Event = this.monday1030aTextBox.Text;
                        evnts.Add(monday1030a);
                    }
                }
                if (monday11aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday11a = new EventClasses.Events();
                        monday11a.Day = "Monday";
                        monday11a.Time = 1100;
                        monday11a.Event = this.monday11aTextBox.Text;
                        evnts.Add(monday11a);
                    }
                }
                if (monday1130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday1130a = new EventClasses.Events();
                        monday1130a.Day = "Monday";
                        monday1130a.Time = 1130;
                        monday1130a.Event = this.monday1130aTextBox.Text;
                        evnts.Add(monday1130a);
                    }
                }
                if (monday12pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday12p = new EventClasses.Events();
                        monday12p.Day = "Monday";
                        monday12p.Time = 1200;
                        monday12p.Event = this.monday12pTextBox.Text;
                        evnts.Add(monday12p);
                    }
                }
                if (monday1230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday1230p = new EventClasses.Events();
                        monday1230p.Day = "Monday";
                        monday1230p.Time = 1230;
                        monday1230p.Event = this.monday1230pTextBox.Text;
                        evnts.Add(monday1230p);
                    }
                }
                if (monday1pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday1p = new EventClasses.Events();
                        monday1p.Day = "Monday";
                        monday1p.Time = 1300;
                        monday1p.Event = this.monday1pTextBox.Text;
                        evnts.Add(monday1p);
                    }
                }
                if (monday130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday130p = new EventClasses.Events();
                        monday130p.Day = "Monday";
                        monday130p.Time = 1330;
                        monday130p.Event = this.monday130pTextBox.Text;
                        evnts.Add(monday130p);
                    }
                }
                if (monday2pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday2p = new EventClasses.Events();
                        monday2p.Day = "Monday";
                        monday2p.Time = 1400;
                        monday2p.Event = this.monday2pTextBox.Text;
                        evnts.Add(monday2p);
                    }
                }
                if (monday230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday230p = new EventClasses.Events();
                        monday230p.Day = "Monday";
                        monday230p.Time = 1430;
                        monday230p.Event = this.monday230pTextBox.Text;
                        evnts.Add(monday230p);
                    }
                }
                if (monday3pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday3p = new EventClasses.Events();
                        monday3p.Day = "Monday";
                        monday3p.Time = 1500;
                        monday3p.Event = this.monday3pTextBox.Text;
                        evnts.Add(monday3p);
                    }
                }
                if (monday330pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday330p = new EventClasses.Events();
                        monday330p.Day = "Monday";
                        monday330p.Time = 1530;
                        monday330p.Event = this.monday330pTextBox.Text;
                        evnts.Add(monday330p);
                    }
                }
                if (monday4pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday4p = new EventClasses.Events();
                        monday4p.Day = "Monday";
                        monday4p.Time = 1600;
                        monday4p.Event = this.monday4pTextBox.Text;
                        evnts.Add(monday4p);
                    }
                }
                if (monday430pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday430p = new EventClasses.Events();
                        monday430p.Day = "Monday";
                        monday430p.Time = 1630;
                        monday430p.Event = this.monday430pTextBox.Text;
                        evnts.Add(monday430p);
                    }
                }
                if (monday5pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday5p = new EventClasses.Events();
                        monday5p.Day = "Monday";
                        monday5p.Time = 1700;
                        monday5p.Event = this.monday5pTextBox.Text;
                        evnts.Add(monday5p);
                    }
                }
                if (monday530pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday530p = new EventClasses.Events();
                        monday530p.Day = "Monday";
                        monday530p.Time = 1730;
                        monday530p.Event = this.monday530pTextBox.Text;
                        evnts.Add(monday530p);
                    }
                }
                if (monday6pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday6p = new EventClasses.Events();
                        monday6p.Day = "Monday";
                        monday6p.Time = 1800;
                        monday6p.Event = this.monday6pTextBox.Text;
                        evnts.Add(monday6p);
                    }
                }
                if (monday630pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday630p = new EventClasses.Events();
                        monday630p.Day = "Monday";
                        monday630p.Time = 1830;
                        monday630p.Event = this.monday630pTextBox.Text;
                        evnts.Add(monday630p);
                    }
                }
                if (monday7pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday7p = new EventClasses.Events();
                        monday7p.Day = "Monday";
                        monday7p.Time = 1900;
                        monday7p.Event = this.monday7pTextBox.Text;
                        evnts.Add(monday7p);
                    }
                }
                if (monday730pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday730p = new EventClasses.Events();
                        monday730p.Day = "Monday";
                        monday730p.Time = 1930;
                        monday730p.Event = this.monday730pTextBox.Text;
                        evnts.Add(monday730p);
                    }
                }
                if (monday8pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday8p = new EventClasses.Events();
                        monday8p.Day = "Monday";
                        monday8p.Time = 2000;
                        monday8p.Event = this.monday8pTextBox.Text;
                        evnts.Add(monday8p);
                    }
                }
                if (monday830pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday830p = new EventClasses.Events();
                        monday830p.Day = "Monday";
                        monday830p.Time = 2030;
                        monday830p.Event = this.monday830pTextBox.Text;
                        evnts.Add(monday830p);
                    }
                }
                if (monday9pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday9p = new EventClasses.Events();
                        monday9p.Day = "Monday";
                        monday9p.Time = 2100;
                        monday9p.Event = this.monday9pTextBox.Text;
                        evnts.Add(monday9p);
                    }
                }
                if (monday930pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday930p = new EventClasses.Events();
                        monday930p.Day = "Monday";
                        monday930p.Time = 2130;
                        monday930p.Event = this.monday930pTextBox.Text;
                        evnts.Add(monday930p);
                    }
                }
                if (monday10pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday10p = new EventClasses.Events();
                        monday10p.Day = "Monday";
                        monday10p.Time = 2200;
                        monday10p.Event = this.monday10pTextBox.Text;
                        evnts.Add(monday10p);
                    }
                }
                if (monday1030pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday1030p = new EventClasses.Events();
                        monday1030p.Day = "Monday";
                        monday1030p.Time = 2230;
                        monday1030p.Event = this.monday1030pTextBox.Text;
                        evnts.Add(monday1030p);
                    }
                }
                if (monday11pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday11p = new EventClasses.Events();
                        monday11p.Day = "Monday";
                        monday11p.Time = 2300;
                        monday11p.Event = this.monday11pTextBox.Text;
                        evnts.Add(monday11p);
                    }
                }
                if (monday1130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events monday1130p = new EventClasses.Events();
                        monday1130p.Day = "Monday";
                        monday1130p.Time = 2330;
                        monday1130p.Event = this.monday1130pTextBox.Text;
                        evnts.Add(monday1130p);
                    }

                }
                if (tues12aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues12a = new EventClasses.Events();
                        tues12a.Day = "Tuesday";
                        tues12a.Time = 0000;
                        tues12a.Event = this.tues12aTextBox.Text;
                        evnts.Add(tues12a);
                    }
                }
                if (tues1230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues1230a = new EventClasses.Events();
                        tues1230a.Day = "Tuesday";
                        tues1230a.Time = 0030;
                        tues1230a.Event = this.tues1230aTextBox.Text;
                        evnts.Add(tues1230a);
                    }
                }
                if (tues1aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues1a = new EventClasses.Events();
                        tues1a.Day = "Tuesday";
                        tues1a.Time = 0100;
                        tues1a.Event = this.tues1aTextBox.Text;
                        evnts.Add(tues1a);
                    }
                }
                if (tues130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues130a = new EventClasses.Events();
                        tues130a.Day = "Tuesday";
                        tues130a.Time = 0130;
                        tues130a.Event = this.tues130aTextBox.Text;
                        evnts.Add(tues130a);
                    }
                }
                if (tues2aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues2a = new EventClasses.Events();
                        tues2a.Day = "Tuesday";
                        tues2a.Time = 0200;
                        tues2a.Event = this.tues2aTextBox.Text;
                        evnts.Add(tues2a);
                    }
                }
                if (tues230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues230a = new EventClasses.Events();
                        tues230a.Day = "Tuesday";
                        tues230a.Time = 0230;
                        tues230a.Event = this.tues230aTextBox.Text;
                        evnts.Add(tues230a);
                    }
                }
                if (tues3aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues3a = new EventClasses.Events();
                        tues3a.Day = "Tuesday";
                        tues3a.Time = 0300;
                        tues3a.Event = this.tues3aTextBox.Text;
                        evnts.Add(tues3a);
                    }
                }
                if (tues330aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues330a = new EventClasses.Events();
                        tues330a.Day = "Tuesday";
                        tues330a.Time = 0330;
                        tues330a.Event = this.tues330aTextBox.Text;
                        evnts.Add(tues330a);
                    }
                }
                if (tues4aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues4a = new EventClasses.Events();
                        tues4a.Day = "Tuesday";
                        tues4a.Time = 0400;
                        tues4a.Event = this.tues4aTextBox.Text;
                        evnts.Add(tues4a);
                    }
                }
                if (tues430aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues430a = new EventClasses.Events();
                        tues430a.Day = "Tuesday";
                        tues430a.Time = 0430;
                        tues430a.Event = this.tues430aTextBox.Text;
                        evnts.Add(tues430a);
                    }
                }
                if (tues5aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues5a = new EventClasses.Events();
                        tues5a.Day = "Tuesday";
                        tues5a.Time = 0500;
                        tues5a.Event = this.tues5aTextBox.Text;
                        evnts.Add(tues5a);
                    }
                }
                if (tues530aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues530a = new EventClasses.Events();
                        tues530a.Day = "Tuesday";
                        tues530a.Time = 0530;
                        tues530a.Event = this.tues530aTextBox.Text;
                        evnts.Add(tues530a);
                    }
                }
                if (tues6aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues6a = new EventClasses.Events();
                        tues6a.Day = "Tuesday";
                        tues6a.Time = 0600;
                        tues6a.Event = this.tues6aTextBox.Text;
                        evnts.Add(tues6a);
                    }
                }
                if (tues630aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues630a = new EventClasses.Events();
                        tues630a.Day = "Tuesday";
                        tues630a.Time = 0630;
                        tues630a.Event = this.tues630aTextBox.Text;
                        evnts.Add(tues630a);
                    }
                }
                if (tues7aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues7a = new EventClasses.Events();
                        tues7a.Day = "Tuesday";
                        tues7a.Time = 0700;
                        tues7a.Event = this.tues7aTextBox.Text;
                        evnts.Add(tues7a);
                    }
                }
                if (tues730aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues730a = new EventClasses.Events();
                        tues730a.Day = "Tuesday";
                        tues730a.Time = 0730;
                        tues730a.Event = this.tues730aTextBox.Text;
                        evnts.Add(tues730a);
                    }
                }
                if (tues8aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues8a = new EventClasses.Events();
                        tues8a.Day = "Tuesday";
                        tues8a.Time = 0800;
                        tues8a.Event = this.tues8aTextBox.Text;
                        evnts.Add(tues8a);
                    }
                }
                if (tues830aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues830a = new EventClasses.Events();
                        tues830a.Day = "Tuesday";
                        tues830a.Time = 0830;
                        tues830a.Event = this.tues830aTextBox.Text;
                        evnts.Add(tues830a);
                    }
                }
                if (tues9aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues9a = new EventClasses.Events();
                        tues9a.Day = "Tuesday";
                        tues9a.Time = 0900;
                        tues9a.Event = this.tues9aTextBox.Text;
                        evnts.Add(tues9a);
                    }
                }
                if (tues930aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues930a = new EventClasses.Events();
                        tues930a.Day = "Tuesday";
                        tues930a.Time = 0930;
                        tues930a.Event = this.tues930aTextBox.Text;
                        evnts.Add(tues930a);
                    }
                }
                if (tues10aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues10a = new EventClasses.Events();
                        tues10a.Day = "Tuesday";
                        tues10a.Time = 1000;
                        tues10a.Event = this.tues10aTextBox.Text;
                        evnts.Add(tues10a);
                    }
                }
                if (tues1030aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues1030a = new EventClasses.Events();
                        tues1030a.Day = "Tuesday";
                        tues1030a.Time = 1030;
                        tues1030a.Event = this.tues1030aTextBox.Text;
                        evnts.Add(tues1030a);
                    }
                }
                if (tues11aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues11a = new EventClasses.Events();
                        tues11a.Day = "Tuesday";
                        tues11a.Time = 1100;
                        tues11a.Event = this.tues11aTextBox.Text;
                        evnts.Add(tues11a);
                    }
                }
                if (tues1130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues1130a = new EventClasses.Events();
                        tues1130a.Day = "Tuesday";
                        tues1130a.Time = 1130;
                        tues1130a.Event = this.tues1130aTextBox.Text;
                        evnts.Add(tues1130a);
                    }
                }
                if (tues12pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues12p = new EventClasses.Events();
                        tues12p.Day = "Tuesday";
                        tues12p.Time = 1200;
                        tues12p.Event = this.tues12pTextBox.Text;
                        evnts.Add(tues12p);
                    }
                }
                if (tues1230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues1230p = new EventClasses.Events();
                        tues1230p.Day = "Tuesday";
                        tues1230p.Time = 1230;
                        tues1230p.Event = this.tues1230pTextBox.Text;
                        evnts.Add(tues1230p);
                    }
                }
                if (tues1pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues1p = new EventClasses.Events();
                        tues1p.Day = "Tuesday";
                        tues1p.Time = 1300;
                        tues1p.Event = this.tues1pTextBox.Text;
                        evnts.Add(tues1p);
                    }
                }
                if (tues130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues130p = new EventClasses.Events();
                        tues130p.Day = "Tuesday";
                        tues130p.Time = 1330;
                        tues130p.Event = this.tues130pTextBox.Text;
                        evnts.Add(tues130p);
                    }
                }
                if (tues2pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues2p = new EventClasses.Events();
                        tues2p.Day = "Tuesday";
                        tues2p.Time = 1400;
                        tues2p.Event = this.tues2pTextBox.Text;
                        evnts.Add(tues2p);
                    }
                }
                if (tues230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues230p = new EventClasses.Events();
                        tues230p.Day = "Tuesday";
                        tues230p.Time = 1430;
                        tues230p.Event = this.tues230pTextBox.Text;
                        evnts.Add(tues230p);
                    }
                }
                if (tues3pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues3p = new EventClasses.Events();
                        tues3p.Day = "Tuesday";
                        tues3p.Time = 1500;
                        tues3p.Event = this.tues3pTextBox.Text;
                        evnts.Add(tues3p);
                    }
                }
                if (tues330pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues330p = new EventClasses.Events();
                        tues330p.Day = "Tuesday";
                        tues330p.Time = 1530;
                        tues330p.Event = this.tues330pTextBox.Text;
                        evnts.Add(tues330p);
                    }
                }
                if (tues4pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues4p = new EventClasses.Events();
                        tues4p.Day = "Tuesday";
                        tues4p.Time = 1600;
                        tues4p.Event = this.tues4pTextBox.Text;
                        evnts.Add(tues4p);
                    }
                }
                if (tues430pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues430p = new EventClasses.Events();
                        tues430p.Day = "Tuesday";
                        tues430p.Time = 1630;
                        tues430p.Event = this.tues430pTextBox.Text;
                        evnts.Add(tues430p);
                    }
                }
                if (tues5pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues5p = new EventClasses.Events();
                        tues5p.Day = "Tuesday";
                        tues5p.Time = 1700;
                        tues5p.Event = this.tues5pTextBox.Text;
                        evnts.Add(tues5p);
                    }
                }
                if (tues530pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues530p = new EventClasses.Events();
                        tues530p.Day = "Tuesday";
                        tues530p.Time = 1730;
                        tues530p.Event = this.tues530pTextBox.Text;
                        evnts.Add(tues530p);
                    }
                }
                if (tues6pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues6p = new EventClasses.Events();
                        tues6p.Day = "Tuesday";
                        tues6p.Time = 1800;
                        tues6p.Event = this.tues6pTextBox.Text;
                        evnts.Add(tues6p);
                    }
                }
                if (tues630pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues630p = new EventClasses.Events();
                        tues630p.Day = "Tuesday";
                        tues630p.Time = 1830;
                        tues630p.Event = this.tues630pTextBox.Text;
                        evnts.Add(tues630p);
                    }
                }
                if (tues7pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues7p = new EventClasses.Events();
                        tues7p.Day = "Tuesday";
                        tues7p.Time = 1900;
                        tues7p.Event = this.tues7pTextBox.Text;
                        evnts.Add(tues7p);
                    }
                }
                if (tues730pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues730p = new EventClasses.Events();
                        tues730p.Day = "Tuesday";
                        tues730p.Time = 1930;
                        tues730p.Event = this.tues730pTextBox.Text;
                        evnts.Add(tues730p);
                    }
                }
                if (tues8pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues8p = new EventClasses.Events();
                        tues8p.Day = "Tuesday";
                        tues8p.Time = 2000;
                        tues8p.Event = this.tues8pTextBox.Text;
                        evnts.Add(tues8p);
                    }
                }
                if (tues830pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues830p = new EventClasses.Events();
                        tues830p.Day = "Tuesday";
                        tues830p.Time = 2030;
                        tues830p.Event = this.tues830pTextBox.Text;
                        evnts.Add(tues830p);
                    }
                }
                if (tues9pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues9p = new EventClasses.Events();
                        tues9p.Day = "Tuesday";
                        tues9p.Time = 2100;
                        tues9p.Event = this.tues9pTextBox.Text;
                        evnts.Add(tues9p);
                    }
                }
                if (tues930pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues930p = new EventClasses.Events();
                        tues930p.Day = "Tuesday";
                        tues930p.Time = 2130;
                        tues930p.Event = this.tues930pTextBox.Text;
                        evnts.Add(tues930p);
                    }
                }
                if (tues10pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues10p = new EventClasses.Events();
                        tues10p.Day = "Tuesday";
                        tues10p.Time = 2200;
                        tues10p.Event = this.tues10pTextBox.Text;
                        evnts.Add(tues10p);
                    }
                }
                if (tues1030pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues1030p = new EventClasses.Events();
                        tues1030p.Day = "Tuesday";
                        tues1030p.Time = 2230;
                        tues1030p.Event = this.tues1030pTextBox.Text;
                        evnts.Add(tues1030p);
                    }
                }
                if (tues11pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues11p = new EventClasses.Events();
                        tues11p.Day = "Tuesday";
                        tues11p.Time = 2300;
                        tues11p.Event = this.tues11pTextBox.Text;
                        evnts.Add(tues11p);
                    }
                }
                if (tues1130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events tues1130p = new EventClasses.Events();
                        tues1130p.Day = "Tuesday";
                        tues1130p.Time = 2330;
                        tues1130p.Event = this.tues1130pTextBox.Text;
                        evnts.Add(tues1130p);
                    }

                }
                if (wed12aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed12a = new EventClasses.Events();
                        wed12a.Day = "Wednesday";
                        wed12a.Time = 0000;
                        wed12a.Event = this.wed12aTextBox.Text;
                        evnts.Add(wed12a);
                    }
                }
                if (wed1230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed1230a = new EventClasses.Events();
                        wed1230a.Day = "Wednesday";
                        wed1230a.Time = 0030;
                        wed1230a.Event = this.wed1230aTextBox.Text;
                        evnts.Add(wed1230a);
                    }
                }
                if (wed1aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed1a = new EventClasses.Events();
                        wed1a.Day = "Wednesday";
                        wed1a.Time = 0100;
                        wed1a.Event = this.wed1aTextBox.Text;
                        evnts.Add(wed1a);
                    }
                }
                if (wed130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed130a = new EventClasses.Events();
                        wed130a.Day = "Wednesday";
                        wed130a.Time = 0130;
                        wed130a.Event = this.wed130aTextBox.Text;
                        evnts.Add(wed130a);
                    }
                }
                if (wed2aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed2a = new EventClasses.Events();
                        wed2a.Day = "Wednesday";
                        wed2a.Time = 0200;
                        wed2a.Event = this.wed2aTextBox.Text;
                        evnts.Add(wed2a);
                    }
                }
                if (wed230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed230a = new EventClasses.Events();
                        wed230a.Day = "Wednesday";
                        wed230a.Time = 0230;
                        wed230a.Event = this.wed230aTextBox.Text;
                        evnts.Add(wed230a);
                    }
                }
                if (wed3aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed3a = new EventClasses.Events();
                        wed3a.Day = "Wednesday";
                        wed3a.Time = 0300;
                        wed3a.Event = this.wed3aTextBox.Text;
                        evnts.Add(wed3a);
                    }
                }
                if (wed330aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed330a = new EventClasses.Events();
                        wed330a.Day = "Wednesday";
                        wed330a.Time = 0330;
                        wed330a.Event = this.wed330aTextBox.Text;
                        evnts.Add(wed330a);
                    }
                }
                if (wed4aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed4a = new EventClasses.Events();
                        wed4a.Day = "Wednesday";
                        wed4a.Time = 0400;
                        wed4a.Event = this.wed4aTextBox.Text;
                        evnts.Add(wed4a);
                    }
                }
                if (wed430aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed430a = new EventClasses.Events();
                        wed430a.Day = "Wednesday";
                        wed430a.Time = 0430;
                        wed430a.Event = this.wed430aTextBox.Text;
                        evnts.Add(wed430a);
                    }
                }
                if (wed5aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed5a = new EventClasses.Events();
                        wed5a.Day = "Wednesday";
                        wed5a.Time = 0500;
                        wed5a.Event = this.wed5aTextBox.Text;
                        evnts.Add(wed5a);
                    }
                }
                if (wed530aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed530a = new EventClasses.Events();
                        wed530a.Day = "Wednesday";
                        wed530a.Time = 0530;
                        wed530a.Event = this.wed530aTextBox.Text;
                        evnts.Add(wed530a);
                    }
                }
                if (wed6aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed6a = new EventClasses.Events();
                        wed6a.Day = "Wednesday";
                        wed6a.Time = 0600;
                        wed6a.Event = this.wed6aTextBox.Text;
                        evnts.Add(wed6a);
                    }
                }
                if (wed630aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed630a = new EventClasses.Events();
                        wed630a.Day = "Wednesday";
                        wed630a.Time = 0630;
                        wed630a.Event = this.wed630aTextBox.Text;
                        evnts.Add(wed630a);
                    }
                }
                if (wed7aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed7a = new EventClasses.Events();
                        wed7a.Day = "Wednesday";
                        wed7a.Time = 0700;
                        wed7a.Event = this.wed7aTextBox.Text;
                        evnts.Add(wed7a);
                    }
                }
                if (wed730aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed730a = new EventClasses.Events();
                        wed730a.Day = "Wednesday";
                        wed730a.Time = 0730;
                        wed730a.Event = this.wed730aTextBox.Text;
                        evnts.Add(wed730a);
                    }
                }
                if (wed8aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed8a = new EventClasses.Events();
                        wed8a.Day = "Wednesday";
                        wed8a.Time = 0800;
                        wed8a.Event = this.wed8aTextBox.Text;
                        evnts.Add(wed8a);
                    }
                }
                if (wed830aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed830a = new EventClasses.Events();
                        wed830a.Day = "Wednesday";
                        wed830a.Time = 0830;
                        wed830a.Event = this.wed830aTextBox.Text;
                        evnts.Add(wed830a);
                    }
                }
                if (wed9aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed9a = new EventClasses.Events();
                        wed9a.Day = "Wednesday";
                        wed9a.Time = 0900;
                        wed9a.Event = this.wed9aTextBox.Text;
                        evnts.Add(wed9a);
                    }
                }
                if (wed930aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed930a = new EventClasses.Events();
                        wed930a.Day = "Wednesday";
                        wed930a.Time = 0930;
                        wed930a.Event = this.wed930aTextBox.Text;
                        evnts.Add(wed930a);
                    }
                }
                if (wed10aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed10a = new EventClasses.Events();
                        wed10a.Day = "Wednesday";
                        wed10a.Time = 1000;
                        wed10a.Event = this.wed10aTextBox.Text;
                        evnts.Add(wed10a);
                    }
                }
                if (wed1030aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed1030a = new EventClasses.Events();
                        wed1030a.Day = "Wednesday";
                        wed1030a.Time = 1030;
                        wed1030a.Event = this.wed1030aTextBox.Text;
                        evnts.Add(wed1030a);
                    }
                }
                if (wed11aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed11a = new EventClasses.Events();
                        wed11a.Day = "Wednesday";
                        wed11a.Time = 1100;
                        wed11a.Event = this.wed11aTextBox.Text;
                        evnts.Add(wed11a);
                    }
                }
                if (wed1130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed1130a = new EventClasses.Events();
                        wed1130a.Day = "Wednesday";
                        wed1130a.Time = 1130;
                        wed1130a.Event = this.wed1130aTextBox.Text;
                        evnts.Add(wed1130a);
                    }
                }
                if (wed12pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed12p = new EventClasses.Events();
                        wed12p.Day = "Wednesday";
                        wed12p.Time = 1200;
                        wed12p.Event = this.wed12pTextBox.Text;
                        evnts.Add(wed12p);
                    }
                }
                if (wed1230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed1230p = new EventClasses.Events();
                        wed1230p.Day = "Wednesday";
                        wed1230p.Time = 1230;
                        wed1230p.Event = this.wed1230pTextBox.Text;
                        evnts.Add(wed1230p);
                    }
                }
                if (wed1pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed1p = new EventClasses.Events();
                        wed1p.Day = "Wednesday";
                        wed1p.Time = 1300;
                        wed1p.Event = this.wed1pTextBox.Text;
                        evnts.Add(wed1p);
                    }
                }
                if (wed130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed130p = new EventClasses.Events();
                        wed130p.Day = "Wednesday";
                        wed130p.Time = 1330;
                        wed130p.Event = this.wed130pTextBox.Text;
                        evnts.Add(wed130p);
                    }
                }
                if (wed2pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed2p = new EventClasses.Events();
                        wed2p.Day = "Wednesday";
                        wed2p.Time = 1400;
                        wed2p.Event = this.wed2pTextBox.Text;
                        evnts.Add(wed2p);
                    }
                }
                if (wed230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed230p = new EventClasses.Events();
                        wed230p.Day = "Wednesday";
                        wed230p.Time = 1430;
                        wed230p.Event = this.wed230pTextBox.Text;
                        evnts.Add(wed230p);
                    }
                }
                if (wed3pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed3p = new EventClasses.Events();
                        wed3p.Day = "Wednesday";
                        wed3p.Time = 1500;
                        wed3p.Event = this.wed3pTextBox.Text;
                        evnts.Add(wed3p);
                    }
                }
                if (wed330pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed330p = new EventClasses.Events();
                        wed330p.Day = "Wednesday";
                        wed330p.Time = 1530;
                        wed330p.Event = this.wed330pTextBox.Text;
                        evnts.Add(wed330p);
                    }
                }
                if (wed4pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed4p = new EventClasses.Events();
                        wed4p.Day = "Wednesday";
                        wed4p.Time = 1600;
                        wed4p.Event = this.wed4pTextBox.Text;
                        evnts.Add(wed4p);
                    }
                }
                if (wed430pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed430p = new EventClasses.Events();
                        wed430p.Day = "Wednesday";
                        wed430p.Time = 1630;
                        wed430p.Event = this.wed430pTextBox.Text;
                        evnts.Add(wed430p);
                    }
                }
                if (wed5pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed5p = new EventClasses.Events();
                        wed5p.Day = "Wednesday";
                        wed5p.Time = 1700;
                        wed5p.Event = this.wed5pTextBox.Text;
                        evnts.Add(wed5p);
                    }
                }
                if (wed530pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed530p = new EventClasses.Events();
                        wed530p.Day = "Wednesday";
                        wed530p.Time = 1730;
                        wed530p.Event = this.wed530pTextBox.Text;
                        evnts.Add(wed530p);
                    }
                }
                if (wed6pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed6p = new EventClasses.Events();
                        wed6p.Day = "Wednesday";
                        wed6p.Time = 1800;
                        wed6p.Event = this.wed6pTextBox.Text;
                        evnts.Add(wed6p);
                    }
                }
                if (wed630pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed630p = new EventClasses.Events();
                        wed630p.Day = "Wednesday";
                        wed630p.Time = 1830;
                        wed630p.Event = this.wed630pTextBox.Text;
                        evnts.Add(wed630p);
                    }
                }
                if (wed7pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed7p = new EventClasses.Events();
                        wed7p.Day = "Wednesday";
                        wed7p.Time = 1900;
                        wed7p.Event = this.wed7pTextBox.Text;
                        evnts.Add(wed7p);
                    }
                }
                if (wed730pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed730p = new EventClasses.Events();
                        wed730p.Day = "Wednesday";
                        wed730p.Time = 1930;
                        wed730p.Event = this.wed730pTextBox.Text;
                        evnts.Add(wed730p);
                    }
                }
                if (wed8pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed8p = new EventClasses.Events();
                        wed8p.Day = "Wednesday";
                        wed8p.Time = 2000;
                        wed8p.Event = this.wed8pTextBox.Text;
                        evnts.Add(wed8p);
                    }
                }
                if (wed830pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed830p = new EventClasses.Events();
                        wed830p.Day = "Wednesday";
                        wed830p.Time = 2030;
                        wed830p.Event = this.wed830pTextBox.Text;
                        evnts.Add(wed830p);
                    }
                }
                if (wed9pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed9p = new EventClasses.Events();
                        wed9p.Day = "Wednesday";
                        wed9p.Time = 2100;
                        wed9p.Event = this.wed9pTextBox.Text;
                        evnts.Add(wed9p);
                    }
                }
                if (wed930pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed930p = new EventClasses.Events();
                        wed930p.Day = "Wednesday";
                        wed930p.Time = 2130;
                        wed930p.Event = this.wed930pTextBox.Text;
                        evnts.Add(wed930p);
                    }
                }
                if (wed10pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed10p = new EventClasses.Events();
                        wed10p.Day = "Wednesday";
                        wed10p.Time = 2200;
                        wed10p.Event = this.wed10pTextBox.Text;
                        evnts.Add(wed10p);
                    }
                }
                if (wed1030pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed1030p = new EventClasses.Events();
                        wed1030p.Day = "Wednesday";
                        wed1030p.Time = 2230;
                        wed1030p.Event = this.wed1030pTextBox.Text;
                        evnts.Add(wed1030p);
                    }
                }
                if (wed11pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed11p = new EventClasses.Events();
                        wed11p.Day = "Wednesday";
                        wed11p.Time = 2300;
                        wed11p.Event = this.wed11pTextBox.Text;
                        evnts.Add(wed11p);
                    }
                }
                if (wed1130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events wed1130p = new EventClasses.Events();
                        wed1130p.Day = "Wednesday";
                        wed1130p.Time = 2330;
                        wed1130p.Event = this.wed1130pTextBox.Text;
                        evnts.Add(wed1130p);
                    }

                }
                if (th12aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th12a = new EventClasses.Events();
                        th12a.Day = "Thursday";
                        th12a.Time = 0000;
                        th12a.Event = this.th12aTextBox.Text;
                        evnts.Add(th12a);
                    }
                }
                if (th1230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th1230a = new EventClasses.Events();
                        th1230a.Day = "Thursday";
                        th1230a.Time = 0030;
                        th1230a.Event = this.th1230aTextBox.Text;
                        evnts.Add(th1230a);
                    }
                }
                if (th1aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th1a = new EventClasses.Events();
                        th1a.Day = "Thursday";
                        th1a.Time = 0100;
                        th1a.Event = this.th1aTextBox.Text;
                        evnts.Add(th1a);
                    }
                }
                if (th130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th130a = new EventClasses.Events();
                        th130a.Day = "Thursday";
                        th130a.Time = 0130;
                        th130a.Event = this.th130aTextBox.Text;
                        evnts.Add(th130a);
                    }
                }
                if (th2aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th2a = new EventClasses.Events();
                        th2a.Day = "Thursday";
                        th2a.Time = 0200;
                        th2a.Event = this.th2aTextBox.Text;
                        evnts.Add(th2a);
                    }
                }
                if (th230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th230a = new EventClasses.Events();
                        th230a.Day = "Thursday";
                        th230a.Time = 0230;
                        th230a.Event = this.th230aTextBox.Text;
                        evnts.Add(th230a);
                    }
                }
                if (th3aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th3a = new EventClasses.Events();
                        th3a.Day = "Thursday";
                        th3a.Time = 0300;
                        th3a.Event = this.th3aTextBox.Text;
                        evnts.Add(th3a);
                    }
                }
                if (th330aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th330a = new EventClasses.Events();
                        th330a.Day = "Thursday";
                        th330a.Time = 0330;
                        th330a.Event = this.th330aTextBox.Text;
                        evnts.Add(th330a);
                    }
                }
                if (th4aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th4a = new EventClasses.Events();
                        th4a.Day = "Thursday";
                        th4a.Time = 0400;
                        th4a.Event = this.th4aTextBox.Text;
                        evnts.Add(th4a);
                    }
                }
                if (th430aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th430a = new EventClasses.Events();
                        th430a.Day = "Thursday";
                        th430a.Time = 0430;
                        th430a.Event = this.th430aTextBox.Text;
                        evnts.Add(th430a);
                    }
                }
                if (th5aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th5a = new EventClasses.Events();
                        th5a.Day = "Thursday";
                        th5a.Time = 0500;
                        th5a.Event = this.th5aTextBox.Text;
                        evnts.Add(th5a);
                    }
                }
                if (th530aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th530a = new EventClasses.Events();
                        th530a.Day = "Thursday";
                        th530a.Time = 0530;
                        th530a.Event = this.th530aTextBox.Text;
                        evnts.Add(th530a);
                    }
                }
                if (th6aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th6a = new EventClasses.Events();
                        th6a.Day = "Thursday";
                        th6a.Time = 0600;
                        th6a.Event = this.th6aTextBox.Text;
                        evnts.Add(th6a);
                    }
                }
                if (th630aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th630a = new EventClasses.Events();
                        th630a.Day = "Thursday";
                        th630a.Time = 0630;
                        th630a.Event = this.th630aTextBox.Text;
                        evnts.Add(th630a);
                    }
                }
                if (th7aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th7a = new EventClasses.Events();
                        th7a.Day = "Thursday";
                        th7a.Time = 0700;
                        th7a.Event = this.th7aTextBox.Text;
                        evnts.Add(th7a);
                    }
                }
                if (th730aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th730a = new EventClasses.Events();
                        th730a.Day = "Thursday";
                        th730a.Time = 0730;
                        th730a.Event = this.th730aTextBox.Text;
                        evnts.Add(th730a);
                    }
                }
                if (th8aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th8a = new EventClasses.Events();
                        th8a.Day = "Thursday";
                        th8a.Time = 0800;
                        th8a.Event = this.th8aTextBox.Text;
                        evnts.Add(th8a);
                    }
                }
                if (th830aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th830a = new EventClasses.Events();
                        th830a.Day = "Thursday";
                        th830a.Time = 0830;
                        th830a.Event = this.th830aTextBox.Text;
                        evnts.Add(th830a);
                    }
                }
                if (th9aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th9a = new EventClasses.Events();
                        th9a.Day = "Thursday";
                        th9a.Time = 0900;
                        th9a.Event = this.th9aTextBox.Text;
                        evnts.Add(th9a);
                    }
                }
                if (th930aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th930a = new EventClasses.Events();
                        th930a.Day = "Thursday";
                        th930a.Time = 0930;
                        th930a.Event = this.th930aTextBox.Text;
                        evnts.Add(th930a);
                    }
                }
                if (th10aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th10a = new EventClasses.Events();
                        th10a.Day = "Thursday";
                        th10a.Time = 1000;
                        th10a.Event = this.th10aTextBox.Text;
                        evnts.Add(th10a);
                    }
                }
                if (th1030aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th1030a = new EventClasses.Events();
                        th1030a.Day = "Thursday";
                        th1030a.Time = 1030;
                        th1030a.Event = this.th1030aTextBox.Text;
                        evnts.Add(th1030a);
                    }
                }
                if (th11aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th11a = new EventClasses.Events();
                        th11a.Day = "Thursday";
                        th11a.Time = 1100;
                        th11a.Event = this.th11aTextBox.Text;
                        evnts.Add(th11a);
                    }
                }
                if (th1130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events th1130a = new EventClasses.Events();
                        th1130a.Day = "Thursday";
                        th1130a.Time = 1130;
                        th1130a.Event = this.th1130aTextBox.Text;
                        evnts.Add(th1130a);
                    }
                }
                if (th12pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th12p = new EventClasses.Events();
                        th12p.Day = "Thursday";
                        th12p.Time = 1200;
                        th12p.Event = this.th12pTextBox.Text;
                        evnts.Add(th12p);
                    }
                }
                if (th1230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th1230p = new EventClasses.Events();
                        th1230p.Day = "Thursday";
                        th1230p.Time = 1230;
                        th1230p.Event = this.th1230pTextBox.Text;
                        evnts.Add(th1230p);
                    }
                }
                if (th1pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th1p = new EventClasses.Events();
                        th1p.Day = "Thursday";
                        th1p.Time = 1300;
                        th1p.Event = this.th1pTextBox.Text;
                        evnts.Add(th1p);
                    }
                }
                if (th130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th130p = new EventClasses.Events();
                        th130p.Day = "Thursday";
                        th130p.Time = 1330;
                        th130p.Event = this.th130pTextBox.Text;
                        evnts.Add(th130p);
                    }
                }
                if (th2pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th2p = new EventClasses.Events();
                        th2p.Day = "Thursday";
                        th2p.Time = 1400;
                        th2p.Event = this.th2pTextBox.Text;
                        evnts.Add(th2p);
                    }
                }
                if (th230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th230p = new EventClasses.Events();
                        th230p.Day = "Thursday";
                        th230p.Time = 1430;
                        th230p.Event = this.th230pTextBox.Text;
                        evnts.Add(th230p);
                    }
                }
                if (th3pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th3p = new EventClasses.Events();
                        th3p.Day = "Thursday";
                        th3p.Time = 1500;
                        th3p.Event = this.th3pTextBox.Text;
                        evnts.Add(th3p);
                    }
                }
                if (th330pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th330p = new EventClasses.Events();
                        th330p.Day = "Thursday";
                        th330p.Time = 1530;
                        th330p.Event = this.th330pTextBox.Text;
                        evnts.Add(th330p);
                    }
                }
                if (th4pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th4p = new EventClasses.Events();
                        th4p.Day = "Thursday";
                        th4p.Time = 1600;
                        th4p.Event = this.th4pTextBox.Text;
                        evnts.Add(th4p);
                    }
                }
                if (th430pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th430p = new EventClasses.Events();
                        th430p.Day = "Thursday";
                        th430p.Time = 1630;
                        th430p.Event = this.th430pTextBox.Text;
                        evnts.Add(th430p);
                    }
                }
                if (th5pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th5p = new EventClasses.Events();
                        th5p.Day = "Thursday";
                        th5p.Time = 1700;
                        th5p.Event = this.th5pTextBox.Text;
                        evnts.Add(th5p);
                    }
                }
                if (th530pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th530p = new EventClasses.Events();
                        th530p.Day = "Thursday";
                        th530p.Time = 1730;
                        th530p.Event = this.th530pTextBox.Text;
                        evnts.Add(th530p);
                    }
                }
                if (th6pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th6p = new EventClasses.Events();
                        th6p.Day = "Thursday";
                        th6p.Time = 1800;
                        th6p.Event = this.th6pTextBox.Text;
                        evnts.Add(th6p);
                    }
                }
                if (th630pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th630p = new EventClasses.Events();
                        th630p.Day = "Thursday";
                        th630p.Time = 1830;
                        th630p.Event = this.th630pTextBox.Text;
                        evnts.Add(th630p);
                    }
                }
                if (th7pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th7p = new EventClasses.Events();
                        th7p.Day = "Thursday";
                        th7p.Time = 1900;
                        th7p.Event = this.th7pTextBox.Text;
                        evnts.Add(th7p);
                    }
                }
                if (th730pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th730p = new EventClasses.Events();
                        th730p.Day = "Thursday";
                        th730p.Time = 1930;
                        th730p.Event = this.th730pTextBox.Text;
                        evnts.Add(th730p);
                    }
                }
                if (th8pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th8p = new EventClasses.Events();
                        th8p.Day = "Thursday";
                        th8p.Time = 2000;
                        th8p.Event = this.th8pTextBox.Text;
                        evnts.Add(th8p);
                    }
                }
                if (th830pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th830p = new EventClasses.Events();
                        th830p.Day = "Thursday";
                        th830p.Time = 2030;
                        th830p.Event = this.th830pTextBox.Text;
                        evnts.Add(th830p);
                    }
                }
                if (th9pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th9p = new EventClasses.Events();
                        th9p.Day = "Thursday";
                        th9p.Time = 2100;
                        th9p.Event = this.th9pTextBox.Text;
                        evnts.Add(th9p);
                    }
                }
                if (th930pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th930p = new EventClasses.Events();
                        th930p.Day = "Thursday";
                        th930p.Time = 2130;
                        th930p.Event = this.th930pTextBox.Text;
                        evnts.Add(th930p);
                    }
                }
                if (th10pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th10p = new EventClasses.Events();
                        th10p.Day = "Thursday";
                        th10p.Time = 2200;
                        th10p.Event = this.th10pTextBox.Text;
                        evnts.Add(th10p);
                    }
                }
                if (th1030pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th1030p = new EventClasses.Events();
                        th1030p.Day = "Thursday";
                        th1030p.Time = 2230;
                        th1030p.Event = this.th1030pTextBox.Text;
                        evnts.Add(th1030p);
                    }
                }
                if (th11pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th11p = new EventClasses.Events();
                        th11p.Day = "Thursday";
                        th11p.Time = 2300;
                        th11p.Event = this.th11pTextBox.Text;
                        evnts.Add(th11p);
                    }
                }
                if (th1130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events th1130p = new EventClasses.Events();
                        th1130p.Day = "Thursday";
                        th1130p.Time = 2330;
                        th1130p.Event = this.th1130pTextBox.Text;
                        evnts.Add(th1130p);
                    }

                }
                if (fri12aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri12a = new EventClasses.Events();
                        fri12a.Day = "Friday";
                        fri12a.Time = 0000;
                        fri12a.Event = this.fri12aTextBox.Text;
                        evnts.Add(fri12a);
                    }
                }
                if (fri1230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri1230a = new EventClasses.Events();
                        fri1230a.Day = "Friday";
                        fri1230a.Time = 0030;
                        fri1230a.Event = this.fri1230aTextBox.Text;
                        evnts.Add(fri1230a);
                    }
                }
                if (fri1aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri1a = new EventClasses.Events();
                        fri1a.Day = "Friday";
                        fri1a.Time = 0100;
                        fri1a.Event = this.fri1aTextBox.Text;
                        evnts.Add(fri1a);
                    }
                }
                if (fri130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri130a = new EventClasses.Events();
                        fri130a.Day = "Friday";
                        fri130a.Time = 0130;
                        fri130a.Event = this.fri130aTextBox.Text;
                        evnts.Add(fri130a);
                    }
                }
                if (fri2aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri2a = new EventClasses.Events();
                        fri2a.Day = "Friday";
                        fri2a.Time = 0200;
                        fri2a.Event = this.fri2aTextBox.Text;
                        evnts.Add(fri2a);
                    }
                }
                if (fri230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri230a = new EventClasses.Events();
                        fri230a.Day = "Friday";
                        fri230a.Time = 0230;
                        fri230a.Event = this.fri230aTextBox.Text;
                        evnts.Add(fri230a);
                    }
                }
                if (fri3aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri3a = new EventClasses.Events();
                        fri3a.Day = "Friday";
                        fri3a.Time = 0300;
                        fri3a.Event = this.fri3aTextBox.Text;
                        evnts.Add(fri3a);
                    }
                }
                if (fri330aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri330a = new EventClasses.Events();
                        fri330a.Day = "Friday";
                        fri330a.Time = 0330;
                        fri330a.Event = this.fri330aTextBox.Text;
                        evnts.Add(fri330a);
                    }
                }
                if (fri4aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri4a = new EventClasses.Events();
                        fri4a.Day = "Friday";
                        fri4a.Time = 0400;
                        fri4a.Event = this.fri4aTextBox.Text;
                        evnts.Add(fri4a);
                    }
                }
                if (fri430aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri430a = new EventClasses.Events();
                        fri430a.Day = "Friday";
                        fri430a.Time = 0430;
                        fri430a.Event = this.fri430aTextBox.Text;
                        evnts.Add(fri430a);
                    }
                }
                if (fri5aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri5a = new EventClasses.Events();
                        fri5a.Day = "Friday";
                        fri5a.Time = 0500;
                        fri5a.Event = this.fri5aTextBox.Text;
                        evnts.Add(fri5a);
                    }
                }
                if (fri530aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri530a = new EventClasses.Events();
                        fri530a.Day = "Friday";
                        fri530a.Time = 0530;
                        fri530a.Event = this.fri530aTextBox.Text;
                        evnts.Add(fri530a);
                    }
                }
                if (fri6aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri6a = new EventClasses.Events();
                        fri6a.Day = "Friday";
                        fri6a.Time = 0600;
                        fri6a.Event = this.fri6aTextBox.Text;
                        evnts.Add(fri6a);
                    }
                }
                if (fri630aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri630a = new EventClasses.Events();
                        fri630a.Day = "Friday";
                        fri630a.Time = 0630;
                        fri630a.Event = this.fri630aTextBox.Text;
                        evnts.Add(fri630a);
                    }
                }
                if (fri7aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri7a = new EventClasses.Events();
                        fri7a.Day = "Friday";
                        fri7a.Time = 0700;
                        fri7a.Event = this.fri7aTextBox.Text;
                        evnts.Add(fri7a);
                    }
                }
                if (fri730aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri730a = new EventClasses.Events();
                        fri730a.Day = "Friday";
                        fri730a.Time = 0730;
                        fri730a.Event = this.fri730aTextBox.Text;
                        evnts.Add(fri730a);
                    }
                }
                if (fri8aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri8a = new EventClasses.Events();
                        fri8a.Day = "Friday";
                        fri8a.Time = 0800;
                        fri8a.Event = this.fri8aTextBox.Text;
                        evnts.Add(fri8a);
                    }
                }
                if (fri830aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri830a = new EventClasses.Events();
                        fri830a.Day = "Friday";
                        fri830a.Time = 0830;
                        fri830a.Event = this.fri830aTextBox.Text;
                        evnts.Add(fri830a);
                    }
                }
                if (fri9aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri9a = new EventClasses.Events();
                        fri9a.Day = "Friday";
                        fri9a.Time = 0900;
                        fri9a.Event = this.fri9aTextBox.Text;
                        evnts.Add(fri9a);
                    }
                }
                if (fri930aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri930a = new EventClasses.Events();
                        fri930a.Day = "Friday";
                        fri930a.Time = 0930;
                        fri930a.Event = this.fri930aTextBox.Text;
                        evnts.Add(fri930a);
                    }
                }
                if (fri10aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri10a = new EventClasses.Events();
                        fri10a.Day = "Friday";
                        fri10a.Time = 1000;
                        fri10a.Event = this.fri10aTextBox.Text;
                        evnts.Add(fri10a);
                    }
                }
                if (fri1030aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri1030a = new EventClasses.Events();
                        fri1030a.Day = "Friday";
                        fri1030a.Time = 1030;
                        fri1030a.Event = this.fri1030aTextBox.Text;
                        evnts.Add(fri1030a);
                    }
                }
                if (fri11aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri11a = new EventClasses.Events();
                        fri11a.Day = "Friday";
                        fri11a.Time = 1100;
                        fri11a.Event = this.fri11aTextBox.Text;
                        evnts.Add(fri11a);
                    }
                }
                if (fri1130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri1130a = new EventClasses.Events();
                        fri1130a.Day = "Friday";
                        fri1130a.Time = 1130;
                        fri1130a.Event = this.fri1130aTextBox.Text;
                        evnts.Add(fri1130a);
                    }
                }
                if (fri12pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri12p = new EventClasses.Events();
                        fri12p.Day = "Friday";
                        fri12p.Time = 1200;
                        fri12p.Event = this.fri12pTextBox.Text;
                        evnts.Add(fri12p);
                    }
                }
                if (fri1230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri1230p = new EventClasses.Events();
                        fri1230p.Day = "Friday";
                        fri1230p.Time = 1230;
                        fri1230p.Event = this.fri1230pTextBox.Text;
                        evnts.Add(fri1230p);
                    }
                }
                if (fri1pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri1p = new EventClasses.Events();
                        fri1p.Day = "Friday";
                        fri1p.Time = 1300;
                        fri1p.Event = this.fri1pTextBox.Text;
                        evnts.Add(fri1p);
                    }
                }
                if (fri130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri130p = new EventClasses.Events();
                        fri130p.Day = "Friday";
                        fri130p.Time = 1330;
                        fri130p.Event = this.fri130pTextBox.Text;
                        evnts.Add(fri130p);
                    }
                }
                if (fri2pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri2p = new EventClasses.Events();
                        fri2p.Day = "Friday";
                        fri2p.Time = 1400;
                        fri2p.Event = this.fri2pTextBox.Text;
                        evnts.Add(fri2p);
                    }
                }
                if (fri230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri230p = new EventClasses.Events();
                        fri230p.Day = "Friday";
                        fri230p.Time = 1430;
                        fri230p.Event = this.fri230pTextBox.Text;
                        evnts.Add(fri230p);
                    }
                }
                if (fri3pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri3p = new EventClasses.Events();
                        fri3p.Day = "Friday";
                        fri3p.Time = 1500;
                        fri3p.Event = this.fri3pTextBox.Text;
                        evnts.Add(fri3p);
                    }
                }
                if (fri330pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri330p = new EventClasses.Events();
                        fri330p.Day = "Friday";
                        fri330p.Time = 1530;
                        fri330p.Event = this.fri330pTextBox.Text;
                        evnts.Add(fri330p);
                    }
                }
                if (fri4pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri4p = new EventClasses.Events();
                        fri4p.Day = "Friday";
                        fri4p.Time = 1600;
                        fri4p.Event = this.fri4pTextBox.Text;
                        evnts.Add(fri4p);
                    }
                }
                if (fri430pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri430p = new EventClasses.Events();
                        fri430p.Day = "Friday";
                        fri430p.Time = 1630;
                        fri430p.Event = this.fri430pTextBox.Text;
                        evnts.Add(fri430p);
                    }
                }
                if (fri5pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri5p = new EventClasses.Events();
                        fri5p.Day = "Friday";
                        fri5p.Time = 1700;
                        fri5p.Event = this.fri5pTextBox.Text;
                        evnts.Add(fri5p);
                    }
                }
                if (fri530pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri530p = new EventClasses.Events();
                        fri530p.Day = "Friday";
                        fri530p.Time = 1730;
                        fri530p.Event = this.fri530pTextBox.Text;
                        evnts.Add(fri530p);
                    }
                }
                if (fri6pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri6p = new EventClasses.Events();
                        fri6p.Day = "Friday";
                        fri6p.Time = 1800;
                        fri6p.Event = this.fri6pTextBox.Text;
                        evnts.Add(fri6p);
                    }
                }
                if (fri630pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri630p = new EventClasses.Events();
                        fri630p.Day = "Friday";
                        fri630p.Time = 1830;
                        fri630p.Event = this.fri630pTextBox.Text;
                        evnts.Add(fri630p);
                    }
                }
                if (fri7pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri7p = new EventClasses.Events();
                        fri7p.Day = "Friday";
                        fri7p.Time = 1900;
                        fri7p.Event = this.fri7pTextBox.Text;
                        evnts.Add(fri7p);
                    }
                }
                if (fri730pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri730p = new EventClasses.Events();
                        fri730p.Day = "Friday";
                        fri730p.Time = 1930;
                        fri730p.Event = this.fri730pTextBox.Text;
                        evnts.Add(fri730p);
                    }
                }
                if (fri8pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri8p = new EventClasses.Events();
                        fri8p.Day = "Friday";
                        fri8p.Time = 2000;
                        fri8p.Event = this.fri8pTextBox.Text;
                        evnts.Add(fri8p);
                    }
                }
                if (fri830pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri830p = new EventClasses.Events();
                        fri830p.Day = "Friday";
                        fri830p.Time = 2030;
                        fri830p.Event = this.fri830pTextBox.Text;
                        evnts.Add(fri830p);
                    }
                }
                if (fri9pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri9p = new EventClasses.Events();
                        fri9p.Day = "Friday";
                        fri9p.Time = 2100;
                        fri9p.Event = this.fri9pTextBox.Text;
                        evnts.Add(fri9p);
                    }
                }
                if (fri930pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri930p = new EventClasses.Events();
                        fri930p.Day = "Friday";
                        fri930p.Time = 2130;
                        fri930p.Event = this.fri930pTextBox.Text;
                        evnts.Add(fri930p);
                    }
                }
                if (fri10pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri10p = new EventClasses.Events();
                        fri10p.Day = "Friday";
                        fri10p.Time = 2200;
                        fri10p.Event = this.fri10pTextBox.Text;
                        evnts.Add(fri10p);
                    }
                }
                if (fri1030pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri1030p = new EventClasses.Events();
                        fri1030p.Day = "Friday";
                        fri1030p.Time = 2230;
                        fri1030p.Event = this.fri1030pTextBox.Text;
                        evnts.Add(fri1030p);
                    }
                }
                if (fri11pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri11p = new EventClasses.Events();
                        fri11p.Day = "Friday";
                        fri11p.Time = 2300;
                        fri11p.Event = this.fri11pTextBox.Text;
                        evnts.Add(fri11p);
                    }
                }
                if (fri1130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events fri1130p = new EventClasses.Events();
                        fri1130p.Day = "Friday";
                        fri1130p.Time = 2330;
                        fri1130p.Event = this.fri1130pTextBox.Text;
                        evnts.Add(fri1130p);
                    }

                }

                if (sat12aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat12a = new EventClasses.Events();
                        sat12a.Day = "Saturday";
                        sat12a.Time = 0000;
                        sat12a.Event = this.sat12aTextBox.Text;
                        evnts.Add(sat12a);
                    }
                }
                if (sat1230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat1230a = new EventClasses.Events();
                        sat1230a.Day = "Saturday";
                        sat1230a.Time = 0030;
                        sat1230a.Event = this.sat1230aTextBox.Text;
                        evnts.Add(sat1230a);
                    }
                }
                if (sat1aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat1a = new EventClasses.Events();
                        sat1a.Day = "Saturday";
                        sat1a.Time = 0100;
                        sat1a.Event = this.sat1aTextBox.Text;
                        evnts.Add(sat1a);
                    }
                }
                if (sat130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat130a = new EventClasses.Events();
                        sat130a.Day = "Saturday";
                        sat130a.Time = 0130;
                        sat130a.Event = this.sat130aTextBox.Text;
                        evnts.Add(sat130a);
                    }
                }
                if (sat2aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat2a = new EventClasses.Events();
                        sat2a.Day = "Saturday";
                        sat2a.Time = 0200;
                        sat2a.Event = this.sat2aTextBox.Text;
                        evnts.Add(sat2a);
                    }
                }
                if (sat230aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat230a = new EventClasses.Events();
                        sat230a.Day = "Saturday";
                        sat230a.Time = 0230;
                        sat230a.Event = this.sat230aTextBox.Text;
                        evnts.Add(sat230a);
                    }
                }
                if (sat3aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat3a = new EventClasses.Events();
                        sat3a.Day = "Saturday";
                        sat3a.Time = 0300;
                        sat3a.Event = this.sat3aTextBox.Text;
                        evnts.Add(sat3a);
                    }
                }
                if (sat330aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat330a = new EventClasses.Events();
                        sat330a.Day = "Saturday";
                        sat330a.Time = 0330;
                        sat330a.Event = this.sat330aTextBox.Text;
                        evnts.Add(sat330a);
                    }
                }
                if (sat4aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat4a = new EventClasses.Events();
                        sat4a.Day = "Saturday";
                        sat4a.Time = 0400;
                        sat4a.Event = this.sat4aTextBox.Text;
                        evnts.Add(sat4a);
                    }
                }
                if (sat430aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat430a = new EventClasses.Events();
                        sat430a.Day = "Saturday";
                        sat430a.Time = 0430;
                        sat430a.Event = this.sat430aTextBox.Text;
                        evnts.Add(sat430a);
                    }
                }
                if (sat5aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat5a = new EventClasses.Events();
                        sat5a.Day = "Saturday";
                        sat5a.Time = 0500;
                        sat5a.Event = this.sat5aTextBox.Text;
                        evnts.Add(sat5a);
                    }
                }
                if (sat530aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat530a = new EventClasses.Events();
                        sat530a.Day = "Saturday";
                        sat530a.Time = 0530;
                        sat530a.Event = this.sat530aTextBox.Text;
                        evnts.Add(sat530a);
                    }
                }
                if (sat6aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat6a = new EventClasses.Events();
                        sat6a.Day = "Saturday";
                        sat6a.Time = 0600;
                        sat6a.Event = this.sat6aTextBox.Text;
                        evnts.Add(sat6a);
                    }
                }
                if (sat630aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat630a = new EventClasses.Events();
                        sat630a.Day = "Saturday";
                        sat630a.Time = 0630;
                        sat630a.Event = this.sat630aTextBox.Text;
                        evnts.Add(sat630a);
                    }
                }
                if (sat7aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat7a = new EventClasses.Events();
                        sat7a.Day = "Saturday";
                        sat7a.Time = 0700;
                        sat7a.Event = this.sat7aTextBox.Text;
                        evnts.Add(sat7a);
                    }
                }
                if (sat730aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat730a = new EventClasses.Events();
                        sat730a.Day = "Saturday";
                        sat730a.Time = 0730;
                        sat730a.Event = this.sat730aTextBox.Text;
                        evnts.Add(sat730a);
                    }
                }
                if (sat8aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat8a = new EventClasses.Events();
                        sat8a.Day = "Saturday";
                        sat8a.Time = 0800;
                        sat8a.Event = this.sat8aTextBox.Text;
                        evnts.Add(sat8a);
                    }
                }
                if (sat830aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat830a = new EventClasses.Events();
                        sat830a.Day = "Saturday";
                        sat830a.Time = 0830;
                        sat830a.Event = this.sat830aTextBox.Text;
                        evnts.Add(sat830a);
                    }
                }
                if (sat9aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat9a = new EventClasses.Events();
                        sat9a.Day = "Saturday";
                        sat9a.Time = 0900;
                        sat9a.Event = this.sat9aTextBox.Text;
                        evnts.Add(sat9a);
                    }
                }
                if (sat930aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat930a = new EventClasses.Events();
                        sat930a.Day = "Saturday";
                        sat930a.Time = 0930;
                        sat930a.Event = this.sat930aTextBox.Text;
                        evnts.Add(sat930a);
                    }
                }
                if (sat10aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat10a = new EventClasses.Events();
                        sat10a.Day = "Saturday";
                        sat10a.Time = 1000;
                        sat10a.Event = this.sat10aTextBox.Text;
                        evnts.Add(sat10a);
                    }
                }
                if (sat1030aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat1030a = new EventClasses.Events();
                        sat1030a.Day = "Saturday";
                        sat1030a.Time = 1030;
                        sat1030a.Event = this.sat1030aTextBox.Text;
                        evnts.Add(sat1030a);
                    }
                }
                if (sat11aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat11a = new EventClasses.Events();
                        sat11a.Day = "Saturday";
                        sat11a.Time = 1100;
                        sat11a.Event = this.sat11aTextBox.Text;
                        evnts.Add(sat11a);
                    }
                }
                if (sat1130aTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat1130a = new EventClasses.Events();
                        sat1130a.Day = "Saturday";
                        sat1130a.Time = 1130;
                        sat1130a.Event = this.sat1130aTextBox.Text;
                        evnts.Add(sat1130a);
                    }
                }
                if (sat12pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat12p = new EventClasses.Events();
                        sat12p.Day = "Saturday";
                        sat12p.Time = 1200;
                        sat12p.Event = this.sat12pTextBox.Text;
                        evnts.Add(sat12p);
                    }
                }
                if (sat1230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat1230p = new EventClasses.Events();
                        sat1230p.Day = "Saturday";
                        sat1230p.Time = 1230;
                        sat1230p.Event = this.sat1230pTextBox.Text;
                        evnts.Add(sat1230p);
                    }
                }
                if (sat1pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat1p = new EventClasses.Events();
                        sat1p.Day = "Saturday";
                        sat1p.Time = 1300;
                        sat1p.Event = this.sat1pTextBox.Text;
                        evnts.Add(sat1p);
                    }
                }
                if (sat130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat130p = new EventClasses.Events();
                        sat130p.Day = "Saturday";
                        sat130p.Time = 1330;
                        sat130p.Event = this.sat130pTextBox.Text;
                        evnts.Add(sat130p);
                    }
                }
                if (sat2pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat2p = new EventClasses.Events();
                        sat2p.Day = "Saturday";
                        sat2p.Time = 1400;
                        sat2p.Event = this.sat2pTextBox.Text;
                        evnts.Add(sat2p);
                    }
                }
                if (sat230pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat230p = new EventClasses.Events();
                        sat230p.Day = "Saturday";
                        sat230p.Time = 1430;
                        sat230p.Event = this.sat230pTextBox.Text;
                        evnts.Add(sat230p);
                    }
                }
                if (sat3pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat3p = new EventClasses.Events();
                        sat3p.Day = "Saturday";
                        sat3p.Time = 1500;
                        sat3p.Event = this.sat3pTextBox.Text;
                        evnts.Add(sat3p);
                    }
                }
                if (sat330pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat330p = new EventClasses.Events();
                        sat330p.Day = "Saturday";
                        sat330p.Time = 1530;
                        sat330p.Event = this.sat330pTextBox.Text;
                        evnts.Add(sat330p);
                    }
                }
                if (sat4pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat4p = new EventClasses.Events();
                        sat4p.Day = "Saturday";
                        sat4p.Time = 1600;
                        sat4p.Event = this.sat4pTextBox.Text;
                        evnts.Add(sat4p);
                    }
                }
                if (sat430pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat430p = new EventClasses.Events();
                        sat430p.Day = "Saturday";
                        sat430p.Time = 1630;
                        sat430p.Event = this.sat430pTextBox.Text;
                        evnts.Add(sat430p);
                    }
                }
                if (sat5pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat5p = new EventClasses.Events();
                        sat5p.Day = "Saturday";
                        sat5p.Time = 1700;
                        sat5p.Event = this.sat5pTextBox.Text;
                        evnts.Add(sat5p);
                    }
                }
                if (sat530pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat530p = new EventClasses.Events();
                        sat530p.Day = "Saturday";
                        sat530p.Time = 1730;
                        sat530p.Event = this.sat530pTextBox.Text;
                        evnts.Add(sat530p);
                    }
                }
                if (sat6pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat6p = new EventClasses.Events();
                        sat6p.Day = "Saturday";
                        sat6p.Time = 1800;
                        sat6p.Event = this.sat6pTextBox.Text;
                        evnts.Add(sat6p);
                    }
                }
                if (sat630pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat630p = new EventClasses.Events();
                        sat630p.Day = "Saturday";
                        sat630p.Time = 1830;
                        sat630p.Event = this.sat630pTextBox.Text;
                        evnts.Add(sat630p);
                    }
                }
                if (sat7pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat7p = new EventClasses.Events();
                        sat7p.Day = "Saturday";
                        sat7p.Time = 1900;
                        sat7p.Event = this.sat7pTextBox.Text;
                        evnts.Add(sat7p);
                    }
                }
                if (sat730pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat730p = new EventClasses.Events();
                        sat730p.Day = "Saturday";
                        sat730p.Time = 1930;
                        sat730p.Event = this.sat730pTextBox.Text;
                        evnts.Add(sat730p);
                    }
                }
                if (sat8pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat8p = new EventClasses.Events();
                        sat8p.Day = "Saturday";
                        sat8p.Time = 2000;
                        sat8p.Event = this.sat8pTextBox.Text;
                        evnts.Add(sat8p);
                    }
                }
                if (sat830pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat830p = new EventClasses.Events();
                        sat830p.Day = "Saturday";
                        sat830p.Time = 2030;
                        sat830p.Event = this.sat830pTextBox.Text;
                        evnts.Add(sat830p);
                    }
                }
                if (sat9pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat9p = new EventClasses.Events();
                        sat9p.Day = "Saturday";
                        sat9p.Time = 2100;
                        sat9p.Event = this.sat9pTextBox.Text;
                        evnts.Add(sat9p);
                    }
                }
                if (sat930pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat930p = new EventClasses.Events();
                        sat930p.Day = "Saturday";
                        sat930p.Time = 2130;
                        sat930p.Event = this.sat930pTextBox.Text;
                        evnts.Add(sat930p);
                    }
                }
                if (sat10pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat10p = new EventClasses.Events();
                        sat10p.Day = "Saturday";
                        sat10p.Time = 2200;
                        sat10p.Event = this.sat10pTextBox.Text;
                        evnts.Add(sat10p);
                    }
                }
                if (sat1030pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat1030p = new EventClasses.Events();
                        sat1030p.Day = "Saturday";
                        sat1030p.Time = 2230;
                        sat1030p.Event = this.sat1030pTextBox.Text;
                        evnts.Add(sat1030p);
                    }
                }
                if (sat11pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat11p = new EventClasses.Events();
                        sat11p.Day = "Saturday";
                        sat11p.Time = 2300;
                        sat11p.Event = this.sat11pTextBox.Text;
                        evnts.Add(sat11p);
                    }
                }
                if (sat1130pTextBox.Text != "")
                {
                    {
                        EventClasses.Events sat1130p = new EventClasses.Events();
                        sat1130p.Day = "Saturday";
                        sat1130p.Time = 2330;
                        sat1130p.Event = this.sat1130pTextBox.Text;
                        evnts.Add(sat1130p);
                    }

                }
                using (StreamWriter file = File.CreateText(@"../../schedule.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, evnts);
                }
        }
        private void OpenButton__Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                events.LoadEvents(filePath);
                foreach (EventClasses.Events evnt in events.eventsList)
                {
                    if (evnt.Day == "Sunday" && evnt.Time == 0000)
                    {
                        this.sunday12aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0030)
                    {
                        this.sunday1230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0100)
                    {
                        this.sunday1aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0130)
                    {
                        this.sunday130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0200)
                    {
                        this.sunday2aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0230)
                    {
                        this.sunday230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0300)
                    {
                        this.sunday3aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0330)
                    {
                        this.sunday330aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0400)
                    {
                        this.sunday4aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0430)
                    {
                        this.sunday430aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0500)
                    {
                        this.sunday5aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0530)
                    {
                        this.sunday530aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0600)
                    {
                        this.sunday6aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0630)
                    {
                        this.sunday630aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0700)
                    {
                        this.sunday7aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0730)
                    {
                        this.sunday730aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0800)
                    {
                        this.sunday8aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0830)
                    {
                        this.sunday830aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0900)
                    {
                        this.sunday9aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 0930)
                    {
                        this.sunday930aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1000)
                    {
                        this.sunday10aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1030)
                    {
                        this.sunday1030aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1100)
                    {
                        this.sunday11aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1130)
                    {
                        this.sunday1130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1200)
                    {
                        this.sunday12pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1230)
                    {
                        this.sunday1230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1300)
                    {
                        this.sunday1pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1330)
                    {
                        this.sunday130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1400)
                    {
                        this.sunday2pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1430)
                    {
                        this.sunday230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1500)
                    {
                        this.sunday3pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1530)
                    {
                        this.sunday330pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1600)
                    {
                        this.sunday4pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1630)
                    {
                        this.sunday430pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1700)
                    {
                        this.sunday5pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1730)
                    {
                        this.sunday530pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1800)
                    {
                        this.sunday6pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1830)
                    {
                        this.sunday630pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1900)
                    {
                        this.sunday7pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 1930)
                    {
                        this.sunday730pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 2000)
                    {
                        this.sunday8pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 2030)
                    {
                        this.sunday830pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 2100)
                    {
                        this.sunday9pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 2130)
                    {
                        this.sunday930pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 2200)
                    {
                        this.sunday10pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 2230)
                    {
                        this.sunday1030pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 2300)
                    {
                        this.sunday11pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Sunday" && evnt.Time == 2330)
                    {
                        this.sunday1130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0000)
                    {
                        this.monday12aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0030)
                    {
                        this.monday1230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0100)
                    {
                        this.monday1aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0130)
                    {
                        this.monday130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0200)
                    {
                        this.monday2aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0230)
                    {
                        this.monday230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0300)
                    {
                        this.monday3aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0330)
                    {
                        this.monday330aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0400)
                    {
                        this.monday4aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0430)
                    {
                        this.monday430aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0500)
                    {
                        this.monday5aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0530)
                    {
                        this.monday530aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0600)
                    {
                        this.monday6aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0630)
                    {
                        this.monday630aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0700)
                    {
                        this.monday7aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0730)
                    {
                        this.monday730aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0800)
                    {
                        this.monday8aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0830)
                    {
                        this.monday830aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0900)
                    {
                        this.monday9aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 0930)
                    {
                        this.monday930aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1000)
                    {
                        this.monday10aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1030)
                    {
                        this.monday1030aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1100)
                    {
                        this.monday11aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1130)
                    {
                        this.monday1130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1200)
                    {
                        this.monday12pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1230)
                    {
                        this.monday1230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1300)
                    {
                        this.monday1pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1330)
                    {
                        this.monday130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1400)
                    {
                        this.monday2pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1430)
                    {
                        this.monday230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1500)
                    {
                        this.monday3pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1530)
                    {
                        this.monday330pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1600)
                    {
                        this.monday4pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1630)
                    {
                        this.monday430pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1700)
                    {
                        this.monday5pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1730)
                    {
                        this.monday530pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1800)
                    {
                        this.monday6pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1830)
                    {
                        this.monday630pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1900)
                    {
                        this.monday7pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 1930)
                    {
                        this.monday730pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 2000)
                    {
                        this.monday8pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 2030)
                    {
                        this.monday830pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 2100)
                    {
                        this.monday9pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 2130)
                    {
                        this.monday930pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 2200)
                    {
                        this.monday10pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 2230)
                    {
                        this.monday1030pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 2300)
                    {
                        this.monday11pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Monday" && evnt.Time == 2330)
                    {
                        this.monday1130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0000)
                    {
                        this.tues12aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0030)
                    {
                        this.tues1230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0100)
                    {
                        this.tues1aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0130)
                    {
                        this.tues130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0200)
                    {
                        this.tues2aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0230)
                    {
                        this.tues230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0300)
                    {
                        this.tues3aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0330)
                    {
                        this.tues330aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0400)
                    {
                        this.tues4aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0430)
                    {
                        this.tues430aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0500)
                    {
                        this.tues5aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0530)
                    {
                        this.tues530aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0600)
                    {
                        this.tues6aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0630)
                    {
                        this.tues630aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0700)
                    {
                        this.tues7aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0730)
                    {
                        this.tues730aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0800)
                    {
                        this.tues8aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0830)
                    {
                        this.tues830aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0900)
                    {
                        this.tues9aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 0930)
                    {
                        this.tues930aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1000)
                    {
                        this.tues10aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1030)
                    {
                        this.tues1030aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1100)
                    {
                        this.tues11aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1130)
                    {
                        this.tues1130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1200)
                    {
                        this.tues12pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1230)
                    {
                        this.tues1230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1300)
                    {
                        this.tues1pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1330)
                    {
                        this.tues130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1400)
                    {
                        this.tues2pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1430)
                    {
                        this.tues230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1500)
                    {
                        this.tues3pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1530)
                    {
                        this.tues330pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1600)
                    {
                        this.tues4pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1630)
                    {
                        this.tues430pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1700)
                    {
                        this.tues5pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1730)
                    {
                        this.tues530pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1800)
                    {
                        this.tues6pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1830)
                    {
                        this.tues630pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1900)
                    {
                        this.tues7pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 1930)
                    {
                        this.tues730pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 2000)
                    {
                        this.tues8pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 2030)
                    {
                        this.tues830pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 2100)
                    {
                        this.tues9pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 2130)
                    {
                        this.tues930pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 2200)
                    {
                        this.tues10pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 2230)
                    {
                        this.tues1030pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 2300)
                    {
                        this.tues11pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Tuesday" && evnt.Time == 2330)
                    {
                        this.tues1130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0000)
                    {
                        this.wed12aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0030)
                    {
                        this.wed1230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0100)
                    {
                        this.wed1aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0130)
                    {
                        this.wed130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0200)
                    {
                        this.wed2aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0230)
                    {
                        this.wed230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0300)
                    {
                        this.wed3aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0330)
                    {
                        this.wed330aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0400)
                    {
                        this.wed4aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0430)
                    {
                        this.wed430aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0500)
                    {
                        this.wed5aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0530)
                    {
                        this.wed530aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0600)
                    {
                        this.wed6aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0630)
                    {
                        this.wed630aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0700)
                    {
                        this.wed7aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0730)
                    {
                        this.wed730aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0800)
                    {
                        this.wed8aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0830)
                    {
                        this.wed830aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0900)
                    {
                        this.wed9aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 0930)
                    {
                        this.wed930aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1000)
                    {
                        this.wed10aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1030)
                    {
                        this.wed1030aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1100)
                    {
                        this.wed11aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1130)
                    {
                        this.wed1130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1200)
                    {
                        this.wed12pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1230)
                    {
                        this.wed1230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1300)
                    {
                        this.wed1pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1330)
                    {
                        this.wed130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1400)
                    {
                        this.wed2pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1430)
                    {
                        this.wed230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1500)
                    {
                        this.wed3pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1530)
                    {
                        this.wed330pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1600)
                    {
                        this.wed4pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1630)
                    {
                        this.wed430pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1700)
                    {
                        this.wed5pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1730)
                    {
                        this.wed530pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1800)
                    {
                        this.wed6pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1830)
                    {
                        this.wed630pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1900)
                    {
                        this.wed7pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 1930)
                    {
                        this.wed730pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 2000)
                    {
                        this.wed8pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 2030)
                    {
                        this.wed830pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 2100)
                    {
                        this.wed9pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 2130)
                    {
                        this.wed930pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 2200)
                    {
                        this.wed10pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 2230)
                    {
                        this.wed1030pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 2300)
                    {
                        this.wed11pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Wednesday" && evnt.Time == 2330)
                    {
                        this.wed1130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0000)
                    {
                        this.th12aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0030)
                    {
                        this.th1230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0100)
                    {
                        this.th1aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0130)
                    {
                        this.th130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0200)
                    {
                        this.th2aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0230)
                    {
                        this.th230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0300)
                    {
                        this.th3aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0330)
                    {
                        this.th330aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0400)
                    {
                        this.th4aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0430)
                    {
                        this.th430aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0500)
                    {
                        this.th5aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0530)
                    {
                        this.th530aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0600)
                    {
                        this.th6aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0630)
                    {
                        this.th630aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0700)
                    {
                        this.th7aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0730)
                    {
                        this.th730aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0800)
                    {
                        this.th8aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0830)
                    {
                        this.th830aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0900)
                    {
                        this.th9aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 0930)
                    {
                        this.th930aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1000)
                    {
                        this.th10aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1030)
                    {
                        this.th1030aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1100)
                    {
                        this.th11aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1130)
                    {
                        this.th1130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1200)
                    {
                        this.th12pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1230)
                    {
                        this.th1230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1300)
                    {
                        this.th1pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1330)
                    {
                        this.th130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1400)
                    {
                        this.th2pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1430)
                    {
                        this.th230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1500)
                    {
                        this.th3pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1530)
                    {
                        this.th330pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1600)
                    {
                        this.th4pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1630)
                    {
                        this.th430pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1700)
                    {
                        this.th5pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1730)
                    {
                        this.th530pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1800)
                    {
                        this.th6pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1830)
                    {
                        this.th630pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1900)
                    {
                        this.th7pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 1930)
                    {
                        this.th730pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 2000)
                    {
                        this.th8pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 2030)
                    {
                        this.th830pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 2100)
                    {
                        this.th9pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 2130)
                    {
                        this.th930pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 2200)
                    {
                        this.th10pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 2230)
                    {
                        this.th1030pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 2300)
                    {
                        this.th11pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Thursday" && evnt.Time == 2330)
                    {
                        this.th1130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0000)
                    {
                        this.fri12aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0030)
                    {
                        this.fri1230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0100)
                    {
                        this.fri1aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0130)
                    {
                        this.fri130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0200)
                    {
                        this.fri2aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0230)
                    {
                        this.fri230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0300)
                    {
                        this.fri3aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0330)
                    {
                        this.fri330aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0400)
                    {
                        this.fri4aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0430)
                    {
                        this.fri430aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0500)
                    {
                        this.fri5aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0530)
                    {
                        this.fri530aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0600)
                    {
                        this.fri6aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0630)
                    {
                        this.fri630aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0700)
                    {
                        this.fri7aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0730)
                    {
                        this.fri730aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0800)
                    {
                        this.fri8aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0830)
                    {
                        this.fri830aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0900)
                    {
                        this.fri9aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 0930)
                    {
                        this.fri930aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1000)
                    {
                        this.fri10aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1030)
                    {
                        this.fri1030aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1100)
                    {
                        this.fri11aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1130)
                    {
                        this.fri1130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1200)
                    {
                        this.fri12pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1230)
                    {
                        this.fri1230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1300)
                    {
                        this.fri1pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1330)
                    {
                        this.fri130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1400)
                    {
                        this.fri2pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1430)
                    {
                        this.fri230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1500)
                    {
                        this.fri3pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1530)
                    {
                        this.fri330pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1600)
                    {
                        this.fri4pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1630)
                    {
                        this.fri430pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1700)
                    {
                        this.fri5pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1730)
                    {
                        this.fri530pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1800)
                    {
                        this.fri6pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1830)
                    {
                        this.fri630pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1900)
                    {
                        this.fri7pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 1930)
                    {
                        this.fri730pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 2000)
                    {
                        this.fri8pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 2030)
                    {
                        this.fri830pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 2100)
                    {
                        this.fri9pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 2130)
                    {
                        this.fri930pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 2200)
                    {
                        this.fri10pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 2230)
                    {
                        this.fri1030pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 2300)
                    {
                        this.fri11pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Friday" && evnt.Time == 2330)
                    {
                        this.fri1130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0000)
                    {
                        this.sat12aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0030)
                    {
                        this.sat1230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0100)
                    {
                        this.sat1aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0130)
                    {
                        this.sat130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0200)
                    {
                        this.sat2aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0230)
                    {
                        this.sat230aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0300)
                    {
                        this.sat3aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0330)
                    {
                        this.sat330aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0400)
                    {
                        this.sat4aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0430)
                    {
                        this.sat430aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0500)
                    {
                        this.sat5aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0530)
                    {
                        this.sat530aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0600)
                    {
                        this.sat6aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0630)
                    {
                        this.sat630aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0700)
                    {
                        this.sat7aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0730)
                    {
                        this.sat730aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0800)
                    {
                        this.sat8aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0830)
                    {
                        this.sat830aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0900)
                    {
                        this.sat9aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 0930)
                    {
                        this.sat930aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1000)
                    {
                        this.sat10aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1030)
                    {
                        this.sat1030aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1100)
                    {
                        this.sat11aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1130)
                    {
                        this.sat1130aTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1200)
                    {
                        this.sat12pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1230)
                    {
                        this.sat1230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1300)
                    {
                        this.sat1pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1330)
                    {
                        this.sat130pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1400)
                    {
                        this.sat2pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1430)
                    {
                        this.sat230pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1500)
                    {
                        this.sat3pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1530)
                    {
                        this.sat330pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1600)
                    {
                        this.sat4pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1630)
                    {
                        this.sat430pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1700)
                    {
                        this.sat5pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1730)
                    {
                        this.sat530pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1800)
                    {
                        this.sat6pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1830)
                    {
                        this.sat630pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1900)
                    {
                        this.sat7pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 1930)
                    {
                        this.sat730pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 2000)
                    {
                        this.sat8pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 2030)
                    {
                        this.sat830pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 2100)
                    {
                        this.sat9pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 2130)
                    {
                        this.sat930pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 2200)
                    {
                        this.sat10pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 2230)
                    {
                        this.sat1030pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 2300)
                    {
                        this.sat11pTextBox.Text = evnt.Event;
                    }
                    else if (evnt.Day == "Saturday" && evnt.Time == 2330)
                    {
                        this.sat1130pTextBox.Text = evnt.Event;
                    }

                }
            }
        }
    }
}
namespace EventClasses
{
    public class Events
    {
        public string Day { get; set; }
        public int Time { get; set; }
        public string Event { get; set; }
    }
    public class EventsClass
    {
        public List<Events> eventsList;

        //Loads in all the resurants from the jsonFile
        public void LoadEvents(string Filename)
        {
            using (System.IO.StreamReader r = new StreamReader(Filename))
            {
                string json = r.ReadToEnd();
                eventsList = JsonConvert.DeserializeObject<List<Events>>(json);

            }
        }
    }
}
