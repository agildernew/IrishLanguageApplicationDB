using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IrishLanguageApplicationDB
{
    class GlobalVariables
    {
        public static SqlConnection SqlConnection()
        {
            SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            return connection;
        }

        public static string SqlConnectionString()
        {
            return null;
        }
        
    }




}
