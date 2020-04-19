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
using System.IO;

namespace IrishLanguageApplicationDB
{
    public partial class AddVocabularyForm : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;

        public AddVocabularyForm(SqlConnection sqlConnection, string selectedTopic)
        {
            InitializeComponent();

            connection = sqlConnection;
            connection.Open();
            cmd = new SqlCommand("SELECT * FROM Topics;", connection);
            reader = cmd.ExecuteReader();
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
            string filePath = "", root = "", newPath = "";

            OpenFileDialog selectImage = new OpenFileDialog();
            selectImage.Filter = "All Files (*.*)|*.*";
            selectImage.FilterIndex = 1;
            selectImage.Multiselect = false;

            if (selectImage.ShowDialog() == DialogResult.OK)
            {
                root = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).Parent.FullName;
                filePath =  selectImage.FileName;
                if (filePath.Contains(root))
                {
                    newPath = filePath.Substring(root.Length);
                } 
                else
                {
                    newPath = filePath;
                }

                txtImagePath.Text = newPath;
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
                connection.Open();
                cmd = new SqlCommand("INSERT INTO Vocabulary (vocabulary_english, topic_name_english, vocabulary_irish, vocabulary_image) VALUES ('" + txtVocabularyEnglish.Text + "', '" + cbxTopicList.SelectedItem.ToString() + "', '" + txtVocabularyIrish.Text + "', '" + txtImagePath.Text + "');", connection);
                reader = cmd.ExecuteReader();
                connection.Close();
                txtVocabularyEnglish.Text = "";
                txtVocabularyIrish.Text = "";
                txtImagePath.Text = "";
            }
        }
    }
}
