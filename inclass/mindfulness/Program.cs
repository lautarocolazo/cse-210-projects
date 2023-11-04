int option = 0;

while (option != 4)
{
  Console.WriteLine("Menu Options:");
  Console.WriteLine("  1. Start breathing activity");
  Console.WriteLine("  2. Start reflecting activity");
  Console.WriteLine("  3. Start listing activity");
  Console.WriteLine("  4. Quit");
  Console.Write("Select a choice from the menu: ");

  option = int.Parse(Console.ReadLine());

  if (option == 1)
  {
    Console.Clear();

    string activityName = "Breathing Activity";
    string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
    int duration;
    
    Console.WriteLine(Environment.NewLine + $"Welcome to the {activityName}" + Environment.NewLine);
    Console.WriteLine(description + Environment.NewLine);

    Console.Write("How long, in seconds, would you like for your session?: ");
    duration = int.Parse(Console.ReadLine());

    BreathingActivity activity = new BreathingActivity(activityName, description, duration);

    Console.Clear();
    
    Console.WriteLine("Get ready...");
    activity.PauseWhileSpinner();

    activity.RunActivity();

    activity.DisplayEndingMessage();

  }

  if (option == 2)
  {
    Console.Clear();

    string activityName = "Reflecting Activity";
    string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    int duration;
    
    Console.WriteLine(Environment.NewLine + $"Welcome to the {activityName}" + Environment.NewLine);
    Console.WriteLine(description + Environment.NewLine);

    Console.Write("How long, in seconds, would you like for your session?: ");
    duration = int.Parse(Console.ReadLine());

    ReflectingActivity activity = new ReflectingActivity(activityName, description, duration);

    Console.Clear();
    
    Console.WriteLine("Get ready...");
    activity.PauseWhileSpinner();

    activity.RunActivity();

    activity.DisplayEndingMessage();

  }

  if (option == 3)
  {
    Console.Clear();

    string activityName = "Listing Activity";
    string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    int duration;
    
    Console.WriteLine(Environment.NewLine + $"Welcome to the {activityName}" + Environment.NewLine);
    Console.WriteLine(description + Environment.NewLine);

    Console.Write("How long, in seconds, would you like for your session?: ");
    duration = int.Parse(Console.ReadLine());

    ListingActivity activity = new ListingActivity(activityName, description, duration);

    Console.Clear();
    
    Console.WriteLine("Get ready...");
    activity.PauseWhileSpinner();

    activity.RunActivity();

    activity.DisplayEndingMessage();

  }
}


Console.WriteLine("End of the program");






