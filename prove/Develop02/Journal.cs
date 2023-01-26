public class Journal
{
   public List<string>_entries = new List<string>();
    public void SaveEntry (string functionString) {

        _entries.Add(functionString);
    }
}

            // prompt and display
            // responsibilites :
            // prompt
            // 1.2.3.4.5. menu

            // variables :
            // Write 
            // Display 
            // Load 
            // Save 
            // Quit 

            // private static bool MainMenu() 
            // { Console.Clear(); 
            // Console.WriteLine("Choose an option:"); 
            // Console.WriteLine("1) Reverse String"); 
            // Console.WriteLine("2) Remove Whitespace"); 
            // Console.WriteLine("3) Exit"); 
            // Console.Write("\r\nSelect an option: "); 
            // switch (Console.ReadLine()) { case "1": ReverseString(); 
            // return true; case "2": RemoveWhitespace(); 
            // return true; 
            // case "3": return false; default: return true; } }
