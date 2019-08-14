using System;
using System.Collections.Generic;
using System.Text;

namespace Model_This
{
    abstract class Autopark
    {
        /*
        protected List<MotorVehicle> vehicles = new List<MotorVehicle>();
        public Autopark(List<MotorVehicle> vehicles)
        {
            this.vehicles = vehicles;
        }
        */
        protected MotorVehicle vehicle { get; set; }
        public Autopark(MotorVehicle vehicle)
        {
            this.vehicle = vehicle;
        }




        public abstract double MAX();


        public abstract override string ToString();



    }
}
