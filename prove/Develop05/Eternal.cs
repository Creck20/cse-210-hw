public class Eternal: Goal{

    public Eternal(string description, string title, int points): base(description, title, points){}
    public override void DisplayGoal(){
        Console.Write($"[ ] {_title} ({_description})\n");
    }
    public override string GetTitle(){
        return _title;
    }
    public override int RecordEvent(){
        Console.WriteLine($"Congratulations! You earned {_points} points!");
        return _points;
    }
    public override string CreateGoalString()
    {
        return $"Eternal Goal~{_title}~{_description}~{_points}";
    }
}