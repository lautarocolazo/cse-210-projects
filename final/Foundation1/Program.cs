using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>(); 

        Dictionary<string, string> comments = new Dictionary<string, string>
        {
            { "Alice", "This video was great!" },
            { "Bob", "I don't like your content!" },
            { "Charly", "Good video." },
        };

        Comment c1 = new Comment("Alice", comments["Alice"]);
        Comment c2 = new Comment("Bob", comments["Bob"]);
        Comment c3 = new Comment("Charly", comments["Charly"]);

        Video v1 = new Video("Video 1", "Author 1", 60);
        Video v2 = new Video("Video 2", "Author 2", 120);
        Video v3 = new Video("Video 3", "Author 3", 180);
        
        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);

        v2.AddComment(c1);
        v2.AddComment(c2);
        v2.AddComment(c3);

        v3.AddComment(c1);
        v3.AddComment(c2);
        v3.AddComment(c3);

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v2);

        foreach (Video video in videos)
        {
            video.DisplayInformation();
        }
        
        Console.WriteLine("End of the program");


    }
}
