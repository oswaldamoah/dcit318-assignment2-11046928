using System;

public static class InterfaceExample
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("=== Interfaces ===");
        
        Car myCar = new Car();
        Bicycle myBike = new Bicycle();

        Console.WriteLine("Car Movement:");
        myCar.Move();

        Console.WriteLine("\nBicycle Movement:");
        myBike.Move();
    }
}

// Interface
public interface IMovable
{
    void Move();
}

// Implementing class
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Implementing class
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}