using System;
using System.Collections.Generic;

public class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    // This just tells you how many comments this vid has
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // Adds a new comment to the list
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}

class Program
{
    static void Main(string[] args)
    {

        // Comments
        Comment comment1 = new Comment("moolah", "Yo, this video is dope!");
        Comment comment2 = new Comment("EpicBob", "Totally learned something new, thanks!");
        Comment comment3 = new Comment("DRmanco", "Super chill , loved it!");
        Comment comment4 = new Comment("Kencar", "I love the new ppsh!");
        Comment comment5 = new Comment("azyd", "Ggs great gameplay");
        Comment comment6 = new Comment("Cazzette", "For real, this was goated!");

        // videos
        Video video1 = new Video("Levi vs GM", "Gothamchess", 360);
        Video video2 = new Video("Warzone Gameplay", "bifl", 300);
        Video video3 = new Video("Best Messi Goals", "MagicMessi", 420);

        // Adding the comments
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);

        video3.AddComment(comment6);
        video3.AddComment(comment2);
        video3.AddComment(comment3);
        video3.AddComment(comment5);

        // store the videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Author}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
