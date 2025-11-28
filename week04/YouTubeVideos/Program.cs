using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video
        {
            Title = "Learning C#",
            Author = "John Doe",
            Length = 600
        };
        video1.AddComment(new Comment("Alex", "Great explanation!"));
        video1.AddComment(new Comment("Maria", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Sam", "I learned a lot."));

        videos.Add(video1);

        Video video2 = new Video
        {
            Title = "How to Cook Pasta",
            Author = "Chef Luigi",
            Length = 420
        };
        video2.AddComment(new Comment("Anna", "Delicious recipe!"));
        video2.AddComment(new Comment("Kevin", "Trying this today."));
        video2.AddComment(new Comment("Laura", "Amazing tutorial!"));

        videos.Add(video2);

        Video video3 = new Video
        {
            Title = "Travel Vlog: Paris",
            Author = "TravelWithMe",
            Length = 900
        };
        video3.AddComment(new Comment("Chris", "Paris looks beautiful!"));
        video3.AddComment(new Comment("Nina", "Love your videos!"));
        video3.AddComment(new Comment("Paul", "I want to visit now!"));

        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
