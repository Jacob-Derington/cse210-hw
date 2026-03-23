class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public string Display()
    {
        string output = "";

        output += $"\n{_title} by {_author} ({_length} sec)\n";
        output += $"Comments: {GetCommentCount()}\n";

        foreach (Comment c in _comments)
        {
            output += c.Display();
        }

        return output;
    }
}