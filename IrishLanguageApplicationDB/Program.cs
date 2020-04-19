using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
using System.IO;

namespace IrishLanguageApplicationDB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "com667.database.windows.net";
            builder.UserID = "aoifegildernew";
            string passwordFilePath = "C:\\AzurePassword.txt";
            if (File.Exists(passwordFilePath))
            {
                string password = File.ReadAllText(passwordFilePath.ToString());
                builder.Password = password;
                builder.InitialCatalog = "IrishAppDB";

                SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
                try
                {
                    sqlConnection.Open();
                    sqlConnection.Close();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new LoginForm(sqlConnection));
                } 
                catch (SqlException s)
                {
                    MessageBox.Show("There was an issue logging into the Azure database. Please contact an administrator.");
                }
            }
            else
            {
                MessageBox.Show("The file " + passwordFilePath + " can not be found with the Azure password details. \r\nPlease contact an administrator.");
            }

        }
    }
}