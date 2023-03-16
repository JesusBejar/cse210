using System;
using System.IO;
public class Entry
{
    public string _date ;
    public string _userAnswer ; 
    public string _ranPrompt ; 

    public Entry ()
    {

    }

    public void DisplayEntry() 
    {
        Console.WriteLine($"{_date} {_ranPrompt} \n {_userAnswer}");
    }
}


