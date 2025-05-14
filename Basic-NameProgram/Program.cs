/*Create a program that asks for a users name and stores the input into variable, 
Create an if / esle statement to unsure the user inputs a valid name,
if name is = not valid display a message asking them to enter a valid name,
Once they enter a valid name send them a message using string intopolation 
saying hi {name} welcome to programming.
*/

using System;

namespace getName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to input their name.
            Console.WriteLine("Hello, What is your name?");

            // reads input and assigns input to sting type variable called name.
            string name = Console.ReadLine();

            // If statement to define weather or not user made an input
            if(string.IsNullOrWhiteSpace(name))
            {
                // if users input was = null or white space (nothing) return error message: 
                Console.WriteLine("Oops, Please endter a valid name.");
            }
            // else statement used to deliver welcome message if user input is = to anything other than nothing.
            else
            {
                // Using string interpolation $ allows for {name} variable to be added to string literal
                // {name.ToUpper} method prints out the user's name in all capitols.
                Console.WriteLine($"Hi {name.ToUpper()} welcome to world of programming!");
            }
        }
    }
}





