namespace SmartHouse.Models
{
     public abstract class Device
     {
          public string Name { get; set; }
          public string Location { get; set; }

          protected Device(string name, string location)
          {
               Name = name;
               Location = location;
          }

          public abstract void TurnOn();
          public abstract void TurnOff();
     }
}
