using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 3, Lautaro G. Colazo" + Environment.NewLine);

        Console.WriteLine("Organizing lecture event..." + Environment.NewLine);
        Address a1 = new Address("Fake address", "Fake city", "Fake state", "USA");

        Lecture l1 = new Lecture("Lecture 1", "Awesome lecture", "11/29/2023", "5 PM", a1, "Lautaro", "Lecture", 25);

        string standardDetails = l1.StandardDetails();
        string fullDetails = l1.FullDetails();
        string shortDescription = l1.ShortDescription();

        Console.WriteLine($"Standard Details:" + Environment.NewLine + standardDetails + Environment.NewLine);
        Console.WriteLine($"Full Details:" + Environment.NewLine + fullDetails + Environment.NewLine);
        Console.WriteLine($"Short Description:" + Environment.NewLine + shortDescription + Environment.NewLine);

        Console.WriteLine("Organizing reception event...");
        Address a2 = new Address("Fake address number 2", "Fake city 2", "Fake state 2", "USA");

        Reception r1 = new Reception("My Reception", "Reception happening on Rexburg", "11/29/2023", "7 PM", a2, "Reception", "rsvp@example.com");

        string standardDetails1 = r1.StandardDetails();
        string fullDetails1 = r1.FullDetails();
        string shortDescription1 = r1.ShortDescription();

        Console.WriteLine($"Standard Details:" + Environment.NewLine + standardDetails1 + Environment.NewLine);
        Console.WriteLine($"Full Details:" + Environment.NewLine + fullDetails1 + Environment.NewLine);
        Console.WriteLine($"Short Description:" + Environment.NewLine + shortDescription1 + Environment.NewLine);

        Console.WriteLine("Organizing ourdoor event...");
        Address a3 = new Address("Fake address number 3", "Fake city 3", "Fake state 3", "USA");

        Outdoor o1 = new Outdoor("Awesome Outdoor event", "Exciting outdoor event", "11/29/2023", "2 PM", a3, "Outdoor", "Sunny");

        string standardDetails2 = o1.StandardDetails();
        string fullDetails2 = o1.FullDetails();
        string shortDescription2 = o1.ShortDescription();

        Console.WriteLine($"Standard Details:" + Environment.NewLine + standardDetails2 + Environment.NewLine);
        Console.WriteLine($"Full Details:" + Environment.NewLine + fullDetails2 + Environment.NewLine);
        Console.WriteLine($"Short Description:" + Environment.NewLine + shortDescription2 + Environment.NewLine);

    }
}
