using System;
using System.Collections.Generic;
using System.Windows;
using EPAM_TASK_ONE;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<AutoFactory> vehicles = new List<AutoFactory>();
        public MainWindow()
        {
            InitializeComponent();
            InfoCompletion();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OutputInfo outputInfo = new OutputInfo(vehicles);
            outputInfo.ShowDialog();
        }

        private void InfoCompletion()
        {
            vehicles.Add(new TruckFactory("Red","V8",49,"Automat",50,"Truck"));
            vehicles.Add(new TruckFactory("Green", "V10", 59, "Robot", 20, "Truck"));
            vehicles.Add(new PassengerFactory("Grey", "M10", 30, "Mechanik", 5, "Passenger"));
            vehicles.Add(new PassengerFactory("Black", "M20", 20, "Automat", 4, "Passenger"));
            vehicles.Add(new BusFactory("Yellow", "G20", 40, "Robot", 4, "Bus"));
        }
    }
}
