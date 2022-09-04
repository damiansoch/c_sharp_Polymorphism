using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //BMW "is a" Car
    internal class BMW:Car
    {

        private string brand = "BMW";

        public string Model { get; set; }
        public BMW(int hP, string color, string model) : base(hP, color)
        {
            this.Model = model;
        }

        //new is creating the new method and hiding the other method
        public new void ShowDetails()
        {
            Console.WriteLine($"Car: {brand}, Horse Power: {HP}, Color: {Color}");
        }

        // in the child class we can not overwrite this anymore, because is sealed
        //sealed can be used only on previously overwritten method
        public sealed override void Repair()
        {
            Console.WriteLine($"{brand} {Model} was repaired");
        }
    }
}
