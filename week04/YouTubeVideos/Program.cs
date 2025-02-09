using System;
using Microsoft.Win32;

class Program
{
    static void Main(string[] args)
    {


        List<Video> videos = new List<Video>();

        videos.Add(new Video("Me at the zoo", "jawed", 120, [new Comment("John Doe", "I like this video"), new Comment("Jane Doe", "I don't like this video."), new Comment("Luke Skywalker", "Never heard of an elephant before!")])); 
        videos.Add(new Video("Never Gonna Give You Up Official Music Video", "Rick Astley", 130, [new Comment("Han Solo", "Watch your mouth, kid, you're gonna find yourself floating home."), new Comment("Bruce Wayne", "Cool video!"), new Comment("Clark Kent", "This video is super!")]));
        videos.Add(new Video("You won't believe what happened!", "John Doe", 600, [new Comment("Peter Parker", "What Clickbait!"), new Comment("Fred Flinstone", "My kids loved this video!"), new Comment("Shaggy Rogers", "Like zoinks!")]));



        foreach (Video item in videos)
        {
            Console.WriteLine("");
            Console.WriteLine($"{item.GetTitle()} by {item.GetAuthor()}");

            Console.WriteLine($"Runtime: {item.GetLength()/60} minutes");

            Console.WriteLine ($"There are {item.GetCommentQuantity()} comments on this video.");

            foreach (Comment review in item.GetComments())
            {

                Console.WriteLine($"{review.GetName()} says:");
                Console.WriteLine($"{review.GetText()}");

            }

        }

    }
}