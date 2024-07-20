using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _vidLength;
    public List<Comment> _comments;

    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _vidLength = length;
        _comments = new List<Comment>();
    }

    public int GetCommentCount()
    {
        return _comments.Count();
    }
}