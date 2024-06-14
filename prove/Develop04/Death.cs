public class Death: Activity{
    public Death(string welcome, string title, double animationTime): base(welcome, title, animationTime){}
    public void DoDeath(){
        Console.WriteLine("\nBreath in ..."); // 1
        Animation();
        Console.WriteLine("\nBreath in ..."); // 2
        Animation();
        Console.WriteLine("\nDon't breath out ..."); // 3 
        Animation();
        Console.WriteLine("\nAre you feeling dizzy?"); // 4
        Animation();
        Console.WriteLine("\nKeep breathing in ..."); // 5
        Animation();
        Console.WriteLine("\nWhen your body convulses  ..."); // 6
        Animation();
        Console.WriteLine("\nThat means your only halfway there ..."); // 7
        Animation();
        Console.WriteLine("\nBreath in ..."); // 8 
        Animation();
        Console.WriteLine("\nIs your vision blurring?"); // 9
        Animation();
        Console.WriteLine("\nKeep breathing in ..."); // 10
        Animation();
    }
}