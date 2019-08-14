using System;
using System.Collections.Generic;
using System.Text;

namespace ModelThis2
{
    abstract class MotorVehicle
    {

        public int power { get; private set; }
        public int maxPassenger { get; private set; }
        public double maxCargoWeight { get; private set; }

        public MotorVehicle(int power, int maxPassenger, double maxCargoWeight)
        {
            this.power = power;
            this.maxPassenger = maxPassenger;
            this.maxCargoWeight = maxCargoWeight;

        }
    }
}
