using System;

namespace DumbCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write a number and press enter");
                string value1 = Console.ReadLine();
                int numericalValue1 = FlipTheFlop(value1);


                Console.WriteLine("Write a number and press enter");
                string value2 = Console.ReadLine();
                int numericalValue2 = FlipTheFlop(value2);

                string flippyflop = "The result is: ";

                if (numericalValue1 == numericalValue2)
                {
                    PrintTheFlop(flippyflop, numericalValue1);
                }
                else
                { 
                    PrintTheFlipper(flippyflop, numericalValue1, numericalValue2);
                }
                
            }
            

        }
        
        private static int FlipTheFlop(string noName)
        {
            int noNameInt = Convert.ToInt32(noName);
            return noNameInt;
        }

        private static void PrintTheFlop(string flopper, int flipper)
        {
            Console.Write(flopper);
            Console.WriteLine(flipper * 3);
        }

        private static void PrintTheFlipper(string flopper, int flipper, int flapper)
        {
            Console.Write(flopper);
            if(flapper != flipper)
            {
                Console.WriteLine(flipper + flapper);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
