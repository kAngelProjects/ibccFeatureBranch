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
            Contact contactWindow = new Contact();
            contactWindow.Show();
            this.Close();
        }

        private void ContactButton_Click(object sender, RoutedEventArgs e)
        {
            Contact contactWindow = new Contact();
            contactWindow.Show();
            this.Close();
        }
    }
}
