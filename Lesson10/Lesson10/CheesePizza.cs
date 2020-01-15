using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    class CheesePizza : IPizza
    {

        public CheesePizza() { }

        public string[] ingredients { get; set; }

        public StringBuilder Prepare()
        {

            ingredients = new string[2] { "cheese", "tomato sauce" };
            StringBuilder recipe = new StringBuilder();
            for (int i = 0; i < ingredients.Length; i++)
            {
                recipe.Append("Add " + ingredients[i] + "\n");

            }

            string otherToppings = AddToppings();

            recipe.Append("Add " + otherToppings + "\n");
            recipe.Append("Bake for 10 minutes." + "\n");
            Console.WriteLine(recipe);
            return recipe;



        }
        public string AddToppings()
        {
            string otherTopping = "hot sauce";
            return otherTopping;
        }


    }
}
