<<<<<<< HEAD
﻿using SmartHouseApp.Models;
using System.Collections.Generic;

namespace SmartHouseApp.Managers
=======
﻿using SmartHouse.Models;
using System.Collections.Generic;

namespace SmartHouse.Managers
>>>>>>> eb5379e596b9c64ce6ebd50b36e66626d494e15d
{
     public class SmartHomeManager
     {
          private static SmartHomeManager _instance;

          public static SmartHomeManager Instance
          {
               get
               {
                    if (_instance == null)
                    {
                         _instance = new SmartHomeManager();
                    }
                    return _instance;
               }
          }

          public List<Room> Rooms { get; } = new List<Room>();

          private SmartHomeManager()
          {
          }

          public void AddRoom(Room room)
          {
               Rooms.Add(room);
          }
     }
}