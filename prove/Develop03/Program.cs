using System;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Test Word Class:
        // Word word1 = new Word("And"); word1.Display();
        // Console.WriteLine();
        // word1.Hide(); word1.Display();

        // Test Citation Class:
        // Citation citation1 = new Citation("Jacob", 6, 12, 0); citation1.Display();
        // Citation citation2 = new Citation("3 Nephi", 11, 3, 4); citation2.Display();

        // Test Verse Class: 
        // Verse verse1 = new Verse("Oh be wise, what can I say more?");
        // verse1.Display(); verse1.HideRandomWord(); verse1.Display();

        //Test File Class: 
        // File file1 = new File(); 
        // string scriptureString = file1.GetScripture();
        // Console.WriteLine(scriptureString);

        // Test Memorize Class: 
        // File file1 = new File(); 
        // string scriptureString = file1.GetScripture();
        // Citation citation2 = new Citation("3 Nephi", 11, 3, 4);
        // Memorize memorize1 = new Memorize(citation2, scriptureString);
        // memorize1.Display();

        // Program
        // Get heading from user:
        Console.WriteLine("Welcome to the scripture memorizer!\n");

        Console.WriteLine("Type the name of the Book of Scripture: ");
        string book = Console.ReadLine();

        Console.WriteLine("Type the number of the Chapter: ");
        int chapter = int.Parse(Console.ReadLine());

        Console.WriteLine("Type the number of the First Verse: ");
        int firstVerse = int.Parse(Console.ReadLine());

        Console.WriteLine("Type the number of the Last Verse");
        Console.WriteLine("(If there is only one verse type 0):");
        int lastVerse = int.Parse(Console.ReadLine());

        // Build Citation:
            Citation citation = new Citation(book, chapter, firstVerse, lastVerse);

        // Populate File

        while(true){
            Console.WriteLine("Copy and paste the scripture into the Scripture.txt file");
            Console.WriteLine("Type 'done' when finished" );
            string proceed = Console.ReadLine();
            if(proceed == "done"){
                break;
            }
        }

        Console.WriteLine();

        // Create Memorize Object: 
        File file = new File(); 
        string scriptureString = file.GetScripture();
        Memorize memorize = new Memorize(citation, scriptureString);
        memorize.Display();

        // Memorize Loop:
        while(true){

            Console.Clear();
            Console.WriteLine("Press enter to continue. Type 'quit' to stop.");
            memorize.Display();

            memorize.HideTwoRandom();

            int count = memorize.GetRevealedCount();
            
            if(count == 0){
                break;
            }
            
            string proceed = Console.ReadLine();
            
            if(proceed == "quit"){
                break;
            }
        }
        
        // Final State of Scripture:
        Console.Clear();
        memorize.Display();
    }
}