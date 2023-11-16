using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
      
        List<Goal> goals = new List<Goal>();
        int globalPoints = 0;

        int option = 0;

        while (option != 6)
        {
            Console.WriteLine($"You have {globalPoints} points.");

            menu.Display();

            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                menu.DisplayGoalsMenu();

                int goalOption = int.Parse(Console.ReadLine());

                if (goalOption == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();

                    simpleGoal.CreateGoal();

                    goals.Add(simpleGoal);
                }
                else if (goalOption == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();

                    eternalGoal.CreateGoal();

                    goals.Add(eternalGoal);
                }
                else if (goalOption == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();

                    checklistGoal.CreateGoal();

                    goals.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }

            if (option == 2)
            {
                Console.WriteLine("The goals are: ");

                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].Display()}");
                }
            }

            if (option == 3)
            {
                Console.Write("What is the name of the file?: ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(globalPoints);

                    foreach (Goal goal in goals)
                    {
                        string goalType = goal.GetType().Name;
                        string goalInfo = $"{goalType}:{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.GetIsComplete()}";

                        if (goal is ChecklistGoal checklistGoal)
                        {
                            goalInfo += $",{checklistGoal._bonusPoints},{checklistGoal._timesToAccomplished},{checklistGoal._currentTimesAccomplished}";
                        }

                        outputFile.WriteLine(goalInfo);
                    }
                }
            }

            if (option == 4)
{
                Console.Write("What is the name of the file?: ");
                string filename = Console.ReadLine();

                Console.WriteLine("Loading file");

                string[] lines = System.IO.File.ReadAllLines(filename);

                if (lines.Length > 0)
                {
                    globalPoints = int.Parse(lines[0]);
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(':');
                    if (parts.Length == 2)
                    {
                        string goalType = parts[0];
                        string[] goalInfo = parts[1].Split(',');

                        Goal goal;
                        switch (goalType)
                        {
                            case "SimpleGoal":
                                goal = new SimpleGoal();
                                break;
                            case "ChecklistGoal":
                                goal = new ChecklistGoal();
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal();
                                break;
                            default:
                                Console.WriteLine($"Unknown goal type: {goalType}");
                                continue;
                        }

                        goal.SetProperties(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), bool.Parse(goalInfo[3]));

                        if (goal is ChecklistGoal checklistGoal)
                        {
                            checklistGoal._bonusPoints = int.Parse(goalInfo[4]);
                            checklistGoal._timesToAccomplished = int.Parse(goalInfo[5]);
                            checklistGoal._currentTimesAccomplished = int.Parse(goalInfo[6]);
                        }

                        goals.Add(goal);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid line format: {lines[i]}");
                    }
                }
            }

            if (option == 5)
            {
                Console.WriteLine("The goals are: ");

                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
                }

                Console.Write("Which goal did you accomplish?: ");

                int goalNumber = int.Parse(Console.ReadLine()) - 1;

                if (goals[goalNumber].IsComplete())
                {
                    Console.WriteLine("You already completed this goal!");
                }
                else
                {
                    goals[goalNumber].CompleteGoal();

                    int goalPoints = goals[goalNumber].GetPoints();

                    Console.WriteLine($"Congratulations! You have earned {goalPoints}!");

                    globalPoints += goalPoints;

                    Console.WriteLine($"You now have {globalPoints}");
                }
            }
        }
    }
}
