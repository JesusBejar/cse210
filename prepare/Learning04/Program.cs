using System;

class Program
{
    static void Main(string[] args)
    {
        BaseAssignment _simpleAssignment = new BaseAssignment("Monk", "Calculus");
        
        // assign the method call to a variable then call the variable
        string summary = _simpleAssignment.GetSummary();  

        Console.WriteLine(summary); 
    }
}