using System;

namespace Additional_Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert some sentence.");
            string sentence = Console.ReadLine();

            FunWithStrings(sentence);

        }

        static void FunWithStrings(string sentence)
        {
            char[] reverseSentence = sentence.ToCharArray();
            Array.Reverse(reverseSentence);
            Console.WriteLine("The reverse way of the sentence is down below:");
            Console.WriteLine(reverseSentence);

            int vowel = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u' || sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] == 'I' || sentence[i] == 'O' || sentence[i] == 'U')
                {
                    vowel++;
                }
            }
            Console.WriteLine($@"The number of vowels in the sentence is: {vowel}");

            string charSentence = new string(reverseSentence);
            if (sentence == charSentence)
            {
                Console.WriteLine($"The sentence: {sentence} is a palindrome. ");
            }
            else
            {
                Console.WriteLine($"The sentence : {sentence} is not a palindrome.");
            }

            string[] words = sentence.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int abc = 0;
            foreach (String s in words)
            {
                if (s.Length > abc)
                {
                    word = s;
                    abc = s.Length;
                }
            }

            Console.WriteLine($"The longest word in the sentence is: {word}.");
            

            int l = 0;
            int wrd = 1;


            while (l <= sentence.Length - 1)
            {
                /* checking whether the current character is white space or new line or tab character*/
                if (sentence[l] == ' ' || sentence[l] == '\n' || sentence[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }

            Console.Write("Total number of words in the sentence is : {0}\n", wrd);

            Console.WriteLine("I am sorry, but I could not solved task 5 and task 7 from this exercise.");
        }
    }   
            
    
}
