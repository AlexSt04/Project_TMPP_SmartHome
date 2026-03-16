using SmartHouseApp.Managers;
using SmartHouseApp.Models;
using System.Windows;
using System.Windows.Controls;

namespace SmartHouseApp.Views
{
     public partial class RoomsView : UserControl
     {
          SmartHomeManager manager = SmartHomeManager.Instance;

          public RoomsView()
          {
               InitializeComponent();

               AddRoomBtn.Click += AddRoomBtn_Click;
               DeleteRoomBtn.Click += DeleteRoomBtn_Click;

               RefreshRooms();
          }

          void RefreshRooms()
          {
               RoomsList.Items.Clear();

               foreach (var room in manager.Rooms)
                    RoomsList.Items.Add(room.Name);
          }

          private void AddRoomBtn_Click(object sender, RoutedEventArgs e)
          {
               Room room = new Room("Room " + (manager.Rooms.Count + 1));

               manager.AddRoom(room);

               RefreshRooms();
          }

          private void DeleteRoomBtn_Click(object sender, RoutedEventArgs e)
          {
               if (RoomsList.SelectedIndex < 0)
                    return;

               manager.Rooms.RemoveAt(RoomsList.SelectedIndex);

               RefreshRooms();
          }
     }
}