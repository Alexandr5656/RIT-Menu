using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
//using FoodClasses;
namespace RIT_Menu
{
    public partial class RestaurantList : Form
    {
        public RIT RIT_Menu = new RIT();
        public RestaurantList()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(closing_form);
            RIT_Menu.LoadResturants();
            this.VerticalScroll.Visible = false;
            panel1.Visible = false;
            for (int i = 0; i < 7; i++)
            {
                restCheck.SetItemChecked(i, true);
            }
            InitializePanels();
            
        }
        /********************************************/
        /*          Saves Json On Closing           */
        /********************************************/
        public void closing_form(object sender, FormClosingEventArgs e)
        {
            RIT_Menu.SaveResturants();
        }
        
        /**************************************/
        /*          Creates panels            */
        /**************************************/
        public void InitializePanels()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();

            foreach (Resturants rest in RIT_Menu.Rit)
            {
                

                if (showOpen.Checked)
                {
                    if (rest.IsOpen)
                    {
                        if (restCheck.CheckedItems.Contains("All"))
                        {
                            AddFavPanel(rest);
                            AddPanel(rest);
                            
                        }
                        else
                            foreach (string type in restCheck.CheckedItems)
                            {
                                if (rest.Type.Contains(type))
                                {
                                    AddFavPanel(rest);
                                    AddPanel(rest);
                                    break;
                                }
                            }
                    }
                }
                else if (!showOpen.Checked)
                {

                    if (restCheck.CheckedItems.Contains("All"))
                    {
                        AddFavPanel(rest);
                        AddPanel(rest);
                        
                    }
                    else
                        foreach (string type in restCheck.CheckedItems)
                        {
                            if (rest.Type.Contains(type))
                            {
                                AddFavPanel(rest);
                                AddPanel(rest);
                                break;
                            }
                        }
                }
            }

        }


        /**********************************/
        /*          Adds a Panel          */
        /**********************************/
        private void AddPanel(Resturants resturant)
        {
            Panel panel1 = new System.Windows.Forms.Panel();

            AddResturantToPanel(ref panel1, resturant);

            this.flowLayoutPanel1.Controls.Add(panel1);

        }


        /***********************************************/
        /*          Adds a Panel to Favorites          */
        /***********************************************/
        private void AddFavPanel(Resturants resturant)
        {
            if (resturant.favorites)
            {
                Panel panel1 = new System.Windows.Forms.Panel();

                AddResturantToPanel(ref panel1, resturant);

                this.flowLayoutPanel2.Controls.Add(panel1);
            }
        }


        /*****************************************************/
        /*          Adds a resturant to the panel            */
        /*****************************************************/
        private void AddResturantToPanel(ref Panel panel1, Resturants resturant)
        {
            /************************************/
            /*  Initiliazing controls Handling  */
            /************************************/ 
            resturant.Clicked = false;
            Label restLabel = new System.Windows.Forms.Label();
            Label cashLabel = new System.Windows.Forms.Label();
            Button addButton = new System.Windows.Forms.Button();
            Label specialLabel = new System.Windows.Forms.Label();
            Label SpecialOne = new System.Windows.Forms.Label();
            Label specialTwo = new System.Windows.Forms.Label();
            Label specialThree = new System.Windows.Forms.Label();
            Label breakfastLabel = new System.Windows.Forms.Label();
            Label lunchLabel = new System.Windows.Forms.Label();
            Label dinnerLabel = new System.Windows.Forms.Label();
            Label openedLabel = new System.Windows.Forms.Label();



            /************************************/
            /*            Panel Handling        */
            /************************************/ 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Margin = new System.Windows.Forms.Padding(75, 3, 50, 3);

            panel1.Controls.Add(restLabel);
            panel1.Controls.Add(openedLabel);
            panel1.Controls.Add(dinnerLabel);
            panel1.Controls.Add(lunchLabel);
            panel1.Controls.Add(breakfastLabel);
            panel1.Controls.Add(specialThree);
            panel1.Controls.Add(specialTwo);
            panel1.Controls.Add(SpecialOne);
            panel1.Controls.Add(specialLabel);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(cashLabel);

            
            panel1.Location = new System.Drawing.Point(15, 21);
            panel1.Name = "panel1";
            panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            panel1.Size = new System.Drawing.Size(400, 200);
            panel1.BackColor = System.Drawing.Color.Silver;
            panel1.ForeColor = System.Drawing.Color.Black;
            panel1.TabIndex = 4;

            /************************************/
            /*       Name of the Resturant      */
            /************************************/
            
            restLabel.Font = new System.Drawing.Font("Ariel", 15, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restLabel.Location = new System.Drawing.Point(0, 0);
            restLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            restLabel.Name = "restLabel";
            restLabel.Size = new System.Drawing.Size(200, 75);
            restLabel.MaximumSize = new System.Drawing.Size(200, 75);
            restLabel.AutoSize = false;
            restLabel.TabIndex = 0;
            restLabel.Text = resturant.Name;
            restLabel.Click += (sender, e) => nameClick(sender, e, resturant);


            /************************************/
            /*            Open Sentence         */
            /************************************/
            openedLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            openedLabel.Location = new System.Drawing.Point(150, 13);
            openedLabel.Name = "openedLabel";
            openedLabel.Size = new System.Drawing.Size(75, 50);
            openedLabel.TabIndex = 10;
            openedLabel.AutoSize = true;
            openedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            if(resturant.times().Equals("Closing soon."))
                openedLabel.Location = new System.Drawing.Point(195, 13);
            else 
                openedLabel.Location = new System.Drawing.Point(250, 13);
            openedLabel.Text = resturant.times();
            

           


            


            /************************************/
            /*            Cost Labeling         */
            /************************************/
            cashLabel.Font = new System.Drawing.Font("Ariel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cashLabel.Location = new System.Drawing.Point(167, 170);
            cashLabel.Name = "cashLabel";
            cashLabel.Size = new System.Drawing.Size(57, 27);
            cashLabel.TabIndex = 1;
            cashLabel.Text = resturant.Costs();



            /************************************/
            /*            AddButton             */
            /************************************/ 
            addButton.Font = new System.Drawing.Font("Ariel", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addButton.Location = new System.Drawing.Point(320, -2);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(78, 66);
            addButton.TabIndex = 2;
            addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(105)))), ((int)(((byte)(2)))));
            addButton.Text = "+";
            addButton.ForeColor = System.Drawing.Color.Black;
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += (sender, e) => adding(sender, e, resturant);


            /************************************/
            /*            Menus Handling        */
            /************************************/
            specialLabel.Font = new System.Drawing.Font("Ariel", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            specialLabel.AutoSize = true;
            specialLabel.Location = new System.Drawing.Point(50, 75);
            specialLabel.Name = "specialLabel";
            specialLabel.Size = new System.Drawing.Size(60, 20);
            specialLabel.TabIndex = 3;
            specialLabel.Text = "Specials";
            
             if (resturant.Specials.Count() > 0)
            {
                specialLabel.Text = "Specials";
                for (int i = 0; i < resturant.Specials.Count; i++)
                {
                    if (i > 2)
                        break;
                    Add_Label(ref panel1, 45, 95 + (20 * i), "- "+resturant.Specials[i].Name + " : $" + resturant.Specials[i].Price.ToString());
                }


            }
            else if (resturant.menus[0].MenuItems.Count() > 0)
            {
                specialLabel.Text = "Menu";
                for (int i = 0; i < resturant.menus[0].MenuItems.Count; i++)
                {
                    if (i > 2)
                        break;
                    Add_Label(ref panel1, 45, 95 + (20 * i), "- " + resturant.menus[0].MenuItems[i].Name +" : $"+ resturant.menus[0].MenuItems[i].Price.ToString());

                }
            }


            /************************************/
            /*        Breakfast Handling        */
            /************************************/ 
            breakfastLabel.AutoSize = true;
            breakfastLabel.Font = new System.Drawing.Font("Ariel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            breakfastLabel.Location = new System.Drawing.Point(250, 125);
            breakfastLabel.Name = "breakfastLabel";
            breakfastLabel.Size = new System.Drawing.Size(68, 17);
            breakfastLabel.TabIndex = 7;
            breakfastLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            breakfastLabel.Text = "Breakfast-Avaliable";
            breakfastLabel.Visible = resturant.Type.Contains("Breakfast");


            /************************************/
            /*            Lunch Handling        */
            /************************************/ 
            lunchLabel.AutoSize = true;
            lunchLabel.Font = new System.Drawing.Font("Ariel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lunchLabel.Location = new System.Drawing.Point(250, 150);
            lunchLabel.Name = "lunchLabel";
            lunchLabel.Size = new System.Drawing.Size(47, 17);
            lunchLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lunchLabel.TabIndex = 8;
            lunchLabel.Text = "Lunch-Avaliable";
            lunchLabel.Visible = resturant.Type.Contains("Lunch");


            /************************************/
            /*            Dinner Handling       */
            /************************************/ 
            dinnerLabel.AutoSize = true;
            dinnerLabel.Font = new System.Drawing.Font("Ariel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dinnerLabel.Location = new System.Drawing.Point(250, 175);
            dinnerLabel.Name = "dinnerLabel";
            dinnerLabel.Size = new System.Drawing.Size(50, 17);
            dinnerLabel.TabIndex = 9;
            dinnerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dinnerLabel.Text = "Dinner-Avaliable";
            dinnerLabel.Visible = resturant.Type.Contains("Dinner");




           

        }


        /*****************************************************/
        /*           Adds a Label to the panel               */
        /*****************************************************/
        private void Add_Label(ref Panel panel1, int locx, int locy, string text)
        {
            Label newLabel = new System.Windows.Forms.Label();
            panel1.Controls.Add(newLabel);
            newLabel.AutoSize = true;
            newLabel.Font = new System.Drawing.Font("Ariel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newLabel.Location = new System.Drawing.Point(locx, locy);
            newLabel.Name = "label1";
            newLabel.Size = new System.Drawing.Size(46, 17);
            newLabel.TabIndex = 5;
            newLabel.Text = text;
            newLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
        }


        /*****************************************************/
        /*                    Un-Used Method                 */
        /*****************************************************/
        private void label3_Click(object sender, EventArgs e)
        {

        }


        /******************************************************************************************************************/
        /*          Checks to see if any of the categories have been changed to only display those catergories.           */
        /******************************************************************************************************************/
        private void restCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

            InitializePanels();

        }


        /******************************************************************************************/
        /*          If the name of the resturant is clicked more details will show up .           */
        /******************************************************************************************/
        private void nameClick(object sender, EventArgs e, Resturants rest)
        {
            this.Visible = false;
            RestaurantDescription popup = new RestaurantDescription(rest, this);




        }


        /***********************************************************************************************************************/
        /* If the add button is pressed this event is called which opens up a new form to add that resurant to your calender.  */
        /***********************************************************************************************************************/
        private void adding(object sender, EventArgs e, Resturants rest)
        {
            Button tsb = (Button)sender;
            AddingEvent ae = new AddingEvent(rest);
            ae.Show();

        }


        /*****************************************************/
        /*                    Un-Used Method                 */
        /*****************************************************/
        private void addButton_Click(object sender, EventArgs e)
        {

        }

        
        /*********************************************************************/
        /* Checks to see if the "Show closed resturants" button is checked.  */
        /*********************************************************************/
        private void ShowClosed_CheckedChanged(object sender, EventArgs e)
        {
            if (showOpen.Checked)
            {
                showOpen.Text = "Only Showing Opened";
                
            }
            else if (!showOpen.Checked)
            {
                showOpen.Text = "Showing Opened and Closed";
            }

            InitializePanels();
        }


        /*****************************************************/
        /*                    Un-Used Method                 */
        /*****************************************************/
        private void suggestedLabel_Click(object sender, EventArgs e)
        {

        }


        /*****************************************************/
        /*                    Un-Used Method                 */
        /*****************************************************/
        private void Rit_Click(object sender, EventArgs e)
        {

        }


        /*****************************************************/
        /*                    Opens Menu Link                */
        /*****************************************************/
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rit.edu/fa/diningservices/locations");
        }

        private void RestaurantList_Load(object sender, EventArgs e)
        {

        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            if(RIT_Menu.favorites!=null)
            RIT_Menu.favorites.Clear();

            foreach (Resturants rest in RIT_Menu.Rit)
            {
                if (rest.favorites)
                {
                    Favorites fav = new Favorites("ss", true);
                    RIT_Menu.Add_Favorite(fav);


                }
               
            }
            RIT_Menu.SaveFavs();
            this.Close();
        }
    }
}
