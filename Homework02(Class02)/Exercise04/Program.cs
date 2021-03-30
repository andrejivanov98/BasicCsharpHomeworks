using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number?");
            string input1 = Console.ReadLine();
            int firstNumber = int.Parse(input1);
            int copyOfFirstNumber = firstNumber;

            Console.WriteLine("Insert another number?");
            string input2 = Console.ReadLine();
            int secondNumber = int.Parse(input2);

            firstNumber = secondNumber;
            secondNumber = copyOfFirstNumber;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
        }
    }
}
