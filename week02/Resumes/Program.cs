using System;

class Program
{
    static void Main(string[] args)
    {
        //creates new instance
        Job job1 = new Job();
        //job1 method
        job1._jobTitle = "Software Engineer";
        job1._company = "Lion Energy";
        job1._startYear = "2025";
        job1._endYear = "2026";
        //job2 method
        Job job2 = new Job();
        job2._jobTitle = "Quality tester";
        job2._company = "Apple";
        job2._startYear = "2020";
        job2._endYear = "2025";
        //create new instance
        Resume myResume = new Resume();
        myResume._name = "Mary";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //displays resume method
        myResume.Display();
    }
}