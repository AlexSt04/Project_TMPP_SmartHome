<<<<<<< HEAD
﻿namespace SmartHouseApp.Models
=======
﻿namespace SmartHouse.Models
>>>>>>> eb5379e596b9c64ce6ebd50b36e66626d494e15d
{
     public abstract class Device : IPrototype
     {
          public string Name { get; set; }
          public string Location { get; set; }

          protected Device(string name, string location)
          {
               Name = name;
               Location = location;
          }

          public abstract Device Clone();
          public abstract void TurnOn();
          public abstract void TurnOff();



     }


}
<<<<<<< HEAD
     
=======
>>>>>>> eb5379e596b9c64ce6ebd50b36e66626d494e15d
