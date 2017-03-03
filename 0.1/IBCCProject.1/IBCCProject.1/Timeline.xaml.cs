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
    /// Interaction logic for Timeline.xaml
    /// </summary>
    public partial class Timeline : Window
    {
        string currentCountryValue = "China"; //default initial value
        string yearValue = "forties"; 

        public Timeline(string countryValue)
        {
            InitializeComponent();
            currentCountryValue = countryValue;
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            menuWindow.Show();
            this.Close();
        }

        //private void categoryBox_Loaded(object sender, RoutedEventArgs e)
        //{
        //    // ... A List.
        //    List<string> dropDownData = new List<string>();
        //    dropDownData.Add("Aerial Warfare");
        //    dropDownData.Add("China");
        //    dropDownData.Add("Japan");
        //    dropDownData.Add("East Germany");
        //    dropDownData.Add("West Germany");
        //    //dropDownData.Add("Czechslovakia");
        //    //dropDownData.Add("Austria");
        //    //dropDownData.Add("Poland");
        //    dropDownData.Add("UK");
        //    dropDownData.Add("France");
        //    //dropDownData.Add("North Africa");
        //    //dropDownData.Add("South Africa");
        //    //dropDownData.Add("New Zealand");
        //    //dropDownData.Add("Australia");
        //    //dropDownData.Add("Italy");
        //    dropDownData.Add("Russia");
        //    //dropDownData.Add("Canada");
        //    dropDownData.Add("USA");
        //    //dropDownData.Add("Vietnam");
        //    //dropDownData.Add("India");

        //    // ... Get the ComboBox reference.
        //    var comboBox = sender as ComboBox;

        //    // ... Assign the ItemsSource to the List.
        //    comboBox.ItemsSource = dropDownData;

        //    // ... Make the first item selected.
        //    comboBox.SelectedIndex = 0;
        //}

        //private void categoryBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{   
        //    string selectedCountry = categoryBox.SelectedItem.ToString();

        //    switch (selectedCountry)
        //    {
        //        case "Aerial Warfare":
        //            currentCountryValue = "Aerial";
        //            break;
        //        case "China":
        //            currentCountryValue = "China";
        //            break;
        //        case "Japan":
        //            currentCountryValue = "Japan";
        //            break;
        //        case "West Germany":
        //            currentCountryValue = "West Germany";
        //            break;
        //        case "East Germany":
        //            currentCountryValue = "East Germany";
        //            break;
        //        case "Czechslovakia":
        //            currentCountryValue = "Czechslovakia";
        //            break;
        //        case "Austria":
        //            currentCountryValue = "Austria";
        //            break;
        //        case "Poland":
        //            currentCountryValue = "Poland";
        //            break;
        //        case "UK":
        //            currentCountryValue = "UK";
        //            break;
        //        case "France":
        //            currentCountryValue = "France";
        //            break;
        //        case "Norway":
        //            currentCountryValue = "Norway";
        //            break;
        //        case "Denmark":
        //            currentCountryValue = "Denmark";
        //            break;
        //        case "North Africa":
        //            currentCountryValue = "North Africa";
        //            break;
        //        case "South Africa":
        //            currentCountryValue = "South Africa";
        //            break;
        //        case "New Zealand":
        //            currentCountryValue = "New Zealand";
        //            break;
        //        case "Australia":
        //            currentCountryValue = "Australia";
        //            break;
        //        case "Italy":
        //            currentCountryValue = "Italy";
        //            break;
        //        case "Russia":
        //            currentCountryValue = "Russia";
        //            break;
        //        case "Canada":
        //            currentCountryValue = "Canada";
        //            break;
        //        case "USA":
        //            currentCountryValue = "USA";
        //            break;
        //        case "Vietnam":
        //            currentCountryValue = "Vietnam";
        //            break;
        //        case "India":
        //            currentCountryValue = "India";
        //            break;
        //        default:
        //            currentCountryValue = "Error";
        //            break;
        //    }

        //    //MessageBox.Show(currentCountryValue);

        //}

        private void fortiesButton_Click(object sender, RoutedEventArgs e)
        {
            yearValue = "forties";
            Timeline_Details detailsWindow = new Timeline_Details(currentCountryValue, yearValue);
            detailsWindow.Show();
            this.Close();
        }

        private void fiftiesButton_Click(object sender, RoutedEventArgs e)
        {
            yearValue = "fifties";
            Timeline_Details detailsWindow = new Timeline_Details(currentCountryValue, yearValue);
            detailsWindow.Show();
            this.Close(); 
        }

        private void sixtiesButton_Click(object sender, RoutedEventArgs e)
        {
            yearValue = "sixties";
            Timeline_Details detailsWindow = new Timeline_Details(currentCountryValue, yearValue);
            detailsWindow.Show();
            this.Close(); 
        }

        private void seventiesButton_Click(object sender, RoutedEventArgs e)
        {
            yearValue = "seventies";
            Timeline_Details detailsWindow = new Timeline_Details(currentCountryValue, yearValue);
            detailsWindow.Show();
            this.Close();
        }

        private void eighties_Click(object sender, RoutedEventArgs e)
        {
            yearValue = "eighties";
            Timeline_Details detailsWindow = new Timeline_Details(currentCountryValue, yearValue);
            detailsWindow.Show();
            this.Close();
        }

        private void countrySelection_Click(object sender, RoutedEventArgs e)
        {
            Timeline2 returnTimeline = new Timeline2();
            returnTimeline.Show();
            this.Close();
        }
    }
}
