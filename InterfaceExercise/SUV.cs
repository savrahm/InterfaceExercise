using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public SUV(int cargoSpace, bool fourWheelDrive, int wheelNum, bool hasSeatBelts, string make, int passengers, string logo, int employees)
        {
            CargoSpace = cargoSpace;
            FourWheelDrive = fourWheelDrive;
            WheelNum = wheelNum;
            HasSeatBelts = hasSeatBelts;
            Make = make;
            Passengers = passengers;
            Logo = logo;
            Employees = employees;
        }

        public bool FourWheelDrive { get; set; } = false;
        public int CargoSpace { get; set; }

        public int WheelNum { get; set; } = 4;
        public bool HasSeatBelts { get; set; } = true;
        public string Make { get; set; }
        public int Passengers { get; set; }

        public string Logo { get; set; }
        public int Employees { get; set; }
    }
}
