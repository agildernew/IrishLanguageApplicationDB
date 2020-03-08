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
    public partial class AddVocabularyForm : Form
    {
        public AddVocabularyForm()
        {
            InitializeComponent();
        }

        public AddVocabularyForm(string selectedTopic)
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Topics;", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            cbxTopicList.Items.Clear();
            while (reader.Read())
            {
                cbxTopicList.Items.Add(reader["topic_name_english"].ToString());
            }

            int topicIndex = 0, numberTopics = 0;
            numberTopics = cbxTopicList.Items.Count;


            for (int i = 0; i < numberTopics; i++)
            {
                cbxTopicList.SelectedIndex = i;
                if (cbxTopicList.SelectedItem.ToString() == selectedTopic.Trim())
                {
                    topicIndex = i;
                }
            }

            cbxTopicList.SelectedIndex = topicIndex;
            connection.Close();

            /*/connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            connection.Open();
            cmd = new SqlCommand("SELECT * FROM Vocabulary;", connection);
            reader = cmd.ExecuteReader();
            cbxTopicList.Items.Clear();
            while (reader.Read())
            {
                cbxTopicList.Items.Add(reader["vocabulary_english"].ToString());
            }

            connection.Close();*/
        }

        private void btnAddMoreVocabulary_Click(object sender, EventArgs e)
        {
           if (txtVocabularyEnglish.Text.Length > 0 && txtVocabularyIrish.Text.Length > 0)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
                connection.Open();
                // SqlCommand cmd = new SqlCommand("SELECT * FROM Topics;", connection);
                //SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Vocabulary] ([vocabulary_english], [topic_name_english], [vocabulary_irish], [vocabulary_image]) VALUES (N" + cbxTopicList.SelectedItem.ToString() + "', N'" + txtVocabularyEnglish.Text + "', N'" + txtVocabularyIrish.Text + "', NULL); ", connection);
                SqlCommand cmd = new SqlCommand("INSERT INTO Vocabulary (vocabulary_english, topic_name_english, vocabulary_irish, vocabulary_image) VALUES ('" + cbxTopicList.SelectedItem.ToString() + "', '" + txtVocabularyEnglish.Text + "', '" + txtVocabularyIrish.Text + "', NULL);", connection);
                //SqlDataReader reader = cmd.ExecuteReader();
                txtVocabularyIrish.Text = "INSERT INTO Vocabulary (vocabulary_english, topic_name_english, vocabulary_irish, vocabulary_image) VALUES ('" + cbxTopicList.SelectedItem.ToString() + "', '" + txtVocabularyEnglish.Text + "', '" + txtVocabularyIrish.Text + "', NULL);";
                connection.Close();
            }
        }
    }
}
