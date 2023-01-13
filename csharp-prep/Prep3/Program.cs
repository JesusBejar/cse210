using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1 ,100);

        // Console.Write($"This is your {magicNum} ");
        // string magicNum = "";

        int userNum = -1;

        while (userNum != magicNum){

            Console.Write("What is your guess? ");
            string userStr = Console.ReadLine();

            // do not need to define data type if it has 
            // defined already
            // ex. int userNum = int.Parse(userStr);
            userNum = int.Parse(userStr);

            if (userNum > magicNum) {
                Console.WriteLine("Guess Lower");
            }

            else if (userNum < magicNum) {
                Console.WriteLine("Guess Higher");
            }
         }
    
    }
}
        