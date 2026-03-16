using SmartHouseApp.Interfaces;

namespace SmartHouseApp.Models
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
