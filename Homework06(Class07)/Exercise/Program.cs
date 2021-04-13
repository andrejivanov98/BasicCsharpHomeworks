using System;
using Models;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ///---Task 01---
            
            Employee employee = new Employee("Bob", "Bobsky", Role.Other, 600);
            SalesPerson salesPerson = new SalesPerson("Bill", "Billsky", 1500);
            Manager manager = new Manager("Elon", "Musk", 5000);
            Contractor contractor1 = new Contractor("Jeff", "Besos", 170, 11, manager);
            Contractor contractor2 = new Contractor("Mark", "Raffalo", 155, 9, manager);



            
            

            salesPerson.ExtendSuccessRevenue(2000);
            manager.AddBonus(4000);
            salesPerson.ExtendSuccessRevenue(3000);

            Console.WriteLine(employee.GetInfo());
            Console.WriteLine(salesPerson.GetInfo());
            Console.WriteLine(manager.GetInfo());

           
         
            Console.WriteLine($"{ contractor1.FirstName} - { contractor1.CurrentPosition("marketing")}");
            Console.WriteLine($"{ contractor2.FirstName} - { contractor2.CurrentPosition("IT")}");


            Console.WriteLine($"Employee salary: {employee.GetSalary()}");
            Console.WriteLine($"SalesPerson salary: {salesPerson.GetSalary()}");
            Console.WriteLine($"Manager salary: {manager.GetSalary()}");
            Console.WriteLine($"First Constructor is {contractor1.FirstName} and his/her salary is: {contractor1.GetSalary()}");
            Console.WriteLine($"Second Constructor is {contractor2.FirstName} and his/her salary is: {contractor2.GetSalary()}");

            ///--Task 02---

            
            

            Ceo ceo = new Ceo("Steve", "Jobs", 70, 340);

            Console.WriteLine($"{ceo.GetInfo()}");
            Console.Write($"The ceo has salary of: {ceo.GetSalary()} dolars.");
            
        }
    }
}
