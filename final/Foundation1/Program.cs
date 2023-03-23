using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videoList = new List<Video>();

        List<Comment> _comments = new List<Comment>();

        // VIDEO 1
        Video video1 = new Video();
        video1._title = "Nate Diaz vs. Connor McGregor 2016 UFC fight";
        video1._author = "Ultimate Fighting Championship";
        video1._length = "840 seconds\n";
        _videoList.Add(video1);

        // 3 COMMENTS 
        Comment c1 = new Comment();
        c1._name = "@DrBeauHightower";
        c1._text = "What a time to be alive. Probably the most excited me and my friends had ever been for a fight, but especially the pre fight trash talk. Iconic.";
        _comments.Add(c1);

        Comment c2 = new Comment();
        c2._name = "@rawbebaba";
        c2._text = "I'll always love Nate Diaz man. What a treasure to the sport.";
        _comments.Add(c2);

        Comment c3 = new Comment();
        c3._name = "@Henroin42";
        c3._text = "10:10 connors face is priceless";
        _comments.Add(c3);

        // VIDEO 2
        Video video2 = new Video();
        video2._title = "\nHow to Add, Remove & Toggle Classes By Using DOM (classlist) property";
        video2._author = "HuXn WebDev";
        video2._length = "322 seconds \n";
        _videoList.Add(video2);

        // 3 COMMENTS 
        Comment c4 = new Comment();
        c4._name = "@lightagainst_darkness6697";
        c4._text = "Thanks man you helped me a lot";
        _comments.Add(c4);

        Comment c5 = new Comment();
        c4._name = "@losL2r2";
        c4._text = "Helped me with my issues";
        _comments.Add(c5);

        Comment c6 = new Comment();
        c4._name = "@muhsinkiki4245";
        c4._text = "Nice";
        _comments.Add(c6);

        // VIDEO 3
        Video video3 = new Video();
        video3._title = "Because of Jesus, You Can Rise Above Anything - Easter 2023 | “Rise”";
        video3._author = "Church of Jesus Christ | Come Unto Christ";
        video3._length = "102 seconds \n";
        _videoList.Add(video3);

        // 3 COMMENTS
        Comment c7 = new Comment();
        c7._name = "@peggygallagher@5802";
        c7._text = "Thank you Lord Jesus for picking me up every time I fall...";

        Comment c8 = new Comment();
        c8._name = "@trudyappleby1622";
        c8._text = "This is so beautiful and touching thank you. From the broken pieces in me.";

        Comment c9 = new Comment();
        c9._name = "@RomonaF1102";
        c9._text = "This was so moving, thank you for creating such uplifting content that gives such powerful reminders of how Christ can help me.";

        foreach (Video video in _videoList)
        {
            // below returns the video name, author and length of time
            video.ReturnVideo();

            // should return 3 for each video
            Console.Write($"Number of comments:");
            if (video.CommentNumberLength(_comments) == 3)
            {
                Console.WriteLine($"{video.CommentNumberLength(_comments)}");
            }
            
            // below should return the set of specific comments for each video
            foreach (Comment comment in _comments)
                {
                    comment.ReturnComment();
                }
        }
    }
}