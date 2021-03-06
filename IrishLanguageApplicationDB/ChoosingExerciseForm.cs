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
    public partial class ChoosingExerciseForm : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;

        string exerciseTopic = "", exerciseType = "", exerciseDescription = "", currentUser = "", userType = "", userTypeIdStr = "";
        int userTypeId = 0;
        Boolean isStudentUser = false;

        public ChoosingExerciseForm(SqlConnection sqlConnection, string topic)
        {
            connection = sqlConnection;
            exerciseTopic = topic;
            InitializeComponent();
        }

        public ChoosingExerciseForm(SqlConnection sqlConnection, string username, string topic)
        {
            connection = sqlConnection;
            exerciseTopic = topic;
            currentUser = username;

            connection.Open();
            cmd = new SqlCommand("SELECT * FROM Users WHERE username = '" + currentUser + "';", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userTypeIdStr = reader["user_type_id"].ToString();
                userTypeId = Int16.Parse(userTypeIdStr);
            }
            connection.Close();

            connection.Open();
            cmd = new SqlCommand("SELECT * FROM UserTypes WHERE user_type_id = " + userTypeIdStr + ";", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userType = reader["user_type"].ToString();
            }
            connection.Close();
            if (userType == "Student")
            {
                isStudentUser = true;
            }
            else
            {
                isStudentUser = false;
            }

            InitializeComponent();
        }

        public ChoosingExerciseForm(SqlConnection sqlConnection, string username, string topic, Boolean isStudent)
        {
            connection = sqlConnection;
            exerciseTopic = topic;
            currentUser = username;
            isStudentUser = isStudent;
            InitializeComponent();
        }

        private void ChoosingExerciseForm_Load(object sender, EventArgs e)
        {
            lblChooseExercise.Text = "Choose an exercise for the topic " + exerciseTopic;

            connection.Open();
            cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE topic_name_english='" + exerciseTopic + "' AND vocabulary_image IS NOT NULL;", connection);

            reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                btnMatchIrishWordToPicture.Enabled = false;
            }

            connection.Close();
        }
        private void ChoosingExerciseForm_Closing(object sender, EventArgs e)
        {

        }

        private void btnMatchIrishWordToPicture_Click(object sender, EventArgs e)
        {
            exerciseType = "MatchIrishToImage";
            exerciseDescription = "Match the Irish word to the given image";
            Form MatchWordToPictureExerciseForm = new MatchWordToPictureExerciseForm(connection, currentUser, isStudentUser, exerciseTopic, exerciseType, exerciseDescription);
            MatchWordToPictureExerciseForm.Show();
            this.Enabled = false;
            this.Hide();
        }

        private void btnMatchEnglishWordToIrishWord_Click(object sender, EventArgs e)
        {
            exerciseType = "MatchEnglishToIrish";
            exerciseDescription = "Match the English word to the given Irish word e.g. if the Irish word is 'Gaeilge' enter the English word for this (i.e. English)." +
                "\n\rComplete the answer column with vocabulary from the English column (your answer should be in English)";
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(connection, currentUser, isStudentUser, exerciseTopic, exerciseType, exerciseDescription);
            MatchOrEnterWordForWordExerciseForm.Show();
            this.Enabled = false;
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form MainForm = new MainForm(connection, currentUser);
            MainForm.Show();
            this.Enabled = false;
            this.Hide();
        }

        private void btnMatchIrishWordToEnglishWord_Click(object sender, EventArgs e)
        {
            exerciseType = "MatchIrishToEnglish";
            exerciseDescription = "Match the Irish word to the given English word e.g. if the English word is 'Irish' enter the Irish word for this (i.e. Gaeilge)" +
                "\n\rComplete the answer column with vocabulary from the Irish column (your answer should be in Irish)";
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(connection, currentUser, isStudentUser, exerciseTopic, exerciseType, exerciseDescription);
            MatchOrEnterWordForWordExerciseForm.Show();
            this.Enabled = false;
            this.Hide();
        }

        private void btnEnterEnglishWordForIrishWord_Click(object sender, EventArgs e)
        {
            exerciseType = "EnterEnglishForIrish";
            exerciseDescription = "Enter the English word for the given Irish word e.g. if the Irish word is 'Gaeilge' enter the English word for this (i.e. English)";
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(connection, currentUser, isStudentUser, exerciseTopic, exerciseType, exerciseDescription);
            MatchOrEnterWordForWordExerciseForm.Show();
            this.Enabled = false;
            this.Hide();
        }

        private void btnEnterIrishWordForEnglishWord_Click(object sender, EventArgs e)
        {
            exerciseType = "EnterIrishForEnglish";
            exerciseDescription = "Enter the Irish word for the given English word e.g. if the English word is 'English' enter the Irish word for this (i.e. Gaeilge)";
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(connection, currentUser, isStudentUser, exerciseTopic, exerciseType, exerciseDescription);
            MatchOrEnterWordForWordExerciseForm.Show();
            this.Enabled = false;
            this.Hide();
        }
    }
}
