using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    class Car
    {
        private string make;
        private string model;
        private int doors;
        private string color;
        
        public enum DriveTrain { 
            FrontWheel,
            RearWheel
        }

        public Car (string make, string model, int doors, string color, DriveTrain driveTrainType)
        {
            this.make = make;
            this.model = model;
            this.doors = doors;
            this.color = color;
            DriveTrain driveTrain = new DriveTrain();
            driveTrain = driveTrainType;
        }

        public void PaintCar(string newColor)
        {
            string[] colorOptions = {"red", "black", "blue", "yellow", "green", "silver" };
            string availableColor = Array.Find(colorOptions, color => color.Equals(newColor));

            if (availableColor == newColor) {

                this.color = newColor;
                Console.WriteLine("The " + make + " " + model + " has been painted " + newColor);
            }

            else
            {
                Console.WriteLine("Sorry, that color isn't available.");
            }
                    
        }


            
    }
}
