using SmartHouse.Models;

namespace SmartHouse.Factories
{
     public class PremiumSmartHomeFactory : ISmartHomeFactory
     {
          public Device CreateLight(string location)
          {
               return new Light("Premium LED Light", location);
          }

          public Device CreateThermostat(string location)
          {
               return new Thermostat("AI Thermostat", location);
          }
     }
}