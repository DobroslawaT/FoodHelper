using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHelper
{
    public class Recipe //: //IEquatable<Recipe>
    {
        public string NameOfRecipe;
        public string[] ingredients;
        public float[] HowMuchIngredients;//this says how much you need of some ingredient
        public string[] TypeOfMeasurment;
        // var IceTea = new Recipe();

        List<string> idk = new List<string>();
        // idk.Add("Yeah");




        public void IceTea()
        {
            NameOfRecipe = "IceTea";
            ingredients = new string[] { "Water", "Tea", "Honey", "Sugar", "Lemon" };
            HowMuchIngredients = new float[] { 1.5F, 6, 2, 1, 1 };
            TypeOfMeasurment = new string[] { "liter", "bag", "table spoon", "table spoon", "fruit" };
            WriteWhatINeed();
        }


        public void WriteWhatINeed()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ingredients[i], "\t", HowMuchIngredients[i], "\t", TypeOfMeasurment[i], "\n");


            }
        }
    }
    public interface IField
    {
        Type Type { get; }
        string Name { get; set; }
        string NameOfingredient { get; set; }

        float HowMuchiNeed { get; set; }
        string TypeOfIngredient1 { get; set; }
    }

    public class Field<T> : IField
    {
        public string Name { get; set; }
        public string NameOfingredient { get; set; }

        Type IField.Type => typeof(T);

        public float HowMuchiNeed { get; set; }

        public T Value { get; set; }
        public string TypeOfIngredient1 { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
        public List<IField> fieldList = new List<IField>()
        {
            new Field<string>()
            {
                Name = "IceTea",
                HowMuchiNeed = 1.5F,
                NameOfingredient = "Water",
                TypeOfIngredient1="l"
            },
            new Field<string>()
            {
                Name = "IceTea",
                HowMuchiNeed = 6,
                NameOfingredient = "Tea bag",
                TypeOfIngredient1=""
            },
            new Field<string>()
            {
                Name = "IceTea",
                HowMuchiNeed = 2,
                NameOfingredient = "Honey",
                TypeOfIngredient1="Table spoon"
            },
            new Field<string>()
            {
                Name = "IceTea",
                HowMuchiNeed = 15,
                NameOfingredient = "Sugar",
                TypeOfIngredient1="g"
            },
            new Field<string>()
            {
                Name = "IceTea",
                HowMuchiNeed = 30,
                NameOfingredient = "Lemon juice",
                TypeOfIngredient1="ml"
            },
        };
        //this.Controls.Add(Field);
    }


   // public class Recipee : IEquatable<Recipee>
    //{

       /* public string NameOfIngredient { get; set; }

        public int HowMuch { get; set; }

        public override string ToString()
        {
            return "   1.  " + NameOfIngredient + HowMuch;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Recipee objAsPart = obj as Recipee;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return HowMuch;
        }
        public bool Equals(Recipee other)
        {
            if (other == null) return false;
            return (this.HowMuch.Equals(other.HowMuch));
        }*/
        // Should also override == and != operators.
   // }
}