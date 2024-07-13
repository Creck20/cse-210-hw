using System;

class Program
{
    static void Main(string[] args)
    {
        // Program Explanation:
        Console.WriteLine("Welcome to the Lvl 1 DND 5e Character Creator!");
        Console.WriteLine("Lets get started by choosing your ability scores: ");

        //Choose ability scores: 
        Abililty abililty = new Abililty();
        abililty.GenerateRollList();
        abililty.DisplayAbilities();

        bool done = false;
        while (!done){
            abililty.ChooseAbility();
            abililty.DisplayAbilities();
            Console.WriteLine("Are you finished? (y/n) ");
            string finished = Console.ReadLine();
            if (finished == "y"){
                done = true;
            }
        }
    }
}