using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        //------------------has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIdInfo(int idNum,string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
                
        }
        //-------------------------------------



        public Car(int hP, string color)
        {
            HP = hP;
            Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Horse Power: {HP}, Color: {Color}");
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
        //just displaying the IDinfo 
        public void GetCarIDInfo()
        {
            Console.WriteLine($"ID: {carIDInfo.IDNum}, owner: {carIDInfo.Owner}");
        }
    }
}
