using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade as a percentage: ");
        string user_input = Console.ReadLine();
        int percentage = int.Parse(user_input);

        bool pass = true;
        string grade = "A";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        if (percentage > 70)
        {
            pass = true;
        }
        else
        {
            pass = false;
        }
        if (pass)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass! Better luck next time!");
        }
        Console.WriteLine($"You got a {grade}.");
    }
}