using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Test constructers
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(3,4);

        // Test getters/setters
        Fraction fraction4 = new Fraction();
        fraction4.SetTop(3);
        int top_test = fraction4.GetTop();
        fraction4.SetBottom(4);
        int bottom_test = fraction4.GetBottom();
        Console.WriteLine($"Top: {top_test}, Bottom: {bottom_test}");

        // Test fraction1
        string frac1Test1 = fraction1.GetFractionString();
        Console.WriteLine(frac1Test1);
        double frac1Test2 = fraction1.GetDecimalValue();
        Console.WriteLine(frac1Test2);

        // Test fraction2
        string frac2Test1 = fraction2.GetFractionString();
        Console.WriteLine(frac2Test1);
        double frac2Test2 = fraction2.GetDecimalValue();
        Console.WriteLine(frac2Test2);

        // Test fraction3
        string frac3Test1 = fraction3.GetFractionString();
        Console.WriteLine(frac3Test1);
        double frac3Test2 = fraction3.GetDecimalValue();
        Console.WriteLine(frac3Test2);
    }
    
}