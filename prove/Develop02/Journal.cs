using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public string _filename;
    public List<string> _entryList = [];

    public void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Journal!");
    }
    public int DisplayMenu()
    {
        // Display Options:
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        // Get choice:
        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        return(choice);
    }
    public void Display() 
    {
        foreach (string entry in _entryList)
        {
            Console.WriteLine(entry);
        }
    }
    
    public void SaveEntry()
    {
        using(StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (string entry in _entryList)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
    public void LoadEntry()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            _entryList.Add(line);
        }
    }  
}