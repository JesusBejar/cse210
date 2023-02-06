using System;

class Scripture
{
    private string _scripture;
    public string DisplayScripture() {
        string scripture = "And as all have not faith, seek ye diligently and teach one another words of wisdom; yea, seek ye out of the best books words of wisdom; seek learning, even by study and also by faith.";
        Console.WriteLine ($"D&C 88:118 {scripture}");
        return scripture;
    }
}