using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int wheels { get; set; }
        public bool HasWindows { get; set; }
        public bool HasBrakes { get; set; }
        public string SteeringWheel { get; set; }

    }
}
