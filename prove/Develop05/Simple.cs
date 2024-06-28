using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

public class Simple: Goal{
    private bool _complete = false;
    public Simple(string description, string title, int points, bool complete): base(description, title, points){
        _complete = complete;
    }
    public override void DisplayGoal(){
        if (_complete == true){
            Console.Write($"[X] {_title } ({_description})\n");
        }
        else{
            Console.Write($"[ ] {_title} ({_description})\n");
        }
    
    }
    public override string GetTitle()
    {
        return _title;
    }
    public override int RecordEvent(){
        Console.WriteLine($"Congratulations! You earned {_points} points!");
        _complete = true;
        return _points;
    }
    public override string CreateGoalString()
    {
        return $"Simple Goal~{_title}~{_description}~{_points}~{_complete}";
    }
}