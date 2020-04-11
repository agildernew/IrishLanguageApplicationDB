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
    public partial class MatchWordToPictureExerciseForm : Form
    {
        string exerciseTopic = "", exerciseType = "", exerciseDescription = "";
        List<string> vocabularyIrish = new List<string>(), vocabularyImagePath = new List<string>();
        List<Button> buttonsIrish = new List<Button>(), buttonsAnswers = new List<Button>();
        List<PictureBox> pictureboxesImages = new List<PictureBox>();
        string[] sortedVocabularyIrish, sortedVocabularyImagePath;
        Image currentImage;

        private void MatchWordToPictureExerciseForm_Load(object sender, EventArgs e)
        {
            
            lblExerciseInstructions.Text = exerciseDescription;

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

            buttonsAnswers.Add(btnImageOne);
            buttonsAnswers.Add(btnImageTwo);
            buttonsAnswers.Add(btnImageThree);
            buttonsAnswers.Add(btnImageFour);
            buttonsAnswers.Add(btnImageFive);
            buttonsAnswers.Add(btnImageSix);
            buttonsAnswers.Add(btnImageSeven);
            buttonsAnswers.Add(btnImageEight);
            buttonsAnswers.Add(btnImageNine);
            buttonsAnswers.Add(btnImageTen);

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

            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE topic_name_english='" + exerciseTopic + "' AND vocabulary_image IS NOT NULL;", connection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int index = 0;
                vocabularyIrish.Add(reader["vocabulary_irish"].ToString());
                vocabularyImagePath.Add(reader["vocabulary_image"].ToString());

                index = index + 1;
            }
            connection.Close();

            sortedVocabularyIrish = vocabularyIrish.ToArray();
            sortedVocabularyImagePath = vocabularyImagePath.ToArray();

            numberOfInstances = vocabularyIrish.Count();
            Random rand = new Random();

            // http://csharphelper.com/blog/2014/07/randomize-arrays-in-c/
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
            }

            DisplayVocabulary();
        }

        int numberOfInstances;
        bool displayIrish = true, displayEnglish = true;
        SqlConnection connection = new SqlConnection();

        public MatchWordToPictureExerciseForm(string topic)
        {
            InitializeComponent();
            exerciseTopic = topic;
        }

        public MatchWordToPictureExerciseForm(string topic, string description)
        {
            exerciseTopic = topic;
            exerciseDescription = description;
            InitializeComponent();
        }

        public void DisplayVocabulary()
        {
            int n = 0;
            do
            {
                buttonsIrish[n].Text = sortedVocabularyIrish[n];
                currentImage = Image.FromFile(sortedVocabularyImagePath[n]);
                pictureboxesImages[n].Image = currentImage;
                buttonsIrish[n].Show();
                buttonsAnswers[n].Show();
                pictureboxesImages[n].Show();
                n = n + 1;
            } while (n < numberOfInstances);
        }
    }
}
