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
            string schedueleStr = "";
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartObject();
                if (sunday12aTextBox.Text != "")
                {
                    
                     writer.Formatting = Formatting.Indented;

                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday12aTextBox.Text);

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday1230aTextBox.Text != "")
                {
                    

                    writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday1230aTextBox.Text);


                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday1aTextBox.Text != "")
                {
                    

                    writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday1aTextBox.Text);
                        


                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday130aTextBox.Text != "")
                {
                    
                    writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday130aTextBox.Text);
                        


                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday2aTextBox.Text != "")
                {
                     writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday2aTextBox.Text);
                        


                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday230aTextBox.Text != "")
                {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday230aTextBox.Text);
                        


                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday3aTextBox.Text != "")
                {

                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday3aTextBox.Text);
                        


                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday330aTextBox.Text != "")
                {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday330aTextBox.Text);
                        


                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday4aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday4aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday430aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday430aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday5aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday5aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday530aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday530aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday6aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday6aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday630aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday630aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday7aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday7aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday730aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday730aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday8aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday8aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday830aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday830aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday9aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday9aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday930aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday930aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday10aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday10aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday1030aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday1030aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday11aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday11aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday1130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday1130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday12pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday12pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday1230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday1230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday1pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday1pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday2pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday2pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday3pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday3pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday330pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday330pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday4pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday4pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday430pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday430pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday5pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday5pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday530pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday530pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday6pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday6pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday630pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday630pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday7pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday7pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday730pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday730pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday8pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday8pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday830pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday830pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday9pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday9pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday930pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday930pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday10pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday10pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday1030pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday1030pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday11pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday11pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sunday1130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Sunday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sunday1130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday12aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday12aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday1230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday1230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday1aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday1aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday2aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday2aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday3aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday3aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday330aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday330aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday4aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday4aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday430aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday430aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday5aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday5aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday530aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday530aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday6aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday6aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday630aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday630aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday7aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday7aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday730aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday730aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday8aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday8aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday830aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday830aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday9aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday9aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday930aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday930aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday10aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday10aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday1030aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday1030aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday11aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday11aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday1130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday1130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday12pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday12pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday1230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday1230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday1pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday1pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday2pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday2pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday3pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday3pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday330pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday330pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday4pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday4pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday430pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday430pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday5pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday5pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday530pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday530pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday6pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday6pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday630pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday630pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday7pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday7pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday730pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday730pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday8pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday8pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday830pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday830pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday9pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday9pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday930pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday930pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday10pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday10pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday1030pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday1030pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday11pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday11pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (monday1130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Monday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.monday1130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues12aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues12aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues1230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues1230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues1aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues1aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues2aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues2aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues3aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues3aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues330aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues330aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues4aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues4aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues430aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues430aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues5aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues5aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues530aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues530aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues6aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues6aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues630aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues630aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues7aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues7aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues730aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues730aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues8aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues8aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues830aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues830aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues9aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues9aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues930aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues930aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues10aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues10aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues1030aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues1030aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues11aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues11aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues1130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues1130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues12pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues12pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues1230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues1230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues1pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues1pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues2pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues2pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues3pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues3pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues330pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues330pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues4pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues4pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues430pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues430pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues5pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues5pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues530pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues530pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues6pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues6pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues630pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues630pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues7pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues7pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues730pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues730pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues8pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues8pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues830pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues830pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues9pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues9pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues930pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues930pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues10pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues10pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues1030pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues1030pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues11pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues11pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (tues1130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Tuesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.tues1130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed12aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed12aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed1230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed1230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed1aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed1aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed2aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed2aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed3aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed3aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed330aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed330aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed4aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed4aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed430aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed430aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed5aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed5aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed530aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed530aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed6aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed6aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed630aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed630aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed7aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed7aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed730aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed730aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed8aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed8aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed830aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed830aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed9aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed9aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed930aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed930aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed10aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed10aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed1030aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed1030aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed11aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed11aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed1130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed1130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed12pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed12pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed1230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed1230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed1pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed1pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed2pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed2pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed3pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed3pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed330pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed330pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed4pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed4pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed430pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed430pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed5pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed5pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed530pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed530pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed6pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed6pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed630pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed630pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed7pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed7pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed730pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed730pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed8pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed8pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed830pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed830pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed9pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed9pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed930pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed930pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed10pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed10pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed1030pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed1030pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed11pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed11pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (wed1130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Wednesday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.wed1130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th12aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th12aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th1230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th1230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th1aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th1aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th2aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th2aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th3aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th3aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th330aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th330aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th4aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th4aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th430aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th430aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th5aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th5aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th530aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th530aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th6aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th6aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th630aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th630aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th7aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th7aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th730aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th730aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th8aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th8aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th830aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th830aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th9aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th9aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th930aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th930aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th10aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th10aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th1030aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th1030aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th11aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th11aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th1130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th1130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th12pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th12pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th1230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th1230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th1pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th1pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th2pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th2pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th3pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th3pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th330pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th330pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th4pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th4pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th430pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th430pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th5pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th5pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th530pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th530pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th6pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th6pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th630pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th630pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th7pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th7pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th730pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th730pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th8pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th8pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th830pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th830pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th9pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th9pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th930pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th930pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th10pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th10pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th1030pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th1030pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th11pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th11pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (th1130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Thursday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.th1130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri12aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri12aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri1230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri1230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri1aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri1aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri2aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri2aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri3aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri3aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri330aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri330aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri430aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri430aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri430aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri430aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri5aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri5aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri530aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri530aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri6aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri6aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri630aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri630aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri7aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri7aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri730aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri730aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri8aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri8aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri830aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri830aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri9aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri9aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri930aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri930aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri10aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri10aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri1030aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri1030aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri11aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri11aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri1130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri1130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri12pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri12pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri1230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri1230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri1pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri1pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri2pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri2pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri3pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri3pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri330pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri330pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri4pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri4pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri430pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri430pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri5pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri5pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri530pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri530pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri6pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri6pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri630pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri630pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri7pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri7pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri730pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri730pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri8pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri8pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri830pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri830pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri9pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri9pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri930pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri930pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri10pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri10pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri1030pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri1030pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri11pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri11pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (fri1130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Friday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.fri1130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat12aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat12aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat1230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat1230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat1aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat1aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat2aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat2aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat230aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat230aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat3aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat3aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat330aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat330aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat4aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat4aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat430aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat430aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat5aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat5aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat530aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat530aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat6aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat6aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat630aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat630aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat7aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat7aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat730aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat730aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat8aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat8aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat830aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat830aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat9aTextBox.Text != "")
                {



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat9aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat930aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("0930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat930aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat10aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat10aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat1030aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat1030aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat11aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat11aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat1130aTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat1130aTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat12pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat12pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat1230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat1230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat1pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat1pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat130pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat2pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1400");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat2pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat230pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1430");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat230pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat3pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1500");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat3pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat330pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1530");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat330pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat4pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1600");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat4pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat430pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1630");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat430pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat5pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1700");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat5pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat530pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1730");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat530pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat6pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1800");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat6pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat630pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1830");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat630pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat7pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1900");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat7pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat730pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("1930");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat730pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat8pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2000");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat8pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat830pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2030");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat830pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat9pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2100");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat9pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat930pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2130");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat930pTextBox.Text);
                        

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat10pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2200");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat10pTextBox.Text);
                        writer.WriteRaw(schedueleStr);

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat1030pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2230");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat1030pTextBox.Text);
                        writer.WriteRaw(schedueleStr);

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat11pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2300");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat11pTextBox.Text);
                        writer.WriteRaw(schedueleStr);

                    }

                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                if (sat1130pTextBox.Text != "")
                {
                    



                    {
                         writer.Formatting = Formatting.Indented;


                        writer.WritePropertyName("Day");
                        writer.WriteValue("Saturday");
                        writer.WritePropertyName("Time");
                        writer.WriteValue("2330");
                        writer.WritePropertyName("Event");
                        writer.WriteValue(this.sat1130pTextBox.Text);
                        writer.WriteRaw(schedueleStr);

                    }
                    System.IO.File.WriteAllText(@"D:\scheduele.json", sb.ToString() + "}");
                }
                writer.WriteEnd();
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