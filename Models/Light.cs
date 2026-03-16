<<<<<<< HEAD
﻿using SmartHouseApp.Interfaces;

namespace SmartHouseApp.Models
=======
﻿using SmartHouse.Interfaces;

namespace SmartHouse.Models
>>>>>>> eb5379e596b9c64ce6ebd50b36e66626d494e15d
{
     public class Light : Device, IDeviceControl
     {
          public Light(string name, string location) : base(name, location) { }

          public override void TurnOn()
          {
               Console.WriteLine($"{Name} light turned ON");
          }

          public override void TurnOff()
          {
               Console.WriteLine($"{Name} light turned OFF");
          }

          public override Device Clone()
          {
               return new Light(this.Name, this.Location);
          }
     }
}
