public class Menu
{

  public void Display()
  {
    Console.WriteLine("Menu Options: ");
    Console.WriteLine(" 1. Create New Goal");
    Console.WriteLine(" 2. List Goals");
    Console.WriteLine(" 3. Save Goals");
    Console.WriteLine(" 4. Load Goals");
    Console.WriteLine(" 5. Record event");
    Console.WriteLine(" 6. Quit");
    Console.Write("Select a choice from the menu: ");
  }

  public void DisplayGoalsMenu()
  {
    Console.WriteLine("The types of goals are: ");
    Console.WriteLine(" 1. Simple Goal");
    Console.WriteLine(" 2. Eternal Goal");
    Console.WriteLine(" 3. Checklist Goal");
    Console.Write("Which type of goal would you like to create?: ");
  }

}

