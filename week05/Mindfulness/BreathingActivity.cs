using System;

namespace MindfulnessApp
{
    public class BreathingActivity : MindfulnessActivity
    {
        public override void StartActivity()
        {
            base.StartActivity();
            Console.WriteLine("This breathing exercise will help you relax. Focus on your breath and let go of any tension.");
        }

        public override void PerformActivity()
        {
            Console.WriteLine("Starting your breathing exercise... Take a deep breath in... and out.");
            for (int i = 0; i < duration / 10; i++)  // Each breath cycle lasts 10 seconds
            {
                Console.WriteLine("Breathe in... Feel your body filling with calm.");
                ShowAnimation();
                Console.WriteLine("Breathe out... Let go of any stress.");
                ShowAnimation();
            }

            EndActivity("Breathing Exercise");
        }
    }
}
