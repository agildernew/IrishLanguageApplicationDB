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
    public partial class AddTopicsForm : Form
    {
        public AddTopicsForm()
        {
            InitializeComponent();
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            if (txtTopicNameEnglish.Text.Length > 0 && txtTopicNameIrish.Text.Length > 0)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Topics (topic_name_english, topic_name_irish) VALUES ('" + txtTopicNameEnglish.Text + "', '" + txtTopicNameIrish.Text + "');", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();

                string topic = txtTopicNameEnglish.ToString();
                //this.Enabled = false;
                //this.Hide();
                //Form ChoosingExerciseForm = new ChoosingExerciseForm();
                Form AddVocabularyForm = new AddVocabularyForm(topic);
                AddVocabularyForm.Show();
            }
        }
    }
}
