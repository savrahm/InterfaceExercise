using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int WheelNum { get; set; }
        public bool HasSeatBelts { get; set; }
        public string Make { get; set; }
        public int Passengers { get; set; }

        
    }
}
