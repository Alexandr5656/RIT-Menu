using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EventClasses;
using EventsLib;
using Newtonsoft.Json;

namespace RIT_Menu
{
    class AddToCal
    {

        static string UppercaseFirstLetter(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        public static bool addToCalendar(string name, DateTime start, DateTime end)
        {

            List<Events> schedule = new List<Events>();


            // read our schedule file
            // load events from JSON & set it as the events list
            string scheduleJSON = System.IO.File.ReadAllText(@"../../events.json");
            schedule = JsonConvert.DeserializeObject<List<Events>>(scheduleJSON);

            Events newEvent = new Events();

            // set event details
            newEvent.Event = name;
            newEvent.Day = UppercaseFirstLetter(start.DayOfWeek.ToString());

            // add trailing 0 to the hour necessary then add them together
            string hour = start.Hour.ToString().PadLeft(2, '0');

            // the minutes are in 30 min blocks, but we will always round down
            string minute = "00";
            if (Int32.Parse(start.Minute.ToString()) > 30)
                minute = "30";

            //combine hours and mintutes to get time
            int time = Int32.Parse(hour + minute);
            newEvent.Time = time;

            //for now, we will only add the event to one time slot even if it applies to multiple.

            // add event to list
            schedule.Add(newEvent);

            // write list back to file
            string newScheduleJSON = JsonConvert.SerializeObject(schedule);
            System.IO.File.WriteAllText(@"../../schedule.json", newScheduleJSON);

            return true;

        }

    }
}
