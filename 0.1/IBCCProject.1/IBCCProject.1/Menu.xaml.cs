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
using System.Timers;
using System.Windows.Threading;
using System.Threading;

namespace IBCCProject._1
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        
        public Menu()
        {
            InitializeComponent();  
        }

        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            Memory_Selection memoryMenuWindow = new Memory_Selection();
            memoryMenuWindow.Show();
            this.Close();
        }

        private void ContactButton_Click(object sender, RoutedEventArgs e)
        {
            Contact contactWindow = new Contact();
            contactWindow.Show();
            this.Close();
        }

        private void RecordButton_Click(object sender, RoutedEventArgs e)
        {
            Memory_Form memoryForm = new Memory_Form();
            memoryForm.Show();
            this.Close();
        }

        private void timelineButton_Click(object sender, RoutedEventArgs e)
        {
            Timeline2 timelineWindow = new Timeline2();
            timelineWindow.Show();
            this.Close();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            Help helpWindow = new Help();
            helpWindow.Show();
            this.Close();
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow screenSaver = new MainWindow();
            screenSaver.Show();
            this.Close();
        }

        private void feedbackButton_Click(object sender, RoutedEventArgs e)
        {
            Feedback_Screen feedback = new Feedback_Screen();
            feedback.Show();
            this.Close();
        }

        private void adminButton_Click(object sender, RoutedEventArgs e)
        {
            Admin_Login adminLogin = new Admin_Login();
            adminLogin.Show();
            this.Close();
        }

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            About aboutScreen = new About();
            aboutScreen.Show();
            this.Close();
        }

    }


} //end class

