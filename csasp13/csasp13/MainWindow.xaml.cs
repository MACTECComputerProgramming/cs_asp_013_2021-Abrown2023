using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace csasp13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OrderHere_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void wheat_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (wheat.IsChecked == true);
        }

        private void Italian_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (Italian.IsChecked == true);
        }

        private void FlatBread_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (FlatBread.IsChecked == true);
        }

        private void Ham_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (Ham.IsChecked == true);
        }

        private void RoastedChicken_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (RoastedChicken.IsChecked == true);
        }

        private void MeatBalls_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (MeatBalls.IsChecked == true);
        }

        private void Steak_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (Steak.IsChecked == true);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (American.IsChecked == true);
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            label.Content = (swiss.IsChecked == true);
        }

        private void pepperjack_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (pepperjack.IsChecked == true);
        }

        private void cucumbers_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (cucumbers.IsChecked == true);
        }

        private void green_pepper_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (green_pepper.IsChecked == true);
        }

        private void lettuce_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (lettuce.IsChecked == true);
        }

        private void Redonion_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (Redonion.IsChecked == true);
        }

        private void AllVeggies_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = (AllVeggies.IsChecked == true);
        }
    }
}
