public class Video 
{
    public string _title ;
    public string _author ;
    public string _length ;
    public int _counter ;
    // public Video (string title, string author, int length)
    // {
    //     _title = title;
    //     _author = author;
    //     _length = length;
    // }

    public int CommentNumberLength(List<Comment> comments)
    {
        _counter = 0;
        foreach (Comment comment in comments)
        {
            _counter += 1;
        }
        return _counter;
    }

    public string ReturnVideo()
    {
        Console.WriteLine($"{_title} \n{_author} \n{_length}");
        return $"{_title} {_author} {_length}";
    }
}