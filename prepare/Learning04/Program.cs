using System;

class Program
{
    static void Main(string[] args)
    {
        // 1
        BaseAssignment _simpleAssignment = new BaseAssignment("Monk", "Calculus");
        
        // assign the method call to a variable then call the variable
        string summary = _simpleAssignment.GetSummary();  

        Console.WriteLine(summary); 

        // 2
        MathAssignment _newAssignment = new MathAssignment("Mulder", "History", "Section 10.1", "Problems 10-15");

        string summary2 = _newAssignment.GetSummary();  

        Console.WriteLine(summary2); 

        string _sectionAndProblems = _newAssignment.GetHomeworkList();

        Console.WriteLine(_sectionAndProblems);

        // 3
        WritingAssignment _writingAssignment = new WritingAssignment("Scully", "Medicine", "The Truth");

        string summary3 = _writingAssignment.GetSummary();  

        Console.WriteLine(summary3); 

        string _titleName = _writingAssignment.GetWritingInfo();

        Console.WriteLine(_titleName);
    }
}