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
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;

        public AddTopicsForm(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
            InitializeComponent();
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            if (txtTopicNameEnglish.Text.Length > 0 && txtTopicNameIrish.Text.Length > 0)
            {
                connection.Open();
                cmd = new SqlCommand("INSERT INTO Topics (topic_name_english, topic_name_irish) VALUES ('" + txtTopicNameEnglish.Text + "', '" + txtTopicNameIrish.Text + "');", connection);
                reader = cmd.ExecuteReader();
                connection.Close();

                string topic = txtTopicNameEnglish.Text;
                Form AddVocabularyForm = new AddVocabularyForm(connection, topic);
                AddVocabularyForm.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Hide();
        }
    }
}