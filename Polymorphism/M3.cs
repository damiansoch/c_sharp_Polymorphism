using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class M3:BMW
    {
        public M3(int hP,string color,string model) : base(hP, color, model)
        {

        }
        ////Cant overwrite because is sealed in the BMW class
        //public override void Repair()
        //{
        //    base.Repair();
        //}
    }
}
