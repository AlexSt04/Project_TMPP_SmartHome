using SmartHouseApp.Models;
using System.Collections.Generic;

namespace SmartHouseApp.Managers
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