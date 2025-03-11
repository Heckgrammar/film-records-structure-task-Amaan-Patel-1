using System;

namespace RecordsStructureTask1
{
    internal class Program
    {
        struct Film
        {
            public string title;
            public string certificate;
            public int year;
            public bool beingShown;

            public Film(string title, string certificate, int year, bool beingShown)
            {
                this.title = title;
                this.certificate = certificate;
                this.year = year;
                this.beingShown = beingShown;
            }
        }

        static void Main(string[] args)
        {
            Film hulk = new Film("Hulk", "12A", 2005, false);
            Film ironMan = new Film("Iron Man", "12A", 2008, false);
            Film antMan = new Film("Ant-Man", "12A", 2015, false);
            Film[] filmCollection = new Film[] { antMan, hulk, ironMan };

            // Find the newest film
            Film newestFilm = filmCollection[0]; // Start with the first film
            for (int i = 1; i < filmCollection.Length; i++)
            {
                if (filmCollection[i].year > newestFilm.year)
                {
                    newestFilm = filmCollection[i];
                }
            }

            // Output the name of the newest film
            Console.WriteLine($"The newest film is: {newestFilm.title}");

            // Update the antMan record to show the film is currently being shown
            for (int i = 0; i < filmCollection.Length; i++)
            {
                if (filmCollection[i].title == "Ant-Man")
                {
                    filmCollection[i].beingShown = true;
                    break; // Exit the loop once we've updated the film
                }
            }

            // Optional: Output the updated status of Ant-Man
            Console.WriteLine($"Is '{antMan.title}' currently being shown? {antMan.beingShown}");
        }
    }
}
