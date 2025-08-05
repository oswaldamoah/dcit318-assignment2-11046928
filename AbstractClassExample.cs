using System;

public static class AbstractClassExample
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("=== Abstract Classes and Methods ===");
        
        Console.Write("Enter circle radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle myCircle = new Circle(radius);

        Console.Write("Enter rectangle width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter rectangle height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Rectangle myRectangle = new Rectangle(width, height);

        Console.WriteLine($"\nCircle Area: {myCircle.GetArea():F2}");
        Console.WriteLine($"Rectangle Area: {myRectangle.GetArea():F2}");
    }
}

// Abstract base class
public abstract class Shape
{
    public abstract double GetArea();
}

// Derived class
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class
public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}