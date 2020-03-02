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
        string exerciseTopic = "";
        List<string> vocabularyEnglish = new List<string>();
        List<string> vocabularyIrish = new List<string>();
        List<TextBox> textboxesIrish = new List<TextBox>();
        List<TextBox> textboxesEnglish = new List<TextBox>();


        public MatchOrEnterWordForWordExerciseForm()
        {
            InitializeComponent();
        }

        public MatchOrEnterWordForWordExerciseForm(string topic)
        {
            exerciseTopic = topic;
            InitializeComponent();
        }

        private void MatchOrEnterWordForWordExerciseForm_Load(object sender, EventArgs e)
        {
            lblExerciseInstructions.Text = exerciseTopic;
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

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE topic_name_english='" + exerciseTopic + "';", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int index = 0;
                vocabularyEnglish.Add(reader["vocabulary_english"].ToString());
                vocabularyIrish.Add(reader["vocabulary_irish"].ToString());
                index = index + 1;
            }
            connection.Close();

            string[] sortedVocabularyEnglish = vocabularyEnglish.ToArray();
            string[] sortedVocabularyIrish = vocabularyIrish.ToArray();

            int numberOfInstances = vocabularyEnglish.Count();
            Random rand = new Random();

            for (int i = 0; i < numberOfInstances - 1; i++)
            {
                int j = rand.Next(i, numberOfInstances);
                string temp = sortedVocabularyEnglish[i];
                sortedVocabularyEnglish[i] = sortedVocabularyEnglish[j];
                sortedVocabularyEnglish[j] = temp;
            }

            //http://csharphelper.com/blog/2014/07/randomize-arrays-in-c/
            for (int i = 0; i < numberOfInstances - 1; i++)
            {
                int j = rand.Next(i, numberOfInstances);
                string temp = sortedVocabularyIrish[i];
                sortedVocabularyIrish[i] = sortedVocabularyIrish[j];
                sortedVocabularyIrish[j] = temp;
            }

            int n = 0;
            do
            {
                textboxesIrish[n].Text = sortedVocabularyIrish[n];
                textboxesEnglish[n].Text = sortedVocabularyEnglish[n];
                n = n + 1;
            } while (n < numberOfInstances);
        }
    }
}
