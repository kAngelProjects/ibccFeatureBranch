using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IBCCProject._1
{
    /// <summary>
    /// Interaction logic for Timeline2.xaml
    /// </summary>
    public partial class Timeline2 : Window
    {
        public Timeline2()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            menuWindow.Show();
            this.Close();
        }

        private void westGermanyButton_Click(object sender, RoutedEventArgs e)
        {
            string countryValue = "West Germany";
            Timeline newTimeline = new Timeline(countryValue);
            newTimeline.Show();
            this.Close();
        }

        private void aerialButton_Click(object sender, RoutedEventArgs e)
        {
            string countryValue = "Aerial";
            Timeline newTimeline = new Timeline(countryValue);
            newTimeline.Show();
            this.Close();
        }

        private void ukButton_Click(object sender, RoutedEventArgs e)
        {
            string countryValue = "UK";
            Timeline newTimeline = new Timeline(countryValue);
            newTimeline.Show();
            this.Close();
        }

        private void eastGermanyButton_Click(object sender, RoutedEventArgs e)
        {
            string countryValue = "East Germany";
            Timeline newTimeline = new Timeline(countryValue);
            newTimeline.Show();
            this.Close();
        }

        private void chinaButton_Click(object sender, RoutedEventArgs e)
        {
            string countryValue = "China";
            Timeline newTimeline = new Timeline(countryValue);
            newTimeline.Show();
            this.Close();
        }

        private void franceButton_Click(object sender, RoutedEventArgs e)
        {
            string countryValue = "France";
            Timeline newTimeline = new Timeline(countryValue);
            newTimeline.Show();
            this.Close();
        }

        private void japanButton_Click(object sender, RoutedEventArgs e)
        {
            string countryValue = "Japan";
            Timeline newTimeline = new Timeline(countryValue);
            newTimeline.Show();
            this.Close();
        }

        private void russiaButton_Click(object sender, RoutedEventArgs e)
        {
            string countryValue = "Russia";
            Timeline newTimeline = new Timeline(countryValue);
            newTimeline.Show();
            this.Close();
        }

        private void usaButton_Click(object sender, RoutedEventArgs e)
        {
            string countryValue = "USA";
            Timeline newTimeline = new Timeline(countryValue);
            newTimeline.Show();
            this.Close();
        }

    }
}
