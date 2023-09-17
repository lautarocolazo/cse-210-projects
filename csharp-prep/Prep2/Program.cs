using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?: ");
        string gradePercentage = Console.ReadLine();
        string letter;

        if (int.Parse(gradePercentage) >= 90) 
        {
            letter = "A";
        }
        else if (int.Parse(gradePercentage) >= 80)
        {
            letter = "B";
        }
        else if (int.Parse(gradePercentage) >= 70)
        {
            letter = "C";
        }
        else if (int.Parse(gradePercentage) >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is equivalent to: {letter}");

        if (int.Parse(gradePercentage) >= 70)
        {
            Console.WriteLine("Congratulations for passing the course");
        }
        else
        {
            Console.WriteLine("Keep working hard!");
        }
    }
}
