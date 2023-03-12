class LoadGoal : BaseGoal 
{
    public LoadGoal(List<string> _goals) : base ( _goals)
    {
        
    }
    public override string SpecificGoalTask()
    {
        Console.WriteLine("Please enter the name of your file:");
        string filename = Console.ReadLine();
        try  
        {
        // create a StreamReader similar to streamwriter
            using (StreamReader reader = new StreamReader(filename))  
            {  
                string line;  
                // read file line by line with while loop
                while ((line = reader.ReadLine()) != null)  
                    {  
                        _goals.Add(line);
                        // foreach (string g in _goals) 
                        //     {
                        //         (_goals.IndexOf(g)+1);
                        //     }
                    }  
            }
        }  
        catch (Exception exp)  
        {  
            Console.WriteLine(exp.Message);  
        }  
        return "";
    }
}