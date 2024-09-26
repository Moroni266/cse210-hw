using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace JobsInformation
{
    public class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public void DisplayJobDetails()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
}