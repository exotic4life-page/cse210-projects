using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Learn C#", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "This was very helpful."));
        video1.AddComment(new Comment("John", "I learned a lot from this video."));
        video1.AddComment(new Comment("Sarah", "Great explanation!"));

        Video video2 = new Video("Introduction to Programming", "Tech World", 480);
        video2.AddComment(new Comment("Mike", "Very easy to understand."));
        video2.AddComment(new Comment("David", "I enjoyed this lesson."));
        video2.AddComment(new Comment("Emma", "Please make more videos like this."));

        Video video3 = new Video("C# Classes Explained", "Programming Hub", 720);
        video3.AddComment(new Comment("James", "The examples were excellent."));
        video3.AddComment(new Comment("Linda", "This helped me understand classes."));
        video3.AddComment(new Comment("Robert", "Very useful tutorial."));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}