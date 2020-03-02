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
    public partial class MatchWordToPictureExerciseForm : Form
    {
        string exerciseTopic = "";

        public MatchWordToPictureExerciseForm()
        {
            InitializeComponent();
        }

        public MatchWordToPictureExerciseForm(string topic)
        {
            InitializeComponent();
            exerciseTopic = topic;
        }
    }
}
