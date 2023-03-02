using System;
using System.Collections.Generic;

public class SBI 
{   
    private List<string> _randomPrompts = new List<string>();   
    private List<string> _randomQuestions = new List<string>();
    private List<int> _selectedQuestions = new List<int>();
    private string _selectedQuestion ;
    private int _index ;
    public List<string> PopulateQuestionList() {
            _randomQuestions.Add("What answer did you give?");
            _randomQuestions.Add("How do your answer make you feel?");
            _randomQuestions.Add("Based on your answer, what do you think you should change in your life?");
            _randomQuestions.Add("What did you like or dislike about your answer?");
            // move index code snippet into reflect(); function - Bryce 
            // use List<str> name.contains() to filter through a list and check if random question is within list - Abraham
            return _randomQuestions;
    }
        public string SelectRandomQuestion() {
        if (_selectedQuestions.Count != _randomQuestions.Count) {
            return Random();
        } else {
            _selectedQuestions.Clear();
            return Random();
        }
    }
        public string Random() {
        do {
            var random = new Random();
            _index = random.Next(_randomQuestions.Count);
        }while(_selectedQuestions.Contains(_index));
            _selectedQuestions.Add(_index);
            return _selectedQuestion = _randomQuestions[_index];
    }
        // for (int a = 10; a >= 0; a--)
    // static Random random = new Random();
    // static List <string> _list = new List<string>{ "for","this", "is","my", "work", "and", "my", "glory"};
    // int wordCount = _list.Count();
    // // Console.WriteLine(wordCount);
    // int index = random.Next(_list.Count);
    // for(int i=0;i<_list.Count;i++)
    // {

    //     // if(_list[i].Contains("for"))
    //     //     _list[index] = "___";
    //     _list[index] = "1";
    //     _list[index] = "2";
    //     _list[index] = "3";
    //     Console.Write(_list[i]);
    // }
        
}


// BELOW WAS PRACTICE FOR PROVE DEVELOP 2 ASSIGNMENT
//    public List<string>_prompts = new List<string>();
//         public void SaveEntry (string functionString) {

//             _prompts.Add(functionString);
//         }

//         public string _journalPrompt ;
         
//         public void DisplayP () 
//         {
//             foreach (string prompt in _prompts)
//             {
//             Console.WriteLine(prompt);
//             }
//         }