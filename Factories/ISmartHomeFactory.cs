using SmartHouse.Models;

namespace SmartHouse.Factories
{
     public interface ISmartHomeFactory
     {
          Device CreateLight(string location);
          Device CreateThermostat(string location);
     }
}