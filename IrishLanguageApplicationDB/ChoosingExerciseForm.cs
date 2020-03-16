using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrishLanguageApplicationDB
{
    public partial class ChoosingExerciseForm : Form
    {
        string exerciseTopic = "", exerciseType = "", exerciseDescription = "";
        public ChoosingExerciseForm()
        {
            InitializeComponent();
        }

        public ChoosingExerciseForm(string topic)
        {
            InitializeComponent();
            exerciseTopic = topic;
        }

        private void ChoosingExerciseForm_Load(object sender, EventArgs e)
        {
            lblChooseExercise.Text = exerciseTopic;
        }
        private void ChoosingExerciseForm_Closing(object sender, EventArgs e)
        {

        }

        private void btnMatchIrishWordToPicture_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            Form MatchWordToPictureExerciseForm = new MatchWordToPictureExerciseForm(exerciseTopic);
            MatchWordToPictureExerciseForm.Show();
        }

        private void btnMatchEnglishWordToIrishWord_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            exerciseType = "MatchEnglishToIrish";
            exerciseDescription = "Match the English word to the given Irish word e.g. if the Irish word is 'Gaeilge' enter the English word for this (i.e. English)";
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(exerciseTopic, exerciseType, exerciseDescription);
            MatchOrEnterWordForWordExerciseForm.Show();
        }

        private void btnMatchIrishWordToEnglishWord_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            exerciseType = "MatchIrishToEnglish";
            exerciseDescription = "Match the Irish word to the given English word e.g. if the English word is 'Irish' enter the Irish word for this (i.e. Gaeilge)";
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(exerciseTopic, exerciseType, exerciseDescription);
            MatchOrEnterWordForWordExerciseForm.Show();
        }

        private void btnEnterEnglishWordForIrishWord_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            exerciseType = "EnterEnglishForIrish";
            exerciseDescription = "Enter the English word for the given Irish word e.g. if the Irish word is 'Gaeilge' enter the English word for this (i.e. English)";
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(exerciseTopic, exerciseType, true, false, exerciseDescription);
            MatchOrEnterWordForWordExerciseForm.Show();
        }

        private void btnEnterIrishWordForEnglishWord_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            exerciseType = "EnterIrishForEnglish";
            exerciseDescription = "Enter the Irish word for the given English word e.g. if the English word is 'English' enter the Irish word for this (i.e. Gaeilge)";
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(exerciseTopic, exerciseType, false, true, exerciseDescription);
            MatchOrEnterWordForWordExerciseForm.Show();
        }
    }
}
