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
            string selectedTopicNameEnglish = "";
            string selectedVocabularyIrish= "";
            string selectedVocabularyEnglish = "";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            //sconnection.ConnectionString = Properties.Settings.Default.IrishAppDBConnectionString;
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Topics;", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            cbxTopicList.Items.Clear();
            while (reader.Read())
            {
                cbxTopicList.Items.Add(reader["topic_name_english"].ToString() + " - " + reader["topic_name_irish"].ToString());
            }
            cbxTopicList.SelectedIndex = 0;
            int index = cbxTopicList.SelectedItem.ToString().IndexOf('-');
            if (index > 0)
            {
                selectedTopicNameEnglish = cbxTopicList.SelectedItem.ToString().Substring(0, index);
            };
            connection.Close();
        }

        private void lbxVocabulary_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVocabularyIrish = "";
            string selectedVocabularyEnglish = "";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            
            connection.Open();
            int index = lbxVocabulary.SelectedItem.ToString().IndexOf('-');
            if (index > 0)
            {
                selectedVocabularyIrish = lbxVocabulary.SelectedItem.ToString().Substring(index + 2);
                selectedVocabularyEnglish = lbxVocabulary.SelectedItem.ToString().Substring(0, index);
            };
            txtIrishVocabulary.Text = selectedVocabularyIrish;
            txtEnglishVocabulary.Text = selectedVocabularyEnglish;
            connection.Close();
        }

        private void cbxTopicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTopicNameEnglish = "";
            string selectedVocabularyIrish = "";
            string selectedVocabularyEnglish = "";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            int index = cbxTopicList.SelectedItem.ToString().IndexOf('-');
            if (index > 0)
            {
                selectedTopicNameEnglish = cbxTopicList.SelectedItem.ToString().Substring(0, index);
            };
            connection.Close();

            connection.Open();
            lbxVocabulary.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE topic_name_english='" + selectedTopicNameEnglish + "';", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbxVocabulary.Items.Add(reader["vocabulary_english"].ToString() + " - " + reader["vocabulary_irish"].ToString());
            }
            lbxVocabulary.SelectedIndex = 0;
            index = lbxVocabulary.SelectedItem.ToString().IndexOf('-');
            if (index > 0)
            {
                selectedVocabularyIrish = lbxVocabulary.SelectedItem.ToString().Substring(index + 2);
                selectedVocabularyEnglish = lbxVocabulary.SelectedItem.ToString().Substring(0, index);
            };
            txtIrishVocabulary.Text = selectedVocabularyIrish;
            txtEnglishVocabulary.Text = selectedVocabularyEnglish;
            connection.Close();
        }
    }
}
