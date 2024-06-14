using System.Security.Cryptography.X509Certificates;

public class Breath : Activity{
    public Breath(string welcome, string title, double animationTime): base(welcome, title, animationTime){}
    public void DoBreath(){
        // Set end time: 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Run loop: 
        while (DateTime.Now < endTime){
            Console.WriteLine("\nBreath in ... ");
            Animation();
            Console.WriteLine("\nBreath out ... ");
            Animation();
        }
        
    }
}