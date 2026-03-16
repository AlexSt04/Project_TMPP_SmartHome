<<<<<<< HEAD
﻿using SmartHouseApp.Interfaces;

namespace SmartHouseApp.Models
=======
﻿using SmartHouse.Interfaces;

namespace SmartHouse.Models
>>>>>>> eb5379e596b9c64ce6ebd50b36e66626d494e15d
{
     public class Thermostat : Device, IDeviceControl, ISensor
     {
          private double temperature = 22.5;

          public Thermostat(string name, string location) : base(name, location) { }

          public override void TurnOn()
          {
               Console.WriteLine("Thermostat activated");
          }

          public override void TurnOff()
          {
               Console.WriteLine("Thermostat deactivated");
          }

          public double ReadValue()
          {
               return temperature;
          }

          public override Device Clone()
          {
               return new Thermostat(this.Name, this.Location);
          }
     }
}
