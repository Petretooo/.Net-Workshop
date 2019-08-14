using System;
using System.Collections.Generic;
using System.Text;

namespace Model_This
{
    class PublicTransportationAutopark : Autopark
    {

        private List<MotorVehicle> vehicles = new List<MotorVehicle>();

        public MotorVehicle vehicle { get; private set; }

        public int maxPassengers { get; private set; }
        public PublicTransportationAutopark(MotorVehicle vehicle, int maxPassengers):base(vehicle)
        {
            this.vehicle = vehicle;
            this.maxPassengers = maxPassengers;
        }

        public PublicTransportationAutopark(MotorVehicle vehicle) : base(vehicle)
        {
            this.vehicle = vehicle;
        }

        public int passengersCalc(List<MotorVehicle> vehicles)
        {
            int sum = 0;
            foreach(var vehicle in vehicles)
            {
                sum += vehicle.maxPassenger;
            }
            return sum;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override double MAX()
        {
            return maxPassengers;
        }








        //Let check if the park if full or not
        // TO DO...

    }
}
