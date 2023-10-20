public class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display(){
        Console.WriteLine($"Name of the applicant: {_name}");
        Console.WriteLine($"Jobs: ");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}
