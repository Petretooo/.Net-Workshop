using System;
using System.Collections.Generic;
using System.Text;

namespace ModelThis2
{
    abstract class Autopark
    {
        
        protected List<MotorVehicle> vehicles { get; set; }
        public Autopark()
        {
            this.vehicles = new List<MotorVehicle>();
        }

        public virtual void Add(MotorVehicle vehicle)
        {
            this.vehicles.Add(vehicle);
        }

        public abstract override string ToString();
    }
}
