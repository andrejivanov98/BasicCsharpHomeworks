using System;

namespace Exercise02_DateTime_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When is your birthday?");
            string birthday = Console.ReadLine();
            DateTime birthDate = DateTime.Parse(birthday);
            AgeCalculator(birthDate);
        }

        static void AgeCalculator(DateTime birthDate)
        {
            int age = 0;
            age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                age = age - 1;

            Console.WriteLine($"You are {age} years old.");

        }

    }
}
