using System;

public static class InheritanceExample
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("=== Inheritance and Method Overriding ===");
        
        Animal genericAnimal = new Animal();
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        Console.WriteLine("Generic Animal:");
        genericAnimal.MakeSound();

        Console.WriteLine("\nDog:");
        myDog.MakeSound();

        Console.WriteLine("\nCat:");
        myCat.MakeSound();
    }
}

// Base class
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}