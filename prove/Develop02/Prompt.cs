using System.ComponentModel.DataAnnotations;

public class Prompt 
{
    public List<string> _promptList = new List<string>
            (["Describe a challenge you faced today and how you overcame it.",
            "Reflect on a recent success and what you learned from it.",
            "Write about a person who inspires you and why.",
            "What are you grateful for today? Why?",
            "Describe a goal you want to achieve and your plan to accomplish."]);
    public string GetPrompt()  
    {
        Random rand = new Random();
        int index = rand.Next(0,5);
        return _promptList[index];
    }

}