public class Journal
{
    public string _journalEntry;

    public string _date;

    public string _fileName;
    
    // below is the list that stores entries that the user
    // types in response to a random prompt
   public List<string>_currentEntries = new List<string>();
    public void DisplayCurrentEntries (string userstring) {

        _currentEntries.Add(userstring);

        foreach (string entry in _currentEntries) {

                Console.WriteLine(entry);

        }

    
    }
    

}
 
    