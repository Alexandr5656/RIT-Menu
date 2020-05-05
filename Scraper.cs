using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace HtmlParseScraper
{
    public class Scraper
    {


        public static List<string> Get_List()
        {

            HtmlWeb web = new HtmlWeb();

            //Full list of things
            string test = "/html/body/div[3]/div[2]/div[1]/section[1]/div[1]/div[2]/section/div/div[2]/div[2]";

            //List of Hours
            string hourTest = "/html/body/div[3]/div[2]/div[1]/section[1]/div[1]/div/section/div/div";

            //The total html of the page
            string ae = "";

            // Parse tool for resturant names
            string names = "class=\"ds-loc\">";

            // Parse tool for Menu categories
            string titlem = "<div class=\"menu-category\">";

            // Parse tool for Hours
            string wed = "<div class=\"row panel-body\">";

            //Hour website
            string hourWeb = "https://www.rit.edu/fa/diningservices/places-to-eat/hours?date=2020-02-19&format=fullweek";

            //Menu website
            string menuWeb = "https://www.rit.edu/fa/diningservices/general-menus";

            //Loads Website
            HtmlDocument doc = web.Load(menuWeb);

            //Loads all the html for Resturant titles and below
            foreach (var items in doc.DocumentNode.SelectNodes(test))
            {
                ae = (items.InnerHtml);
            }


            // List of the name of the resturants
            List<string> Names = ParseSpecfic(ae, names);
            // List of menu categories
            List<string> Titles = ParseSpecfic(ae, titlem);


            // Prints all the titles as a test
            foreach (string word in Titles)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Done");


            Console.ReadLine();
            return Titles;
        }

        //Parses the html by adding the text after the parser string which is a html code til a < appears
        public static List<string> ParseSpecfic(string st, string parser)
        {


            List<string> Titles = new List<string>();

            for (int i = 0; i < st.Length - (parser.Length + 1); i++)
            {
                if ((st.Substring(i, parser.Length)).Equals(parser))
                {
                    string temp = "";

                    for (int j = i + parser.Length; j < st.Length - (parser.Length + 1); j++)
                    {
                        temp += st[j];
                        if (st[j + 1].Equals('<'))
                        {

                            Titles.Add(temp);
                            break;
                        }

                    }
                }
            }

            return Titles;
        }


        //Cleans any html of html code and only leave a list of text
        public static List<string> CleanUp(List<string> array1)
        {
            List<string> cleaned = new List<string>();

            foreach (string word in array1)
            {

                if (!word.Equals("h3") && !word.Equals("") && !word.Equals('\n') && !word.Equals("br") && !word.Equals("div") && !word.Equals("/h3") && !word.Equals("/a"))
                {

                    if (!(word[0].Equals('d') && word[1].Equals('i') && word[2].Equals('v')) && !word.Equals("/div") && !word[0].Equals(' '))
                    {
                        cleaned.Add(word);
                    }

                }
            }
            return cleaned;
        }
    }
}
