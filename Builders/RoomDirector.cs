namespace SmartHouse.Builders
{
     public class RoomDirector
     {
          public void BuildLivingRoom(IRoomBuilder builder)
          {
               builder.SetRoomName("Living Room");
               builder.AddLight();
               builder.AddThermostat();
          }

          public void BuildBedroom(IRoomBuilder builder)
          {
               builder.SetRoomName("Bedroom");
               builder.AddLight();
          }
     }
}