using System.Collections.Generic;

namespace SmartHouseApp.Models
{
     public class Room
     {
          public string Name { get; set; }

          public List<Device> Devices { get; set; } = new List<Device>();

          public Room(string name)
          {
               Name = name;
          }

          public void AddDevice(Device device)
          {
               Devices.Add(device);
          }
     }
}