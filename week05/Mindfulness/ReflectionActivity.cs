using System;

namespace MindfulnessApp
{
    public class ReflectionActivity : MindfulnessActivity
    {
        private string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private string[] questions = {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself through this experience?",
            "How did you feel when you completed this challenge?",
            "What strengths did you discover in yourself during this moment?",
            "How can this experience inspire you in the future?"
        };

        public override void StartActivity()
        {
            base.StartActivity();
            Console.WriteLine("This activity is all about recognizing your inner strength and resilience. Reflect on the powerful moments in your life.");
        }

        public override void PerformActivity()
        {
            Random rand = new Random();
            string prompt = prompts[rand.Next(prompts.Length)];
            Console.WriteLine($"Prompt: {prompt}");
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Let's reflect deeply. Take your time to think about the following questions.");
            for (int i = 0; i < duration / 10; i++)  // Each question lasts 10 seconds
            {
                string question = questions[rand.Next(questions.Length)];
                Console.WriteLine(question);
                ShowAnimation();
            }

            EndActivity("Reflection Activity");
        }
    }
}
