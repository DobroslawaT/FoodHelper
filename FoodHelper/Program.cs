using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHelper
{
    struct Master
    {
        public static readonly Dictionary<string, string> IceTea1 = new Dictionary<string, string>
        {
            {"Water","ml" },
            {"Teabags"," " },
            {"Honey", "Tbsp" },
            {"Sugar", "g" },
            {"Lemon juice","ml" }

        };
        public static readonly Dictionary<string, float> IceTea2 = new Dictionary<string, float>
        {
            {"Step 1",1500 },
            {"Step 2",6 },
            {"Step 3", 2 },
            {"Step 4", 15 },
            {"Step 5",30 }

        };
    }

        static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            var IceTea=new Recipe();
            IceTea.NameOfRecipe = "IceTea";
            IceTea.ingredients = new string[] { "Water", "Tea", "Honey","Sugar","Lemon"};
            IceTea.HowMuchIngredients = new float[] { 1.5F, 6,2,1,1};
            IceTea.TypeOfMeasurment = new string[] { "liter", "bag","table spoon","table spoon","fruit"};
        }
    }
}
