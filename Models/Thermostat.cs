using SmartHouse.Interfaces;

namespace SmartHouse.Models
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
     }
}
