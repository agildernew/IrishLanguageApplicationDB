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
    public partial class MatchOrEnterWordForWordExerciseForm : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;

        string currentUser = "", exerciseTopic = "", exerciseType = "", exerciseDescription = "";
        List<string> vocabularyEnglish = new List<string>(), vocabularyIrish = new List<string>();
        List<TextBox> textboxesIrish = new List<TextBox>(), textboxesEnglish = new List<TextBox>(), textboxesAnswers = new List<TextBox>();
        string[] sortedVocabularyIrish, sortedVocabularyEnglish;
        int numberOfInstances;
        bool displayIrish = true, displayEnglish = true, isStudent = false, isParent = false;

        private void btnViewLeaderBoard_Click(object sender, EventArgs e)
        {
            Form LeaderBoardForm;
            if (isParent)
            {
                LeaderBoardForm = new LeaderBoardForm(connection, exerciseTopic, "All", currentUser);

            }
            else
            {
                LeaderBoardForm = new LeaderBoardForm(connection, exerciseTopic, "All");

            }
            LeaderBoardForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form MainForm = new ChoosingExerciseForm(connection, currentUser, exerciseTopic);
            MainForm.Show();
            this.Enabled = false;
            this.Hide();
        }

        public MatchOrEnterWordForWordExerciseForm(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string currentEnglish = "", currentIrish = "", currentAnswer = "";
            int score = 0;
            double scorePercentage = 0.00;
            for (int i = 0; i < numberOfInstances; i++)
            {
                currentEnglish = "";
                currentIrish = "";
                currentAnswer = "";

                if (exerciseType == "MatchIrishToEnglish" || exerciseType == "EnterIrishForEnglish")
                {
                    currentEnglish = textboxesEnglish[i].Text;
                    currentAnswer = textboxesAnswers[i].Text;

                    for (int j = 0; j < numberOfInstances; j++)
                    {
                        if (currentEnglish.ToLower() == vocabularyEnglish[j].ToLower())
                        {
                            currentIrish = vocabularyIrish[j];

                            if (vocabularyIrish[j].ToLower() == currentAnswer.ToLower())
                            {
                                score = score + 1;
                                textboxesAnswers[i].BackColor = Color.LightGreen;
                            }
                            else
                            {
                                textboxesAnswers[i].BackColor = Color.Red;
                            }
                        }
                    }
                }
                else if (exerciseType == "MatchEnglishToIrish" || exerciseType == "EnterEnglishForIrish")
                {
                    currentIrish = textboxesIrish[i].Text;
                    currentAnswer = textboxesAnswers[i].Text;

                    for (int j = 0; j < numberOfInstances; j++)
                    {
                        if (currentIrish.ToLower() == vocabularyIrish[j].ToLower())
                        {
                            currentEnglish = vocabularyEnglish[j];

                            if (vocabularyEnglish[j].ToLower() == currentAnswer.ToLower())
                            {
                                score = score + 1;
                                textboxesAnswers[i].BackColor = Color.LightGreen;
                            }
                            else
                            {
                                textboxesAnswers[i].BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            scorePercentage = Math.Round(((double)score / (double)numberOfInstances) * 100, 2);

            string markingMessage = "";
            if (scorePercentage > 90)
            {
                markingMessage = "Ar fheabhas! - Excellent!";
            } 
            else if (scorePercentage > 70)
            {
                markingMessage = "Go hiontach - Very good";
            }
            else if (scorePercentage > 60)
            {
                markingMessage = "Go maith - Good";
            }
            else
            {
                markingMessage = "Coinnigh ort ag iarraidh - Keep trying";
            }
            lblScore.Text = "Scór = " + score.ToString() + "/" + numberOfInstances.ToString() + " -> " + scorePercentage.ToString() + "% \r\n" + markingMessage;

            connection.Open();
            cmd = new SqlCommand("SELECT * FROM Users WHERE username ='" + currentUser + "';", connection);

            reader = cmd.ExecuteReader();
            isParent = false;
            while (reader.Read())
            {
                if (Int32.Parse(reader["user_type_id"].ToString()) == 4)
                {
                    isParent = true;
                }
            }
            connection.Close();
            btnViewLeaderBoard.Show();

            if (isStudent)
            {
                int oldScore = 0;
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM LeaderBoard WHERE username = '" + currentUser + "' AND exerciseType = '" + exerciseType + "';", connection);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    oldScore = Int16.Parse(reader["score"].ToString());
                }
                connection.Close();

                if (oldScore < score)
                {
                    connection.Open();
                    cmd = new SqlCommand("INSERT INTO LeaderBoard (username, score, topic, exerciseType) VALUES ('" + currentUser + "', " + scorePercentage + ", '" + exerciseTopic + "', '" + exerciseType + "');", connection);

                    reader = cmd.ExecuteReader();
                    connection.Close();
                }
                btnSubmit.Enabled = false;
            }
        }

        public MatchOrEnterWordForWordExerciseForm(SqlConnection sqlConnection, string user, bool isStudentUser, string topic, string extype, string description)
        {
            connection = sqlConnection;
            currentUser = user;
            isStudent = isStudentUser;
            exerciseTopic = topic;
            exerciseType = extype;
            exerciseDescription = description;
            InitializeComponent();
        }

        private void MatchOrEnterWordForWordExerciseForm_Load(object sender, EventArgs e)
        {
            lblExerciseInstructions.Text = exerciseDescription;
            btnViewLeaderBoard.Hide();

            textboxesEnglish.Add(txtEnglishWordOne);
            textboxesEnglish.Add(txtEnglishWordTwo);
            textboxesEnglish.Add(txtEnglishWordThree);
            textboxesEnglish.Add(txtEnglishWordFour);
            textboxesEnglish.Add(txtEnglishWordFive);
            textboxesEnglish.Add(txtEnglishWordSix);
            textboxesEnglish.Add(txtEnglishWordSeven);
            textboxesEnglish.Add(txtEnglishWordEight);
            textboxesEnglish.Add(txtEnglishWordNine);
            textboxesEnglish.Add(txtEnglishWordTen);

            textboxesIrish.Add(txtIrishWordOne);
            textboxesIrish.Add(txtIrishWordTwo);
            textboxesIrish.Add(txtIrishWordThree);
            textboxesIrish.Add(txtIrishWordFour);
            textboxesIrish.Add(txtIrishWordFive);
            textboxesIrish.Add(txtIrishWordSix);
            textboxesIrish.Add(txtIrishWordSeven);
            textboxesIrish.Add(txtIrishWordEight);
            textboxesIrish.Add(txtIrishWordNine);
            textboxesIrish.Add(txtIrishWordTen);

            textboxesAnswers.Add(txtAnswerOne);
            textboxesAnswers.Add(txtAnswerTwo);
            textboxesAnswers.Add(txtAnswerThree);
            textboxesAnswers.Add(txtAnswerFour);
            textboxesAnswers.Add(txtAnswerFive);
            textboxesAnswers.Add(txtAnswerSix);
            textboxesAnswers.Add(txtAnswerSeven);
            textboxesAnswers.Add(txtAnswerEight);
            textboxesAnswers.Add(txtAnswerNine);
            textboxesAnswers.Add(txtAnswerTen);

            if (exerciseType == "EnterEnglishForIrish")
            {
                displayEnglish = false;
            }
            else if (exerciseType == "EnterIrishForEnglish")
            {
                displayIrish = false;
            }

            connection.Open();
            cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE topic_name_english='" + exerciseTopic + "';", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int index = 0;
                vocabularyEnglish.Add(reader["vocabulary_english"].ToString());
                vocabularyIrish.Add(reader["vocabulary_irish"].ToString());
                index = index + 1;
            }
            connection.Close();

            sortedVocabularyEnglish = vocabularyEnglish.ToArray();
            sortedVocabularyIrish = vocabularyIrish.ToArray();

            numberOfInstances = vocabularyEnglish.Count();
            if (numberOfInstances > 10)
            {
                numberOfInstances = 10;
            }
            Random rand = new Random();

            // Stephens, R., 2014. Randomize arrays in C#. [Blog] C# Helper, Available at: <http://csharphelper.com/blog/2014/07/randomize-arrays-in-c/> [Accessed 3 March 2020].
            for (int i = 0; i < numberOfInstances - 1; i++)
            {
                int j = rand.Next(i, numberOfInstances);
                string temp = sortedVocabularyEnglish[i];
                sortedVocabularyEnglish[i] = sortedVocabularyEnglish[j];
                sortedVocabularyEnglish[j] = temp;
            }

            for (int i = 0; i < numberOfInstances - 1; i++)
            {
                int j = rand.Next(i, numberOfInstances);
                string temp = sortedVocabularyIrish[i];
                sortedVocabularyIrish[i] = sortedVocabularyIrish[j];
                sortedVocabularyIrish[j] = temp;
            }

            for (int i=0; i < 10; i++)
            {
                textboxesIrish[i].Hide();
                textboxesEnglish[i].Hide();
                textboxesAnswers[i].Hide();
            }

            if (displayEnglish == true & displayIrish == true)
            {
                DisplayVocabularyIrish();
                DisplayVocabularyEnglish();
            }
            else if (displayEnglish == true & displayIrish == false)
            {
                DisplayVocabularyEnglish();
            }
            else if (displayEnglish == false & displayIrish == true)
            {
                DisplayVocabularyIrish();
            }
        }

        public void DisplayVocabularyIrish()
        {
            int n = 0;
            do
            {
                textboxesIrish[n].Text = sortedVocabularyIrish[n];
                textboxesIrish[n].Show();
                textboxesAnswers[n].Show();
                textboxesAnswers[n].Focus();
                n = n + 1;
            } while (n < numberOfInstances);
        }

        public void DisplayVocabularyEnglish()
        {
            int n = 0;
            do
            {
                textboxesEnglish[n].Text = sortedVocabularyEnglish[n];
                textboxesEnglish[n].Show();
                textboxesAnswers[n].Show();
                textboxesAnswers[n].Focus();
                n = n + 1;
            } while (n < numberOfInstances);
        }
    }
}
