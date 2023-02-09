using System;

class List
{
    Scripture scr = new Scripture();
    Random random = new Random();
    
    // should I make the return value List<string> or void???
    // List<string>
    public void SplitScripture (string _scripture) {
        // this variable contains the scripture split
        string[] _wordList = _scripture.Split(' ');

        // below for loop prints out all words within
        // scripture individually

        // foreach (var word in _wordList)
        // {
        //     System.Console.WriteLine($"{word}");
        // }

        int wordCount = _wordList.Count();
        // Console.WriteLine(wordCount);
        int index = random.Next(0, wordCount);

        for(int i=0;i<wordCount;i++)
        {
            for(int j=0;j<3;j++)
            {
                index = random.Next(0, wordCount);
                if(_wordList[i].Contains("as"))
                    _wordList[index] = "___";
            }

            Console.Write(_wordList[i] + " ");

        }
    }

}
        
        // Console.Write(_wordList[i]);
