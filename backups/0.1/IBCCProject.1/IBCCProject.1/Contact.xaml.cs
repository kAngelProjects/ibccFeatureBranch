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
using System.Diagnostics;

namespace IBCCProject._1
{
    /// <summary>
    /// Interaction logic for Contact.xaml
    /// </summary>
            
    public partial class Contact : Window
    {
        //Process _touchKeyboardProcess = null;
        private TextBox _currentTextbox;

        public Contact()
        {
            InitializeComponent();
        }
        

        private void TextBoxLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            _currentTextbox = e.Source as TextBox;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            //var nameValue = nameTextBox.Text;
        }

        private void qButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsEnabled == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "Q";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "q";
            }
            
        }

        
    }

    
}
