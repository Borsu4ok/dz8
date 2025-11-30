using System;

abstract class Shape
{
    public abstract int Area();
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int Area() => Width * Height;
}

class Square : Shape
{
    public int Side { get; set; }

    public override int Area() => Side * Side;
}

class Program3
{
    static void Main(string[] args)
    {
        Shape rect = new Rectangle { Width = 5, Height = 10 };
        Shape square = new Square { Side = 10 };

        Console.WriteLine(rect.Area());     
        Console.WriteLine(square.Area());   
    }
}
