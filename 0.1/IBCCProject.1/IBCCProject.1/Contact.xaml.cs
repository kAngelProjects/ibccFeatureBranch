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
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

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
            //save last textbox to have focus
            _currentTextbox = e.Source as TextBox;
        }

        private void qButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true) {
                _currentTextbox.Text = _currentTextbox.Text + "Q";
            }
            else {
                _currentTextbox.Text = _currentTextbox.Text + "q";
            }
            
        }

        private void wButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true) {
                _currentTextbox.Text = _currentTextbox.Text + "W";
            }
            else {
                _currentTextbox.Text = _currentTextbox.Text + "w";
            }

        }

        private void eButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "E";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "e";
            }

        }

        private void rButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "R";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "r";
            }
        }

        private void tButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "T";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "t";
            }
        }

        private void yButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "Y";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "y";
            }
        }

        private void uButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "U";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "u";
            }
        }

        private void iButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "I";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "i";
            }
        }

        private void oButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "O";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "o";
            }
        }

        private void pButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "P";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "p";
            }
        }

        private void aButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "A";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "a";
            }
        }

        private void sButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "S";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "s";
            }
        }

        private void dButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "D";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "d";
            }
        }

        private void fButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "F";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "f";
            }
        }

        private void gButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "G";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "g";
            }
        }

        private void hButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "H";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "h";
            }
        }

        private void jButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "J";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "j";
            }
        }

        private void kButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "K";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "k";
            }
        }

        private void lButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "L";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "l";
            }
        }

        private void zButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "Z";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "z";
            }
        }

        private void xButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "X";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "x";
            }
        }

        private void cButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "C";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "c";
            }
        }

        private void VButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "V";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "v";
            }
        }

        private void bButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "B";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "b";
            }
        }

        private void nButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "N";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "n";
            }
        }

        private void mButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "M";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "m";
            }
        }

        private void backspaceButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_currentTextbox.Text))
            {
                _currentTextbox.Text = _currentTextbox.Text.Remove(_currentTextbox.Text.Length - 1, 1);
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            bool validEntry = true;
            bool invalidEmail = false;
            bool missingContact = false;
            bool missingName = false;
            bool invalidPhone = false;

            //get the values from the text boxes
            var nameValue = nameText.Text;
            var telephoneValue = telephoneText.Text;
            var emailValue = emailText.Text;

            //MessageBox.Show(nameValue);

            if (string.IsNullOrWhiteSpace(nameText.Text))
            {
                validEntry = false;
                missingName = true;
            }

            if (string.IsNullOrWhiteSpace(telephoneText.Text) && string.IsNullOrWhiteSpace(emailText.Text))
            {
                validEntry = false;
                missingContact = true;
            }

            bool letterResult = nameValue.All(Char.IsLetter);

            if (letterResult == false)
            {
                validEntry = false;
                MessageBox.Show("Please use only letters in the name field.");
            }

            bool telephoneDigitsOnly = DigitsOnly(telephoneValue);

            if (telephoneValue.Length < 11 || telephoneDigitsOnly == false)
            {
                validEntry = false;
                invalidPhone = true;
            }

            //validate email
            if (!string.IsNullOrWhiteSpace(emailText.Text))
            {
                if (!IsValidEmail(emailValue))
                {
                    validEntry = false;
                    invalidEmail = true;
                }
            }

            if (validEntry)
            {
                //handle valid entry; add data to database
                writeValuesToDatabase(nameValue, telephoneValue, emailValue);
            } else {
                //show a message depending on the submission problem

                if (invalidEmail == true)
                {
                    MessageBox.Show("The email address you have entered is invalid. Please try again."); 
                }

                if (missingContact == true)
                {
                    MessageBox.Show("Please enter either a telephone number or email address.");
                }

                if (missingName == true)
                {
                    MessageBox.Show("Please remember to enter your name."); 
                }

                if (invalidPhone == true)
                {
                    MessageBox.Show("Please enter a phone number that is at least 11 digits long and contains only digits.");
                }

            }
        }

        private bool DigitsOnly(string s)
        {
            int len = s.Length;
            for (int i = 0; i < len; ++i)
            {
                char c = s[i];
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void writeValuesToDatabase(string nameValue, string telValue, string emailValue)
        {
            MySqlConnection connectionString = new MySqlConnection("Server=localhost;Database=bomber_command;Uid=root;Pwd=IBCCProject17;");

            string insertQuery = "INSERT INTO contact (name, telephone, email) VALUES ('" + nameValue + "', '" + telValue + "', '" + emailValue + "')";
            bool errorOccurred = false;

            try
            {
                MySqlCommand command = connectionString.CreateCommand();
                command.CommandText = insertQuery;
                connectionString.Open();
                command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                // ex.Message;
                errorOccurred = true;
                MessageBox.Show("An error has occurred in writing the data. Please report this to an administrator.");
            }
            finally
            {
                connectionString.Close();
            }

            if (!errorOccurred)
            {
                MessageBox.Show("Your contact details have been successfully recorded. A member of the IBCC team will soon be in touch.");
                //clear fields on successful submission
                nameText.Text = "";
                telephoneText.Text = "";
                emailText.Text = "";
            }
        
        
        }

        //symbols code

        private void dotButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + ".";
        }

        private void commaButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + ",";
        }

        private void atSignButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "@";
        }

        private void questionMarkButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "?";
        }

        private void exclamationMarkButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "!";
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "1";
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "2";
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "3";
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "4";
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "5";
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "6";
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "7";
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "8";
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "9";
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + "0";
        }

        private void spaceButton_Click(object sender, RoutedEventArgs e)
        {
            _currentTextbox.Text = _currentTextbox.Text + " ";
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            menuWindow.Show();
            this.Close();
        }

        
    }

    
}
