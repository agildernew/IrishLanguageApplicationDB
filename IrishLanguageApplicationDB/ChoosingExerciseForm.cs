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
        string exerciseTopic = "";
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
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(exerciseTopic);
            MatchOrEnterWordForWordExerciseForm.Show();
        }

        private void btnMatchIrishWordToEnglishWord_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(exerciseTopic);
            MatchOrEnterWordForWordExerciseForm.Show();
        }

        private void btnEnterEnglishWordForIrishWord_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(exerciseTopic, true, false);
            MatchOrEnterWordForWordExerciseForm.Show();
        }

        private void btnEnterIrishWordForEnglishWord_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm(exerciseTopic, false, true);
            MatchOrEnterWordForWordExerciseForm.Show();
        }
    }
}
