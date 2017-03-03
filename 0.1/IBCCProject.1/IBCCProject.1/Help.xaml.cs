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
    /// Interaction logic for Help.xaml
    /// </summary>
    public partial class Help : Window
    {

        public Help()
        {
            InitializeComponent();

            summaryBox.Text = "On this screen you can read through the memories provided by veterans and their families. Use the navigation buttons to see all available entries, and use the Read button to see the full account.";
            //placeholder image until more entries are added to the memory menu and a screenshot can be taken
            screenshotImage.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/memorySelectionScreen.PNG", UriKind.RelativeOrAbsolute));
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            menuWindow.Show();
            this.Close();
        }

        private void memoryHelp_Click(object sender, RoutedEventArgs e)
        {
            summaryBox.Text = "On this screen you can read through the memories provided by veterans and their families. Use the navigation buttons to see all available entries, and use the Read button to see the full account.";
            //placeholder image until more entries are added to the memory menu and a screenshot can be taken
            screenshotImage.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/memorySelectionScreen.PNG", UriKind.RelativeOrAbsolute));
        }

        private void contactHelp_Click(object sender, RoutedEventArgs e)
        {
            summaryBox.Text = "If you have historical documents or other memorabilia you would like to submit to the IBCC's Digital Archive, you can fill out a form to submit your contact details on this screen. Either a phone number or email address can be submitted (or both).";
            screenshotImage.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/contactScreen.PNG", UriKind.RelativeOrAbsolute));
        }

        private void recordHelp_Click(object sender, RoutedEventArgs e)
        {
            summaryBox.Text = "If you have a story of the war you would like to provide (it could be something you have heard from a relative), please do so on this screen. If you would like to contribute a longer account, please give your contact details on the Contact screen instead.";
            screenshotImage.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/memoryScreen.PNG", UriKind.RelativeOrAbsolute));
        }

        private void timelineHelp_Click(object sender, RoutedEventArgs e)
        {
            summaryBox.Text = "On this screen you can select a country and read about important events post 1945 in ten year intervals.";
            screenshotImage.Source = new BitmapImage(new Uri(@"/IBCCProject.1;component/Images/timelineScreen1.PNG", UriKind.RelativeOrAbsolute));
        }
    }
}
