using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Real Calculator!");

            Console.WriteLine("Insert a number?");
            string input1 = Console.ReadLine();
            int firstNumber = int.Parse(input1);

            Console.WriteLine("Insert another number?");
            string input2 = Console.ReadLine();
            int secondNumber = int.Parse(input2);

            Console.WriteLine("What operation you want to do?");
            string sign = Console.ReadLine();

            if(sign == "+")
            {
                Console.WriteLine("The result is " +  (firstNumber + secondNumber));
            }
            else if(sign == "-")
            {
                Console.WriteLine("The result is " +  (firstNumber - secondNumber));
            }
            else if (sign == "*")
            {
                Console.WriteLine("The result is " +  (firstNumber * secondNumber));
            }
            else if (sign == "/")
            {
                Console.WriteLine("The result is " + (firstNumber / secondNumber));
            }
            else
            {
                Console.WriteLine("You must insert one of the signs +, -, * or / .");
            };

        }
    }
}
