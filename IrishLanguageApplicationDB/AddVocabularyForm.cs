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
        }

        private void btnAddMoreVocabulary_Click(object sender, EventArgs e)
        {
            if (txtVocabularyEnglish.Text.Length > 0 && txtVocabularyIrish.Text.Length > 0)
            {
                addVocabularyToDatabase();
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            string filePath = "";

            OpenFileDialog selectImage = new OpenFileDialog();
            selectImage.Filter = "All Files (*.*)|*.*";
            selectImage.FilterIndex = 1;
            selectImage.Multiselect = true;

            if (selectImage.ShowDialog() == DialogResult.OK)
            {
                filePath = selectImage.FileName;
                txtImagePath.Text = filePath;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            txtImagePath.Text = "";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtVocabularyEnglish.Text.Length > 0 && txtVocabularyIrish.Text.Length > 0)
            {
                addVocabularyToDatabase();
            }

            this.Enabled = false;
            this.Hide();
        }

        private void addVocabularyToDatabase()
        {
            if (txtVocabularyEnglish.Text.Length > 0 && txtVocabularyIrish.Text.Length > 0)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Vocabulary (vocabulary_english, topic_name_english, vocabulary_irish, vocabulary_image) VALUES ('" + txtVocabularyEnglish.Text + "', '" + cbxTopicList.SelectedItem.ToString() + "', '" + txtVocabularyIrish.Text + "', '" + txtImagePath.Text + "');", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
                txtVocabularyEnglish.Text = "";
                txtVocabularyIrish.Text = "";
                txtImagePath.Text = "";
            }
        }
    }
}
