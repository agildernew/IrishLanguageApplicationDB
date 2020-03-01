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

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbxVocabulary.ClearSelected();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Topics;", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbxTopicList.Items.Add(reader["topic_name_english"].ToString() + " - " + reader["topic_name_irish"]);
            }
            connection.Close(); 
            
            connection.Open();
            cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE topic_name_english='Numbers';", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbxVocabulary.Items.Add(reader["vocabulary_english"].ToString() + " - " + reader["vocabulary_irish"]);
            }
            connection.Close();

            //txtEnglishVocabulary.Text = lbxVocabulary.SelectedItem.ToString();
        }
    }
}
