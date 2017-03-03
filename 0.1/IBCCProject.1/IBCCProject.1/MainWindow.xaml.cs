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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace IBCCProject._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            BackgroundVideo.Position = TimeSpan.FromSeconds(0);
            BackgroundVideo.Play();

            channel1.Position = TimeSpan.FromSeconds(0);
            channel1.Play();

            secondChannel.Position = TimeSpan.FromSeconds(0);
            secondChannel.Play();

            thirdChannel.Position = TimeSpan.FromSeconds(0);
            thirdChannel.Play();
        }

        private void openMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Warning: This application may contain upsetting content or images. User discretion is advised.");
            Menu menuWindow = new Menu();
            menuWindow.Show();
            this.Close();
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            BackgroundVideo.Position = TimeSpan.FromSeconds(0);
            BackgroundVideo.Play();
        }

        private void channel1_MediaEnded(object sender, RoutedEventArgs e)
        {
            channel1.Position = TimeSpan.FromSeconds(0);
            channel1.Play();
        }

        private void secondChannel_MediaEnded(object sender, RoutedEventArgs e)
        {
            secondChannel.Position = TimeSpan.FromSeconds(0);
            secondChannel.Play();
        }

        private void thirdChannel_MediaEnded(object sender, RoutedEventArgs e)
        {
            thirdChannel.Position = TimeSpan.FromSeconds(0);
            thirdChannel.Play();
        }

        
    }

    
}
