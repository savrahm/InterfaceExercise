using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public Car(bool hasTrunk, bool raceCar, int wheelNum, bool hasSeatBelts, string make, int passengers, string logo, int employees)
        {
            HasTrunk = hasTrunk;
            RaceCar = raceCar;
            WheelNum = wheelNum;
            HasSeatBelts = hasSeatBelts;
            Make = make;
            Passengers = passengers;
            Logo = logo;
            Employees = employees;
        }

        public bool HasTrunk { get; set; } = true;
        public bool RaceCar { get; set; } = false;


        public int WheelNum { get; set; } = 4;
        public bool HasSeatBelts { get; set; } = true;
        public string Make { get; set; }
        public int Passengers { get; set; }

        public string Logo { get; set; }
        public int Employees { get; set; }
    }
}
