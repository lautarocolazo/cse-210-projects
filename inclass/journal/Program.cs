
Console.WriteLine("Please select one of the following choices: ");

int menuOption = -1;

Journal journal = new Journal("Lautaro", "test");

while (menuOption != 5)
{

  Console.WriteLine("1. Write");
  Console.WriteLine("2. Display");
  Console.WriteLine("3. Load");
  Console.WriteLine("4. Save");
  Console.WriteLine("5. Quit");
  Console.WriteLine("What would you like to do?");

  menuOption = int.Parse(Console.ReadLine());
  if (menuOption == 5)
  {
    return;
  }
  else if (menuOption == 1)
  {
    Prompt prompt = new Prompt();

    string randomPrompt = prompt.GeneratePrompt();
    string date = DateTime.Now.ToString("MM/dd/yyyy");

    Entry entry = new Entry(date, randomPrompt);
    
    Console.WriteLine("Chosen prompt: ");
    Console.WriteLine(entry._prompt);
    
    string response = Console.ReadLine();
    entry._response = response;
    
    journal.AddEntryToJournal(entry);

  }
  else if (menuOption == 2)
  {
    journal.ShowAllEntries();
  }
  else if (menuOption == 3)
  {
    Console.WriteLine("What is the name of the file?");
    string filename = Console.ReadLine();
    journal.Load(filename);
  }
  else if (menuOption == 4)
  {
    Console.WriteLine("What is the name of the file?");
    string filename = Console.ReadLine();
    journal.Save(filename);
  }
  else
  {
    Console.WriteLine("Invalid option");
  }
}



