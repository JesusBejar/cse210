using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videoList = new List<Video>();

        List<Comment> _comments = new List<Comment>();

        Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video();
        video1._title = "Nate Diaz vs. Connor McGregor 2016 UFC fight";
        video1._author = "Ultimate Fighting Championship";
        video1._length = "30 seconds\n";
        _videoList.Add(video1);

        Comment c1 = new Comment();
        c1._name = "@DrBeauHightower";
        c1._text = "What a time to be alive. Probably the most excited me and my friends had ever been for a fight, but especially the pre fight trash talk. Iconic.";
        _comments.Add(c1);

        foreach (Video video in _videoList)
        {
            video.ReturnVideo();
            video.CommentNumberLength(_comments);
            foreach (Comment comment in _comments)
            {
                comment.ReturnComment();
            }
        }
    }
}