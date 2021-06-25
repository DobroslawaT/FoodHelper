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

        public Form3(string ComboBoxRecipe)
        {
            InitializeComponent();
            textBox1.Text = ComboBoxRecipe;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Ingredients:";
            foreach (var field in fieldList)
            {
                if (field.Variable == "IceTea:" + "\n")
                {
                    textBox1.Text = field.NameOfingredient + "\t" + field.HowMuchiNeed + "\t" + field.TypeOfIngredient1 + "\n";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
