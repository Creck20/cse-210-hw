using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter a username: ");
            string userName = Console.ReadLine();
            return(userName);
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return(userNumber);
        }
        static int SquareNumber(int favorite)
        {
            return(favorite*favorite);
        }
        static void DisplayResult(int userNumber, string userName)
        {
            Console.WriteLine($"Username: {userName}");
            Console.WriteLine($"User-number: {userNumber}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(squaredNumber,userName);

    }     
}
