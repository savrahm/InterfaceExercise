using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompany, IVehicle
    {
        public Truck(int bedSize, int towingAmt, int wheelNum, bool hasSeatBelts, string make, int passengers, string logo, int employees)
        {
            BedSize = bedSize;
            TowingAmt = towingAmt;
            WheelNum = wheelNum;
            HasSeatBelts = hasSeatBelts;
            Make = make;
            Passengers = passengers;
            Logo = logo;
            Employees = employees;
        }
        public int BedSize { get; set; }
        public int TowingAmt { get; set; }

        public int WheelNum { get; set; } = 4;
        public bool HasSeatBelts { get; set; } = true;
        public string Make { get; set; }
        public int Passengers { get; set; }

        public string Logo { get; set; }
        public int Employees { get; set; }
    }
}
