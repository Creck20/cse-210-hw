using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Peterson and Sons and Friends Bits and Parts";
        job1._jobTitle = "Bit Maker";
        job1._startYear = 1998;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Gorb Co.";
        job2._jobTitle = "Globulous";
        job2._startYear = 1950;
        job2._endYear = 2024;

        Resume resume1 = new Resume();
        resume1._name = "Doctor Dankmaster";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

       resume1.Display();
    }
}