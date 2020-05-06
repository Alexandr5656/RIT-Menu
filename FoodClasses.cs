using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using HtmlAgilityPack;
using Scraper;
using Newtonsoft.Json;


namespace FoodClasses
{
    public class RIT
    {
        public List<Resturants> Rit;

        /*****************************************************/
        /*          Loads in resturants from Json            */
        /*****************************************************/
        public RIT()
        {
            ScrapeWeb sb = new ScrapeWeb();
        }
        public void LoadResturants()
        {
            using (System.IO.StreamReader r = new StreamReader("../../json1.json"))
            {
                string json = r.ReadToEnd();
                Rit = JsonConvert.DeserializeObject<List<Resturants>>(json);

            }
        }
        public void SaveResturants()
        {
            System.IO.File.WriteAllText(@"../../json1.json", string.Empty);
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter("../../json1.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, Rit);

            }
        }
    }
    public class Resturants
    {

        /*********************************/
        /*          Variables            */
        /*********************************/
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Type = new List<string>();
        public List<Menus> menus = new List<Menus>();
        public List<Foods> Specials = new List<Foods>();
        public int HourOpen { get; set; }
        public int HourClose { get; set; }
        public bool Clicked { get; set; }
        public bool Added { get; set; }
        public bool IsOpen { get; set; }
        public bool favorites { get; set; }
        public MealHours Breakfast { get; set; }
        public MealHours Lunch { get; set; }
        public MealHours Dinner { get; set; }



        /*****************************************************/
        /*          Calc Cost By Average Food Price          */
        /*****************************************************/
         public string Costs()
         {
             string pricetag = "";
             double prices = 0;
             double count = 0;
            foreach (Menus menu in menus)
            {
                foreach (Foods food in menu.MenuItems)
                {
                    prices += food.Price;
                    count++;
                }
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
         

        /*************************************************************************************/
        /*          Gives the time til closing or opening or just if its open when           */
        /*************************************************************************************/
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


        /**************************************************************/
        /*          Gives the open and close time of each meal        */
        /**************************************************************/
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
                //if(Dinner.TimeStart!=null&&Dinner.Tim returnvalue = "Dinner: " + Change_Time(Dinner.TimeStart) + " - " + Change_Time(Dinner.TimeEnd);
            }
            return returnvalue;
        }


        /***********************************************************/
        /*          Changes the time from military to am/pm        */
        /***********************************************************/
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


        /********************************************************/
        /*          Gets military time from current time        */
        /********************************************************/
        public int timeNow = (DateTime.Now.Hour * 100 + DateTime.Now.Minute);


        /**************************************************/
        /*          Returns a open/close statement        */
        /**************************************************/
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


