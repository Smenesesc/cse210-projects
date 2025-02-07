// For creativity I'm adding more conversation prompts so that it is more friendly and engaging
using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! Welcome to the Mindfulness Program.");
            Console.WriteLine("Take a moment for yourself to reflect, relax, and be present.");
            
            while (true)
            {
                Console.WriteLine("\n--- What would you like to do today? ---");
                Console.WriteLine("1. Take a Breathing Break");
                Console.WriteLine("2. Reflect on Your Strengths");
                Console.WriteLine("3. List Positive Things in Your Life");
                Console.WriteLine("4. Exit the Program");

                string choice = Console.ReadLine();

                MindfulnessActivity activity = null;

                if (choice == "1")
                {
                    activity = new BreathingActivity();
                }
                else if (choice == "2")
                {
                    activity = new ReflectionActivity();
                }
                else if (choice == "3")
                {
                    activity = new ListingActivity();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Thank you for spending time on your mindfulness today. Take care!");
                    break;
                }
                else
                {
                    Console.WriteLine("Oops! I didn't quite catch that. Please choose a number from the list.");
                    continue;
                }

                activity.GetDuration();
                activity.StartActivity();
                activity.PerformActivity();
            }
        }
    }
}
