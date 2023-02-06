using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scr = new Scripture();
        Interactor inter = new Interactor();
        List list = new List();

        scr.DisplayScripture();
        inter.Decide();
    }
}