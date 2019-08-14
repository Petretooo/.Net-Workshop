using System;
using System.Collections.Generic;
using System.Text;

namespace ModelThis2
{
    class LogisticAutopark : Autopark
    {

        private MotorVehicle vehicle { get; set; }
        private double maxCargoWeight { get; set; }
        public LogisticAutopark() : base()
        {
            
        }
        public override void Add(MotorVehicle vehicle)
        {
            base.Add(vehicle);
            MAX(vehicle);
        }
        private void MAX(MotorVehicle vehicle)
        {
            this.maxCargoWeight += vehicle.maxCargoWeight;
        }

        public int COUNT()
        {
            int counter = 0;
            foreach (var v in base.vehicles)
            {
                    counter++;
            }
            return counter;
        }


        public override string ToString()
        {
            if (vehicles.Capacity == 0)
            {
                return $"The Logistic Autopark is empty!";
            }
            return $"The maximum cargo weight of the Logistic Autopark is: {maxCargoWeight} kg., and the number of vehicles in this autopark is: {COUNT()}";
        }
    }
}
