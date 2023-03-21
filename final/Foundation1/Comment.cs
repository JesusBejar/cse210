public class Comment 
{
    public string _name ;
    public string _text ;
    // public Comment(string name, string text)
    // {
    //     _name = name;
    //     _text = text;
    // }

    public string ReturnComment()
    {
        Console.WriteLine($"{_name} \n{_text}");
        return $"{_name} {_text}";
    }
}
