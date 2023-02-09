using System;

class Scripture
{
    private string _scripture = "And as all have not faith, seek ye diligently and teach one another words of wisdom; yea, seek ye out of the best books words of wisdom; seek learning, even by study and also by faith.";
    public string DisplayScripture() {
        // string scripture can now be accessed through DisplayScripture method
        Console.WriteLine ($"D&C 88:118 {_scripture}");
        return _scripture;
    }
    public string GetandSetScripture
        {  
            get  
            {  
                return _scripture;  
            }  
            set  
            {  
                _scripture = "And as all have not faith, seek ye diligently and teach one another words of wisdom; yea, seek ye out of the best books words of wisdom; seek learning, even by study and also by faith."; 
            }  
        }  
}