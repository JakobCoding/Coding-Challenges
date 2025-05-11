/*
Challenge: Print Your Name,Write a simple C# program that:
- Asks the user to enter their name.
- Reads the user input.
- Prints a greeting message that includes their name.*/

using System;

class Program
{
    static void Main()
    {
        // Ask the user for their name 
        Console.Write("Enter your name: ");

        // Read user input and assign it to a variable
        string name = Console.ReadLine();

        // Print a greeting message
        Console.WriteLine("Hello, " + name + "! Welcome to the C# programming world.");

        // Ask the user for their age
        Console.Write("Enter your age: ");

        // Read user input and convert it to an integer
        int age = Convert.ToInt32(Console.ReadLine());

        // Print a message with the user's age
        Console.WriteLine("Hi " + name + ", you are " + age + " years old!");
    }
}