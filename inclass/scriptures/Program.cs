Scripture scripture = new Scripture();

string option = "";

while (option != "quit")
{
  
Console.WriteLine($"This is the scripture: {scripture.GetScripture()}");

Console.WriteLine("Please press enter to continue or 'quit' to finish");

option = Console.ReadLine();

if (option == "")
{
  scripture.HideWords();
}

Console.Clear();

}
