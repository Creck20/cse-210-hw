public class Hyperventilate: Activity{
    public Hyperventilate(string welcome, string title, double animationTime): base(welcome, title, animationTime){}
    public void DoHyperventilate(){
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