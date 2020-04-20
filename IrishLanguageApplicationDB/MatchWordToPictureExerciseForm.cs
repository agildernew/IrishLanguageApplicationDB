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
    public partial class MatchWordToPictureExerciseForm : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;

        string currentUser = "", exerciseTopic = "", exerciseType = "", exerciseDescription = "", currentIrishAnswer = "";
        List<string> vocabularyIrish = new List<string>(), vocabularyEnglish = new List<string>(), vocabularyImagePath = new List<string>();
        List<Button> buttonsIrish = new List<Button>();
        List<TextBox> textboxesAnswers = new List<TextBox>();
        List<PictureBox> pictureboxesImages = new List<PictureBox>();
        string[] sortedVocabularyIrish, sortedVocabularyEnglish, sortedVocabularyImagePath;
        bool isStudent = false, isParent = false;
        Image currentImage;

        private void MatchWordToPictureExerciseForm_Load(object sender, EventArgs e)
        {
            lblExerciseInstructions.Text = exerciseDescription;
            btnViewLeaderBoard.Hide();

            buttonsIrish.Add(btnOne);
            buttonsIrish.Add(btnTwo);
            buttonsIrish.Add(btnThree);
            buttonsIrish.Add(btnFour);
            buttonsIrish.Add(btnFive);
            buttonsIrish.Add(btnSix);
            buttonsIrish.Add(btnSeven);
            buttonsIrish.Add(btnEight);
            buttonsIrish.Add(btnNine);
            buttonsIrish.Add(btnTen);

            textboxesAnswers.Add(txtImageOne);
            textboxesAnswers.Add(txtImageTwo);
            textboxesAnswers.Add(txtImageThree);
            textboxesAnswers.Add(txtImageFour);
            textboxesAnswers.Add(txtImageFive);
            textboxesAnswers.Add(txtImageSix);
            textboxesAnswers.Add(txtImageSeven);
            textboxesAnswers.Add(txtImageEight);
            textboxesAnswers.Add(txtImageNine);
            textboxesAnswers.Add(txtImageTen);

            pictureboxesImages.Add(pbxImageOne);
            pictureboxesImages.Add(pbxImageTwo);
            pictureboxesImages.Add(pbxImageThree);
            pictureboxesImages.Add(pbxImageFour);
            pictureboxesImages.Add(pbxImageFive);
            pictureboxesImages.Add(pbxImageSix);
            pictureboxesImages.Add(pbxImageSeven);
            pictureboxesImages.Add(pbxImageEight);
            pictureboxesImages.Add(pbxImageNine);
            pictureboxesImages.Add(pbxImageTen);

            for (int i = 0; i < 10; i++)
            {
                buttonsIrish[i].Hide();
                textboxesAnswers[i].Hide();
                pictureboxesImages[i].Hide();
            }

            connection.Open();
            cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE topic_name_english='" + exerciseTopic + "' AND vocabulary_image IS NOT NULL;", connection);

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["vocabulary_image"].ToString().Substring(0, 8) == "\\Images\\")
                {
                    int index = 0;
                    vocabularyIrish.Add(reader["vocabulary_irish"].ToString());
                    vocabularyEnglish.Add(reader["vocabulary_english"].ToString());
                    vocabularyImagePath.Add(reader["vocabulary_image"].ToString());
                    index = index + 1;
                }
            }
            connection.Close();

            sortedVocabularyIrish = vocabularyIrish.ToArray();
            sortedVocabularyEnglish = vocabularyEnglish.ToArray();
            sortedVocabularyImagePath = vocabularyImagePath.ToArray();

            numberOfInstances = vocabularyIrish.Count();
            Random rand = new Random();

            // Stephens, R., 2014. Randomize arrays in C#. [Blog] C# Helper, Available at: <http://csharphelper.com/blog/2014/07/randomize-arrays-in-c/> [Accessed 3 March 2020].
            for (int i = 0; i < numberOfInstances - 1; i++)
            {
                int j = rand.Next(i, numberOfInstances);
                string temp = sortedVocabularyIrish[i];
                sortedVocabularyIrish[i] = sortedVocabularyIrish[j];
                sortedVocabularyIrish[j] = temp;
            }

            for (int i = 0; i < numberOfInstances - 1; i++)
            {
                int j = rand.Next(i, numberOfInstances);
                string temp = sortedVocabularyImagePath[i];
                sortedVocabularyImagePath[i] = sortedVocabularyImagePath[j];
                sortedVocabularyImagePath[j] = temp;

                temp = sortedVocabularyEnglish[i];
                sortedVocabularyEnglish[i] = sortedVocabularyEnglish[j];
                sortedVocabularyEnglish[j] = temp;
            }

            DisplayVocabulary();
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

                currentEnglish = sortedVocabularyEnglish[i];
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

        public MatchWordToPictureExerciseForm(SqlConnection sqlConnection, string username, bool isStudentUser, string topic, string type, string description)
        {
            connection = sqlConnection;
            currentUser = username;
            isStudent = isStudentUser;
            exerciseTopic = topic;
            exerciseType = type;
            exerciseDescription = description;
            InitializeComponent();
        }

        public void DisplayVocabulary()
        {
            try
            {
                currentImage = null;
                string filePath = "", root = "", newPath = "";

                int n = 0;
                do
                {
                    buttonsIrish[n].Text = sortedVocabularyIrish[n];
                    filePath = sortedVocabularyImagePath[n];
                    root = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).Parent.FullName + filePath;
                    currentImage = Image.FromFile(root);
                    pictureboxesImages[n].Image = currentImage;
                    buttonsIrish[n].Show();
                    textboxesAnswers[n].Show();
                    pictureboxesImages[n].Show();
                    n = n + 1;
                } while (n < numberOfInstances);
            }
            catch (Exception ex)
            {

            }
        }

        int numberOfInstances;

        private void btnOne_Click(object sender, EventArgs e)
        {
            currentIrishAnswer = btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            currentIrishAnswer = btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            currentIrishAnswer = btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            currentIrishAnswer = btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            currentIrishAnswer = btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            currentIrishAnswer = btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            currentIrishAnswer = btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            currentIrishAnswer = btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            currentIrishAnswer = btnNine.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            currentIrishAnswer = btnTen.Text;
        }

        private void txtImageOne_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageOne.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void txtImageTwo_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageTwo.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void txtImageThree_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageThree.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void txtImageFour_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageFour.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void txtImageFive_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageFive.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void txtImageSix_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageSix.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void txtImageSeven_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageSeven.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void txtImageEight_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageEight.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void txtImageNine_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageNine.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void txtImageTen_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageTen.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void pbxImageOne_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageOne.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void pbxImageTwo_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageTwo.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form MainForm = new ChoosingExerciseForm(connection, currentUser, exerciseTopic);
            MainForm.Show();
            this.Enabled = false;
            this.Hide();
        }

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

        private void pbxImageThree_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageThree.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void pbxImageFour_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageFour.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void pbxImageFive_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageFive.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void pbxImageSix_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageSix.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void pbxImageSeven_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageSeven.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void pbxImageEight_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageEight.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void pbxImageNine_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageNine.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }

        private void pbxImageTen_Click(object sender, EventArgs e)
        {
            if (currentIrishAnswer != "")
            {
                txtImageTen.Text = currentIrishAnswer;
                currentIrishAnswer = "";
            }
        }
    }
}
