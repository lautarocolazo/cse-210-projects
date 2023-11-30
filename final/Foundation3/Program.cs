using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 3, Lautaro G. Colazo");

        Console.WriteLine("Organizing lecture event...");
        Address a1 = new Address("Fake address", "Fake city", "Fake state", "USA");

        Lecture l1 = new Lecture("Lecture 1", "Awesome lecture", "11/29/2023", "5 PM", a1, "Lecture", "Lautaro", 25);

        string standardDetails = l1.StandardDetails();
        string fullDetails = l1.FullDetails();
        string shortDescription = l1.ShortDescription();

        Console.WriteLine($"Standard Details: {standardDetails}");
        Console.WriteLine($"Full Details: {fullDetails}");
        Console.WriteLine($"Short Description: {shortDescription}");

        // Reception r1 = new Reception();
        //
        // Outdoor o1 = new Outdoor();

    }
}
