using SmartHouse.Models;

namespace SmartHouse.Builders
{
     public class SmartRoomBuilder : IRoomBuilder
     {
          private Room _room;

          public void SetRoomName(string name)
          {
               _room = new Room(name);
          }

          public void AddLight()
          {
               _room.AddDevice(new Light("Ceiling Light", _room.Name));
          }

          public void AddThermostat()
          {
               _room.AddDevice(new Thermostat("Thermostat", _room.Name));
          }

          public void AddDoorLock()
          {
               _room.AddDevice(new DoorLock("Door Lock", _room.Name));
          }

          public Room GetRoom()
          {
               return _room;
          }
     }
}