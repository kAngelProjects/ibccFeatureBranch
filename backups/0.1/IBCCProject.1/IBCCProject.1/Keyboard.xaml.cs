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
    /// Interaction logic for Keyboard.xaml
    /// </summary>
    public partial class Keyboard : Window
    {
        public Keyboard()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            entryBox.Text += "1";
        }
    }
}
