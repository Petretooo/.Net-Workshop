using System;
using System.Collections.Generic;
using System.Text;

namespace ModelThis2
{
    class Bus : MotorVehicle
    {
        public int Power { get; private set; }
        public int Passengers { get; private set; }
        public double CargoWeight { get; private set; }


        public Bus(int power, int passengers, double cargo) : base(power, passengers, cargo)
        {
            this.Power = power;
            this.Passengers = passengers;
            this.CargoWeight = cargo;
        }
        protected double maxCargoWeight()
        {
            return CargoWeight;
        }

        protected int maxPassenger()
        {
            return Passengers;
        }

        protected int power()
        {
            return Power;
        }
    }
}
