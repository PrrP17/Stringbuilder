using System;
using composition_stringbilder.Entities;

namespace composition_stringbilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("have a nice trip");
            Comment c2 = new Comment("Wow thats awesome");

            Post p1 = new Post(
                DateTime.Parse("24/06/2018 13:05:44"),
                "Travelig to New Zeland",
                "Im goig to visit this woderful country",
                12
            );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "see you tomorrow",
                5

            );

            p2.AddComment(c3);
            p2.AddComment(c4);

            System.Console.WriteLine(p1);
            System.Console.WriteLine(p2);
        }
    }
}
