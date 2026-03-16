using System.Collections.Generic;
using SmartHouse.Models;

namespace SmartHouse.Core
{
     public class SmartHome
     {
          private List<Room> rooms = new List<Room>();

          public void AddRoom(Room room)
          {
               rooms.Add(room);
          }

          public List<Room> GetRooms()
          {
               return rooms;
          }
     }
}
