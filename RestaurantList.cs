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
            for (int i = 0; i < 6; i++)
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
            panel1.Controls.Add(restLabel);
            panel1.Location = new System.Drawing.Point(15, 21);
            panel1.Name = "panel1";
            panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            panel1.Size = new System.Drawing.Size(400, 279);
            panel1.BackColor = System.Drawing.Color.DimGray;
            panel1.TabIndex = 0;



            /************************************/
            /*       Name of the Resturant      */
            /************************************/ 
            restLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restLabel.Location = new System.Drawing.Point(0, 13);
            restLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            restLabel.Name = "restLabel";
            restLabel.Size = new System.Drawing.Size(100, 23);
            restLabel.TabIndex = 0;
            restLabel.Text = resturant.Name;
            restLabel.Click += (sender, e) => nameClick(sender, e, resturant);



            /************************************/
            /*            Cost Labeling         */
            /************************************/ 
            cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cashLabel.Location = new System.Drawing.Point(167, 248);
            cashLabel.Name = "cashLabel";
            cashLabel.Size = new System.Drawing.Size(57, 27);
            cashLabel.TabIndex = 1;
            cashLabel.Text = resturant.Costs();



            /************************************/
            /*            AddButton             */
            /************************************/ 
            addButton.Location = new System.Drawing.Point(320, -2);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(78, 66);
            addButton.TabIndex = 2;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += (sender, e) => adding(sender, e, resturant);


            /************************************/
            /*            Menus Handling        */
            /************************************/
            specialLabel.AutoSize = true;
            specialLabel.Location = new System.Drawing.Point(39, 102);
            specialLabel.Name = "specialLabel";
            specialLabel.Size = new System.Drawing.Size(61, 17);
            specialLabel.TabIndex = 3;
            specialLabel.Text = "Specials";
            
             if (resturant.Specials.Count() > 0)
            {
                specialLabel.Text = "Specials";
                for (int i = 0; i < resturant.Specials.Count; i++)
                {
                    if (i >= 2)
                        break;
                    Add_Label(ref panel1, 49, 140 + (10 * i), resturant.Specials[i].Name);
                }


            }
            else if (resturant.Menu.Count() > 0)
            {
                specialLabel.Text = "Menu";
                for (int i = 0; i < resturant.Specials.Count; i++)
                {
                    if (i >= 2)
                        break;
                    Add_Label(ref panel1, 40, 140 + (10 * i), resturant.Menu[i].Name);

                }
            }


            /************************************/
            /*        Breakfast Handling        */
            /************************************/ 
            breakfastLabel.AutoSize = true;
            breakfastLabel.Location = new System.Drawing.Point(320, 141);
            breakfastLabel.Name = "breakfastLabel";
            breakfastLabel.Size = new System.Drawing.Size(68, 17);
            breakfastLabel.TabIndex = 7;
            breakfastLabel.Text = "Breakfast";
            breakfastLabel.Visible = resturant.Type.Contains("Breakfast");


            /************************************/
            /*            Lunch Handling        */
            /************************************/ 
            lunchLabel.AutoSize = true;
            lunchLabel.Location = new System.Drawing.Point(320, 174);
            lunchLabel.Name = "lunchLabel";
            lunchLabel.Size = new System.Drawing.Size(47, 17);
            lunchLabel.TabIndex = 8;
            lunchLabel.Text = "Lunch";
            lunchLabel.Visible = resturant.Type.Contains("Lunch");


            /************************************/
            /*            Dinner Handling       */
            /************************************/ 
            dinnerLabel.AutoSize = true;
            dinnerLabel.Location = new System.Drawing.Point(320, 202);
            dinnerLabel.Name = "dinnerLabel";
            dinnerLabel.Size = new System.Drawing.Size(50, 17);
            dinnerLabel.TabIndex = 9;
            dinnerLabel.Text = "Dinner";
            dinnerLabel.Visible = resturant.Type.Contains("Dinner");




            /************************************/
            /*            Open Sentence         */
            /************************************/ 
            openedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            openedLabel.Location = new System.Drawing.Point(150, 13);
            openedLabel.Name = "openedLabel";
            openedLabel.Size = new System.Drawing.Size(100, 23);
            openedLabel.TabIndex = 10;
            openedLabel.AutoSize = true;
            openedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            openedLabel.Text = resturant.times();

        }


        /*****************************************************/
        /*           Adds a Label to the panel               */
        /*****************************************************/
        private void Add_Label(ref Panel panel1, int locx, int locy, string text)
        {
            Label newLabel = new System.Windows.Forms.Label();
            panel1.Controls.Add(newLabel);
            newLabel.AutoSize = true;
            newLabel.Location = new System.Drawing.Point(locx, locy);
            newLabel.Name = "label1";
            newLabel.Size = new System.Drawing.Size(46, 17);
            newLabel.TabIndex = 5;
            newLabel.Text = text;
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
            if (rest.Clicked)
            {
                tsb.Image = this.imageList1.Images[0];
                panel1.Size = new System.Drawing.Size(400, 279);
                rest.Added = false;
                rest.Clicked = false;
            }
            else
            {
                tsb.Image = this.imageList1.Images[1];
                rest.Added = true;
                rest.Clicked = true;
            }
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
    }
}
