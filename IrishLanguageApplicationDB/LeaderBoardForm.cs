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
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;

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


        public LeaderBoardForm(SqlConnection sqlConnection, string yearGroup)
        {
            connection = sqlConnection;
            currentYearGroup = yearGroup;
            InitializeComponent();
        }

        public LeaderBoardForm(SqlConnection sqlConnection, string topic, string yearGroup)
        {
            connection = sqlConnection;
            currentTopic = topic;
            currentYearGroup = yearGroup;
            InitializeComponent();
        }

        public LeaderBoardForm(SqlConnection sqlConnection, string topic, string yearGroup, string user)
        {
            connection = sqlConnection;
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

            if (parentUsername != "")
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM ParentStudent WHERE username = '" + parentUsername + "';", connection);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int index = 0;
                    children.Add(reader["student_username"].ToString());
                    index = index + 1;
                }
                connection.Close();

                for (int i = 0; i < children.Count; i++)
                {
                    connection.Open();

                    if (currentYearGroup == "8")
                    {
                        cmd = new SqlCommand("SELECT TOP 10[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND [LeaderBoard].[username] = '" + children[i] + "' AND form_class LIKE '08%' ORDER BY score DESC;", connection);
                    }
                    else if (currentYearGroup == "9")
                    {
                        cmd = new SqlCommand("SELECT TOP 10[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND [LeaderBoard].[username] = '" + children[i] + "' AND form_class LIKE '09%' ORDER BY score DESC;", connection);
                    }
                    else if (currentYearGroup == "10")
                    {
                        cmd = new SqlCommand("SELECT TOP 10[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND [LeaderBoard].[username] = '" + children[i] + "' AND form_class LIKE '10%' ORDER BY score DESC;", connection);
                    }
                    else
                    {
                        cmd = new SqlCommand("SELECT TOP 10[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND [LeaderBoard].[username] = '" + children[i] + "' ORDER BY score DESC;", connection);
                    }

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int index = 0;
                        userId.Add(reader["username"].ToString());
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
                
                if (currentYearGroup == "8")
                {
                    cmd = new SqlCommand("SELECT TOP 10[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND form_class LIKE '08%' ORDER BY score DESC;", connection);
                }
                else if (currentYearGroup == "9")
                {
                    cmd = new SqlCommand("SELECT TOP 10[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND form_class LIKE '09%' ORDER BY score DESC;", connection);
                }
                else if (currentYearGroup == "10")
                {
                    cmd = new SqlCommand("SELECT TOP 10[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND form_class LIKE '10%' ORDER BY score DESC;", connection);
                }
                else
                {
                    cmd = new SqlCommand("SELECT TOP 10[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' ORDER BY score DESC;", connection);
                }

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int index = 0;
                    userId.Add(reader["username"].ToString());
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
                cmd = new SqlCommand("SELECT * FROM Users WHERE username = '" + userId[i] + "';", connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    formClass.Add(reader["form_class"].ToString());
                }
                connection.Close();
            }

            for (int i = numberOfInstances - 1; i >= 0; i--)
            {
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
}
