// Creativity added:
// I added a ChecklistGoal class where you can set a target number of completions for a goal, and once that target is met, the user receives bonus points. 
// This provides a dynamic and engaging way to track goals that require repeated actions, adding a fun layer of achievement through the bonus system.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager goalManager = new GoalManager();

        // Create some goals to demonstrate
        Goal goal1 = new SimpleGoal("Run Marathon", "Complete a marathon", 1000);
        Goal goal2 = new EternalGoal("Read Scriptures", "Read scriptures daily", 100);
        Goal goal3 = new ChecklistGoal("Attend the Temple", "Attend the temple 10 times", 50, 10, 500);

        goalManager.AddGoal(goal1);
        goalManager.AddGoal(goal2);
        goalManager.AddGoal(goal3);

        // Menu options
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Display goals");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Display score");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Exit");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    goalManager.ListGoalDetails();
                    break;
                case 2:
                    goalManager.RecordEvent();
                    break;
                case 3:
                    goalManager.DisplayPlayerInfo();
                    break;
                case 4:
                    goalManager.SaveGoals();
                    break;
                case 5:
                    goalManager.LoadGoals();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
