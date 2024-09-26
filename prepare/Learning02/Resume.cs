using System;
using JobsInformation;

namespace ResumeJobs
{
    public class Resume
    {
        public string _name;
        public List<Job> _jobs;

        public void DisplayResumeJobsDetails()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (var job in _jobs)
            {
                job.DisplayJobDetails();
            }
        }
    }
}