using System.Collections.Generic;

namespace SmartHouseApp.Models
{
     public class SmartHome
     {
          public List<Room> Rooms { get; set; } = new List<Room>();

          public void AddRoom(Room room)
          {
               Rooms.Add(room);
          }

          public void ShowRooms()
          {
               foreach (var room in Rooms)
               {
                    System.Console.WriteLine("Room: " + room.Name);
               }
          }
     }
}