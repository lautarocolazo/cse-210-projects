using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        int guessNumber = -1;

        while (magicNumber != guessNumber)
        {

            Console.WriteLine("What is your guess number?: ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Guess lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Guess higher");
            }
            else
            {
                Console.WriteLine("You guessed right!");
            }
        }
        Console.WriteLine("End of the game.");
    }
}
