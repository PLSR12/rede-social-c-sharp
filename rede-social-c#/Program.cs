using System;
using rede_social_c_.Entities;

namespace rede_social_c_
{
 class Program
{
    static void Main(string[] args)
    {

     Comment c1 = new Comment("Have a nice trip");
     Comment c2 = new Comment("Wow that's awesome");

            Post p1 = new Post(
                DateTime.Parse("21/06/2025 13:05:44"),
                "Travelling to New Zeeland",
                "I'm going to visit this wonderful country",
                50
               );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("Good dreams");

            Post p2 = new Post(
                DateTime.Parse("21/06/2025 13:05:44"),
                "Good night guys",
                "See you tomorrow",
                5
                );

            p2.AddComment(c3);
            p2.AddComment(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
