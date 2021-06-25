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
            int n = 1;
            for(int i = 0; i < 13; i++)
            {
                //n = i;
                if (numberOfPortions.Equals("i") )
                {
                    n=i;
                    return;
                }
            }/*
            else if (numberOfPortions.Equals("n+1") && n < 13)
            {
                n = n++;
            }
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
            else if (numberOfPortions.Equals("n+1")&&n<13)
            {
                n =n++;
            }*/
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
                textBox1.Text += "Eggs" + "\t\t\t" + n * (ingr = 2F) + "\t" + "" + "\r\n";
                textBox1.Text += "Mirin" + "\t\t\t" + n * (ingr = 1F) + "\t" + "table spoon" + "\r\n";
                textBox1.Text += "Sugar" + "\t\t\t" + n * (ingr = 2F) + "\t" + "table spoon" + "\r\n";
                textBox1.Text += "Salt" + "\t\t\t" + n * (ingr = 1F) + "\t" + "tea spoon" + "\r\n";
                textBox1.Text += "Oil" + "\t\t" + n * (ingr = 1F) + "\t" + "table spoon" + "\r\n";
                textBox1.Text += "\r\n\r\n";
                textBox1.Text += "Steps:\r\n";
                textBox1.Text += "1. Mix together the eggs, mirin, sugar and salt in a bowl\r\n";
                textBox1.Text += "2. Put the oil and afterwards the mixture into a pan on medium heat\r\n";
                textBox1.Text += "3. When the egg is set, gently roll it\r\n";
                textBox1.Text += "4. Remove from the pan and enjoy\r\n";
            }
            else if (chooseRecipe.Equals("Rice with strawberries"))
            {
                textBox1.Text += "Water" + "\t\t\t" + n * (ingr = 0.48F) + "\t" + "l" + "\r\n";
                textBox1.Text += "Rice" + "\t\t\t" + n * (ingr = 220F) + "\t" + "g" + "\r\n";
                textBox1.Text += "Strawberries" + "\t\t\t" + n * (ingr = 250F) + "\t" + "g" + "\r\n";
                textBox1.Text += "\r\n\r\n";
                textBox1.Text += "Steps:\r\n";
                textBox1.Text += "1. Wash the rice\r\n";
                textBox1.Text += "2. Put the water and the rice into a pot\r\n";
                textBox1.Text += "3. Bring the water to a boil\r\n";
                textBox1.Text += "4. Then turn the heat down to maintain a simmer\r\n";
                textBox1.Text += "5. For long grain rice check th rice after 15 minutes and for brown rice after 30\r\n";
                textBox1.Text += "6. Turn ofd the heat and let the rice sit\r\n";
                textBox1.Text += "7. Meanwhile crush the strawberries\r\n";
                textBox1.Text += "8. When the rice is ready, serve it with strawberries\r\n";
            }
            else if (chooseRecipe.Equals("Rice sauce"))
            {
                textBox1.Text += "Rice Vinegar" + "\t\t\t" + n * (ingr = 1.5F) + "\t" + "table sppon" + "\r\n";
                textBox1.Text += "Sugar" + "\t\t\t" + n * (ingr = 1F) + "\t" + "table sppon" + "\r\n";
                textBox1.Text += "Salt" + "\t\t" + n * (ingr = 1F) + "\t" + "table sppon" + "\r\n";
                textBox1.Text += "\r\n\r\n";
                textBox1.Text += "Steps:\r\n";
                textBox1.Text += "1. Add the rice vinegar, sugar and salt into a bowl\r\n";
                textBox1.Text += "2. Stir until the sugar dissolves\r\n";
            }
            else if (chooseRecipe.Equals("Pina Colada"))
            {
                textBox1.Text += "Ice" + "\t\t\t" + n * (ingr = 470F) + "\t" + "g" + "\r\n";
                textBox1.Text += "Cream of Coconut" + "\t\t\t" + n * (ingr = 45F) + "\t" + "ml" + "\r\n";
                textBox1.Text += "Pineapple juice" + "\t\t\t" + n * (ingr = 45F) + "\t" + "ml" + "\r\n";
                textBox1.Text += "White Rum" + "\t\t\t" + n * (ingr = 45F) + "\t" + "ml" + "\r\n";
                textBox1.Text += "Cherry" + "\t\t" + n * (ingr = 1F) + "\t" + "" + "\r\n";
                textBox1.Text += "\r\n\r\n";
                textBox1.Text += "Steps:\r\n";
                textBox1.Text += "1. Crush the ice\r\n";
                textBox1.Text += "2. Add the ice, the cream of coconut, pineapple juice and white rum into a blender\r\n";
                textBox1.Text += "3. Blend the ingredients together until smooth\r\n";
                textBox1.Text += "4. Poor into a tall glass and garnish with a straw and a cherry\r\n";

            }
            else if (chooseRecipe.Equals("Lemon Sorbet"))
            {
                textBox1.Text += "Water" + "\t\t\t" + n * (ingr = 0.15F) + "\t" + "l" + "\r\n";
                textBox1.Text += "Sugar" + "\t\t\t" + n * (ingr = 30F) + "\t" + "g" + "\r\n";
                textBox1.Text += "lemon juice" + "\t\t" + n * (ingr = 30F) + "\t" + "ml" + "\r\n";
                textBox1.Text += "\r\n\r\n";
                textBox1.Text += "Steps:\r\n";
                textBox1.Text += "1. Juice the lemon\r\n";
                textBox1.Text += "2. Stir over low heat until the sugar dissolves\r\n";
                textBox1.Text += "3. Add the lemon juice\r\n";
                textBox1.Text += "4. Let it cool and put the mixture in a frost resistant container\r\n";
                textBox1.Text += "5. Put the container in the freezer for 3 to 5 hours\r\n";
                textBox1.Text += "6. Stir the Sorbet every hour\r\n";
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