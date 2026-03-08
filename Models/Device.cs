namespace SmartHouse.Models
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
