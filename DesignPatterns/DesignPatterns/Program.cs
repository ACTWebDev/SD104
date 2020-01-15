using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Builder
            
            TheBuilder DellBuilder = new TheBuilder("Dell", "Inspiron");
            DellBuilder.AddFirstOption("black", 15);
            DellBuilder.AddSecondOption(8);
            DellBuilder.AddThirdOption(256);

            Laptop dell1 = DellBuilder.GetLaptop();

            DellBuilder.AddFirstOption("silver", 14);
            DellBuilder.AddSecondOption(16);
            DellBuilder.AddThirdOption(500);

            Laptop dell2 = DellBuilder.GetLaptop();

            //Observer

            ClassA source = new ClassA();
            FirstObserver observer1 = new FirstObserver(source);
            SecondObserver observer2 = new SecondObserver(source);
            source.ChangeMe(5);
            source.ChangeMe(90);
            source.ChangeMe(200);
            source.ChangeMe(1);

        }
    }
}
