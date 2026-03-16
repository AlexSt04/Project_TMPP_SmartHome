using SmartHouseApp.Models;

namespace SmartHouseApp.Factories
{
     public class ThermostatFactory : DeviceFactory
     {
          public override Device CreateDevice(string name, string location)
          {
               return new Thermostat(name, location);
          }
     }
}