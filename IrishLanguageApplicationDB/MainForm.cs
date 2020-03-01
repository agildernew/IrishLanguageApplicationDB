using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IrishLanguageApplicationDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Topics;", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbxVocabulary.Items.Add(reader["topic_name_english"].ToString() + " - " + reader["topic_name_irish"]);

            }
            connection.Close();
        }
     }
    }
}
