using System;

class List
{
    Scripture scr = new Scripture();
    Random random = new Random();

    private int _wordCount ;
    
    // should I make the return value List<string> or void???
    // List<string>
    public void SplitScripture (string _scripture) {
            // this variable contains the scripture split
            string[] _wordList = _scripture.Split(' ');
            
                int wordCount = _wordList.Count();
                // Console.WriteLine(wordCount);
                int index = random.Next(0, wordCount);
                // How can I continue looping until the list is filled with ____???
                for (int x=0;x<wordCount;x++)
                {
                    for(int j=0;j<3;j++)
                    {
                        index = random.Next(0, wordCount);

                        if (_wordList[x].Contains("And")) {

                            _wordList[index] = "___";
                        }

                    }

                        Console.Write(_wordList[x] + " ");
                }
         }   
}
