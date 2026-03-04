using SmartHouse.Models;

namespace SmartHouse.Factories
{
     public class LightFactory : DeviceFactory
     {
          public override Device CreateDevice(string name, string location)
          {
               return new Light(name, location);
          }
     }
}