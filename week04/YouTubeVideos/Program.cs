using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Book of mormon in America", "David Martinez", 1200);
        Video video2 = new Video("Why do I need Jesus in my life?", "George McKerry", 600);
        Video video3 = new Video("What does eternal life mean? (LDS perspective)", "Luis Ospina", 900);

        video1.AddComment(new Comment("Jonathan Quinteros", "This historical overview really helped me understand the timeline better."));
        video1.AddComment(new Comment("Carlos Mendez", "Great explanation, thank you for sharing these insights!"));
        video1.AddComment(new Comment("Emily White", "I love studying the geography and history behind these events."));

        video2.AddComment(new Comment("Mark Taylor", "I needed to hear this message today. Very uplifting."));
        video2.AddComment(new Comment("Hannah Brooks", "Simple, clear, and straight to the heart. Thank you George!"));
        video2.AddComment(new Comment("Daniel Kim", "This gave me a lot of peace during a stressful week."));

        video3.AddComment(new Comment("Rachel Adams", "Such a clear breakdown of the difference between immortality and eternal life."));
        video3.AddComment(new Comment("Kevin Ross", "Awesome video, Luis! I'm sharing this with my study group."));
        video3.AddComment(new Comment("Sofia Morales", "Very well explained and easy to follow from start to finish."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
    
        foreach(Video v in videos)
        {
            Console.WriteLine(v.GetDisplay());
            Console.WriteLine();
        }
    
    }
}