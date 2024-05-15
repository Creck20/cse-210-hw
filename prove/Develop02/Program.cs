using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Xml.Serialization;

/*
I added a function to count the number of words typed in the response.
*/
class Program
{
    static void Main(string[] args)
    {
        // Initialize Classes
        Journal journal = new Journal();
        Entry entry = new Entry();
        Prompt prompt = new Prompt();

        // Call welcome message:
        journal.DisplayWelcome();

        // Loop through program: 
        bool proceed = true;
        while(proceed)
        {
            // Get choice:
            int choice = journal.DisplayMenu();
            
            switch (choice)
            {
                case 1: 
                    // Display Prompt:
                    Console.WriteLine("Getting prompt...\n");
                    string current_prompt = prompt.GetPrompt();
                    Console.WriteLine($"{current_prompt}\n");

                    // Get Entry Text:
                    Console.Write("Record Your Entry Here: ");
                    string current_text = Console.ReadLine();

                    // Get Date and Time: 
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    // Compile and Add Entry: 
                    entry._entryDate = dateText;
                    entry._entryPrompt = current_prompt;
                    entry._entryText = current_text;
                    entry._entryLength = entry.NumberOfWords();
                    string current_entry = entry.CompileEntry();
                    journal._entryList.Add(current_entry);

                    break;

                case 2:
                    // Display Entry List:
                    journal.Display();
                    break;

                case 3:
                    // Clear Current Entry List:
                    journal._entryList = [];

                    // Load Entry List: 
                    Console.Write("Please Enter Filename: ");
                    journal._filename = Console.ReadLine();
                    journal.LoadEntry();

                    break;

                case 4:
                    // Save Entry List: 
                    Console.Write("Please Enter Filename: ");
                    journal._filename = Console.ReadLine();
                    journal.SaveEntry();

                    break;

                case 5: 
                    proceed = false;
                    break;
            }
        }
    }
}