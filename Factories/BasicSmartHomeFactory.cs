using SmartHouse.Models;

namespace SmartHouse.Factories
{
     public class BasicSmartHomeFactory : ISmartHomeFactory
     {
          public Device CreateLight(string location)
          {
               return new Light("Basic Light", location);
          }

          public Device CreateThermostat(string location)
          {
               return new Thermostat("Basic Thermostat", location);
          }
     }
}