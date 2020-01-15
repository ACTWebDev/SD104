using System;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            PepperoniPizza pepperoni = new PepperoniPizza();
            pepperoni.Prepare();

            CheesePizza cheese = new CheesePizza();
            cheese.Prepare();

            Oven theOven = new Oven();
            //The oven can work with any class that uses IPizza
            theOven.Bake(cheese);
            theOven.Bake(pepperoni);
           
            //Password Generator example.
            PasswordGenerator passwordGen = new PasswordGenerator();
            string password = passwordGen.CreatePassword();
            Console.WriteLine("New Password is : " + password);
        }
    }
}
