using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string logo { get; set; }
        public string name { get; set; }  
        public int wheels { get; set; }
        public bool HasWindows { get; set; }
        public bool HasBrakes { get; set; }
        public string SteeringWheel { get; set; }
        public bool GoodEconomy { get; set; }
        public string speed { get; set; }
    }
}
