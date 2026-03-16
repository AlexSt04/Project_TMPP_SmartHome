using SmartHouse.Models;

namespace SmartHouse.Factories
{
     public abstract class DeviceFactory
     {
          public abstract Device CreateDevice(string name, string location);
     }
}