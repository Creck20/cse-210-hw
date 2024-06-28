using System;
using System.ComponentModel.Design;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

/*
To exceed requirements and show creativity, I created the murder goal. 
This adds new functionality to the program, as you can now lose points for murdering someone. 
The murder goal also keeps track of how many people you murdered. It dials 911 with the animation
from last week.
*/
class Program
{
    static int Menu(int points){
        Console.WriteLine($"\n You have {points} points. \n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    0. Quit");
        Console.Write("Your choice: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    static int SubMenu(){
        Console.WriteLine("\nGoal Options:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Check List Goal");
        Console.WriteLine("    4. Murder Goal");
        Console.Write("Select goal type: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    static int GoalComplete(List<Goal> goalList){
        // Display activity selection:
        Console.WriteLine("\nSelect the activity you completed: ");
        int counter = 0;
        foreach (Goal goal in goalList){
            string title = goal.GetTitle();
            Console.WriteLine($"{counter}.  {title}");
            counter++;
        }

        Console.Write("Your selection: ");
        int choice = int.Parse(Console.ReadLine());

        // Update goal and get points:
        int points = goalList[choice].RecordEvent();
        return points;

        
        
    }
    static void Main(string[] args)
    {

        // Initialize a variable called points that will 
        // hold the value of all the points gained in the 
        // individual classes:
        int points = 0; 

        // Initialize a Goal list to hold all current goals:
        List<Goal> goalList = new List<Goal>();
        
        // Primary Program Loop: 
        int choice;
        bool proceed = true;
        while (proceed){

            // Display menu and get choice: 
            choice = Menu(points);
            
            // Make decision: 
            switch (choice){
                // Create new goal:
                case 1: 
                    // Display sub menu: 
                    int choice2 = SubMenu();

                    // Make decision: 
                    switch (choice2){
                        // Simple Goal:
                        case 1: 
                            // Prompt User for goal title, description, and points: 
                            Console.Write("\nPlease enter the title of the goal: ");
                            string title = Console.ReadLine();
                            Console.Write("\nPlease enter a short description of the goal: ");
                            string description = Console.ReadLine();
                            Console.Write("\nPlease enter the number of points associated with this goal: ");
                            int pointsSimple = int.Parse(Console.ReadLine());

                            // Initialize goal object: 
                            Simple simple = new Simple(description, title, pointsSimple, false);

                            // Add goal to list: 
                            goalList.Add(simple);

                            break;

                        // Eternal Goal:
                        case 2: 
                            // Prompt User for goal title, description, and points: 
                            Console.Write("\nPlease enter the title of the goal: ");
                            title = Console.ReadLine();
                            Console.Write("\nPlease enter a short description of the goal: ");
                            description = Console.ReadLine();
                            Console.Write("\nPlease enter the number of points associated with this goal: ");
                            int pointsEternal = int.Parse(Console.ReadLine());

                            // Initialize goal object: 
                            Eternal eternal = new Eternal(description, title, pointsEternal);

                            // Add goal to list: 
                            goalList.Add(eternal);

                            break;

                        // Checklist Goal: 
                        case 3: 
                            // Prompt User for goal title, description, and points: 
                            Console.Write("\nPlease enter the title of the goal: ");
                            title = Console.ReadLine();
                            Console.Write("\nPlease enter a short description of the goal: ");
                            description = Console.ReadLine();
                            Console.Write("\nPlease enter the number of points for completing one activity: ");
                            int completeValue = int.Parse(Console.ReadLine());
                            Console.Write("\nPlease enter the number of times this goal needs to be completed for a bonus: ");
                            int bonusNumber= int.Parse(Console.ReadLine());
                            Console.Write("\nPlease enter the value of the bonus: ");
                            int bonusValue = int.Parse(Console.ReadLine());


                            // Initialize goal object: 
                            Check check = new Check(description, title, completeValue, bonusValue, bonusNumber, false, 0);

                            // Add goal to list: 
                            goalList.Add(check);
                            break;

                            case 4: 
                                title = "Don't Murder";
                                description = "Resist the urge...";
                                int pointsMurder = 450;
                                Murder murder = new Murder(description, title, pointsMurder, 0);
                                goalList.Add(murder);
                                break;
                    }

                    break;

                // List goals: 
                case 2:
                    // Counter For list: 
                    int counter = 0;

                    Console.WriteLine("\nThe goals are: ");
                    // Iterate through goalList and display each: 
                    foreach (Goal goal in goalList){
                        Console.Write($"{counter}.  ");
                        goal.DisplayGoal();
                        counter++;
                    }

                    break;

                // Save goals: 
                case 3: 
                    // Get filename from user and save:
                    Console.Write("\nPlease enter the filename: ");
                    string fileName = Console.ReadLine();
                    Goal.Save(points, goalList, fileName);

                    break;

                // Load goals:
                case 4: 
                    // Get filename from user and save:
                    Console.Write("\nPlease enter the filename: ");
                    fileName = Console.ReadLine();
                    points = Goal.LoadPoints(fileName);
                    goalList = Goal.LoadGoalList(fileName);
                    break;

                // Record event: 
                case 5: 
                    points += GoalComplete(goalList);
                    break;

                // Quit: 
                case 0: 
                    proceed = false;
                    break;

                default: 
                    Console.WriteLine("Please type an integer between 0 and 5.");
                    break;
            }
        }
    }
}