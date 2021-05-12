using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using EPAM_TASK_ONE;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для OutputInfo.xaml
    /// </summary>
    public partial class OutputInfo : Window
    {
        private List<AutoFactory> vehicles = new List<AutoFactory>();
        public OutputInfo(List<AutoFactory> vehicles)
        {
            InitializeComponent();
            this.vehicles = vehicles;
            AutoCompletion();
        }

        private void AutoCompletion()
        {
            table.Items.Clear();
            for (var i = 0; i < vehicles.Count; i++)
            {
                table.Items.Add(vehicles[i]);

            }
        }
        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            table.Items.Clear();
            AutoCompletion();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        

        }
   }
