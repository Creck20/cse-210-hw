using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.IO;

public abstract class Goal{
    protected string _description;
    protected int _points;
    protected string _title;
    public Goal(string description, string title, int points){
        _description = description;
        _title = title;
        _points = points;
    }
    public abstract void DisplayGoal();
    public abstract int RecordEvent();
    public abstract string GetTitle();
    public static void Save(int points, List<Goal> goalList, string fileName){
        using(StreamWriter outputFile = new StreamWriter(fileName, false)){
            // Clear the file:

            // The first line will have the points:
            outputFile.WriteLine(points);

            // All remaining lines will have the goaltype
            foreach (Goal goal in goalList){
                outputFile.WriteLine(goal.CreateGoalString());
            }

        }
    }
    public static List<Goal> LoadGoalList(string fileName){
        // Initialize the goal list and read the file into a list of strings: 
        string[] lines = System.IO.File.ReadAllLines(fileName);
        List<Goal> goalList = new List<Goal>();

        // Split the line string, create the goal object, append it to the list:
        foreach (string line in lines.Skip(1)){ // Skip the first line...
            string[] parts = line.Split("~");

            // Eternal Goal: 
            if (parts[0] == "Eternal Goal"){
                string title = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                Eternal eternal = new Eternal(description, title, points);
                goalList.Add(eternal);
            }

            // Simple Goal:
            else if (parts[0] == "Simple Goal"){
                string title = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);
                Simple simple = new Simple(description, title, points, complete);
                goalList.Add(simple);
            }

            // Murder Goal:
            else if (parts[0] == "Murder Goal"){
                string title = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int murderNumber = int.Parse(parts[4]);
                Murder murder = new Murder(description, title, points, murderNumber);
                goalList.Add(murder);
            }

            // Checklist Goal:
            else {
                string title = parts[1];
                string description = parts[2];
                int completeValue = int.Parse(parts[3]);
                int numberCompleted = int.Parse(parts[4]);
                int bonusNumber = int.Parse(parts[5]);
                int bonusValue = int.Parse(parts[6]);
                bool complete = bool.Parse(parts[7]);
                Check check = new Check(description, title, completeValue, 
                bonusValue, bonusNumber, complete, numberCompleted);
                goalList.Add(check);
            }
    
        }

        // Return reconstructed goal list:
        return goalList;

    }
    public static int LoadPoints(string fileName){
        return int.Parse(File.ReadLines(fileName).FirstOrDefault());
    }

    public abstract string CreateGoalString();
}