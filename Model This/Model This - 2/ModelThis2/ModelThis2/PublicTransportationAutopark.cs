using System;
using System.Collections.Generic;
using System.Text;

namespace ModelThis2
{
    class PublicTransportationAutopark : Autopark
    {

        private MotorVehicle vehicle { get; set; }

        private int maxPassengers { get; set; }

        public PublicTransportationAutopark() : base()
        {
            
        }
        public override void Add(MotorVehicle vehicle)
        {
            base.Add(vehicle);
            MAX(vehicle);
        }
        private void MAX(MotorVehicle vehicle)
        {
            this.maxPassengers += vehicle.maxPassenger;
        }

        int COUNT()
        {
            int counter = 0;
            foreach(var v in base.vehicles){
                    counter++;
            }
            return counter;
        }


                public override string ToString()
        {
            if(vehicles.Capacity == 0)
            {
                return $"The Public Transportation Autopark is empty!";
            }
            return $"The maximum passengers in the Public Transportation Autopark is: {maxPassengers}, and the number of vehicles in this autopark is: {COUNT()}";
        }

    }
}
