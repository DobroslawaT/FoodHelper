using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FoodHelper
{
    public partial class Form3 : Form
    {
        public string chooseRecipe;
        public string numberOfPortions;
        
            // Variable to store the passed in text
            string Value1;
        float HowMuchiNeed1;



            /*public Form2(string text)
            {
                InitializeComponent();

                this.passedInText = text;
            }
            */
            public Form3()
        {
            InitializeComponent();
            //textBox1.Text = ComboBoxRecipe;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Ingredients:\r\n";

            //textBox1.Text += chooseRecipe + numberOfPortions;
            int n = 0;
            if (numberOfPortions.Equals("1"))//it works XD
            {
                n = 1;
            }
            else if (numberOfPortions.Equals("2"))
            {
                n = 2;
            }
            else if (numberOfPortions.Equals("3"))
            {
                n = 3;
            }
            else if (numberOfPortions.Equals("4"))
            {
                n = 4;
            }
            else if (numberOfPortions.Equals("5"))
            {
                n=5;
            }
            else if (numberOfPortions.Equals("6"))
            {
                n = 6;
            }
            // List<IField> fieldList = new List<IField>();
            float ingr = 0;
            if (chooseRecipe.Equals("IceTea"))
            {
                textBox1.Text += "Water" + "\t\t\t" + n*(ingr=1.5F) + "\t" + "l" + "\r\n";
                textBox1.Text += "Honey" + "\t\t\t" + n * (ingr = 2F) + "\t" + "table spoon" + "\r\n";
                textBox1.Text += "Tea" + "\t\t\t" + n * (ingr = 6F) + "\t" + "bag" + "\r\n";
                textBox1.Text += "Sugar" + "\t\t\t" + n * (ingr = 15F) + "\t" + "g" + "\r\n";
                textBox1.Text += "lemon juice" + "\t\t" + n * (ingr = 30F) + "\t" + "ml" + "\r\n";
                textBox1.Text += "\r\n\r\n";
                textBox1.Text += "Steps:\r\n";
                textBox1.Text += "1. Boil water\r\n";
                textBox1.Text += "2. Put the teabags in the water\r\n";
                textBox1.Text += "3. Remove the teabags\r\n";
                textBox1.Text += "4. Put the rest of ingredients inside\r\n";
                textBox1.Text += "5. Stir until honey and sugar dissolve\r\n";
                textBox1.Text += "6. Put the tea into an airtight container and put in the fridge until it's cool\r\n";


            }
            else if (chooseRecipe.Equals("Sushi"))
            {
                textBox1.Text += "Rice" + "\t\t\t" + n * (ingr = 83F) + "\t" + "g" + "\r\n";
                textBox1.Text += "Nori" + "\t\t\t" + n * (ingr = 1F) + "\t" + "pcs" + "\r\n";
                textBox1.Text += "Avocado" + "\t\t\t" + n * (ingr = 1F) + "\t" + "pcs" + "\r\n";
                textBox1.Text += "Cottage" + "\t\t\t" + n * (ingr = 9F) + "\t" + "g" + "\r\n";
                textBox1.Text += "Salmon" + "\t\t\t" + n * (ingr = 25F) + "\t" + "g" + "\r\n";
                textBox1.Text += "Water" + "\t\t\t" + n * (ingr = 166F) + "\t" + "ml" + "\r\n";
                textBox1.Text += "Japanese omlet" + "\t\t" + n * (0.5F) + "\t" + "portion" + "\r\n";
                textBox1.Text += "Rice sauce" + "\t\t" + n * (ingr = 1) + "\t" + "portion" + "\r\n";
                textBox1.Text += "\r\n\r\n";
                textBox1.Text += "Steps:\r\n";
                textBox1.Text += "1. Wash rice untill water will be clean\r\n";
                textBox1.Text += "2. Cover up rice with the water and cook around 10 minutes\r\n";
                textBox1.Text += "3. Leave for 10-15 minutes\r\n";
                textBox1.Text += "4. Add rice sauce and mix\r\n";
                textBox1.Text += "5. Wait until rice is cool\r\n";
                textBox1.Text += "6. Prepare long slices of japanese omlet, avocado and salmon\r\n";
                textBox1.Text += "6. Take nori and spread rice on it. Leave 2 cm on a top without rice\r\n";
                textBox1.Text += "7. put slices at the bottom and add some cottage on it\r\n";
                textBox1.Text += "8. Roll it and cut into peaces\r\n";
            }
            else if (chooseRecipe.Equals("Japanese omlet"))
            {

            }
            else if (chooseRecipe.Equals("Rice with strawberries"))
            {

            }
            else if (chooseRecipe.Equals("Rice sauce"))
            {

            }
            // {
            /* foreach (var IField in fieldList)
             {
                 if (IField.Name == "IceTea")
                 {
                     textBox1.Text += Field.NameOfingredient + "\t" + Field.HowMuchiNeed + "\t" + Field.TypeOfIngredient1 + "\n";
                 }
             }
        // }
        /* else if (chooseRecipe.Equals("Sushi"))
         {

         }*/
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}