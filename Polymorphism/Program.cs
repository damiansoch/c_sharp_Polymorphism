using System;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car(1100, "Black"),
                new BMW(1200, "Blue", "M5"),
                new Audi(1300, "Red", "R8")
            };

            foreach (Car car in cars)
            {
                car.ShowDetails();
                car.Repair();
                Console.WriteLine("\n");
            }

            Car bmwCar = new BMW(800, "Green", "m4");
            bmwCar.ShowDetails();
            //because it's created as a Car, ShowDetails method comes from Car class
            BMW bmwCar2 = (BMW)bmwCar;
            bmwCar2.ShowDetails();
            //We can cast the car to a derived class and than the method will be taken from the class

            

            M3 m3 = new(500, "Orange", "M3-turbo");
            m3.Repair();
            //setting the CatIdInfo for above
            m3.SetCarIdInfo(1234, "Damian Socha");
            m3.GetCarIDInfo();
        }
    }
}
