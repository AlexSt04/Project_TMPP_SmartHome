using SmartHouse.Core;
using SmartHouse.Factories;
using SmartHouse.Models;

class Program
{
     static void Main(string[] args)
     {
          SmartHome home = new SmartHome();

          Room livingRoom = new Room("Living Room");

          // Alegem tipul de fabrica (Basic sau Premium)
          ISmartHomeFactory factory = new PremiumSmartHomeFactory();

          // Cream dispozitivele prin Abstract Factory
          Device light = factory.CreateLight("Living Room");
          Device thermostat = factory.CreateThermostat("Living Room");

          livingRoom.AddDevice(light);
          livingRoom.AddDevice(thermostat);

          home.AddRoom(livingRoom);

          light.TurnOn();
          thermostat.TurnOn();

          // Cast pentru a accesa metoda ReadValue()
          if (thermostat is Thermostat t)
          {
               Console.WriteLine("Temperature: " + t.ReadValue());
          }
     }
}