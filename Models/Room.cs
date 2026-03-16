using System.Collections.Generic;

<<<<<<< HEAD
namespace SmartHouseApp.Models
=======
namespace SmartHouse.Models
>>>>>>> eb5379e596b9c64ce6ebd50b36e66626d494e15d
{
     public class Room
     {
          public string Name { get; set; }
<<<<<<< HEAD

          public List<Device> Devices { get; set; } = new List<Device>();
=======
          private List<Device> devices = new List<Device>();
>>>>>>> eb5379e596b9c64ce6ebd50b36e66626d494e15d

          public Room(string name)
          {
               Name = name;
          }

          public void AddDevice(Device device)
          {
<<<<<<< HEAD
               Devices.Add(device);
          }
     }
}
=======
               devices.Add(device);
          }

          public List<Device> GetDevices()
          {
               return devices;
          }
     }
}
>>>>>>> eb5379e596b9c64ce6ebd50b36e66626d494e15d
