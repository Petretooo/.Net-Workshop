using System;
using System.Collections.Generic;
using System.Text;

namespace Model_This
{
    class LogisticAutopark : Autopark
    {

        private List<MotorVehicle> vehicles = new List<MotorVehicle>();

        public MotorVehicle vehicle { get; private set; }
        public double MaxCargoWeight { get; private set; }
        public LogisticAutopark(MotorVehicle vehicle, int MaxCargoWeight):base(vehicle)
        {
            this.vehicle = vehicle;
            this.MaxCargoWeight = MaxCargoWeight;
        }
        public LogisticAutopark(MotorVehicle vehicle) : base(vehicle)
        {
            this.vehicle = vehicle;
        }

        public double maxCargoWeight()
        {
            return MaxCargoWeight;
        }

        public double CargoCalc(List<MotorVehicle> vehicle)
        {
            double sum = 0.0;
            foreach(var v in vehicle)
            {
                sum += v.maxCargoWeight;
            }
            return sum;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override double MAX()
        {
            return MaxCargoWeight;
        }






        //Let check if the park if full or not
        // TO DO...

    }
}
