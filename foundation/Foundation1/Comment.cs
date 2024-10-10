public class Comment
{
    public string commentCreator { get; set; }
    public string commentText { get; set; }

    public Comment(string creator, string text)
    {
        commentCreator = creator;
        commentText = text;
    }
}