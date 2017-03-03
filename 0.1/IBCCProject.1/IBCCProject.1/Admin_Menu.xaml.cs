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
    /// Interaction logic for Admin_Menu.xaml
    /// </summary>
    public partial class Admin_Menu : Window
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu newMenu = new Menu();
            newMenu.Show();
            this.Close();
        }

        private void contactButton_Click(object sender, RoutedEventArgs e)
        {
            Admin_Selection adminSelection = new Admin_Selection();
            adminSelection.Show();
            this.Close();
        }

        private void feedbackButton_Click(object sender, RoutedEventArgs e)
        {
            Admin_Feedback feedbackPage = new Admin_Feedback();
            feedbackPage.Show();
            this.Close();
        }
    }
}
