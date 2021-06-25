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


        public Form3()
        {
            InitializeComponent();
            //textBox1.Text = ComboBoxRecipe;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Ingredients:";

            textBox1.Text += chooseRecipe+ numberOfPortions;
            int n=0;

            if (numberOfPortions.Equals("1"))//it works XD
            {
                n = 1;
            }
            else if (numberOfPortions.Equals("2"))
            {
                n = 2;
            }



            if (chooseRecipe.Equals("IceTea"))
            {
                /*foreach (var field in fieldList)
                {
                    if (field.Variable == "IceTea:" + "\n")
                    {
                        textBox1.Text = field.NameOfingredient + "\t" + field.HowMuchiNeed + "\t" + field.TypeOfIngredient1 + "\n";
                    }
                }*/
            }
            else if (chooseRecipe.Equals("Sushi"))
            {

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


    }
    }
}
