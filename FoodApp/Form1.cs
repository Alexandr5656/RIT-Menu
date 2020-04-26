using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class Form1 : Form
    {
        public RIT foodApp = new RIT();
        public Form1()
        {
            InitializeComponent();

            foodApp.LoadResturants();
            
            panel1.Visible = false;
            for (int i = 0; i < 6; i++)
            { 
            restCheck.SetItemChecked(i,true);
            }
            InitializePanels();
        }
        //Creates all the panels
        private void InitializePanels()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Resturants rest in foodApp.Rit)
            {
                if (showOpen.Checked)
                {
                    if (rest.IsOpen)
                    {
                        foreach (string type in restCheck.CheckedItems)
                        {
                            if (rest.Type.Contains(type))
                            {
                                AddPanel(rest);
                                break;
                            }
                        }
                    }
                }
                else if(!showOpen.Checked)
                {

                    foreach (string type in restCheck.CheckedItems)
                    {
                        if (rest.Type.Contains(type))
                        {
                            AddPanel(rest);
                            break;
                        }
                    }
                }
            }
            
        }
        //Adds a panel
        private void AddPanel(Resturants resturant)
        {
            Panel panel1 = new System.Windows.Forms.Panel();

            AddResturantToPanel(ref panel1, resturant);
            //Add_Label(ref panel1, 50, 59, resturant.Name);
            Add_Label(ref panel1, 50, 59, resturant.times());
            Add_Label(ref panel1, 50, 59, resturant.Costs());
            Add_Label(ref panel1, 50, 59, resturant.Name);
            Add_Label(ref panel1, 50, 59, resturant.Name);
            Add_Label(ref panel1, 50, 59, resturant.Name);
            int countMeal = 0;
            foreach (string meal in resturant.Type)
            {
                Add_Label(ref panel1, 50, 59+(10*countMeal), meal);
            }
            if (resturant.Specials.Count() > 0)
            {
                for (int i = 0; i < resturant.Specials.Count; i++)
                {
                    if (i >= 2)
                        break;
                    Add_Label(ref panel1, 50, 59 + (10 * i), resturant.Specials[i].Name);
                }


            }
            else if (resturant.Menu.Count() > 0)
            {
                for (int i = 0; i < resturant.Specials.Count; i++)
                {
                    if (i >= 2)
                        break;
                    Add_Label(ref panel1, 50, 59 + (10 * i), resturant.Menu[i].Name);
                    
                }
            }
            this.flowLayoutPanel1.Controls.Add(panel1);
            this.flowLayoutPanel1.Controls.SetChildIndex(panel1, flowLayoutPanel1.Controls.Count);
        }
        //Adds a resturant to the panel
        private void AddResturantToPanel(ref Panel panel1, Resturants resturant)
        {
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
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            // 
            // restLabel
            // 
            restLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restLabel.Location = new System.Drawing.Point(0, 13);
            restLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            restLabel.Name = "restLabel";
            restLabel.Size = new System.Drawing.Size(100, 23);
            restLabel.TabIndex = 0;
            restLabel.Text = resturant.Name;
            restLabel.Click += (sender, e) => nameClick(sender, e, resturant);
            // 
            // cashLabel
            // 
            cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cashLabel.Location = new System.Drawing.Point(167, 248);
            cashLabel.Name = "cashLabel";
            cashLabel.Size = new System.Drawing.Size(57, 27);
            cashLabel.TabIndex = 1;
            cashLabel.Text = resturant.Costs();
            // 
            // addButton
            // 
            addButton.Location = new System.Drawing.Point(320, -2);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(78, 66);
            addButton.TabIndex = 2;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += (sender,e)=>adding(sender,e, resturant);
            // 
            // specialLabel
            // 
            specialLabel.AutoSize = true;
            specialLabel.Location = new System.Drawing.Point(39, 102);
            specialLabel.Name = "specialLabel";
            specialLabel.Size = new System.Drawing.Size(61, 17);
            specialLabel.TabIndex = 3;
            specialLabel.Text = "Specials";
            // 
            // SpecialOne
            // 
            SpecialOne.AutoSize = true;
            SpecialOne.Location = new System.Drawing.Point(39, 140);
            SpecialOne.Name = "SpecialOne";
            SpecialOne.Size = new System.Drawing.Size(46, 17);
            SpecialOne.TabIndex = 4;
            
            
            // 
            // specialTwo
            // 
            specialTwo.AutoSize = true;
            specialTwo.Location = new System.Drawing.Point(39, 160);
            specialTwo.Name = "specialTwo";
            specialTwo.Size = new System.Drawing.Size(46, 17);
            specialTwo.TabIndex = 5;
            
            // 
            // specialThree
            // 
            specialThree.AutoSize = true;
            specialThree.Location = new System.Drawing.Point(39, 180);
            specialThree.Name = "specialThree";
            specialThree.Size = new System.Drawing.Size(46, 17);
            specialThree.TabIndex = 6;
            
            Label[] sl = { SpecialOne,specialTwo,specialThree};
            // sl.Add(SpecialOne);
            // sl.Add(specialTwo);
            //  sl.Add(specialThree);
            if (resturant.Specials.Count()>0)
            {
                for (int i = 0; i < resturant.Specials.Count; i++)
                {
                    sl[i].Text = resturant.Specials[i].Name;
                }


            }
            else if (resturant.Menu.Count() > 0)
            {
                for (int i = 0; i < resturant.Specials.Count; i++)
                {
                    sl[i].Text = resturant.Menu[i].Name;
                }
            }
            // 
            // breakfastLabel
            // 
            breakfastLabel.AutoSize = true;
            breakfastLabel.Location = new System.Drawing.Point(320, 141);
            breakfastLabel.Name = "breakfastLabel";
            breakfastLabel.Size = new System.Drawing.Size(68, 17);
            breakfastLabel.TabIndex = 7;
            breakfastLabel.Text = "Breakfast";
            
            breakfastLabel.Visible = resturant.Type.Contains("Breakfast");
            // 
            // lunchLabel
            // 
            lunchLabel.AutoSize = true;
            lunchLabel.Location = new System.Drawing.Point(320, 174);
            lunchLabel.Name = "lunchLabel";
            lunchLabel.Size = new System.Drawing.Size(47, 17);
            lunchLabel.TabIndex = 8;
            lunchLabel.Text = "Lunch";
            lunchLabel.Visible = resturant.Type.Contains("Lunch"); 
            // 
            // dinnerLabel
            // 
            dinnerLabel.AutoSize = true;
            dinnerLabel.Location = new System.Drawing.Point(320, 202);
            dinnerLabel.Name = "dinnerLabel";
            dinnerLabel.Size = new System.Drawing.Size(50, 17);
            dinnerLabel.TabIndex = 9;
            dinnerLabel.Text = "Dinner";
            dinnerLabel.Visible = resturant.Type.Contains("Dinner");
            // 
            // openedLabel
            // 
            openedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            openedLabel.Location = new System.Drawing.Point(150, 13);
            openedLabel.Name = "openedLabel";
            openedLabel.Size = new System.Drawing.Size(100, 23);
            openedLabel.TabIndex = 10;
            openedLabel.AutoSize = true;
            openedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No; 
            openedLabel.Text = resturant.times();

        }
        private void Add_Label(ref Panel panel1,int locx,int locy, string text)
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
        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        //Checks to see if any of the categories have been changed to only display those catergories.
        private void restCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            InitializePanels();
            
        }
        //If the name of the resturant is clicked more details will show up 
        private void nameClick(object sender, EventArgs e,Resturants rest)
        { 
            this.Visible = false;
            ResterantDescription popup = new ResterantDescription(rest,this);
            
            
           
            
        }
        //If the add button is pressed this event is called which opens up a new form to add that resurant to your calender
        private void adding(object sender, EventArgs e,Resturants rest)
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
        private void addButton_Click(object sender, EventArgs e)
        {
           
        }
        //Checks to see if the "Show closed resturants" button is checked
        private void ShowClosed_CheckedChanged(object sender, EventArgs e)
        {

            InitializePanels();
        }

        private void suggestedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
