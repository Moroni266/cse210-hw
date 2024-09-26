using System;
using JobsInformation;
using ResumeJobs;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job Job1 = new Job();
        Job1._company = "Microsoft";
        Job1._jobTitle = "Software Engineer";
        Job1._startYear = 2019;
        Job1._endYear = 2022;

        Job Job2 = new Job();
        Job2._company = "Apple";
        Job2._jobTitle = "Manager";
        Job2._startYear = 2022;
        Job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Moroni Lopez";
        myResume._jobs = [Job1, Job2];

        myResume.DisplayResumeJobsDetails();
    }
}