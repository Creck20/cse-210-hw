using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("John Doe", "Computer Science");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assing2 = new MathAssignment("John Doe", "Division", "6.8", "1-3000");
        Console.WriteLine(assing2.GetSummary());
        Console.WriteLine(assing2.GetHomeworkList());

        WritingAssignment assign3 = new WritingAssignment("John Doe", "The History of Fish", "Fish, Am I right?");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());
    }
}