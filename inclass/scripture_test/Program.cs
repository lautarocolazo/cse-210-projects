Scripture scripture = new Scripture(new Reference("Genesis", 1, 1), "In the beginning God created the heavens and the earth.");

while (!scripture.IsCompletelyHidden())
{
    Console.WriteLine(scripture.GetRenderedReference());
    Console.WriteLine(scripture.GetRenderedText());
    Console.WriteLine("Please press enter to continue or 'quit' to finish");

    string input = Console.ReadLine();

    if (input.ToLower() == "quit")
    {
        break;
    }
    scripture.HideWords(3);
}

Console.WriteLine("End of program");
