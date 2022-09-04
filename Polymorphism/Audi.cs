using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Audi : Car
    {
        private string brand = "Audi";

        public string Model { get; set; }
        public Audi(int hP, string color, string model) : base(hP, color)
        {
            this.Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Car: {brand}, Horse Power: {HP}, Color: {Color}");
        }
        public override void Repair()
        {
            Console.WriteLine($"{brand} was repaired");
        }
    }
}
