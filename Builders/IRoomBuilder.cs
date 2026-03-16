using SmartHouse.Models;

namespace SmartHouse.Builders
{
     public interface IRoomBuilder
     {
          void SetRoomName(string name);
          void AddLight();
          void AddThermostat();
          void AddDoorLock();
          Room GetRoom();
     }
}