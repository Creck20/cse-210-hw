using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 2);
        // Console.WriteLine(square.GetArea());
        // Console.WriteLine(square.GetColor());
        
        Rectangle rectangle = new Rectangle("Red", 2, 3);
        // Console.WriteLine(rectangle.GetArea());
        // Console.WriteLine(rectangle.GetColor());

        Circle circle = new Circle("Yellow", 1);
        // Console.WriteLine(circle.GetArea());
        // Console.WriteLine(circle.GetColor());

        List<Shape> list1 = new List<Shape>(){
            square, rectangle, circle
        };

        foreach (Shape shape in list1){
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }

        
    }
}