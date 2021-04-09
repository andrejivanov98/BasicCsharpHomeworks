using System;




namespace Exercise01.Classes


{
    class Program
    {
        static void Main()
        {
            
            Car[] cars = new Car[4]
            {
                new Car("Hyndai", 200),
                new Car("Mazda", 220),
                new Car ("Porsche", 260),
                new Car ("Ferrari", 300)

            };

            Driver[] drivers = new Driver[4]
            {
                new Driver("Bob", 6),
                new Driver("Greg", 8),
                new Driver("Jill", 8),
                new Driver("Anne", 7)
            };

            Console.WriteLine("Insert order number of the first car you want to select.");
            Console.WriteLine("0. Hyndai");
            Console.WriteLine("1. Mazda");
            Console.WriteLine("2. Porsche");
            Console.WriteLine("3. Ferrari");

            string firstCarInput = Console.ReadLine();
            bool validFirstCarInput = int.TryParse(firstCarInput, out int firstCar);

            if (!validFirstCarInput)
            {
                Console.WriteLine("Wrong input. Insert 0-3 to select a car.");
            }

            Console.WriteLine("Insert order number of the first driver you want to drive the first car.");
            Console.WriteLine("0. Bob");
            Console.WriteLine("1. Greg");
            Console.WriteLine("2. Jill");
            Console.WriteLine("3. Anne");

            string firstDriverInput = Console.ReadLine();
            bool validFirstDriverInput = int.TryParse(firstDriverInput, out int firstDriver);

            if (!validFirstDriverInput)
            {
                Console.WriteLine("Wrong input. Insert 0-3 to select a driver.");
            }

            //-----------------------------------------------------------------------------------------------

            Console.WriteLine("Insert order number of the second car you want to select.");
            Console.WriteLine("0. Hyndai");
            Console.WriteLine("1. Mazda");
            Console.WriteLine("2. Porsche");
            Console.WriteLine("3. Ferrari");

            

            
            string secondCarInput = Console.ReadLine();
            while (secondCarInput == firstCarInput)
            {

                Console.WriteLine("You have selected the same car, select different car.");

                Console.WriteLine("0. Hyndai");
                Console.WriteLine("1. Mazda");
                Console.WriteLine("2. Porsche");
                Console.WriteLine("3. Ferrari");
                secondCarInput = Console.ReadLine();

            }

            bool validSecondCarInput = int.TryParse(secondCarInput, out int secondCar);

            if (!validSecondCarInput)
            {
                Console.WriteLine("Wrong input. Insert number 0-3.");

            }




            Console.WriteLine("Insert order number of the second driver you want to drive the second car.");
            Console.WriteLine("0. Bob");
            Console.WriteLine("1. Greg");
            Console.WriteLine("2. Jill");
            Console.WriteLine("3. Anne");

            string secondDriverInput = Console.ReadLine();
            bool validSecondDriverInput = int.TryParse(secondDriverInput, out int secondDriver);

            if (!validSecondDriverInput)
            {
                Console.WriteLine("Wrong input. Insert 0-3 to select a driver.");
            }

            string firstSettedDriver = drivers[firstDriver].Name;
            string secondSettedDriver = drivers[secondDriver].Name;




            if (cars[firstCar].CalculateSpeed(cars[firstCar].Speed, drivers[firstDriver].Skill) > cars[secondCar].CalculateSpeed(cars[secondCar].Speed, drivers[secondDriver].Skill))
            {
                Console.WriteLine($@" The car {cars[firstCar].Model} has won the race, driving with {cars[firstCar].Speed} km/h and was driven by the driver {firstSettedDriver}.");
            }
            else
            {
                Console.WriteLine($@"The car {cars[secondCar].Model} has won the race, driving with {cars[secondCar].Speed} km/h and was driven by the driver {secondSettedDriver}.");
               
            }

            Console.WriteLine("Do you want to race again?");
            RaceAgain();

            static void RaceAgain()
            {
                Console.WriteLine($@"Answer with ""yes"" or ""no"". ");
                string answer = Console.ReadLine();

                    if (answer == "yes")
                    {
                        Console.WriteLine("Let's start another race.");
                        Main();
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Thank you for your previous race.");
                    }
                    else
                    {
                        Console.WriteLine("You are tired, go home!");
                    }

                
                
            }

        }
        




    }
}