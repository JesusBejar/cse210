using System;

class Program
{
    static void Main(string[] args)
    {
        // this is f1 CHECK
        static void DisplayWelcome() 
        {
            Console.WriteLine("Welcome to the program!");
        }
        // call 1
        DisplayWelcome();

        // this is f2 CHECK
        static string PromptUserName() 
        {
            Console.Write("Enter your name: ");
            string userNameInput = Console.ReadLine();
            return userNameInput;
        }
        string userName = PromptUserName();

        // this is f3
        static int PromptUserNumber() 
        {
            Console.Write("Enter your favorite number: ");
            string favNumberInput = Console.ReadLine();
            int favNum = int.Parse(favNumberInput);
            // below is a way to combine the two lines above
            // int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }
        int userNum = PromptUserNumber();

        // this is f4
        static int SquareNumber(int number) 
        {
            int squaredNum = (number * number);
            return squaredNum;
        }
        int squaredNum = SquareNumber(userNum);

        // this is f5
        static void DisplayResult(string userName, int squaredNumber) 
        {
            Console.WriteLine ($"{userName}, your number squared {squaredNumber} ");
        }
        // call 5
        DisplayResult(userName, squaredNum);
        
    }
}