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
        string currentTopic = "", currentYearGroup = "";
        List<string> userId = new List<string>(), score = new List<string>(), formClass = new List<string>();
        List<Label> labelsUserIds = new List<Label>(), labelsScores = new List<Label>(), labelsFormClasses = new List<Label>();

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

            LoadUsers(currentTopic, currentYearGroup);
        }

        public void LoadUsers(string topic, string yearGroup)
        {
            for (int i = 0; i < 10; i++)
            {
                labelsUserIds[i].Text = ".";
                labelsScores[i].Text = ".";
                labelsFormClasses[i].Text = ".";

                labelsUserIds[i].Hide();
                labelsScores[i].Hide();
                labelsFormClasses[i].Hide();

                userId.Clear();
                score.Clear();
                formClass.Clear();
                //i = i + 1;
            }


            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LeaderBoard WHERE topic = '" + currentTopic + "' ORDER BY score DESC;", connection); //WHERE form_class='" + 08A or 08B...... + "' and topic = "";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int index = 0;
                userId.Add(reader["user_id"].ToString());
                score.Add(reader["score"].ToString());
                index = index + 1;
            }
            connection.Close();

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

            for (int i = 0; i < numberOfInstances; i++)
            {
                if (formClass[i].Contains("8") && currentYearGroup != "8")
                {
                    userId.RemoveAt(i);
                    score.RemoveAt(i);
                    formClass.RemoveAt(i);

                    userId.ToArray();
                    score.ToArray();
                    formClass.ToArray();
                }

                if (formClass[i].Contains("9") && currentYearGroup != "9")
                {
                    userId.RemoveAt(i);
                    score.RemoveAt(i);
                    formClass.RemoveAt(i);

                    userId.ToArray();
                    score.ToArray();
                    formClass.ToArray();
                }

                if (formClass[i].Contains("10") && currentYearGroup != "10")
                {
                    userId.RemoveAt(i);
                    score.RemoveAt(i);
                    formClass.RemoveAt(i);

                    userId.ToArray();
                    score.ToArray();
                    formClass.ToArray();
                }
                numberOfInstances = userId.Count();
            }

            numberOfInstances = userId.Count();

            int n = 0;
            do
            {
                labelsUserIds[n].Show();
                labelsScores[n].Show();
                labelsFormClasses[n].Show();

                labelsUserIds[n].Text = userId[n];
                //labelsScores[n].Text = score[n];
                labelsFormClasses[n].Text = formClass[n];
                n = n + 1;
            } while (n < numberOfInstances);
        }

    }
}
