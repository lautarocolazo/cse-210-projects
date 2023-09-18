using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string name = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int squareNumber = SquareNumber(favoriteNumber);

        DisplayResult(name, squareNumber);
        
    }
    static void DisplayWelcome()
    {
       Console.WriteLine("Welcome to the program!"); 
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
        

    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;

    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}
