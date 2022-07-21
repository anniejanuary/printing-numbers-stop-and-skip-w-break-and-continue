using System;

namespace BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Break();
            Continue();
            ContinueOddNumber();
            Console.ReadLine();
        }

        public static void Break()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if (counter == 3)
                {
                    Console.WriteLine("At 3 we stop");
                    break;
                }
            }
        }

        public static void Continue()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                if (counter == 3)
                {
                    Console.WriteLine("We're skipping 3");
                    continue;
                }
                Console.WriteLine(counter);

            }
        }

        public static void ContinueOddNumber()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                if (counter %2 == 0)
                {
                    Console.WriteLine("Now comes an odd number");
                    continue;
                }
                Console.WriteLine(counter);

            }
        }
    }
}
