using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first number?");
            string input1 = Console.ReadLine();
            int firstNumber = int.Parse(input1);

            Console.WriteLine("Insert second number?");
            string input2 = Console.ReadLine();
            int secondNumber = int.Parse(input2);

            Console.WriteLine("Insert third number?");
            string input3 = Console.ReadLine();
            int thirdNumber = int.Parse(input3);

            Console.WriteLine("Insert forth number?");
            string input4 = Console.ReadLine();
            int forthNumber = int.Parse(input4);

            int average = (firstNumber + secondNumber + thirdNumber + forthNumber) / 4;

            Console.WriteLine("The average of the inserted numbers is " + average);
        }
    }
}
