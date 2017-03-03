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
using System.Data;
using MySql.Data.MySqlClient;

namespace IBCCProject._1
{
    /// <summary>
    /// Interaction logic for Admin_Feedback.xaml
    /// </summary>
    public partial class Admin_Feedback : Window
    {
        DataTable memory_table = new DataTable("feedback");

        //For storing the current page number.
        private int paging_PageIndex = 1;

        //For storing the Paging Size. Here it is static but you can use a property
        //to expose and update value.
        private int paging_NoOfRecPerPage = 3;

        //To check the paging direction according to use selection.
        private enum PagingMode { First = 1, Next = 2, Previous = 3, Last = 4 };

        public Admin_Feedback()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            listContacts();
        }

        private void listContacts()
        {
            MySqlConnection mySQLCon = new MySqlConnection();

            MySqlConnection connectionString = new MySqlConnection("Server=localhost;Database=bomber_command;Uid=root;Pwd=IBCCProject17;");

            mySQLCon.ConnectionString = "Server=localhost;Database=bomber_command;Uid=root;Pwd=IBCCProject17;";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mySQLCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM bomber_command.feedback";

            MySqlDataAdapter mySQLDA = new MySqlDataAdapter();
            mySQLDA.SelectCommand = cmd;

            DataSet ds = new DataSet();
            try
            {

                paging_PageIndex = 1; //For default
                mySQLDA.Fill(memory_table);


                if (memory_table.Rows.Count > 0)
                {

                    DataTable tmpTable = new DataTable();

                    //Copying the schema to the temporary table.
                    tmpTable = memory_table.Clone();

                    //If total record count is greater than page size then import records
                    //from 0 to pagesize (here 20)
                    //Else import reports from 0 to total record count.
                    if (memory_table.Rows.Count >= paging_NoOfRecPerPage)
                    {
                        for (int i = 0; i < paging_NoOfRecPerPage; i++)
                        {
                            tmpTable.ImportRow(memory_table.Rows[i]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < memory_table.Rows.Count; i++)
                        {
                            tmpTable.ImportRow(memory_table.Rows[i]);
                        }
                    }

                    //Bind the table to the gridview.
                    pagination.DataContext = tmpTable.DefaultView;

                    //Dispose the temporary table.
                    tmpTable.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message");
            }
            finally
            {
                mySQLDA.Dispose();
                cmd.Dispose();
                mySQLCon.Dispose();
            }


        } //end list contact




        private void CustomPaging(int mode)
        {
            //There is no need for these variables but i created them just for readability
            int totalRecords = memory_table.Rows.Count;
            int pageSize = paging_NoOfRecPerPage;

            //If total record count is less than  the page size then return.
            if (totalRecords <= pageSize)
            {
                return;
            }

            switch (mode)
            {
                case (int)PagingMode.Next:
                    if (totalRecords > (paging_PageIndex * pageSize))
                    {
                        DataTable tmpTable = new DataTable();
                        tmpTable = memory_table.Clone();

                        if (totalRecords >= ((paging_PageIndex * pageSize) + pageSize))
                        {
                            for (int i = paging_PageIndex * pageSize; i <
                                ((paging_PageIndex * pageSize) + pageSize); i++)
                            {
                                tmpTable.ImportRow(memory_table.Rows[i]);
                            }
                        }
                        else
                        {
                            for (int i = paging_PageIndex * pageSize; i < totalRecords; i++)
                            {
                                tmpTable.ImportRow(memory_table.Rows[i]);
                            }
                        }

                        paging_PageIndex += 1;

                        pagination.DataContext = tmpTable.DefaultView;
                        tmpTable.Dispose();
                    }
                    break;
                case (int)PagingMode.Previous:
                    if (paging_PageIndex > 1)
                    {
                        DataTable tmpTable = new DataTable();
                        tmpTable = memory_table.Clone();

                        paging_PageIndex -= 1;

                        for (int i = ((paging_PageIndex * pageSize) - pageSize);
                            i < (paging_PageIndex * pageSize); i++)
                        {
                            tmpTable.ImportRow(memory_table.Rows[i]);
                        }

                        pagination.DataContext = tmpTable.DefaultView;
                        tmpTable.Dispose();
                    }
                    break;
                case (int)PagingMode.First:
                    paging_PageIndex = 2;
                    CustomPaging((int)PagingMode.Previous);
                    break;
                case (int)PagingMode.Last:
                    paging_PageIndex = (totalRecords / pageSize);
                    CustomPaging((int)PagingMode.Next);
                    break;
            }
        } //end custom paging

        private void btnFirst_Click(object sender, System.EventArgs e)
        {
            CustomPaging((int)PagingMode.First);
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            CustomPaging((int)PagingMode.Next);
        }

        private void btnPrev_Click(object sender, System.EventArgs e)
        {
            CustomPaging((int)PagingMode.Previous);
        }

        private void btnLast_Click(object sender, System.EventArgs e)
        {
            CustomPaging((int)PagingMode.Last);
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            menuWindow.Show();
            this.Close();
        }

    }
}
