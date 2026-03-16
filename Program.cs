using SmartHouse.Builders;
using SmartHouse.Core;
using SmartHouse.Factories;
using SmartHouse.Managers;
using SmartHouse.Models;

class Program
{
     static void Main(string[] args)
     {
          SmartHome home = new SmartHome();

          // Alegem tipul de fabrica (Basic sau Premium)
          ISmartHomeFactory factory = new PremiumSmartHomeFactory();

          // Cream camera
          Room livingRoom = new Room("Living Room");

          // Cream dispozitive prin Abstract Factory
          Device light = factory.CreateLight("Living Room");
          Device thermostat = factory.CreateThermostat("Living Room");

          livingRoom.AddDevice(light);
          livingRoom.AddDevice(thermostat);

          home.AddRoom(livingRoom);

          light.TurnOn();
          thermostat.TurnOn();

          if (thermostat is Thermostat t)
          {
               Console.WriteLine("Temperature: " + t.ReadValue());
          }

          // ---------------- BUILDER PATTERN ----------------

          RoomDirector director = new RoomDirector();
          SmartRoomBuilder builder = new SmartRoomBuilder();

          director.BuildLivingRoom(builder);

          Room builtRoom = builder.GetRoom();

          home.AddRoom(builtRoom);

          Console.WriteLine("Room created with Builder: " + builtRoom.Name);

          //---------------- PROTOTYPE PATTERN ----------------

          Device thermostat1 = new Thermostat("Thermostat", "Living Room");

          Device thermostat2 = thermostat1.Clone();

          //----------------- SINGLETON PATTERN ----------------
          
          var manager = SmartHomeManager.Instance;

          manager.AddRoom(livingRoom);
     }
}