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
        int numberOfInstances = 0, index = 0;
        string currentTopic = "", message = "", currentVocabularyEnglish = "";
        bool isEditMode = true, initialLoadCompleted = false;
        List<string> databaseTopic = new List<string>(), databaseEnglish = new List<string>(), databaseIrish = new List<string>(), databaseImage = new List<string>();

        public AddVocabularyForm(SqlConnection sqlConnection, string selectedTopic)
        {
            connection = sqlConnection;
            currentTopic = selectedTopic.Trim();
            InitializeComponent();
        }

        public AddVocabularyForm(SqlConnection sqlConnection, string selectedTopic, bool editMode)
        {
            isEditMode = editMode;
            connection = sqlConnection;
            currentTopic = selectedTopic.Trim();
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtVocabularyEnglish.Text.Length > 0 && txtVocabularyIrish.Text.Length > 0)
            {
                addVocabularyToDatabase();
            }
        }

        private void btnAddVocabulary_Click(object sender, EventArgs e)
        {
            btnAddVocabulary.Hide();
            btnEditVocabulary.Show();
            isEditMode = false;
            txtVocabularyEnglish.Clear();
            txtVocabularyIrish.Clear();
            txtImagePath.Clear();
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

        private void loadVocabularyFromDatabase()
        {
            numberOfInstances = 0;
            databaseEnglish.Clear();
            databaseIrish.Clear();
            databaseImage.Clear();

            connection.Open();

            cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE topic_name_english = '" + cbxTopicList.Text + "';", connection);

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                databaseEnglish.Add(reader["vocabulary_english"].ToString());
                databaseIrish.Add(reader["vocabulary_irish"].ToString());
                databaseImage.Add(reader["vocabulary_image"].ToString());

                databaseEnglish.ToArray();
            }

            numberOfInstances = databaseEnglish.Count();

            connection.Close();
        }

        private void loadVocabulary(int newIndex)
        {
            numberOfInstances = databaseEnglish.Count();
            if (initialLoadCompleted == true) { 
                if (numberOfInstances > 0)
                {
                    isEditMode = true;
                    btnAddVocabulary.Show();
                    btnEditVocabulary.Hide();
                    txtVocabularyEnglish.Text = databaseEnglish[newIndex];
                    txtVocabularyIrish.Text = databaseIrish[newIndex];
                    txtImagePath.Text = databaseImage[newIndex];
                    currentVocabularyEnglish = txtVocabularyEnglish.Text;

                }
                else
                {
                    isEditMode = false;
                    btnAddVocabulary.Hide();
                    btnEditVocabulary.Show();

                    txtVocabularyEnglish.Clear();
                    txtVocabularyIrish.Clear();
                    txtImagePath.Clear();
                }
            }
        }

        private void btnEditVocabulary_Click(object sender, EventArgs e)
        {
            isEditMode = true;
            btnEditVocabulary.Hide();
            btnAddVocabulary.Show();
            loadVocabularyFromDatabase();
            loadVocabulary(0);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            loadVocabulary(index);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index = databaseEnglish.IndexOf(txtVocabularyEnglish.Text);
            if (index != 0)
            {
                index = index - 1;
                loadVocabulary(index);
            }
            else
            {
                loadVocabulary(index);
            }
        }

        private void btnAddNewTopic_Click(object sender, EventArgs e)
        {
            Form AddTopicsForm = new AddTopicsForm(connection);
            AddTopicsForm.Show();
            this.Enabled = false;
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index != numberOfInstances - 1)
            {
                index = index + 1;
                loadVocabulary(index);
            }
            else
            {
                loadVocabulary(index);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = databaseEnglish.Count() - 1;
            loadVocabulary(index);
        }

        private void cbxTopicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadVocabularyFromDatabase();
            loadVocabulary(0);
        }

        private void AddVocabularyForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("SELECT * FROM Topics;", connection);
            reader = cmd.ExecuteReader();
            cbxTopicList.Items.Clear();
            while (reader.Read())
            {
                cbxTopicList.Items.Add(reader["topic_name_english"].ToString());
            }
            connection.Close();

            int topicIndex = 0, numberTopics = 0;
            numberTopics = cbxTopicList.Items.Count;

            for (int i = 0; i < numberTopics; i++)
            {
                cbxTopicList.SelectedIndex = i;
                if (cbxTopicList.SelectedItem.ToString() == currentTopic)
                {
                    topicIndex = i;
                }
            }
            initialLoadCompleted = true;
            cbxTopicList.SelectedIndex = topicIndex;

            btnEditVocabulary.Hide();
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            txtImagePath.Text = "";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Hide();
        }

        private void addVocabularyToDatabase()
        {
            string addedVocabularyEnglish = "";
            bool vocabularyExists = false;

            if (txtVocabularyEnglish.Text.Length > 0 && txtVocabularyIrish.Text.Length > 0 && initialLoadCompleted == true)
            {
                connection.Open();
                addedVocabularyEnglish = txtVocabularyEnglish.Text;
                if (isEditMode)
                {
                    if (txtImagePath.Text == "")
                    {
                        cmd = new SqlCommand("UPDATE Vocabulary SET vocabulary_english = '" + txtVocabularyEnglish.Text + "', vocabulary_irish = '" + txtVocabularyIrish.Text + "', vocabulary_image = NULL WHERE vocabulary_english = '" + currentVocabularyEnglish + "';", connection);
                    }
                    else
                    {
                        cmd = new SqlCommand("UPDATE Vocabulary SET vocabulary_english = '" + txtVocabularyEnglish.Text + "', vocabulary_irish = '" + txtVocabularyIrish.Text + "', vocabulary_image = '" + txtImagePath.Text + "' WHERE vocabulary_english = '" + currentVocabularyEnglish + "';", connection);
                    }

                    reader = cmd.ExecuteReader();
                    message = currentVocabularyEnglish + " has been updated under the topic " + currentTopic + ".";
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE vocabulary_english = '" + txtVocabularyEnglish.Text + "';", connection);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["vocabulary_english"].ToString() == txtVocabularyEnglish.Text)
                        {
                            vocabularyExists = true;
                        }
                    }

                    connection.Close();

                    connection.Open();
                    if (vocabularyExists)
                    {
                        message = txtVocabularyEnglish.Text + " already exists under the topic " + currentTopic + ".";
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO Vocabulary (vocabulary_english, topic_name_english, vocabulary_irish, vocabulary_image) VALUES ('" + txtVocabularyEnglish.Text + "', '" + cbxTopicList.SelectedItem.ToString() + "', '" + txtVocabularyIrish.Text + "', '" + txtImagePath.Text + "');", connection);
                        reader = cmd.ExecuteReader();
                        message = txtVocabularyEnglish.Text + " has been added to the database under the topic " + currentTopic + ".";

                    }
                }
                connection.Close();
                MessageBox.Show(message);

                loadVocabularyFromDatabase();

                index = 0;

                for (int i = 0; i < numberOfInstances; i++)
                {
                    if (databaseEnglish[i] == addedVocabularyEnglish)
                    {
                        index = i;
                    }
                }

                loadVocabulary(index);
            }
        }
    }
}
