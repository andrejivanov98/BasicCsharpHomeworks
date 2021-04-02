using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number?");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            bool successValue = int.TryParse(input, out n);

             if (!successValue)
             {
            Console.WriteLine("Wrong input inserted.");
             return;
             }
          
            Substrings(n);
        }
        static void Substrings(int n)
        {
           
            string sentence = "Hello from SEDC code academy 2021";
            string newSentence = sentence.Substring(0, n);
            
            Console.WriteLine(newSentence);
            int newSentenceLength = newSentence.Length;
            Console.WriteLine(newSentenceLength);
            


        }
    }
}
