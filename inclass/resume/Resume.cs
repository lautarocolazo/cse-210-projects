public class Resume
{
  public string _name;
  public List<Job> _jobs = new List<Job>();

  public Resume(string name)
  {
    _name = name;
  }

  public void AddJobToResume(Job job)
  {
    _jobs.Add(job);
  }

  public void DisplayResume()
  {
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine($"Jobs: ");
    foreach (Job job in _jobs)
    {
      job.DisplayJob();
    }
  }
}

