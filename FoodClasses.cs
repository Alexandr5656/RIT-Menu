using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RIT_Menu
{
    public class RIT
    {
        public List<Resturants> Rit;

        //Loads in all the resurants from the jsonFile
        public void LoadResturants()
        {
            using (System.IO.StreamReader r = new StreamReader("../../json1.json"))
            {
                string json = r.ReadToEnd();
                Rit = JsonConvert.DeserializeObject<List<Resturants>>(json);

            }
        }
    }
    public class Resturants
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Type { get; set; }
        public List<Foods> Menu { get; set; }
        public List<Foods> Specials { get; set; }

        public int HourOpen { get; set; }
        public int HourClose { get; set; }
        public bool Clicked { get; set; }
        public bool Added { get; set; }
        public bool IsOpen { get; set; }
        public bool favorites { get; set; }
        public MealHours Breakfast { get; set; }
        public MealHours Lunch { get; set; }
        public MealHours Dinner { get; set; }
        //Calculates the cost by dividing the total price of every food by the amount of food then deciding
        //how expensive the food is on average
        public string Costs()
        {
            string pricetag = "";
            double prices = 0;
            double count = 0;
            foreach (Foods food in Menu)
            {
                prices += food.Price;
                count++;
            }
            prices = (prices / count);
            if (prices < 3.00)
                pricetag = "$";
            else if (prices > 3.00)
                pricetag = "$$";
            else if (prices > 8.00)
                pricetag = "$$$";
            return pricetag;
        }
        //Gives the time til closing or opening or just if its open when 
        public string Time(bool OpenOrClose)
        {
            string time = "";
            if (OpenOrClose)
            {
                time = HourOpen.ToString().Substring(0, 2) + ":" + HourOpen.ToString().Substring(2, 2);
                if (HourOpen > 1200)
                {
                    time += " PM";
                }
                else
                {
                    time += " AM";
                }

            }
            else if (!OpenOrClose)
            {
                time = HourClose.ToString().Substring(0, 2) + " : " + HourClose.ToString().Substring(2, 2);
                if (HourClose > 1200)
                {
                    time += " PM";
                }
                else
                {
                    time += " AM";
                }
            }

            return time;
        }
        public string Time(string type)
        {
            string returnvalue = "";
            if (type.Equals("Breakfast"))
            {
                //if(Breakfast.TimeStart!=null&&Breakfast.TimeEnd!=null)
                returnvalue = "Breakfast: " + Change_Time(Breakfast.TimeStart) + " - " + Change_Time(Breakfast.TimeEnd);
            }
            else if (type.Equals("Lunch"))
            {
                //if(Lunch.TimeStart!=null&&Lunch.TimeEnd!=null)
                returnvalue = "Lunch: " + Change_Time(Lunch.TimeStart) + " - " + Change_Time(Lunch.TimeEnd);
            }
            else if (type.Equals("Dinner"))
            {
                //if(Dinner.TimeStart!=null&&Dinner.TimeEnd!=null)
                returnvalue = "Dinner: " + Change_Time(Dinner.TimeStart) + " - " + Change_Time(Dinner.TimeEnd);
            }
            return returnvalue;
        }
        //Changing military time to am/pm time
        public string Change_Time(int num)
        {
            int numChanged = num % 1200;
            string ChangedTime = "";
            if (num % 1200 >= 1000)
            {
                ChangedTime += numChanged.ToString().Substring(0, 2) + ":" + numChanged.ToString().Substring(2, 2);

            }
            else if (num % 1200 >= 100)
            {
                ChangedTime += numChanged.ToString().Substring(0, 1) + ":" + numChanged.ToString().Substring(1, 2);
            }
            else
            {
                numChanged += 1200;
                ChangedTime += numChanged.ToString().Substring(0, 2) + ":" + numChanged.ToString().Substring(2, 2);
            }
            if (num > 1200)
            {
                ChangedTime += "PM";
            }
            else
            {
                ChangedTime += "AM";
            }
            return ChangedTime;
        }

        //Gets the current time for the next method
        public int timeNow = (DateTime.Now.Hour * 100 + DateTime.Now.Minute);
        //Sends the right string to the time labels for each resturant box
        public string times()
        {
            string timing = "";

            int timeTilClose = timeNow - HourClose;
            int timeTilOpen = HourOpen - timeNow;
            int operatingHours = HourClose - HourOpen;

            if (operatingHours < 0)
            {

                timeTilClose += 2400;
            }
            if (timeTilOpen >= timeNow && timeNow <= timeTilClose)
            {
                IsOpen = true;
                if (timeTilClose < 60)
                {
                    timing = "Closing soon.";
                }
                else
                {
                    timing = "Currently open.";
                }
            }
            else
            {
                IsOpen = false;
                timing = "Closed";
            }




            return timing;
        }
        //Adds a food to the menu for a webscraper may be usesless for now
        public void Add_Food(Foods food)
        {
        Menu.Add(food);
        }

    }
    public class MealHours
    {
        public int TimeStart { get; set; }
        public int TimeEnd { get; set; }
    }
    public class Foods
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int TimeStart { get; set; }
        public int TimeEnd { get; set; }
        //public string TimeOfDay { get; set; }
    }

}
