using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;

        int inputNumber = -1;
        
        while (inputNumber != 0)
        {
            Console.WriteLine("Enter number: ");
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
            else
            {
                Console.WriteLine("Finished adding numbers");
            }
        }

        int smallest = int.MaxValue;
        int largest = int.MaxValue;
        int index;

        foreach (int number in numbers)
        {
            index = numbers.IndexOf(number);            
            
            if (index == 0)
            {
                smallest = number;
                largest = number;
            }
            else
            {
                if (smallest > number)
                {
                    smallest = number;
                }

                if (largest < number)
                {
                    largest = number;
                }
            }

            sum += number;
        }

        int avg = sum / numbers.Count;

        Console.WriteLine($"The length of the list is: {numbers.Count}");
        Console.WriteLine($"The sum of all numbers is: {sum}");
        Console.WriteLine($"The avg of all numbers is: {avg}");
        Console.WriteLine($"The smallest of all numbers is: {smallest}");
        Console.WriteLine($"The largest of all numbers is: {largest}");
    }
}
