class Video(string title, string author, int length, List<Comment> comments)
{

    List<Comment> _comments = comments;
    string _title = title;
    string _author = author;
    int _length = length;

    public int GetCommentQuantity()
    {

        return _comments.Count;

    }


    public string GetTitle()
    {

        return _title;

    }

    public string GetAuthor()
    {

        return _author;

    }

    public int GetLength()
    {

        return _length;

    }

    public List<Comment> GetComments()
    {

        return _comments;

    }



}