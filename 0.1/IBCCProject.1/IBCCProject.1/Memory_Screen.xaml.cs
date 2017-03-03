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
using MySql.Data.MySqlClient;

namespace IBCCProject._1
{
    /// <summary>
    /// Interaction logic for Memory_Screen.xaml
    /// </summary>
    public partial class Memory_Screen : Window
    {
        public Memory_Screen(string memory_id)
        {
            InitializeComponent();
            this.memoryId = memory_id;

            assignText();
      }

        public string memoryId { get; set; }

        private void assignText()
        {
            MySqlConnection MYSQLconnection = new MySqlConnection("Server=localhost;Database=bomber_command;Uid=root;Pwd=IBCCProject17;");

            string selectQuery = "SELECT * FROM bomber_command.memory WHERE memory_id = " + memoryId;
            int alwaysDisplay = 0;

            bool errorOccurred = false;

            try
            {

                MySqlCommand cmd = new MySqlCommand(selectQuery, MYSQLconnection);
                MYSQLconnection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    memoryTitle.Text = reader.GetString("memory_title");
                    memoryContent.Text = reader.GetString("memory_content");
                    memoryNumber.Content = memoryNumber.Content + reader.GetString("memory_id");
                    alwaysDisplay = reader.GetInt16("always_display");
                }

                if (alwaysDisplay == 1)
                {
                    //this memory was created by an administrator and cannot be removed
                    flagButton.Visibility = Visibility.Hidden;
                }

            }
            catch (Exception ex)
            {
                // ex.Message;
                errorOccurred = true;
                MessageBox.Show("An error has occurred in reading the data. Please report this to an administrator.");
            }
            finally
            {
                MYSQLconnection.Close();
            }

            if (!errorOccurred)
            {
               
            }
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            menuWindow.Show();
            this.Close();
        }

        private void flagButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("By pressing Continue on the next pop-up, this memory will be flagged and removed for public viewing. By pressing Cancel, the memory will remain. Use this button only to remove inappropriate or offensive entries. If in doubt, please consult a member of staff. A flagged memory will be hidden from view but may be reinstated at the discretion of IBCC staff.");
            Popup1.IsOpen = true;
        }

        private void confirmFlag_Click(object sender, RoutedEventArgs e)
        {
            updateFlag();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Popup1.IsOpen = false;
        }

        private void updateFlag()
        {
            String updateQuery = "UPDATE memory SET displayed=0 WHERE memory_id=" + memoryId;

            bool errorOccurred = false;

            MySqlConnection mySQLCon = new MySqlConnection();
            MySqlConnection connectionString = new MySqlConnection("Server=localhost;Database=bomber_command;Uid=root;Pwd=IBCCProject17;");

            try
            {
                MySqlCommand command = connectionString.CreateCommand();
                command.CommandText = updateQuery;
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
                Popup1.IsOpen = false;
                MessageBox.Show("Successfully removed inappropriate entry. Thank you for your assistance!");

                Memory_Selection memoryScreen = new Memory_Selection();
                memoryScreen.Show();
                this.Close();

            }
            else
            {
                Popup1.IsOpen = false;
                MessageBox.Show("A problem occurred in removing the memory. Please inform a member of staff.");
            }


        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Memory_Selection memoryMenu = new Memory_Selection();
            memoryMenu.Show();
            this.Close();
        }

    }
}
