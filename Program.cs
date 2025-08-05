using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== OOP Concepts Demonstrator ===");
            Console.WriteLine("1. Inheritance and Method Overriding");
            Console.WriteLine("2. Abstract Classes and Methods");
            Console.WriteLine("3. Interfaces");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    InheritanceExample.Run();
                    break;
                case "2":
                    AbstractClassExample.Run();
                    break;
                case "3":
                    InterfaceExample.Run();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}