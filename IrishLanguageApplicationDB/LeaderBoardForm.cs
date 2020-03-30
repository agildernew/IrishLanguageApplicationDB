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

        public LeaderBoardForm()
        {
            InitializeComponent();
        }

        private void LeaderBoardForm_Load(object sender, EventArgs e)
        {
            List<string> userId = new List<string>(), score = new List<string>();
            List<Label> labelsUserIds = new List<Label>(), labelsScores = new List<Label>();
            int numberOfInstances = 0;

            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";


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

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LeaderBoard;", connection); //WHERE form_class='" + 08A or 08B...... + "' and topic = "";
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

            int n = 0;
            do
            {
                //textboxesIrish[n].Text = sortedVocabularyIrish[n];
                labelsUserIds[n].Text = userId[n];
                labelsScores[n].Text = score[n];
                //textboxesAnswers[n].Show();
                n = n + 1;
            } while (n < numberOfInstances);
        }
    }
}
