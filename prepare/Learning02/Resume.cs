public class Resume {

    public List<Job>_jobs = new List<Job>();

    public string _name ;

    public string _company ;
    
    public string _title ;
    public int _startYear ;
    public int _endYear ;

    public void DisplayDetails()
    {
        Console.WriteLine ($"Name: {_name}");
        Console.WriteLine ("Jobs:");

        foreach (Job job in _jobs){

            job.DisplayDetails();
        }

        
    }
}