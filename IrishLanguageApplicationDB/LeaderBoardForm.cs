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
        int index = 0;
        List<string> userId = new List<string>(), score = new List<string>(), formClass = new List<string>(), exerciseType = new List<string>(), children = new List<string>();

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
            LoadUsers(currentTopic, currentYearGroup);
        }

        private void getExerciseType(string exerciseType)
        {
            if (exerciseType == "MatchIrishToImage")
            {
                currentExerciseType = "Match Irish to Image";
            }
            else if (exerciseType == "MatchEnglishToIrish")
            {
                currentExerciseType = "Match English to Irish";
            }
            else if (exerciseType == "MatchIrishToEnglish")
            {
                currentExerciseType = "Match Irish to English";
            }
            else if (exerciseType == "EnterEnglishForIrish")
            {
                currentExerciseType = "Enter English for Irish";
            }
            else if (exerciseType == "EnterIrishForEnglish")
            {
                currentExerciseType = "Enter Irish for English";
            }
            else
            {
                currentExerciseType = exerciseType;
            }
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
                dgvLeaderBoardData.Rows.Clear();
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
                        cmd = new SqlCommand("SELECT TOP 1000[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND [LeaderBoard].[username] = '" + children[i] + "' AND form_class LIKE '08%' ORDER BY score DESC;", connection);
                    }
                    else if (currentYearGroup == "9")
                    {
                        cmd = new SqlCommand("SELECT TOP 1000[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND [LeaderBoard].[username] = '" + children[i] + "' AND form_class LIKE '09%' ORDER BY score DESC;", connection);
                    }
                    else if (currentYearGroup == "10")
                    {
                        cmd = new SqlCommand("SELECT TOP 1000[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND [LeaderBoard].[username] = '" + children[i] + "' AND form_class LIKE '10%' ORDER BY score DESC;", connection);
                    }
                    else
                    {
                        cmd = new SqlCommand("SELECT TOP 1000[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND [LeaderBoard].[username] = '" + children[i] + "' ORDER BY score DESC;", connection);
                    }

                    
                    reader = cmd.ExecuteReader();
                    index = 0;
                    while (reader.Read())
                    {
                        userId.Add(reader["username"].ToString());
                        score.Add(reader["score"].ToString());
                        exerciseType.Add(reader["exerciseType"].ToString());
                        formClass.Add(reader["form_class"].ToString());
                        index = index + 1;
                        getExerciseType(reader["exerciseType"].ToString());
                        dgvLeaderBoardData.Rows.Add(index, reader["score"].ToString(), currentExerciseType, reader["form_class"].ToString(), reader["username"].ToString());
                    }
                    connection.Close();
                }
            }
            else
            {
                connection.Open();
                
                if (currentYearGroup == "8")
                {
                    cmd = new SqlCommand("SELECT TOP 1000[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND form_class LIKE '08%' ORDER BY score DESC;", connection);
                }
                else if (currentYearGroup == "9")
                {
                    cmd = new SqlCommand("SELECT TOP 1000[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND form_class LIKE '09%' ORDER BY score DESC;", connection);
                }
                else if (currentYearGroup == "10")
                {
                    cmd = new SqlCommand("SELECT TOP 1000[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' AND form_class LIKE '10%' ORDER BY score DESC;", connection);
                }
                else
                {
                    cmd = new SqlCommand("SELECT TOP 1000[LeaderBoard].[username],[LeaderBoard].[score],[LeaderBoard].[topic],[LeaderBoard].[exerciseType],[Users].[form_class] FROM LeaderBoard LEFT JOIN Users ON LeaderBoard.username=Users.username WHERE topic = '" + currentTopic + "' ORDER BY score DESC;", connection);
                }

                reader = cmd.ExecuteReader();
                index = 0;
                while (reader.Read())
                {
                    userId.Add(reader["username"].ToString());
                    score.Add(reader["score"].ToString());
                    exerciseType.Add(reader["exerciseType"].ToString());
                    formClass.Add(reader["form_class"].ToString());
                    index = index + 1;
                    getExerciseType(reader["exerciseType"].ToString());
                    dgvLeaderBoardData.Rows.Add(index, reader["score"].ToString(), currentExerciseType, reader["form_class"].ToString(), reader["username"].ToString());
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
                        n = n + 1;
                    } while (n < numberOfInstances);
                }
            }
        }
    }
}
