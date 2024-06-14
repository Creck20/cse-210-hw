using System.Security.Cryptography.X509Certificates;

public class Activity{
    protected int _duration;
    protected string _welcome;
    protected string _title;
    protected double _animationTime;
    public Activity(string welcome, string title, double animationTime){
        _welcome = welcome;
        _title = title;
        _animationTime = animationTime;
    }
    public void Animation(){
        // Set end time: 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_animationTime);

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
    public void DefDuration(int duration){
        _duration = duration;
    }
    public void DisplayWelcome(){
        Console.WriteLine(_welcome,"\n");
    }
    public void DisplayExit(){
        Console.WriteLine("\nGood job!");
        Animation();
        Console.WriteLine($"You have completed the {_title} activity after {_duration} seconds.");
        Animation();
    }
    public void CountDown(){
        for (int i = 5; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}