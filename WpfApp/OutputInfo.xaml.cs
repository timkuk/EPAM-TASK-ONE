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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //    if (Validation() && Convert.ToInt32(tb1.Text) > 0 && Convert.ToInt32(tb1.Text) <= vehicles.Count)
            //    {
            //        if (tb7.Text.ToLower() == "individual")
            //        {
            //            int[] dateOne = { dp1.SelectedDate.Value.Year, dp1.SelectedDate.Value.Month, dp1.SelectedDate.Value.Day };
            //            int[] dateTwo = { dp2.SelectedDate.Value.Year, dp2.SelectedDate.Value.Month, dp2.SelectedDate.Value.Day };
            //            vehicles[Convert.ToInt32(tb1.Text) - 1] = new IndividualsVehicles(dateOne, Convert.ToDouble(tb4.Text), tb2.Text, tb5.Text, tb7.Text, dateTwo, Convert.ToInt32(tb1.Text));
            //        }
            //        else
            //        {
            //            int[] dateOne = { dp1.SelectedDate.Value.Year, dp1.SelectedDate.Value.Month, dp1.SelectedDate.Value.Day };
            //            int[] dateTwo = { dp2.SelectedDate.Value.Year, dp2.SelectedDate.Value.Month, dp2.SelectedDate.Value.Day };
            //            vehicles[Convert.ToInt32(tb1.Text) - 1] = new LegalEntitiesVehicles(dateOne, Convert.ToDouble(tb4.Text), tb2.Text, tb5.Text, tb7.Text, dateTwo, Convert.ToInt32(tb1.Text));
            //        }
            //        table.Items.Clear();
            //        AutoCompletion();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Wrong data");
            //    }
        }

    //private bool Validation()
    //    {
    //        //    bool flag = false;
    //        //    if (tb2.Text != "" && tb5.Text != "")
    //        //    {
    //        //        if (dp1.SelectedDate.Value <= dp2.SelectedDate.Value)
    //        //        {
    //        //            if (tb7.Text.ToLower() == "individual" || tb7.Text.ToLower() == "legal")
    //        //            {
    //        //                if (double.TryParse(tb4.Text, out double tmp))
    //        //                {
    //        //                    flag = true;
    //        //                }
    //        //            }
    //        //        }
    //        //    }
    //           return flag;
    //    }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //    if (Validation())
            //    {
            //        if (tb7.Text.ToLower() == "individual")
            //        {
            //            int[] dateOne = { dp1.SelectedDate.Value.Year, dp1.SelectedDate.Value.Month, dp1.SelectedDate.Value.Day };
            //            int[] dateTwo = { dp2.SelectedDate.Value.Year, dp2.SelectedDate.Value.Month, dp2.SelectedDate.Value.Day };
            //            vehicles.Add(new IndividualsVehicles(dateOne, Convert.ToDouble(tb4.Text), tb2.Text, tb5.Text, tb7.Text, dateTwo, vehicles.Count + 1));
            //        }
            //        else
            //        {
            //            int[] dateOne = { dp1.SelectedDate.Value.Year, dp1.SelectedDate.Value.Month, dp1.SelectedDate.Value.Day };
            //            int[] dateTwo = { dp2.SelectedDate.Value.Year, dp2.SelectedDate.Value.Month, dp2.SelectedDate.Value.Day };
            //            vehicles.Add(new LegalEntitiesVehicles(dateOne, Convert.ToDouble(tb4.Text), tb2.Text, tb5.Text, tb7.Text, dateTwo, vehicles.Count + 1));
            //        }
            //        table.Items.Clear();
            //        AutoCompletion();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Wrong data");
            //    }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //    var delete = 0;
            //    if (int.TryParse(tb0.Text, out delete))
            //    {
            //        if (delete > 0 && delete <= vehicles.Count)
            //        {
            //            vehicles.RemoveAt(delete - 1);
            //            for (var i = 0; i < vehicles.Count; i++)
            //                vehicles[i].Number = i + 1;
            //            table.Items.Clear();
            //            AutoCompletion();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Wrong number");
            //        }
            //    }
            //    else
            //        MessageBox.Show("Wrong number");

        }
    }
}