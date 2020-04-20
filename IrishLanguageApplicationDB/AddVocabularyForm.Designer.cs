namespace IrishLanguageApplicationDB
{
    partial class AddVocabularyForm
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
            this.lblTopicNameEnglish = new System.Windows.Forms.Label();
            this.lblVocabularyEnglish = new System.Windows.Forms.Label();
            this.lblVocabularyIrish = new System.Windows.Forms.Label();
            this.lblVocabularyImage = new System.Windows.Forms.Label();
            this.txtVocabularyEnglish = new System.Windows.Forms.TextBox();
            this.txtVocabularyIrish = new System.Windows.Forms.TextBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.cbxTopicList = new System.Windows.Forms.ComboBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnAddNewTopic = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditVocabulary = new System.Windows.Forms.Button();
            this.btnAddVocabulary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTopicNameEnglish
            // 
            this.lblTopicNameEnglish.AutoSize = true;
            this.lblTopicNameEnglish.Location = new System.Drawing.Point(14, 19);
            this.lblTopicNameEnglish.Name = "lblTopicNameEnglish";
            this.lblTopicNameEnglish.Size = new System.Drawing.Size(167, 18);
            this.lblTopicNameEnglish.TabIndex = 6;
            this.lblTopicNameEnglish.Text = "Topic Name English";
            // 
            // lblVocabularyEnglish
            // 
            this.lblVocabularyEnglish.AutoSize = true;
            this.lblVocabularyEnglish.Location = new System.Drawing.Point(14, 51);
            this.lblVocabularyEnglish.Name = "lblVocabularyEnglish";
            this.lblVocabularyEnglish.Size = new System.Drawing.Size(161, 18);
            this.lblVocabularyEnglish.TabIndex = 5;
            this.lblVocabularyEnglish.Text = "Vocabulary English";
            // 
            // lblVocabularyIrish
            // 
            this.lblVocabularyIrish.AutoSize = true;
            this.lblVocabularyIrish.Location = new System.Drawing.Point(14, 84);
            this.lblVocabularyIrish.Name = "lblVocabularyIrish";
            this.lblVocabularyIrish.Size = new System.Drawing.Size(139, 18);
            this.lblVocabularyIrish.TabIndex = 11;
            this.lblVocabularyIrish.Text = "Vocabulary Irish";
            // 
            // lblVocabularyImage
            // 
            this.lblVocabularyImage.AutoSize = true;
            this.lblVocabularyImage.Location = new System.Drawing.Point(14, 117);
            this.lblVocabularyImage.Name = "lblVocabularyImage";
            this.lblVocabularyImage.Size = new System.Drawing.Size(139, 18);
            this.lblVocabularyImage.TabIndex = 10;
            this.lblVocabularyImage.Text = "Image Attached";
            // 
            // txtVocabularyEnglish
            // 
            this.txtVocabularyEnglish.BackColor = System.Drawing.Color.White;
            this.txtVocabularyEnglish.Location = new System.Drawing.Point(187, 42);
            this.txtVocabularyEnglish.Name = "txtVocabularyEnglish";
            this.txtVocabularyEnglish.Size = new System.Drawing.Size(383, 27);
            this.txtVocabularyEnglish.TabIndex = 8;
            // 
            // txtVocabularyIrish
            // 
            this.txtVocabularyIrish.BackColor = System.Drawing.Color.White;
            this.txtVocabularyIrish.Location = new System.Drawing.Point(187, 75);
            this.txtVocabularyIrish.Name = "txtVocabularyIrish";
            this.txtVocabularyIrish.Size = new System.Drawing.Size(383, 27);
            this.txtVocabularyIrish.TabIndex = 13;
            // 
            // txtImagePath
            // 
            this.txtImagePath.BackColor = System.Drawing.Color.White;
            this.txtImagePath.Location = new System.Drawing.Point(187, 108);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(383, 27);
            this.txtImagePath.TabIndex = 12;
            // 
            // cbxTopicList
            // 
            this.cbxTopicList.BackColor = System.Drawing.Color.White;
            this.cbxTopicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTopicList.Location = new System.Drawing.Point(187, 10);
            this.cbxTopicList.Name = "cbxTopicList";
            this.cbxTopicList.Size = new System.Drawing.Size(383, 26);
            this.cbxTopicList.TabIndex = 6;
            this.cbxTopicList.SelectedIndexChanged += new System.EventHandler(this.cbxTopicList_SelectedIndexChanged);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(398, 143);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(38, 32);
            this.btnFirst.TabIndex = 18;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(442, 143);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(38, 32);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(486, 143);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 32);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(530, 143);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(38, 32);
            this.btnLast.TabIndex = 21;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.White;
            this.btnAddImage.Location = new System.Drawing.Point(126, 193);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(218, 34);
            this.btnAddImage.TabIndex = 14;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.White;
            this.btnRemoveImage.Location = new System.Drawing.Point(126, 233);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(218, 34);
            this.btnRemoveImage.TabIndex = 15;
            this.btnRemoveImage.Text = "Remove Image";
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(126, 274);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(218, 34);
            this.btnSaveChanges.TabIndex = 16;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnAddNewTopic
            // 
            this.btnAddNewTopic.BackColor = System.Drawing.Color.White;
            this.btnAddNewTopic.Location = new System.Drawing.Point(350, 233);
            this.btnAddNewTopic.Name = "btnAddNewTopic";
            this.btnAddNewTopic.Size = new System.Drawing.Size(218, 34);
            this.btnAddNewTopic.TabIndex = 9;
            this.btnAddNewTopic.Text = "Add New Topic";
            this.btnAddNewTopic.UseVisualStyleBackColor = false;
            this.btnAddNewTopic.Click += new System.EventHandler(this.btnAddNewTopic_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(350, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(218, 34);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnEditVocabulary
            // 
            this.btnEditVocabulary.BackColor = System.Drawing.Color.White;
            this.btnEditVocabulary.Location = new System.Drawing.Point(352, 193);
            this.btnEditVocabulary.Name = "btnEditVocabulary";
            this.btnEditVocabulary.Size = new System.Drawing.Size(218, 34);
            this.btnEditVocabulary.TabIndex = 22;
            this.btnEditVocabulary.Text = "Edit Vocabulary";
            this.btnEditVocabulary.UseVisualStyleBackColor = false;
            this.btnEditVocabulary.Click += new System.EventHandler(this.btnEditVocabulary_Click);
            // 
            // btnAddVocabulary
            // 
            this.btnAddVocabulary.BackColor = System.Drawing.Color.White;
            this.btnAddVocabulary.Location = new System.Drawing.Point(350, 193);
            this.btnAddVocabulary.Name = "btnAddVocabulary";
            this.btnAddVocabulary.Size = new System.Drawing.Size(218, 34);
            this.btnAddVocabulary.TabIndex = 23;
            this.btnAddVocabulary.Text = "Enter New Vocabulary";
            this.btnAddVocabulary.UseVisualStyleBackColor = false;
            this.btnAddVocabulary.Click += new System.EventHandler(this.btnAddVocabulary_Click);
            // 
            // AddVocabularyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 318);
            this.Controls.Add(this.btnAddVocabulary);
            this.Controls.Add(this.btnEditVocabulary);
            this.Controls.Add(this.lblTopicNameEnglish);
            this.Controls.Add(this.lblVocabularyEnglish);
            this.Controls.Add(this.lblVocabularyIrish);
            this.Controls.Add(this.cbxTopicList);
            this.Controls.Add(this.txtVocabularyEnglish);
            this.Controls.Add(this.txtVocabularyIrish);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.lblVocabularyImage);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnAddNewTopic);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Name = "AddVocabularyForm";
            this.Text = "Add Vocabulary";
            this.Load += new System.EventHandler(this.AddVocabularyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //Declaring Labels
        private System.Windows.Forms.Label lblTopicNameEnglish;
        private System.Windows.Forms.Label lblVocabularyEnglish;
        private System.Windows.Forms.Label lblVocabularyIrish;
        private System.Windows.Forms.Label lblVocabularyImage;
        //Declaring Textboxes
        private System.Windows.Forms.TextBox txtVocabularyEnglish;
        private System.Windows.Forms.TextBox txtVocabularyIrish;
        private System.Windows.Forms.TextBox txtImagePath;
        //Declaring Comboboxes
        private System.Windows.Forms.ComboBox cbxTopicList;
        //Declaring Butons
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnAddNewTopic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditVocabulary;
        private System.Windows.Forms.Button btnAddVocabulary;
    }
}