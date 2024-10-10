public class Video
{
    public string videoTitle { get; set; }
    public string videoAuthor { get; set; }
    public int videoLength { get; set; }
    public List<Comment> videoComments { get; set; }

    public Video(string title, string author, int length)
    {
        videoTitle = title;
        videoAuthor = author;
        videoLength = length;
        videoComments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return videoComments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {videoTitle}");
        Console.WriteLine($"Author: {videoAuthor}");
        Console.WriteLine($"Length: {videoLength} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        foreach (var comment in videoComments)
        {
            Console.WriteLine($"Comment by {comment.commentCreator}: {comment.commentText}");
        }
        Console.WriteLine();
    }
}