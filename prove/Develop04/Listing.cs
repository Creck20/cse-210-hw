public class Listing : Activity{
    private List<string> _listPrompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public string PromptGenerator(){
        Random rand = new Random();
        int index = rand.Next(0,4);
        return _listPrompts[index];
    }
    public Listing(string welcome, string title, double animationTime): base(welcome, title, animationTime){}
    public List<string> DoList(){
        // Initialize Response List:
        List<string> responseList = new List<string>();
        
        // Get endTime:
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Run loop:
        Console.WriteLine("Your response: ");
        while (DateTime.Now < endTime){
            responseList.Add(Console.ReadLine());
        }

        return responseList;


        
    }
    
}