using System;
using System.IO;
public class File
{
    Journal _journalReference = new Journal();

    public string _fileNombre;

    public void enterFileNombre () {
        Console.WriteLine("Please enter file name: ");
        _fileNombre = Console.ReadLine();
    }

    // public void SaveToAFile () {
    //     enterFileNombre();
    //     // don't use semi colons for using methods
    //     using(StreamWriter file = new StreamWriter(_fileNombre))
    //     {
    //         file.WriteLine(_journalEntry);
    //     }
    // }

        void SaveToAFile () 
        {
       using (StreamWriter outputFile = new StreamWriter(_fileNombre)) {

        foreach (Journal entry in _journalReference._currentEntries) 
            {
            
            outputFile.WriteLine($"{entry._date} {entry._date} {entry._journalEntry}");

            }
        }

        public void LoadFile() 
        {
            String line;
            try {
                StreamWriter sr = new StreamWriter (_journalReference._fileName);

                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e) {
                Console.WriteLine("Exception :" + e.Message);
            }
            finally {
                Console.Write("Executing block");
            }
            }

}


