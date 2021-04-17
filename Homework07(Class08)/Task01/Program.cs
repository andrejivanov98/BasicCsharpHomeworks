using System;
using System.Collections;
using System.Collections.Generic;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            Queue<int> myQueue = new Queue<int>();
            Stack<int> myStack = new Stack<int>();

            do
            {
                int num;
                while (true)
                {
                    Console.WriteLine("Insert a number");
                    if (int.TryParse(Console.ReadLine(), out num)) { break; }
                }
                myQueue.Enqueue(num);
                myStack.Push(num);
                myList.Add(num);
                Console.WriteLine("Do you want to insert another number? Y/N");
            }
            
            while (Console.ReadLine().ToUpper() == "Y");
            PrintCollections(myList);
            PrintCollections(myQueue);
            PrintCollections(myStack);
        }

        static void PrintCollections(IEnumerable collection)
        {
            foreach (object x in collection)
            {
                Console.WriteLine($"{collection} : {x}");
            }
        }
    }
}

        