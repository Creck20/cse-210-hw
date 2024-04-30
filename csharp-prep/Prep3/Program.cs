using System;

class Program
{
    static void Main(string[] args)
    {
        //Initialize magic number: 
        Random radnomGenerator = new Random();
        int magic_number = radnomGenerator.Next(1,100);

        //Intialize guess:
        Console.WriteLine("Guess the magic number!");
        int guess = -1;

        //Run unitl guessed: 
        while (guess != magic_number)
        {

        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (guess > magic_number)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < magic_number)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("Correct!");
        }

        }
    }
}