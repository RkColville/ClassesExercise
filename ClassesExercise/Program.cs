using System;
using System.Collections.Generic;
namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "FJ";
            myCar.Year = 2014;

            var tesla = new Car()
            {
                Make = "Tesla",
                Model = "S",
                Year = 2021
            };

            var Lexus = new Car("Lexus", "GX", 2001);
            var carList = new List<Car>() { myCar, tesla, Lexus, };
            //Console.WriteLine(carList.Capacity);

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
            
            



        }
    }
}
