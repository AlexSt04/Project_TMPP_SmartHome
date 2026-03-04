using System.Collections.Generic;

namespace SmartHouse.Models
{
     public class Room
     {
          public string Name { get; set; }
          private List<Device> devices = new List<Device>();

          public Room(string name)
          {
               Name = name;
          }

          public void AddDevice(Device device)
          {
               devices.Add(device);
          }

          public List<Device> GetDevices()
          {
               return devices;
          }
     }
}
