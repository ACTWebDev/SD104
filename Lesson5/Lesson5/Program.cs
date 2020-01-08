using System;

namespace Lesson5
{
    class Program
    {


        enum MovieRatings
        {
            Terrible = 0,
            Bad = 1,
            OK = 2,
            PrettyGood = 3,
            ReallyGood = 4,
            Great = 5,
            BestMovieEver = 6
        }

        struct Actor
        {
            public int actor_id;
            public string first_name;
            public string last_name;
            public DateTime last_update;
        }


        static void Main(string[] args)
        {

            
            MovieRatings rating = MovieRatings.Terrible;
            if(rating == MovieRatings.Terrible)
            {
                Console.WriteLine("Worst movie I've ever seen!");

            }
            else if (rating == MovieRatings.BestMovieEver)
            {
                Console.WriteLine("It was the best movie ever!");
            }
            else
            {
                Console.WriteLine("Well, it wasn't the worst movie ever, but it wasn't the best either.");
            }
            
            Console.WriteLine("This statement after the IF will always run.");





            int movieRating = 1;
            if (movieRating == 1)
            {
                Console.WriteLine("What does a rating of 1 mean?");
            }

            Actor greatActor = new Actor();
            greatActor.actor_id = 1;
            greatActor.first_name = "Steve";
            greatActor.last_name = "McQueen";
            greatActor.last_update = DateTime.Now;

            Actor actor = new Actor
            {
                actor_id = 2,
                first_name = "Tommy",
                last_name = "Wiseau",
                last_update = DateTime.Now
            };


            if (rating == MovieRatings.Terrible & actor.last_name == "Wiseau")
            {
                Console.WriteLine("The movie is terrible and stars Tommy Wiseau. You must be watching 'The Room'! ");
            }

            if (rating == MovieRatings.Terrible | rating == MovieRatings.Bad)
            {
                Console.WriteLine("I can't recommend this movie to friends.");
            }





    }
    }
}
