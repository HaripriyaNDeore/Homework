using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.ObjOri
{
    class Movie
    {
        string MovieName;
        string MovieDirector;
        string MovieProducer;
        string MovieMaleActor;
        int MovieRating;

        public Movie()
        {
            Console.WriteLine("In Movie Constructor");
        }
        public void SetMovieName(string MName)
        {
            MovieName = MName;
        }
        public string GetMovieName()
        {
            return MovieName;
        }
        public void SetMovieDirector(string director)
        {
            MovieDirector = director;
        }
        public string GetMovieDirector()
        {
            return MovieDirector;
        }
        public void SetMovieProducer(string producer)
        {
            MovieProducer = producer;
        }
        public string GetMovieProducer()
        {
            return MovieProducer;
        }
        public void SetMovieMaleActor(string MActor)
        {
            MovieMaleActor = MActor;
        }
        public string GetMovieMaleActor()
        {
            return MovieMaleActor;
        }
        public void SetMovieRating(int rating)
        {
            MovieRating = rating;
        }
        public int GetMovieRating()
        {
            return MovieRating;
        }

        static void Main(string[] args)
        {
            Movie m = new Movie();
            m.SetMovieName("PavanKhind");
            m.SetMovieDirector("Digpal Lanjekar");
            m.SetMovieProducer("Ajay Arekar");
            m.SetMovieMaleActor("Ankit");
            m.SetMovieRating(5);


            Console.WriteLine("----------------------------------");
            string mname = m.GetMovieName();
            string mdire = m.GetMovieDirector();
            string mproducer = m.GetMovieProducer();
            string mactor = m.GetMovieMaleActor();
            int mrating = m.GetMovieRating();
            Console.WriteLine("Movie Name: "+ mname);
            Console.WriteLine("Movie Director: " + mdire);
            Console.WriteLine("Movie Producer: " + mproducer);
            Console.WriteLine("Movie Male Actor: " + mactor);
            Console.WriteLine("Movie Movie Rating: " + mrating);


            Movie m2 = new Movie();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter Movie Name");
            string mname1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Movie Director");
            string mdir1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Movie Producer");
            string mproducer1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Movie Actor");
            string mactor1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Movie Rating");
            string mrating1 = Convert.ToString(Console.ReadLine());

           
            m2.SetMovieName(mname1);
            m2.SetMovieDirector(mdir1);
            m2.SetMovieProducer(mproducer1);
            m2.SetMovieMaleActor(mactor1);
            m2.SetMovieRating(mrating);

            Console.WriteLine("Movie Name: "+m2.GetMovieName() + "Movie Director: "+ m2.GetMovieDirector() + "Movie Producer: "+ m2.GetMovieProducer() + "Movie Actor: "+ m2.GetMovieMaleActor() + "Movie Rating: "+ m2.GetMovieRating());

            Console.Read();



        }
    }
    
}
