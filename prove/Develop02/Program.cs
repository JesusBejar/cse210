using System;

public class main
{

    static void Main(string[] args)
    {
    
        // int randomNum = random.Next(0, _promptReference._questionPrompts.Count);
        // _promptReference.randomNum = randomNum;

        //     _date = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            {
            
            Console.WriteLine ("Please select one of the following choices");
            Console.WriteLine ("1) Write");
            Console.WriteLine ("2) Display");
            Console.WriteLine ("3) Load");
            Console.WriteLine ("4) Save");
            Console.WriteLine ("5) Quit");
            Console.WriteLine("What would you like to do? ");
            int _userChoice = int.Parse(Console.ReadLine());

            {
            if (_userChoice == 1)
            {

            }

            else if (_userChoice == 2)
            {

            }
            else if (_userChoice == 3)
            {

            }
            else if (_userChoice == 4)
            {

            }
            else 
            {
                System.Environment.Exit(0); 
            }
        }

    }
}
}