namespace IrishLanguageApplicationDB
{
    partial class ChoosingExerciseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChooseExercise = new System.Windows.Forms.Label();
            this.btnMatchIrishWordToPicture = new System.Windows.Forms.Button();
            this.btnMatchEnglishWordToIrishWord = new System.Windows.Forms.Button();
            this.btnMatchIrishWordToEnglishWord = new System.Windows.Forms.Button();
            this.btnEnterEnglishWordForIrishWord = new System.Windows.Forms.Button();
            this.btnEnterIrishWordForEnglishWord = new System.Windows.Forms.Button();
            this.btnFillInBlanks = new System.Windows.Forms.Button();
            this.btnMultipleChoice = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseExercise
            // 
            this.lblChooseExercise.Location = new System.Drawing.Point(100, 20);
            this.lblChooseExercise.Name = "lblChooseExercise";
            this.lblChooseExercise.Size = new System.Drawing.Size(150, 16);
            this.lblChooseExercise.TabIndex = 0;
            this.lblChooseExercise.Text = "Choose an exercise";
            // 
            // btnMatchIrishWordToPicture
            // 
            this.btnMatchIrishWordToPicture.Location = new System.Drawing.Point(10, 50);
            this.btnMatchIrishWordToPicture.Name = "btnMatchIrishWordToPicture";
            this.btnMatchIrishWordToPicture.Size = new System.Drawing.Size(300, 24);
            this.btnMatchIrishWordToPicture.TabIndex = 1;
            this.btnMatchIrishWordToPicture.Text = "Match the Irish Word to the Picture";
            this.btnMatchIrishWordToPicture.Click += new System.EventHandler(this.btnMatchIrishWordToPicture_Click);
            // 
            // btnMatchEnglishWordToIrishWord
            // 
            this.btnMatchEnglishWordToIrishWord.Location = new System.Drawing.Point(10, 80);
            this.btnMatchEnglishWordToIrishWord.Name = "btnMatchEnglishWordToIrishWord";
            this.btnMatchEnglishWordToIrishWord.Size = new System.Drawing.Size(300, 24);
            this.btnMatchEnglishWordToIrishWord.TabIndex = 1;
            this.btnMatchEnglishWordToIrishWord.Text = "Match the English Word to the Irish Word";
            this.btnMatchEnglishWordToIrishWord.Click += new System.EventHandler(this.btnMatchEnglishWordToIrishWord_Click);
            // 
            // btnMatchIrishWordToEnglishWord
            // 
            this.btnMatchIrishWordToEnglishWord.Location = new System.Drawing.Point(10, 110);
            this.btnMatchIrishWordToEnglishWord.Name = "btnMatchIrishWordToEnglishWord";
            this.btnMatchIrishWordToEnglishWord.Size = new System.Drawing.Size(300, 24);
            this.btnMatchIrishWordToEnglishWord.TabIndex = 1;
            this.btnMatchIrishWordToEnglishWord.Text = "Match the Irish Word to the English Word";
            this.btnMatchIrishWordToEnglishWord.Click += new System.EventHandler(this.btnMatchIrishWordToEnglishWord_Click);
            // 
            // btnEnterEnglishWordForIrishWord
            // 
            this.btnEnterEnglishWordForIrishWord.Location = new System.Drawing.Point(10, 140);
            this.btnEnterEnglishWordForIrishWord.Name = "btnEnterEnglishWordForIrishWord";
            this.btnEnterEnglishWordForIrishWord.Size = new System.Drawing.Size(300, 24);
            this.btnEnterEnglishWordForIrishWord.TabIndex = 1;
            this.btnEnterEnglishWordForIrishWord.Text = "Enter the English Word for the given Irish Word";
            // 
            // btnEnterIrishWordForEnglishWord
            // 
            this.btnEnterIrishWordForEnglishWord.Location = new System.Drawing.Point(10, 170);
            this.btnEnterIrishWordForEnglishWord.Name = "btnEnterIrishWordForEnglishWord";
            this.btnEnterIrishWordForEnglishWord.Size = new System.Drawing.Size(300, 24);
            this.btnEnterIrishWordForEnglishWord.TabIndex = 1;
            this.btnEnterIrishWordForEnglishWord.Text = "Enter the Irish Word for the given English Word";
            // 
            // btnFillInBlanks
            // 
            this.btnFillInBlanks.Location = new System.Drawing.Point(10, 200);
            this.btnFillInBlanks.Name = "btnFillInBlanks";
            this.btnFillInBlanks.Size = new System.Drawing.Size(300, 24);
            this.btnFillInBlanks.TabIndex = 1;
            this.btnFillInBlanks.Text = "Fill in the blanks";
            // 
            // btnMultipleChoice
            // 
            this.btnMultipleChoice.Location = new System.Drawing.Point(10, 230);
            this.btnMultipleChoice.Name = "btnMultipleChoice";
            this.btnMultipleChoice.Size = new System.Drawing.Size(300, 24);
            this.btnMultipleChoice.TabIndex = 1;
            this.btnMultipleChoice.Text = "Multiple Choice";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(260, 270);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 24);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            // 
            // ChoosingExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 310);
            this.Controls.Add(this.lblChooseExercise);
            this.Controls.Add(this.btnMatchIrishWordToPicture);
            this.Controls.Add(this.btnMatchEnglishWordToIrishWord);
            this.Controls.Add(this.btnMatchIrishWordToEnglishWord);
            this.Controls.Add(this.btnEnterEnglishWordForIrishWord);
            this.Controls.Add(this.btnEnterIrishWordForEnglishWord);
            this.Controls.Add(this.btnFillInBlanks);
            this.Controls.Add(this.btnMultipleChoice);
            this.Controls.Add(this.btnBack);
            this.Name = "ChoosingExerciseForm";
            this.Text = "ChoosingExerciseForm";
            this.Load += new System.EventHandler(this.ChoosingExerciseForm_Load);
            //this.OnFormClosed += new System.EventHandler(this.ChoosingExerciseForm_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private void InitalizeCompnents()
        {

		}

        // Declaring Labels
        private System.Windows.Forms.Label lblChooseExercise;
        // Declaring Buttons
        private System.Windows.Forms.Button btnMatchIrishWordToPicture;
        private System.Windows.Forms.Button btnMatchEnglishWordToIrishWord;
        private System.Windows.Forms.Button btnMatchIrishWordToEnglishWord;
        private System.Windows.Forms.Button btnEnterEnglishWordForIrishWord;
        private System.Windows.Forms.Button btnEnterIrishWordForEnglishWord;
        private System.Windows.Forms.Button btnFillInBlanks;
        private System.Windows.Forms.Button btnMultipleChoice;
        private System.Windows.Forms.Button btnBack;
    }
}