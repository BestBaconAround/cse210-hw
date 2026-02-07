using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Fixing Random Shutdowns on a Gaming PC", "BaconTech", 742);
        v1.AddComment(new Comment("Mia", "That beep mouse disconnect thing happened to me too."));
        v1.AddComment(new Comment("Jordan", "Solid troubleshooting flow, straight to the point."));
        v1.AddComment(new Comment("Avery", "Can you do one on static discharge protection?"));
        videos.Add(v1);

        Video v2 = new Video("POTS Tips: Staying Functional Without Fainting", "Health Nerd", 515);
        v2.AddComment(new Comment("Sam", "Finally someone explains it without fluff."));
        v2.AddComment(new Comment("Riley", "The hydration part is real, electrolytes save me."));
        v2.AddComment(new Comment("Taylor", "Could you cover low blood pressure strategies next?"));
        videos.Add(v2);

        Video v3 = new Video("C# Classes Explained Like You Have Zero Attention Span", "Code Wizard", 603);
        v3.AddComment(new Comment("Chris", "The metaphors actually worked, wild."));
        v3.AddComment(new Comment("Nina", "Encapsulation finally makes sense."));
        v3.AddComment(new Comment("Leo", "More projects like this please."));
        videos.Add(v3);

        Video v4 = new Video("Dirt Bike Crash Stories, What To Do After You Eat It", "TrackRat", 388);
        v4.AddComment(new Comment("Dylan", "Getting off the track fast is the real advice."));
        v4.AddComment(new Comment("Olivia", "Bro that jump story was insane."));
        v4.AddComment(new Comment("Ethan", "Helmet and neck brace, every time."));
        videos.Add(v4);

        foreach (Video video in videos)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title:  {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("---- Comment List ----");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
