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

        struct MovieData
        {
            public string MovieName;
            public MovieRatings rating;
            public bool myFavoriteMovie;
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

            //simple if statement
            int myvalue = 20;
            bool isLessThanTen = false;
            
            if (myvalue < 10)
            {
                isLessThanTen = true;
            }
            else
            {
                isLessThanTen = false;
            }

            //ternary short version
            isLessThanTen = myvalue < 10 ? true: false;

            //More Examples

            MovieData greatEscape = new MovieData();
            greatEscape.MovieName = "The Great Escape";
            greatEscape.rating = MovieRatings.BestMovieEver;

            MovieData inception = new MovieData();
            inception.MovieName = "Inception";
            inception.rating = MovieRatings.ReallyGood;

            MovieData tlj = new MovieData();
            tlj.MovieName = "The Last Jedi";
            tlj.rating = MovieRatings.Terrible;

            MovieData[] listOfMovies = { greatEscape, inception, tlj };

            for (int i = 0; i < listOfMovies.Length; i++)
            {
                //if movie has rating of best movie ever, set myFavoriteMovie to true (shorthand version_
              listOfMovies[i].myFavoriteMovie = listOfMovies[i].rating == MovieRatings.BestMovieEver ? true : false;

            }

            //if one of the movies in this list has myFavoriteMovie as true, print that out.
            foreach(MovieData movie in listOfMovies)
            {
                if (movie.myFavoriteMovie == true)
                {
                    Console.WriteLine($"{movie.MovieName} is my favorite movie");
                }
            }







        }
    }
}
