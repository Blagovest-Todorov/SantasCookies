using System;

namespace SantasCookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBatches = int.Parse(Console.ReadLine());
            int totalBoxes = 0;

            for (int i = 0; i < numBatches; i++)
            {
                // for every Batch :
                int amountFlourGr = int.Parse(Console.ReadLine());
                int amountSugarGr = int.Parse(Console.ReadLine());
                int amountCocoaGr = int.Parse(Console.ReadLine());

                int frCups = amountFlourGr / 140;
                int srSpoons = amountSugarGr / 20;
                int coSpoons = amountCocoaGr / 10;

                if (frCups <= 0 || srSpoons <= 0 || coSpoons <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                    continue;
                }

                int totalCookiesBake =(140+10+20)*Math.Min(Math.Min(frCups,srSpoons),coSpoons)/25;                   

                int numbBoxesForBatch  = totalCookiesBake / 5;
                totalBoxes += (int)numbBoxesForBatch;

                Console.WriteLine($"Boxes of cookies: {numbBoxesForBatch}");
            }


            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
