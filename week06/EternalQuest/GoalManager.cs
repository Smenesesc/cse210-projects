using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? Please enter the number:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;
        _goals[choice].RecordEvent();
    }

    public void SaveGoals()
    {
        // Saving logic here
        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        // Loading logic here
        Console.WriteLine("Goals loaded!");
    }
}
