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
    public partial class MultipleChoiceForm : Form
    {                
        SqlConnection connection = new SqlConnection();
        string exerciseTopic = "";
        List<string> vocabularyEnglish = new List<string>(), vocabularyIrish = new List<string>(), vocabulayAnswers = new List<string>();
        string[] sortedVocabularyIrish, sortedVocabularyEnglish;
        int currentIndex = 0;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            currentIndex = currentIndex + 1;
            this.Hide();
            Form MultipleChoiceForm = new MultipleChoiceForm(exerciseTopic, currentIndex);
            MultipleChoiceForm.Closed += (s, args) => this.Close();
            MultipleChoiceForm.Show();
        }

        int numberOfInstances = 0;

        public MultipleChoiceForm(string topic)
        {
            exerciseTopic = topic;

            InitializeComponent();
        }

        public MultipleChoiceForm(string topic, int newIndex)
        {
            exerciseTopic = topic;
            currentIndex = newIndex;

            InitializeComponent();
        }

        private void MultipleChoiceForm_Load(object sender, EventArgs e)
        {
            if (currentIndex == 0)
            {
                InitialLoad();
            }

            LoadQuestion();
        }

        public void InitialLoad()
        {
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

            sortedVocabularyEnglish = vocabularyEnglish.ToArray();
            sortedVocabularyIrish = vocabularyIrish.ToArray();
        }

        public void LoadQuestion()
        {
            string currentIrish = "",  currentEnglish = "", currentAnswer = "";

            numberOfInstances = vocabularyEnglish.Count();
            Random rand = new Random();

            // http://csharphelper.com/blog/2014/07/randomize-arrays-in-c/
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

            currentIrish = sortedVocabularyIrish[currentIndex].ToString();
            lblQuestion.Text = currentIrish;

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vocabulary WHERE vocabulary_irish='" + currentIrish + "';", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int index = 0;
                currentAnswer = reader["vocabulary_english"].ToString();
                vocabulayAnswers.Add(currentAnswer);
                index = index + 1;
            }
            connection.Close();

            //vocabulayAnswers.ToArray();

            for (int i = 0; i == 3; i++)
            {
                currentEnglish = sortedVocabularyEnglish[i];
                currentAnswer = vocabulayAnswers[i];

                if (currentEnglish != currentAnswer)
                {
                    vocabulayAnswers.Add(sortedVocabularyEnglish[i]);
                }
                string message = currentEnglish + "  =  " + currentAnswer;
                MessageBox.Show(message);

            }

            btnAnswer2.Text = currentEnglish;
            btnAnswer3.Text = sortedVocabularyEnglish[0];

            btnAnswer1.Text = vocabulayAnswers[0];
            //btnAnswer2.Text = vocabulayAnswers[1];
            //btnAnswer3.Text = vocabulayAnswers[2];
            //btnAnswer4.Text = vocabulayAnswers[3];
        }
    }
}
