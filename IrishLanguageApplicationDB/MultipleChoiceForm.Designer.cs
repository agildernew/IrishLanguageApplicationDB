namespace IrishLanguageApplicationDB
{
    partial class MultipleChoiceForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(13, 13);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(59, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "lblQuestion";
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Location = new System.Drawing.Point(16, 43);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(111, 23);
            this.btnAnswer1.TabIndex = 1;
            this.btnAnswer1.Text = "Answer 1";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Location = new System.Drawing.Point(137, 43);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(111, 23);
            this.btnAnswer2.TabIndex = 2;
            this.btnAnswer2.Text = "Answer 2";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Location = new System.Drawing.Point(16, 72);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(111, 23);
            this.btnAnswer3.TabIndex = 3;
            this.btnAnswer3.Text = "Answer 3";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Location = new System.Drawing.Point(137, 72);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(111, 23);
            this.btnAnswer4.TabIndex = 4;
            this.btnAnswer4.Text = "Answer 4";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(179, 101);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(69, 22);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // MultipleChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 135);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "MultipleChoiceForm";
            this.Text = "MultipleChoiceForm";
            this.Load += new System.EventHandler(this.MultipleChoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnConfirm;
    }
}