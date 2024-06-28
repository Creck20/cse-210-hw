public class Murder: Goal{
    private int _murderNumber = 0; 
    public Murder(string description, string title, int points, int murderNumber): base(description, title, points){
        _murderNumber = murderNumber;
    }
    public override void DisplayGoal(){
            Console.Write($"[ ] {_title} ({_description}) -- {_murderNumber}\n   Let's not go any higher...");
    
    }
    public override string GetTitle()
    {
        return _title;
    }
    public override int RecordEvent(){
        Console.Write("\nDid you murder anyone this time? (y/n) ");
        string accountability = Console.ReadLine();
        int points;

        if (accountability == "y"){
            Console.WriteLine("\nYou've been naughty...");
            Console.Write("Dialing:");
            MurderAnimation();
            Console.Write(" 9");
            MurderAnimation();
            Console.Write(" 1");
            MurderAnimation();
            Console.Write(" 1");
            MurderAnimation();
            points = -1000;
            Console.Clear();
            Console.WriteLine("Run\n");
        }
        else {
            Console.WriteLine("\nGood Job! You didn't commit murder!");
            points = _points;
        }

        return points;
    }
    public override string CreateGoalString()
    {
        return $"Murder Goal~{_title}~{_description}~{_points}~{_murderNumber}";
    }

    private void MurderAnimation(){
        // Set end time: 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(1.5);

        // Set up animation list: 
        List<string> animationStrings = ["|", "/","-", "\\", "|", "/", "-", "\\"];
  
        // Run animation: 
        int i = 0;

        while (DateTime.Now < endTime){
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count){
                i = 0;
            }
        }
        
    }
    
}