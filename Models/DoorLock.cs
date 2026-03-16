<<<<<<< HEAD
﻿using SmartHouseApp.Interfaces;

namespace SmartHouseApp.Models
=======
﻿using SmartHouse.Interfaces;

namespace SmartHouse.Models
>>>>>>> eb5379e596b9c64ce6ebd50b36e66626d494e15d
{
     public class DoorLock : Device, IDeviceControl
     {
          public DoorLock(string name, string location) : base(name, location) { }

          public override void TurnOn()
          {
               Console.WriteLine("Door locked");
          }

          public override void TurnOff()
          {
               Console.WriteLine("Door unlocked");
          }

          public override Device Clone()
          {
               return new DoorLock(this.Name, this.Location);
          }
     }
}
