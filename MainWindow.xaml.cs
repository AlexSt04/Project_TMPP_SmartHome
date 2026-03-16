using SmartHouseApp.Factories;
using SmartHouseApp.Managers;
using SmartHouseApp.Factories;
using SmartHouseApp.Managers;
using SmartHouseApp.Models;
using System.Windows;
using SmartHouseApp.Views;

namespace SmartHouseApp
{


     public partial class MainWindow : Window
     {
          SmartHomeManager manager = SmartHomeManager.Instance;

          public MainWindow()
          {
               InitializeComponent();

               MainContent.Content = new RoomsView();

               RoomsBtn.Click += RoomsBtn_Click;
          }
          public MainWindow()
          {
               InitializeComponent();

               MainContent.Content = new DashboardView();
          }


          void UpdateStats()
          {
               RoomCount.Text = manager.Rooms.Count.ToString();

               int deviceCount = 0;

               foreach (var room in manager.Rooms)
                    deviceCount += room.Devices.Count;

               DeviceCount.Text = deviceCount.ToString();
          }

          void RoomsBtn_Click(object sender, RoutedEventArgs e)
          {
               MainContent.Content = new RoomsView();
          }


     }
}