using System;

namespace MindfulnessApp
{
    public abstract class MindfulnessActivity
    {
        protected int duration;

        public void GetDuration()
        {
            Console.Write("How much time would you like to spend on this activity (in seconds)? ");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine($"Great choice! You've selected {duration} seconds.");
        }

        public void StartActivity()
        {
            Console.WriteLine("Alright, let's get started... Take a deep breath and get ready.");
            System.Threading.Thread.Sleep(3000); // 3 seconds to prepare
        }

        public void EndActivity(string activityName)
        {
            Console.WriteLine($"Well done! You've completed the {activityName}.");
            Console.WriteLine($"You spent {duration} seconds on this activity. Keep going! You're doing great.");
            System.Threading.Thread.Sleep(2000); // 2 seconds to wrap up
        }

        public void ShowAnimation()
        {
            Console.Write("Please be patient while we process... ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".", System.Console.CursorLeft, System.Console.CursorTop);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();  // Move to next line after animation
        }

        public abstract void PerformActivity();
    }
}
