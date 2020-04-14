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
    public partial class LeaderBoardForm : Form
    {
        SqlConnection connection = new SqlConnection();
        string currentTopic = "", currentYearGroup = "", currentExerciseType = "", parentUsername = "";
        List<string> userId = new List<string>(), score = new List<string>(), formClass = new List<string>(), exerciseType = new List<string>(), children = new List<string>();
        List<Label> labelsUserIds = new List<Label>(), labelsScores = new List<Label>(), labelsFormClasses = new List<Label>(), labelsExerciseType = new List<Label>();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Hide();
        }

        private void btnYear8_Click(object sender, EventArgs e)
        {
            currentYearGroup = "8";
            LoadUsers(currentTopic, currentYearGroup);
        }

        private void btnYear9_Click(object sender, EventArgs e)
        {
            currentYearGroup = "9";
            LoadUsers(currentTopic, currentYearGroup);
        }

        private void btnYear10_Click(object sender, EventArgs e)
        {
            currentYearGroup = "10";
            LoadUsers(currentTopic, currentYearGroup);
        }

        private void btnAllYears_Click(object sender, EventArgs e)
        {
            currentYearGroup = "All";
            LoadUsers(currentTopic, currentYearGroup);
        }

        int numberOfInstances = 0;


        public LeaderBoardForm(string yearGroup)
        {
            currentYearGroup = yearGroup;
            InitializeComponent();
        }

        public LeaderBoardForm(string topic, string yearGroup)
        {
            currentTopic = topic;
            currentYearGroup = yearGroup;
            InitializeComponent();
        }

        public LeaderBoardForm(string topic, string yearGroup, string user)
        {
            currentTopic = topic;
            currentYearGroup = yearGroup;
            parentUsername = user;
            InitializeComponent();
        }


        private void LeaderBoardForm_Load(object sender, EventArgs e)
        {
            labelsUserIds.Add(lblFirstName);
            labelsUserIds.Add(lblSecondName);
            labelsUserIds.Add(lblThirdName);
            labelsUserIds.Add(lblFourthName);
            labelsUserIds.Add(lblFifthName);
            labelsUserIds.Add(lblSixthName);
            labelsUserIds.Add(lblSeventhName);
            labelsUserIds.Add(lblEighthName);
            labelsUserIds.Add(lblNinthName);
            labelsUserIds.Add(lblTenthName);

            labelsScores.Add(lblFirstScore);
            labelsScores.Add(lblSecondScore);
            labelsScores.Add(lblThirdScore);
            labelsScores.Add(lblFourthScore);
            labelsScores.Add(lblFifthScore);
            labelsScores.Add(lblSixthScore);
            labelsScores.Add(lblSeventhScore);
            labelsScores.Add(lblEighthScore);
            labelsScores.Add(lblNinthScore);
            labelsScores.Add(lblTenthScore);

            labelsFormClasses.Add(lblFirstClass);
            labelsFormClasses.Add(lblSecondClass);
            labelsFormClasses.Add(lblThirdClass);
            labelsFormClasses.Add(lblFourthClass);
            labelsFormClasses.Add(lblFifthClass);
            labelsFormClasses.Add(lblSixthClass);
            labelsFormClasses.Add(lblSeventhClass);
            labelsFormClasses.Add(lblEighthClass);
            labelsFormClasses.Add(lblNinthClass);
            labelsFormClasses.Add(lblTenthClass);

            labelsExerciseType.Add(lblExerciseTypeOne);
            labelsExerciseType.Add(lblExerciseTypeTwo);
            labelsExerciseType.Add(lblExerciseTypeThree);
            labelsExerciseType.Add(lblExerciseTypeFour);
            labelsExerciseType.Add(lblExerciseTypeFive);
            labelsExerciseType.Add(lblExerciseTypeSix);
            labelsExerciseType.Add(lblExerciseTypeSeven);
            labelsExerciseType.Add(lblExerciseTypeEight);
            labelsExerciseType.Add(lblExerciseTypeNine);
            labelsExerciseType.Add(lblExerciseTypeTen);

            LoadUsers(currentTopic, currentYearGroup);
        }

        public void LoadUsers(string topic, string yearGroup)
        {
            if (yearGroup == "All")
            {
                lblYearGroup.Text = "These are the scores for the students in All Year Groups for the topic " + topic;

            }
            else
            {
                lblYearGroup.Text = "These are the scores for the students in Year " + yearGroup + " for the topic " + topic;
            }

            for (int i = 0; i < 10; i++)
            {
                labelsUserIds[i].Hide();
                labelsScores[i].Hide();
                labelsFormClasses[i].Hide();
                labelsExerciseType[i].Hide();

                userId.Clear();
                score.Clear();
                formClass.Clear();
                exerciseType.Clear();
                children.Clear();
            }

            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";

            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            if (parentUsername != "")
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM ParentStudent WHERE user_id = '" + parentUsername + "';", connection);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int index = 0;
                    children.Add(reader["student_user_id"].ToString());
                    index = index + 1;
                }
                connection.Close();

                for (int i = 0; i < children.Count; i++)
                {

                    connection.Open();
                    cmd = new SqlCommand("SELECT * FROM LeaderBoard WHERE topic = '" + currentTopic + "' AND user_id = '" + children[i] + "' ORDER BY score DESC;", connection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int index = 0;
                        userId.Add(reader["user_id"].ToString());
                        score.Add(reader["score"].ToString());
                        exerciseType.Add(reader["exerciseType"].ToString());
                        index = index + 1;
                    }
                    connection.Close();
                }
            }
            else
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM LeaderBoard WHERE topic = '" + currentTopic + "' ORDER BY score DESC;", connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int index = 0;
                    userId.Add(reader["user_id"].ToString());
                    score.Add(reader["score"].ToString());
                    exerciseType.Add(reader["exerciseType"].ToString());
                    index = index + 1;
                }
                connection.Close();
            }

            numberOfInstances = userId.Count();

            for (int i = 0; i < numberOfInstances; i++)
            {
                connection.Open();

                cmd = new SqlCommand("SELECT * FROM Users WHERE user_id = '" + userId[i] + "';", connection);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    formClass.Add(reader["form_class"].ToString());
                }

                connection.Close();
            }




            for (int i = numberOfInstances - 1; i >= 0; i--)
            {
                if (currentYearGroup == "8")
                {
                    if (formClass[i].Contains("9") || formClass[i].Contains("10"))
                    {
                        userId.RemoveAt(i);
                        score.RemoveAt(i);
                        formClass.RemoveAt(i);

                        userId.ToArray();
                        score.ToArray();
                        formClass.ToArray();
                    }
                }

                if (currentYearGroup == "9")
                {
                    if (formClass[i].Contains("8") || formClass[i].Contains("10"))
                    {
                        userId.RemoveAt(i);
                        score.RemoveAt(i);
                        formClass.RemoveAt(i);

                        userId.ToArray();
                        score.ToArray();
                        formClass.ToArray();
                    }
                }

                if (currentYearGroup == "10")
                {
                    if (formClass[i].Contains("8") || formClass[i].Contains("9"))
                    {
                        userId.RemoveAt(i);
                        score.RemoveAt(i);
                        formClass.RemoveAt(i);

                        userId.ToArray();
                        score.ToArray();
                        formClass.ToArray();
                    }
                }
            }

            numberOfInstances = userId.Count();

            if (numberOfInstances > 0)
            {
                int n = 0;
                do
                {
                    labelsUserIds[n].Show();
                    labelsScores[n].Show();
                    labelsFormClasses[n].Show();
                    labelsExerciseType[n].Show();

                    labelsUserIds[n].Text = userId[n];
                    labelsScores[n].Text = score[n];
                    labelsFormClasses[n].Text = formClass[n];
                    if (exerciseType[n] == "MatchIrishToImage")
                    {
                        currentExerciseType = "Match Irish to Image";
                    }
                    else if (exerciseType[n] == "MatchEnglishToIrish")
                    {
                        currentExerciseType = "Match English to Irish";
                    }
                    else if (exerciseType[n] == "MatchIrishToEnglish")
                    {
                        currentExerciseType = "Match Irish to English";
                    }
                    else if (exerciseType[n] == "EnterEnglishForIrish")
                    {
                        currentExerciseType = "Enter English for Irish";
                    }
                    else if (exerciseType[n] == "EnterIrishForEnglish")
                    {
                        currentExerciseType = "Enter Irish for English";
                    }
                    else
                    {
                        currentExerciseType = exerciseType[n];
                    }

                    labelsExerciseType[n].Text = currentExerciseType;
                    n = n + 1;
                } while (n < numberOfInstances);
            }
        }

    }
}
