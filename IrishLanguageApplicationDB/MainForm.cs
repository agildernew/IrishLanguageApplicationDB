﻿using System;
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
        public string topic = "", selectedVocabularyIrish = "", selectedVocabularyEnglish = "", selectedVocabularyImagePath = "", user = "", userType = "";
        Image currentImage;

        public MainForm(string currentUser, string currentUserType)
        {
            user = currentUser;
            userType = currentUserType;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string selectedTopicNameEnglish = "";
            lblUserName.Text = user;

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

            if (userType != "Admin")
            {
                btnAddTopic.Hide();
                btnDeleteTopic.Hide();
                btnAddVocabulary.Hide();
                btnDeleteVocabulary.Hide();
                if (userType != "Teacher")
                {
                    btnEditUser.Hide();
                }
            }
        }

        private void loadListboxWithVocabulary(int currentIndex, int newIndex)
        {
            int newPosition = currentIndex + newIndex;
            selectedVocabularyIrish = "";
            selectedVocabularyEnglish = "";
            selectedVocabularyImagePath = "";
            pbxImages.Image = null;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";

            connection.Open();
            if (!(newPosition > lbxVocabulary.Items.Count - 1) && !(newPosition < 0))
            {
                lbxVocabulary.SelectedIndex = newPosition;
            }

            int index = lbxVocabulary.SelectedItem.ToString().IndexOf('-');
            if (index > 0)
            {
                selectedVocabularyIrish = lbxVocabulary.SelectedItem.ToString().Substring(index + 2);
                selectedVocabularyEnglish = lbxVocabulary.SelectedItem.ToString().Substring(0, index);

                SqlCommand cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE vocabulary_english='" + selectedVocabularyEnglish + "';", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    selectedVocabularyImagePath = reader["vocabulary_image"].ToString();
                }
            };
            txtIrishVocabulary.Text = selectedVocabularyIrish;
            txtEnglishVocabulary.Text = selectedVocabularyEnglish;

            if (selectedVocabularyImagePath != "") 
            {
                currentImage = Image.FromFile(selectedVocabularyImagePath);
                pbxImages.Image = currentImage;
            }
            
            connection.Close();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            int index = cbxTopicList.SelectedItem.ToString().IndexOf('-');
            topic = cbxTopicList.SelectedItem.ToString().Substring(0, index);
            //this.Enabled = false;
            //this.Hide();
            //Form ChoosingExerciseForm = new ChoosingExerciseForm();
            if (userType == "Student")
            {
                Form ChoosingExerciseForm = new ChoosingExerciseForm(user, topic);
                ChoosingExerciseForm.Show();
            }
            else
            {
                Form ChoosingExerciseForm = new ChoosingExerciseForm(topic);
                ChoosingExerciseForm.Show();
            }
        }

        private void cbxTopicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTopicNameEnglish = "";
            selectedVocabularyIrish = "";
            selectedVocabularyEnglish = "";
            selectedVocabularyImagePath = "";
            pbxImages.Image = null;
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
            int numberOfVocabulary = 0;
            while (reader.Read())
            {
                lbxVocabulary.Items.Add(reader["vocabulary_english"].ToString() + " - " + reader["vocabulary_irish"].ToString());
                numberOfVocabulary = numberOfVocabulary + 1;
            }
            connection.Close();
            if (numberOfVocabulary > 0)
            {
                btnPlayGame.Enabled = true;
                lbxVocabulary.SelectedIndex = 0;
                index = lbxVocabulary.SelectedItem.ToString().IndexOf('-');
                connection.Open();

                if (index > 0)
                {
                    selectedVocabularyIrish = lbxVocabulary.SelectedItem.ToString().Substring(index + 2).Trim();
                    selectedVocabularyEnglish = lbxVocabulary.SelectedItem.ToString().Substring(0, index).Trim();

                    cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE vocabulary_english='" + selectedVocabularyEnglish + "';", connection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        selectedVocabularyImagePath = reader["vocabulary_image"].ToString();
                    };
                };
                connection.Close();
                txtIrishVocabulary.Text = selectedVocabularyIrish;
                txtEnglishVocabulary.Text = selectedVocabularyEnglish;

                if (selectedVocabularyImagePath != "")
                {
                    currentImage = Image.FromFile(selectedVocabularyImagePath);
                    pbxImages.Image = currentImage;
                }
            }
            else
            {
                btnPlayGame.Enabled = false;
                txtEnglishVocabulary.Text = "";
                txtIrishVocabulary.Text = "";
            }
            connection.Close();
        }

        private void lbxVocabulary_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVocabularyIrish = "";
            string selectedVocabularyEnglish = "";
            pbxImages.Image = null;
            
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";

            connection.Open();
            int index = lbxVocabulary.SelectedItem.ToString().IndexOf('-');
            if (index > 0)
            {
                selectedVocabularyIrish = lbxVocabulary.SelectedItem.ToString().Substring(index + 2);
                selectedVocabularyEnglish = lbxVocabulary.SelectedItem.ToString().Substring(0, index);
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE vocabulary_english='" + selectedVocabularyEnglish + "';", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    selectedVocabularyImagePath = reader["vocabulary_image"].ToString();
                };
            };
            connection.Close();
            txtIrishVocabulary.Text = selectedVocabularyIrish;
            txtEnglishVocabulary.Text = selectedVocabularyEnglish;

            if (selectedVocabularyImagePath != "")
            {
                currentImage = Image.FromFile(selectedVocabularyImagePath);
                pbxImages.Image = currentImage;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            loadListboxWithVocabulary(0);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int currentIndex = lbxVocabulary.SelectedIndex;
            loadListboxWithVocabulary(currentIndex, -1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentIndex = lbxVocabulary.SelectedIndex;
            loadListboxWithVocabulary(currentIndex, +1);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int lastIndex = lbxVocabulary.Items.Count;
            loadListboxWithVocabulary(lastIndex - 1);
        }

        private void loadListboxWithVocabulary(int newIndex)
        {
            int newPosition = newIndex;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";

            connection.Open();
            lbxVocabulary.SelectedIndex = newPosition;

            int index = lbxVocabulary.SelectedItem.ToString().IndexOf('-');
            if (index > 0)
            {
                selectedVocabularyIrish = lbxVocabulary.SelectedItem.ToString().Substring(index + 2);
                selectedVocabularyEnglish = lbxVocabulary.SelectedItem.ToString().Substring(0, index);

                SqlCommand cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE vocabulary_english='" + selectedVocabularyEnglish + "';", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    selectedVocabularyImagePath = reader["vocabulary_image"].ToString();
                }
            };

            txtIrishVocabulary.Text = selectedVocabularyIrish;
            txtEnglishVocabulary.Text = selectedVocabularyEnglish;

            if (selectedVocabularyImagePath != "")
            {
                currentImage = Image.FromFile(selectedVocabularyImagePath);
                pbxImages.Image = currentImage;
            }
            connection.Close();
        }

        private void btnViewLeaderboard_Click(object sender, EventArgs e)
        {
            int index = cbxTopicList.SelectedItem.ToString().IndexOf('-');
            topic = cbxTopicList.SelectedItem.ToString().Substring(0, index).Trim();
            if (userType == "Parent")
            {
                Form LeaderBoardForm = new LeaderBoardForm(topic, "All", user);
                LeaderBoardForm.Show();
            }
            else
            {
                Form LeaderBoardForm = new LeaderBoardForm(topic, "All");
                LeaderBoardForm.Show();
            }
        }

        private void btnAmhranNabhFiann_Click(object sender, EventArgs e)
        {
            Form AmhranNabfFiannForm = new AmhranNabfFiannForm();
            AmhranNabfFiannForm.Show();
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            //Form ChoosingExerciseForm = new ChoosingExerciseForm();
            Form AddTopicsForm = new AddTopicsForm();
            AddTopicsForm.Show();
        }

        private void btnAddVocabulary_Click(object sender, EventArgs e)
        {
            int index = cbxTopicList.SelectedItem.ToString().IndexOf('-');
            topic = cbxTopicList.SelectedItem.ToString().Substring(0, index);
            //this.Enabled = false;
            //this.Hide();
            //Form ChoosingExerciseForm = new ChoosingExerciseForm();
            Form AddVocabularyForm = new AddVocabularyForm(topic);
            AddVocabularyForm.Show();
        }

        private void btnDeleteTopic_Click(object sender, EventArgs e)
        {
            int index = cbxTopicList.SelectedItem.ToString().IndexOf('-');
            topic = cbxTopicList.SelectedItem.ToString().Substring(0, index).Trim();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Vocabulary WHERE topic_name_english = '" + topic + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            connection.Close();

            connection.Open();
            cmd = new SqlCommand("DELETE FROM Topics WHERE topic_name_english = '" + topic + "'", connection);
            reader = cmd.ExecuteReader();
            connection.Close();

            connection.Open();
            cmd = new SqlCommand("SELECT * FROM Topics;", connection);
            reader = cmd.ExecuteReader();
            cbxTopicList.Items.Clear();
            while (reader.Read())
            {
                cbxTopicList.Items.Add(reader["topic_name_english"].ToString() + " - " + reader["topic_name_irish"].ToString());
            }
            cbxTopicList.SelectedIndex = 0;
            connection.Close();
        }

        private void btnDeleteVocabulary_Click(object sender, EventArgs e)
        {
            int vocabularyIndex = lbxVocabulary.SelectedItem.ToString().IndexOf('-');
            int topicIndex = cbxTopicList.SelectedItem.ToString().IndexOf('-');
            int currentIndex = lbxVocabulary.SelectedIndex;
            topic = cbxTopicList.SelectedItem.ToString().Substring(0, topicIndex).Trim();
            string vocabulary = lbxVocabulary.SelectedItem.ToString().Substring(0, vocabularyIndex).Trim();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Vocabulary WHERE vocabulary_english = '" + vocabulary + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            connection.Close();

            connection.Open();
            lbxVocabulary.Items.Clear();
            cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE topic_name_english='" + topic + "';", connection);
            reader = cmd.ExecuteReader();
            int numberOfVocabulary = 0;
            while (reader.Read())
            {
                lbxVocabulary.Items.Add(reader["vocabulary_english"].ToString() + " - " + reader["vocabulary_irish"].ToString());
                numberOfVocabulary = numberOfVocabulary + 1;
            }
            if (numberOfVocabulary > 0)
            {
                btnPlayGame.Enabled = true;
                if (currentIndex != 0)
                { 
                lbxVocabulary.SelectedIndex = currentIndex - 1;
                } 
                else
                {
                    lbxVocabulary.SelectedIndex = currentIndex;
                }
                int index = lbxVocabulary.SelectedItem.ToString().IndexOf('-');
                if (index > 0)
                {
                    selectedVocabularyIrish = lbxVocabulary.SelectedItem.ToString().Substring(index + 2).Trim();
                    selectedVocabularyEnglish = lbxVocabulary.SelectedItem.ToString().Substring(0, index).Trim();
                };
                txtIrishVocabulary.Text = selectedVocabularyIrish;
                txtEnglishVocabulary.Text = selectedVocabularyEnglish;
            }
            else
            {
                btnPlayGame.Enabled = false;
                txtEnglishVocabulary.Text = "";
                txtIrishVocabulary.Text = "";
            }
            connection.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentUserName = user;
            //this.Enabled = false;
            //this.Hide();
            Form ChangePasswordForm = new ChangePasswordForm(currentUserName);
            ChangePasswordForm.Show();
        }
    }
}
