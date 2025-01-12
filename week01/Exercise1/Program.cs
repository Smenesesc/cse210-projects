using System;

class Program
{
    static void Main(string[] args)
    {
        // first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();  // Store the first name

        // last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();  // Store the last name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}