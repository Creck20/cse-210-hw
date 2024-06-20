using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

/*
To exceed requirements: I have created a variable animation time that is set in each activity. 
I have also created the hyperventilate and Wim Hof (death) classes. 
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the mindfullness app!\n");

        // Main Loop: 
        bool proceed = true;

        while (proceed) {

            // Display Menu: 
            Console.WriteLine("\nPlease select an activity: ");
            Console.WriteLine("    1. Breathing");
            Console.WriteLine("    2. Reflection");
            Console.WriteLine("    3. Listing");
            Console.WriteLine("    4. Hyperventilate");
            Console.WriteLine("    5. Death (Wim Hof)");
            Console.WriteLine("    0. Quit");
            Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            
            // Make choice: 
            switch (choice) {

                case 1: 
                    // Construct Breath Activity: 
                    Breath breath = new Breath("\nWelcome to the breathing activity.\n"
                    + "This activity will help you relax by breathing in and out slowly.\n"
                    + "Clear your mind and focus on your breathing.\n",
                    "breathing",3);
                    
                    breath.DisplayWelcome();

                    // Set Duration: 
                    Console.Write("Please set a duration for the activity in seconds: ");
                    int duration = int.Parse(Console.ReadLine());
                    breath.DefDuration(duration);

                    // Prepare and countdown: 
                    Console.Write("\nPrepare to begin: ");
                    breath.CountDown();

                    // Run breathing activity: 
                    breath.DoBreath();

                    // Finish activity: 
                    breath.DisplayExit();

                    break;
                
                case 2: 
                    // Construct Reflect Activity: 
                    Reflect reflect = new Reflect("\nWelcome to the reflecting activity.\n"
                    + "This activity will help you reflect on times in your life when you have shown strength and resilience.\n"
                    + "This will help you recognize the power you have and how you can use it in other aspects of your life.\n",
                    "reflecting", 5);
                    
                    reflect.DisplayWelcome();

                    // Set Duration: 
                    Console.Write("Please set a duration for the activity in seconds: ");
                    duration = int.Parse(Console.ReadLine());
                    reflect.DefDuration(duration);

                    // Prepare and countdown: 
                    Console.Write("\nPrepare to begin: ");
                    reflect.CountDown();

                    // Display Prompt:
                    Console.WriteLine("\nYour prompt is: ");
                    Console.WriteLine(reflect.PromptGenerator());

                    // Run the reflect: 
                    reflect.DoReflect();

                    // Display Exit:
                    reflect.DisplayExit();

                    break;

                case 3: 
                    // Construct Listing Activity: 
                    Listing listing = new Listing("\nWelcome to the listing activity.\n"
                    + "Reflect on the good things in life.\n"
                    + "List off as many things as you can that are related to the prompt.\n",
                    "listing",5);
                    
                    listing.DisplayWelcome();

                    // Set Duration: 
                    Console.Write("Please set a duration for the activity in seconds: ");
                    duration = int.Parse(Console.ReadLine());
                    listing.DefDuration(duration);


                    // Prepare and countdown: 
                    Console.Write("\nPrepare to begin: ");
                    listing.CountDown();

                    // Display Prompt:
                    Console.WriteLine("\nYour prompt is: ");
                    Console.WriteLine(listing.PromptGenerator());

                    // List items:
                    Console.WriteLine("\nList as many things as you can: \n");
                    List<string> responseList = listing.DoList();

                    // Display Results: 
                    int length = responseList.Count;
                    Console.WriteLine($"\nYou listed {length} items: ");
                    foreach (string thread in responseList){
                        Console.WriteLine(thread);
                    }

                    // Finish activity
                    listing.DisplayExit();

                    break;

                case 4: 
                    // Construct Hyperventilate Activity: 
                    Hyperventilate hyperventilate = new Hyperventilate("\nWelcome to the hyperventilate activity.\n"
                    + "This activity will be fun.\n",
                    "hyperventilate",0.5);
                    
                    hyperventilate.DisplayWelcome();

                    // Set Duration: 
                    Console.Write("Please set a duration for the activity in seconds: ");
                    duration = int.Parse(Console.ReadLine());
                    hyperventilate.DefDuration(duration);

                    // Prepare and countdown: 
                    Console.Write("\nPrepare to begin: ");
                    hyperventilate.CountDown();

                    // Run breathing activity: 
                    hyperventilate.DoHyperventilate();

                    // Finish activity: 
                    hyperventilate.DisplayExit();

                    break;

                case 5: 
                    // Construct Death Activity: 
                    Death death = new Death("\nWelcome to the reflecting activity.\n"
                    + "This activity will help you escape your troubles for a bit.\n"
                    + "Warning: May cause unconsciousness or prove fatal.\n",
                    "reflecting", 7);
                    
                    death.DisplayWelcome();

                    // Set Duration: 
                    Console.Write("This activty has a set duration.");
                    duration = 25;
                    death.DefDuration(duration);

                    // Prepare and countdown: 
                    Console.Write("\nPrepare to begin: ");
                    death.CountDown();

                    // Run the reflect: 
                    death.DoDeath();

                    // Display Exit:
                    death.DisplayExit();

                    break;

                case 0:
                    proceed = false;
                    break;

                default: 
                    Console.WriteLine("Please enter an integer between 0 and 4.");
                    break;
                

            }
        }
    }
}