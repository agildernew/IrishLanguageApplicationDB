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
        public ChoosingExerciseForm()
        {
            InitializeComponent();
        }

        private void ChoosingExerciseForm_Load(object sender, EventArgs e)
        {

        }
        private void ChoosingExerciseForm_Closing(object sender, EventArgs e)
        {

        }


        private void btnMatchIrishWordToPicture_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            Form MatchWordToPictureExerciseForm = new MatchWordToPictureExerciseForm();
            MatchWordToPictureExerciseForm.Show();
        }

        private void btnMatchEnglishWordToIrishWord_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm();
            MatchOrEnterWordForWordExerciseForm.Show();
        }

        private void btnMatchIrishWordToEnglishWord_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //this.Hide();
            Form MatchOrEnterWordForWordExerciseForm = new MatchOrEnterWordForWordExerciseForm();
            MatchOrEnterWordForWordExerciseForm.Show();
        }
    }
}
