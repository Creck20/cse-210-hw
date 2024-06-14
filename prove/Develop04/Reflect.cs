using System.Security.Cryptography.X509Certificates;

public class Reflect : Activity{
    private List<string> _listPrompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    private List<string> _listReflect = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflect(string welcome, string title, double animationTime): base(welcome, title, animationTime){}
     public string PromptGenerator(){
        Random rand = new Random();
        int index = rand.Next(0,3);
        return _listPrompts[index];
    }
    public void DoReflect(){
        // Set end time: 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Run loop: 
        int i = 0;

        while (DateTime.Now < endTime){
            Console.WriteLine($"\n{_listReflect[i]}");
            Animation();
            i++;

            if (i >= _listReflect.Count){
                i = 0;
            }
        }
    }

}