        /******************************************************************************************/
        /*          Adds a food to the menu maybe for a webscraper but its useless for now        */
        /******************************************************************************************/
        /*public void Add_Food(Foods food)
        {
        Menu.Add(food);
        }*/
        public void Add_Menu(Menus men)
        {
            menus.Add(men);
        }
    }
    public class MealHours
    {
        public int TimeStart { get; set; }
        public int TimeEnd { get; set; }
        public MealHours(int open, int close)
        {
            TimeStart = open;
            TimeEnd = close;
        }
    }
    public class Foods
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int TimeStart { get; set; }
        public int TimeEnd { get; set; }

    }
    public class Menus
    {
        public string Name { get; set; }
        public List<Foods> MenuItems = new List<Foods>();
        public void Add_Food(Foods food)
        {
            MenuItems.Add(food);
        }
    }

    public class ScrapeWeb
    {
        public List<string> ListOfResturants = new List<string>();
        public List<string> ListOfMenus = new List<string>();
        public List<string> ListOfFood = new List<string>();
        public ScrapeWeb()
        {

            string FullHtmlList = "/html/body/div[3]/div[2]/div[1]/section[1]/div[1]/div[2]/section/div/div[2]/div[2]";

            //List of Hours
            string hourTest = "/html/body/div[3]/div[2]/div[1]/section[1]/div[1]/div/section/div/div";

            //The total html of the page
            string ae = "";

            // Parse tool for resturant names
            string names = "class=\"ds-loc\">";

            // Parse tool for Menu categories
            string titlem = "<div class=\"menu-category\">";

            //Parse tool for food items
            string foodie = "menu-items\">";

            // Parse tool for Hours
            string wed = "<div class=\"row panel-body\">";

            //Hour website
            string hourWeb = "https://www.rit.edu/fa/diningservices/places-to-eat/hours?date=2020-02-19&format=fullweek";

            //Menu website
            string menuWeb = "https://www.rit.edu/fa/diningservices/general-menus";



            Scraping scrape = new Scraping();




            Random ran = new Random();
            ListOfResturants = scrape.Get_List(names, FullHtmlList, menuWeb);
            List<Resturants> RIT_Rest = new List<Resturants>();
            int Rest_Count = 0;
            foreach (string rest in ListOfResturants)
            {
                RIT_Rest.Add(new Resturants());
                RIT_Rest[Rest_Count].Name = rest;
                RIT_Rest[Rest_Count].HourOpen = (ran.Next(6, 12) * 100) + (ran.Next(0, 59));//random hour open generator if i couldnt get hours scraped
                RIT_Rest[Rest_Count].HourClose = (ran.Next(6, 12) * 100) + (ran.Next(0, 59));//random hour close generator if i couldnt get hours scraped
                //This description is a basis 
                RIT_Rest[Rest_Count].Description = "Located in Monroe Hall, Artesano is the on-campus patisserie offering a wide selection of upscale delicacies, including breakfast pastries and sandwiches, cookies, tarts, and a wide variety of gluten-free, vegan baked goods and specialty created treats. Artesano proudly serves blended frozen drinks, espressos, lattes and cappuccinos from Peet’s Coffee.";

                Rest_Count++;
            }






            ListOfMenus = scrape.Get_List(titlem, FullHtmlList, menuWeb);
            int Menu_Count = 0;
            List<Menus> Rit_Menus = new List<Menus>();
            foreach (string menu in ListOfMenus)
            {
                Rit_Menus.Add(new Menus());
                Rit_Menus[Menu_Count].Name = menu;
                Menu_Count++;
            }







            ListOfFood = scrape.Get_List(foodie, FullHtmlList, menuWeb);
            int Food_Count = 0;
            Random rand = new Random();
            List<Foods> Rit_Food = new List<Foods>();
            foreach (string food in ListOfFood)
            {
                Rit_Food.Add(new Foods());
                Rit_Food[Food_Count].Name = food;
                Rit_Food[Food_Count].Price = rand.Next(1, 14);//Since we cant actually get the price from the website we will use this for now
                Food_Count++;
            }

            List<string> ResturantsAndMenus = scrape.Get_List(titlem, FullHtmlList, menuWeb, names);
            List<string> MenusAndFood = scrape.Get_List(titlem, FullHtmlList, menuWeb, foodie);
            int aCount = 0;
            List<int> keysRest = new List<int>();
            List<int> keysMenu = new List<int>();
            foreach (string RestOrMenu in ResturantsAndMenus)
            {

                foreach (Resturants rest in RIT_Rest)
                {
                    if (rest.Name == RestOrMenu)
                    {
                        keysRest.Add(aCount);

                    }
                }
                aCount++;
            }
            int bCount = 0;
            foreach (string MenuOrFood in MenusAndFood)
            {

                foreach (Menus Menu in Rit_Menus)
                {
                    if (Menu.Name == MenuOrFood)
                    {
                        keysMenu.Add(bCount);

                    }
                }
                bCount++;
            }

            List<string> typess = new List<string>();
            typess.Add("Breakfast");
            int menuOrFoodCount = 0;
            //for(int i = 0;i<Rit_Menus)
            Console.WriteLine(Rit_Menus.Count + "\n" + Rit_Food.Count);
            foreach (Menus menu in Rit_Menus)
            {
                menu.Add_Food(Rit_Food[menuOrFoodCount]);
                menuOrFoodCount++;
            }
            /*
             * Waiting til i fix the food <br> problem before i implement more than one food item
             * 
             *
            for (int a = 0; a < Rit_Menus.Count; a++)
            {
                if (a != Rit_Menus.Count - 1)
                {
                    
                    for (int b = keysMenu[a]; b < (keysMenu[a + 1] - 1); b++)
                    {
                        Rit_Menus[a].Add_Food(Rit_Food[menuOrFoodCount]);
                        
                        menuOrFoodCount++;
                    }
                }
                else
                {
                    for (int b = menuOrFoodCount; b < Rit_Menus.Count; b++)
                    {
                        
                        Rit_Menus[a].Add_Food(Rit_Food[menuOrFoodCount]);
                        menuOrFoodCount++;
                    }
                }
            }

            */







            int restOrMenuCount = 0;
            for (int a = 0; a < RIT_Rest.Count; a++)
            {
                if (a != RIT_Rest.Count - 1)
                {

                    for (int b = keysRest[a]; b < (keysRest[a + 1] - 1); b++)
                    {
                        RIT_Rest[a].Add_Menu(Rit_Menus[restOrMenuCount]);

                        if (typess.Contains(Rit_Menus[restOrMenuCount].Name))
                        {
                            RIT_Rest[a].Type.Add(Rit_Menus[restOrMenuCount].Name);
                            if (Rit_Menus[restOrMenuCount].Name == "Breakfast")
                            {
                                RIT_Rest[a].Breakfast = new MealHours(rand.Next(6, 9) * 100, 900);
                            }
                            else if (Rit_Menus[restOrMenuCount].Name == "Lunch")
                            {
                                RIT_Rest[a].Lunch = new MealHours(1130, 1200);
                            }
                            else if (Rit_Menus[restOrMenuCount].Name == "Dinner")
                            {
                                RIT_Rest[a].Dinner = new MealHours(1230, 1300);
                            }
                        }
                        restOrMenuCount++;
                    }
                }
                else
                {
                    for (int b = restOrMenuCount; b < Rit_Menus.Count; b++)
                    {
                        RIT_Rest[a].menus.Add(Rit_Menus[restOrMenuCount]);
                        if (typess.Contains(Rit_Menus[restOrMenuCount].Name))
                        {
                            RIT_Rest[a].Type.Add(Rit_Menus[restOrMenuCount].Name);
                        }
                        restOrMenuCount++;
                    }
                }
            }



            /*
             * Add food now
             */
            System.IO.File.WriteAllText(@"../../json1.json", string.Empty);
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter("../../json1.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, RIT_Rest);

            }

            Console.ReadLine();
            //Loop through all theresturant and menus scrape 
            //Add the menu to the list in each resturant once the name of a resturant is called
            //loop through all the foods and menus and resturants
            //Once a resutrant name is called increase count then once a mneu is called increase the menu count
            //from there keep adding food to the menu once a resturant or menu is called increase the appropriate count
            //

        }

    }
}