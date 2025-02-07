using System;

namespace MindfulnessApp
{
    public class ListingActivity : MindfulnessActivity
    {
        private string[] prompts = {
            "Who are the people in your life that you appreciate?",
            "What are some personal strengths that you're proud of?",
            "Who are the people you've helped recently?",
            "What are the small moments of joy you've experienced this week?",
            "Who are your heroes, and why do they inspire you?"
        };

        public override void StartActivity()
        {
            base.StartActivity();
            Console.WriteLine("This activity is designed to help you recognize and appreciate the positive aspects of your life.");
        }

        public override void PerformActivity()
        {
            Random rand = new Random();
            string prompt = prompts[rand.Next(prompts.Length)];
            Console.WriteLine($"Prompt: {prompt}");
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Now, take a moment and start listing the things that come to mind.");
            Console.WriteLine("You can type 'done' anytime to finish early.");
            int count = 0;

            while (count < duration / 5) 
            {
                string item = Console.ReadLine();
                if (item.ToLower() == "done") break;

                count++;
            }

            Console.WriteLine($"You listed {count} items! Great job focusing on the positives.");
            EndActivity("Listing Activity");
        }
    }
}
