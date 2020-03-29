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
        List<string> vocabularyEnglish = new List<string>(), vocabularyIrish = new List<string>();
        string[] sortedVocabularyIrish, sortedVocabularyEnglish;
        int numberOfInstances = 0;

        public MultipleChoiceForm(string topic)
        {
            exerciseTopic = topic;

            InitializeComponent();
        }

        private void MultipleChoiceForm_Load(object sender, EventArgs e)
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
        }
    }
}
