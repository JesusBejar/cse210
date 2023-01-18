public class Job 
{   
    public string _company ;
    // public Array _companies = ["Google", "Microsoft", "Intel"];
    public string _title ;
    public int _startYear ;
    public int _endYear ;

    public void DisplayDetails()
    {
        Console.WriteLine ($"{_title} ({_company}) {_startYear}-{_endYear}");
    }

}
// additional jobs below
// public string _title2 = "Trilingual Data Scientist";
//     public string _company2 = "Bloomberg";
//     public int _startYear2 = 2031;
//     public int _endYear2 = 2035;

//     public string _title3 = "UFC Welterweight Champion of the world";
//     public string _company3 = "Ultimate Fighting Championship";
//     public int _startYear3 = 2036;
//     public int _endYear3 = 2040;