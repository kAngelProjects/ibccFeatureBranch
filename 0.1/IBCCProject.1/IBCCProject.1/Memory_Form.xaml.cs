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
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace IBCCProject._1
{
    /// <summary>
    /// Interaction logic for Memory_Form.xaml
    /// </summary>
    public partial class Memory_Form : Window
    {
        private TextBox _currentTextbox;

        public Memory_Form()
        {
            InitializeComponent();
        }

        private void qButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "Q";
            }
            else
            {
                _currentTextbox.Text = _currentTextbox.Text + "q";
            }

        }

        private void wButton_Click(object sender, RoutedEventArgs e)
        {
            if (capsLock.IsChecked == true)
            {
                _currentTextbox.Text = _currentTextbox.Text + "W";
            }
            else
            {
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

        private void TextBoxLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            //save last textbox to have focus
            _currentTextbox = e.Source as TextBox;
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            bool validEntry = true;
            //validate the user's input first

            var titleValue = titleText.Text;
            var memoryValue = memoryText.Text;

            if (string.IsNullOrWhiteSpace(titleText.Text) || string.IsNullOrWhiteSpace(memoryText.Text))
            {
                validEntry = false;
            }

            //check for offensive language
            bool hasBadWordsTitle = FilterWords(titleValue);
            bool hasBadWordsEntry = FilterWords(memoryValue);

            if (hasBadWordsTitle == true || hasBadWordsEntry == true)
            {
                validEntry = false;
            }

            if (validEntry)
            {
                //save the entry here
                bool result = saveData(titleValue, memoryValue);
            }
            else
            {
                MessageBox.Show("There are errors in your data entry. Both fields are required, and no offensive language may be used.");
            }

        }

        public bool FilterWords(string inputWords)
        {
            Regex wordFilter = new Regex("(damn|shit|Jerry|Krouts|Fritz|nips|Nips|jerry|krouts|fritz|damnit|dammit|bloody|sodding|yids|Yids|yid|Yid|nigger|Nigger|darnit|spics|Spics|wops|Wop|wop|shite|damn|Gerry)");
            return wordFilter.IsMatch(inputWords);
        }

        private bool saveData(string titleValue, string memoryValue)
        {

            MySqlConnection connectionString = new MySqlConnection("Server=localhost;Database=bomber_command;Uid=root;Pwd=IBCCProject17;");

            //insert into table and escape strings to ensure single quotes can be inserted properly
            string insertQuery = "INSERT INTO memory (memory_title, memory_content, displayed, always_display) VALUES ('" + titleValue.Replace("'", "''") + "', '" + memoryValue.Replace("'", "''") + "', 1, 0)";
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connectionString.Close();
            }

            if (!errorOccurred)
            {
                MessageBox.Show("Your memory has been recorded. Thank you for contributing to the IBCC's digital archive!");
                titleText.Text = "";
                memoryText.Text = "";
            }

            return errorOccurred;
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            menuWindow.Show();
            this.Close();
        }

        
    }
}
