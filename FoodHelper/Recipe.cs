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
        { NameOfRecipe = "IceTea";
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

            string NameOfingredient { get; set; }

            float HowMuchiNeed { get; set; }
            string TypeOfIngredient1 { get; set; }
        }

        public class Field<T> : IField
        {
            public string NameOfingredient { get; set; }

            Type IField.Type => typeof(T);

            public float HowMuchiNeed { get; set; }

            public T Value { get; set; }
            public string TypeOfIngredient1 { get; set; }

            public override string ToString()
            {
                return Value.ToString();
            }
            List<IField> fieldList = new List<IField>()
        {
            new Field<string>()
            {
                Value = "IceTea",
                HowMuchiNeed = 1.5F,
                NameOfingredient = "Water",
                TypeOfIngredient1="l"
            },
            new Field<string>()
            {
                Value = "IceTea",
                HowMuchiNeed = 6,
                NameOfingredient = "Tea bag",
                TypeOfIngredient1=""
            },
            new Field<string>()
            {
                Value = "IceTea",
                HowMuchiNeed = 2,
                NameOfingredient = "Honey",
                TypeOfIngredient1="Table spoon"
            },
            new Field<string>()
            {
                Value = "IceTea",
                HowMuchiNeed = 15,
                NameOfingredient = "Sugar",
                TypeOfIngredient1="g"
            },
            new Field<string>()
            {
                Value = "IceTea",
                HowMuchiNeed = 30,
                NameOfingredient = "Lemon juice",
                TypeOfIngredient1="ml"
            },
        };
         //this.Controls.Add(Field);
        }


    public class Recipee : IEquatable<Recipee>
    {
        public string NameOfIngredient { get; set; }

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
        }
        // Should also override == and != operators.
    }

    /*static void Main(string[] args)
    {
        var fieldList = new List<IField>()
    {
        new Field<string>()
        {
            Value = "IceTea",
            HowMuchiNeed = 1.5F,
            NameOfingredient = "Water",
            TypeOfIngredient1="l"
        },
        new Field<string>()
        {
            Value = "IceTea",
            HowMuchiNeed = 6,
            NameOfingredient = "Tea bag",
            TypeOfIngredient1=""
        },
        new Field<string>()
        {
            Value = "IceTea",
            HowMuchiNeed = 2,
            NameOfingredient = "Honey",
            TypeOfIngredient1="Table spoon"
        },
        new Field<string>()
        {
            Value = "IceTea",
            HowMuchiNeed = 15,
            NameOfingredient = "Sugar",
            TypeOfIngredient1="g"
        },
        new Field<string>()
        {
            Value = "IceTea",
            HowMuchiNeed = 30,
            NameOfingredient = "Lemon juice",
            TypeOfIngredient1="ml"
        },
        /*new Field<int>()
        {
            Value = 4711,
            HowMuchiNeed = sizeof(int),
            NameOfingredient = "An integer value"
        },
        new Field<double>()
        {
            Value = 2.4,
            HowMuchiNeed = sizeof(double),
            NameOfingredient = "A double value"
        }*/
    /*  };
      }*/
    /* public string IceTea1()
     {
         string IceTeaRecipe;
         return IceTeaRecipe;
     }*/
    // public Recipe()
    //   {
    //}

    /* public void MyMethod(int parameter1, string parameter2)
     {
         Console.WriteLine("First Parameter {0}, second parameter {1}",
                                                     parameter1, parameter2);
     }

     public int MyAutoImplementedProperty { get; set; }

     private int myPropertyVar;

     public int MyProperty
     {
         get { return myPropertyVar; }
         set { myPropertyVar = value; }
     }*/
}
//}



// Simple business object. A HowMuch is used to identify the type of part
// but the part name can change.

/*
public class Example
{
    public static void Main()
    {
        // Create a list of parts.
        List<Recipee> parts = new List<Recipee>();

        // Add parts to the list.
        parts.Add(new Recipee() { NameOfIngredient = "crank arm", HowMuch = 1234 });
        parts.Add(new Recipee() { NameOfIngredient = "chain ring", HowMuch = 1334 });
        parts.Add(new Recipee() { NameOfIngredient = "regular seat", HowMuch = 1434 });
        parts.Add(new Recipee() { NameOfIngredient = "banana seat", HowMuch = 1444 });
        parts.Add(new Recipee() { NameOfIngredient = "cassette", HowMuch = 1534 });
        parts.Add(new Recipee() { NameOfIngredient = "shift lever", HowMuch = 1634 });

        // Write out the parts in the list. This will call the overridden ToString method
        // in the Recipee class.
        Console.WriteLine();
        foreach (Recipee aPart in parts)
        {
            Console.WriteLine(aPart);
        }

        // Check the list for part #1734. This calls the IEquatable.Equals method
        // of the Recipee class, which checks the HowMuch for equality.
        Console.WriteLine("\nContains(\"1734\"): {0}",
        parts.Contains(new Recipee { HowMuch = 1734, NameOfIngredient = "" }));

        // Insert a new item at position 2.
        Console.WriteLine("\nInsert(2, \"1834\")");
        parts.Insert(2, new Recipee() { NameOfIngredient = "brake lever", HowMuch = 1834 });

        //Console.WriteLine();
        foreach (Recipee aPart in parts)
        {
            Console.WriteLine(aPart);
        }

        Console.WriteLine("\nParts[3]: {0}", parts[3]);

        Console.WriteLine("\nRemove(\"1534\")");

        // This will remove part 1534 even though the NameOfIngredient is different,
        // because the Equals method only checks HowMuch for equality.
        parts.Remove(new Recipee() { HowMuch = 1534, NameOfIngredient = "cogs" });

        Console.WriteLine();
        foreach (Recipee aPart in parts)
        {
            Console.WriteLine(aPart);
        }
        Console.WriteLine("\nRemoveAt(3)");
        // This will remove the part at index 3.
        parts.RemoveAt(3);

        Console.WriteLine();
        foreach (Recipee aPart in parts)
        {
            Console.WriteLine(aPart);
        }
    }
}*/

/*foreach (string dinosaur in dinosaurs)
{
    Console.WriteLine(dinosaur);
}*/