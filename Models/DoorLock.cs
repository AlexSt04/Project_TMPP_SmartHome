using SmartHouseApp.Interfaces;

namespace SmartHouseApp.Models
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
