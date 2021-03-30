using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number.");
            string input1 = Console.ReadLine();
            int firstInput = int.Parse(input1);

          
            Console.WriteLine("Insert another number.");
            string input2 = Console.ReadLine();
            int secondInput = int.Parse(input2);

            if(firstInput > secondInput)
            {
                Console.WriteLine(firstInput + "is larger than" + secondInput);
            }
            else
            {
                Console.WriteLine(secondInput + "is larger than" + firstInput);
            };

            if(firstInput % 2 == 0)
            {
                Console.WriteLine("The number" + firstInput + "is even number.");
            }
            else
            {
                Console.WriteLine("The number" + firstInput + "is odd number.");
            };

            if (secondInput % 2 == 0)
            {
                Console.WriteLine("The number" + secondInput + "is even number.");
            }
            else
            {
                Console.WriteLine("The number" + secondInput + "is odd number.");
            };






        }
    }
}
