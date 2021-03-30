using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Insert a number:");
                string input = Console.ReadLine();

                bool validParse = int.TryParse(input, out int number);

                if (!validParse)
                {
                    i--;
                    continue;
                }

                arrayOfNumbers[i] = number;
            }

            int sum = 0;

            foreach (var number in arrayOfNumbers)
            {
                if(number % 2 == 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
