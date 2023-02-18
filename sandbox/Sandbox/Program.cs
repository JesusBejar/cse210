using System;
using System.Collections.Generic;

class Program
{          
    static void Main(string[] args) 
    {
        for (int a = 10; a >= 0; a--)
        {
            Console.Write("\rBreathe in...{0:00}", a);
            System.Threading.Thread.Sleep(1000);
        } 

    }
 
   
}
    // BELOW IS CODE TO MAKE A PAUSE FOR THE MINDFULLNESS ASSIGNMENT
    // {
    // Console.WriteLine("Going to sleep for a second...");

    // Thread.Sleep(3000);

    // Console.WriteLine("I'm back!!");
    

    // BELOW WAS PRACTICE FROM INHERITANCE PREP ACTIVITY FEB 18 2023
    // a regular class called Person

    // the student instance automatically has the GetName() method!
    //     Student student = new Student();
    //     string name = student.GetName();
    //     Console.WriteLine(name);
    //     Random random = new Random();

    //   }

    //   public class Person
    // {
    //     public string GetName()
    //     {
    //         return "Joseph";
    //     }
    // }

    //     // a class that inherits from Person
    //     // the Person class is the parent class while Student is the child
    // public class Student : Person
    // {
    //     public string GetNumber()
    //     {
    //         return "0123456789";
    //     }
    // }


//    BELOW WAS PRACTICE CODE FOR THE SCRIPTURE MEMORIZER PROJECT FEB 13 2023
//          List <string> _list = new List<string>{ "for","this", "is","my", "work", "and", "my", "glory"};
//         int wordCount = _list.Count();
//     // Console.WriteLine(wordCount);
//         int index = random.Next(_list.Count);
//         for(int i=0;i<_list.Count;i++)
//         {
//             if(_list[i].Contains("for"))
//                 _list[index] = "___";
//         }
        // if(_list[i].Contains("for"))
        //     _list[index] = "___";
        // 
        // int wordIndex = random.Next(0, wordCount);
        // string word = wordIndex.ToString();
        // Console.WriteLine(word);

        //  var list = new List<string>{ "one","two","three","four"};
        //  int index = random.Next(list.Count);
        //  list[index] = "___";
        //  Console.WriteLine(list);


//    BELOW IS CODE I REFERENCED FOR THE SCRIPTURE MEMORIZER ACTIVITY
    // {
    //     Console.WriteLine("Hello Mr.Sun! Try press enter now:");
    // var userInput = Console.ReadKey();
    // if(userInput.Key == ConsoleKey.Enter)
    // {
    //     Console.WriteLine("You pressed enter!");
    // } else
    // {
    //     Console.WriteLine("You pressed something else");
    // }

    // }
// BELOW WAS PRACTICE CODE FOR ENCAMPULATION
    //         Console.WriteLine("Transaction doing SBI Bank");
    //         IBank sbi = BankFactory.GetBankObject("SBI");
    //         sbi.ValidateCard();
    //         sbi.WithdrawMoney();
    //         sbi.CheckBalanace();
    //         sbi.BankTransfer();
    //         sbi.MiniStatement();
    //         Console.WriteLine("\nTransaction doing AXIX Bank");
    //         IBank AXIX = BankFactory.GetBankObject("AXIX");
    //         AXIX.ValidateCard();
    //         AXIX.WithdrawMoney();
    //         AXIX.CheckBalanace();
    //         AXIX.BankTransfer();
    //         AXIX.MiniStatement();
    //         Console.Read();
    //     }
    // }
    // public abstract class IBank
    // {
    //     public abstract void ValidateCard();
    //     public abstract void WithdrawMoney();
    //     public abstract void CheckBalanace();
    //     public abstract void BankTransfer();
    //     public abstract void MiniStatement();
    // }
    // public class BankFactory
    // {
    //     public static IBank GetBankObject(string bankType)
    //     {
    //         IBank BankObject = null;
    //         if (bankType == "SBI")
    //         {
    //             BankObject = new SBI();
    //         }
    //         else if (bankType == "AXIX")
    //         {
    //             BankObject = new AXIX();
    //         }
    //         return BankObject;
    //     }
    // }
    // public class SBI : IBank
    // {
    //     public override void BankTransfer()
    //     {
    //         Console.WriteLine("SBI Bank Bank Transfer");
    //     }
    //     public override void CheckBalanace()
    //     {
    //         Console.WriteLine("SBI Bank Check Balanace");
    //     }
    //     public override void MiniStatement()
    //     {
    //         Console.WriteLine("SBI Bank Mini Statement");
    //     }
    //     public override void ValidateCard()
    //     {
    //         Console.WriteLine("SBI Bank Validate Card");
    //     }
    //     public override void WithdrawMoney()
    //     {
    //         Console.WriteLine("SBI Bank Withdraw Money");
    //     }
    // }
    // public class AXIX : IBank
    // {
    //     public override void BankTransfer()
    //     {
    //         Console.WriteLine("AXIX Bank Bank Transfer");
    //     }
    //     public override void CheckBalanace()
    //     {
    //         Console.WriteLine("AXIX Bank Check Balanace");
    //     }
    //     public override void MiniStatement()
    //     {
    //         Console.WriteLine("AXIX Bank Mini Statement");
    //     }
    //     public override void ValidateCard()
    //     {
    //         Console.WriteLine("AXIX Bank Validate Card");
    //     }
    //     public override void WithdrawMoney()
    //     {
    //         Console.WriteLine("AXIX Bank Withdraw Money");
    //     }
    // }
// BELOW WAS PRACTICE FOR PROVE DEVELOP 2 ASSIGNMENT
//  Entry prompt1 = new Entry();

//         Console.WriteLine("Please write a journal prompt: ");

//         prompt1._journalPrompt = Console.ReadLine();

//         Console.WriteLine(prompt1._journalPrompt);
//         // above displays _journalPrompts attribute

//         prompt1.SaveEntry(prompt1._journalPrompt);

//         // var random = new Random();

//         // int index = random.Next(promptList.Count);

//         // Console.WriteLine(promptList[index]);
        
//         prompt1.DisplayP();

        