using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[5] { "Branko", "Vasko", "Ranko", "Krsto", "Blazo" };
            string[] studentsG2 = new string[5] { "Ljupbe", "Damco", "Bobi", "Mehmet", "Ilir" };

            Console.WriteLine("Insert a number 1 or 2.");
            string number = Console.ReadLine();

            if (number == "1")  
            {
                Console.WriteLine("The students in G1 are:");
                for (int i=0; i<studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            }
            else if(number == "2")
            {
                Console.WriteLine("The Students in G2 are:");
                for(int i=0; i<studentsG2.Length; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            }
            else
            {
                Console.WriteLine("You have inserted wrong input");
            }
        }
    }
}
