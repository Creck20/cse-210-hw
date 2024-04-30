using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a series of positve integers. Stop by entering 0.");
        int number = 1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Please enter a positive integer: ");
            number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                numbers.Add(number);
            }
        }
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        int summation = numbers.Sum();
        Console.WriteLine($"The sum is: {summation}.");

        int length = numbers.Count;
        Console.WriteLine($"The length is: {length}.");

        int average = summation / length;
        Console.WriteLine($"The average is: {average}.");

        int max = numbers.Max();
        Console.WriteLine($"The max is: {max}.");

        int min = numbers.Min();
        Console.WriteLine($"The min is: {min}.");
    }
}