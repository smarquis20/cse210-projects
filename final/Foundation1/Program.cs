using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Top 10 Games Online", "Joe Smith", 700);
        Video video2 = new Video("Try not to Laugh", "Shaun Marquis", 450);
        Video video3 = new Video("Build a House in 7 Days", "Joe Burch", 600);
        Video video4 = new Video("Best Financial advise", "Josh Cato", 300);

        Comment video1comm1 = new Comment("Michelle", "Game number 5 is my favorite.");
        video1._comments.Add(video1comm1);
        Comment video1comm2 = new Comment("Sonney", "You need to add number 11.");
        video1._comments.Add(video1comm2);
        Comment video1comm3 = new Comment("Russell", "Where can I buy number 3.");
        video1._comments.Add(video1comm3);

        Comment video2comm1 = new Comment("Charly", "Funniest clip ever!");
        video2._comments.Add(video2comm1);
        Comment video2comm2 = new Comment("Twila", "I have seen better.");
        video2._comments.Add(video2comm2);
        Comment video2comm3 = new Comment("Colleen", "Super Funny");
        video2._comments.Add(video2comm3);

        Comment video3comm1 = new Comment("Niles", "Where do you buy the lumber?");
        video3._comments.Add(video3comm1);
        Comment video3comm2 = new Comment("Amy", "House looks fantastic!");
        video3._comments.Add(video3comm2);
        Comment video3comm3 = new Comment("Blake", "How do you do the concrete?");
        video3._comments.Add(video3comm3);

        Comment video4comm1 = new Comment("Sam", "How do I invest in a 401k?");
        video4._comments.Add(video4comm1);
        Comment video4comm2 = new Comment("Clark", "What kind of school account should i set up?");
        video4._comments.Add(video4comm2);
        Comment video4comm3 = new Comment("Matt", "Great advise!");
        video4._comments.Add(video4comm3);

        List<Video> _videos = new List<Video>{video1, video2, video3};

        foreach (Video video in _videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._vidLength} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine();
                Console.Write($"Comment by: ");
                Console.WriteLine(comment._name);
                Console.WriteLine(comment._comment);
            }
        }

    }
}