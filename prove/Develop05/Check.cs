public class Check: Goal{
    // The points for completing a task:
    private int _completeValue;
    // The number of tasks completed: 
    private int _numberCompleted = 0;
    // The number of tasks to complete before recieving a bonus: 
    private int _bonusNumber;
    // The number of points you recieve on a bonus. 
    private int _bonusValue;
    private bool _complete;

    public Check(string description, string title, int completeValue, int bonusValue, int bonusNumber, bool complete, int numberCompleted): 
    base(description, title, 0){
        _completeValue = completeValue;
        _bonusValue = bonusValue;
        _bonusNumber = bonusNumber;
        _complete = complete;
        _numberCompleted = numberCompleted;
    }

    public override void DisplayGoal(){
        if (_complete == true){
            Console.Write($"[X] {_title} ({_description}) -- {_numberCompleted}/{_bonusNumber}\n");
        }
        else{
            Console.Write($"[ ] {_title} ({_description}) -- {_numberCompleted}/{_bonusNumber}\n");

        }
        
    }
    public override string GetTitle()
    {
        return _title;
    }
    public override int RecordEvent(){
        // Increase the number of task completed by one.
        _numberCompleted++;
        int points = 0;

        // Tasks are remaining: 
        if (_numberCompleted != _bonusNumber){
            points = _completeValue;
            Console.WriteLine($"Congratulations! You completed a task and earned {points} points!");
        }

        // No tasks left: 
        else{
            points = _completeValue + _bonusValue;
            _complete = true;
            Console.WriteLine($"Congratulations! You completed all task and earned {points}points!");
        }

        return points;
        
    }
    public override string CreateGoalString(){
        return $"Eternal Goal~{_title}~{_description}~{_completeValue}~{_numberCompleted}~{_bonusNumber}~{_bonusValue}~{_complete}";
    }
}