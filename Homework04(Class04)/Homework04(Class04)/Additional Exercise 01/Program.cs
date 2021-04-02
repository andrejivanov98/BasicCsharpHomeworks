using System;

namespace Additional_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a sentence.");
            string sentence = Console.ReadLine();
            Console.WriteLine("Please insert a character.");
            string oneChar = Console.ReadLine();
            char character;
            bool validChar = char.TryParse(oneChar, out character);
            if (!validChar)
            {
                Console.WriteLine("The inserted character is not correct, please try again.");
            }

            Console.WriteLine("Insert a number.");
            string input = Console.ReadLine();
            int n;
            bool validInput = int.TryParse(input, out n);
            if (!validInput)
            {
                Console.WriteLine("Wrong number inserted.");
            }


            PrintTimesOfCharacter(sentence, character);
            Substrings(sentence, n);

        }
        static void PrintTimesOfCharacter(string sentence, char character)
        {
            int result = sentence.Split(character).Length - 1;
            Console.WriteLine($@"The character ""{character}"" is contained {result} times in the sentence: {sentence} ");
        }

        static void Substrings(string sentence, int n)
        {
            string newSentence = sentence.Substring(0, n);
            int newSentenceLength = newSentence.Length;

            Console.WriteLine($@"The new substracted sentence is {newSentence}.");
            
            Console.WriteLine($@"The length of the new substracted sentence is {newSentenceLength}.");
        }
        
    }
}
