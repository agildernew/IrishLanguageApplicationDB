namespace IrishLanguageApplicationDB
{
    partial class MainForm
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
            this.cbxTopicList = new System.Windows.Forms.ComboBox();
            this.txtIrishVocabulary = new System.Windows.Forms.TextBox();
            this.txtEnglishVocabulary = new System.Windows.Forms.TextBox();
            this.lblTopics = new System.Windows.Forms.Label();
            this.lblVocabulary = new System.Windows.Forms.Label();
            this.lblIrish = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtImageIMG = new System.Windows.Forms.TextBox();
            this.pbxImages = new System.Windows.Forms.PictureBox();
            this.lbxVocabulary = new System.Windows.Forms.ListBox();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.btnAddVocabulary = new System.Windows.Forms.Button();
            this.btnCancelAddTopic = new System.Windows.Forms.Button();
            this.btnCancelAddVocabulary = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTopicList
            // 
            this.cbxTopicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTopicList.Items.AddRange(new object[] {
            "List",
            "Of",
            "Vocabulary",
            "Topics"});
            this.cbxTopicList.Location = new System.Drawing.Point(60, 20);
            this.cbxTopicList.Name = "cbxTopicList";
            this.cbxTopicList.Size = new System.Drawing.Size(150, 21);
            this.cbxTopicList.TabIndex = 6;
            // 
            // txtIrishVocabulary
            // 
            this.txtIrishVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtIrishVocabulary.Location = new System.Drawing.Point(300, 40);
            this.txtIrishVocabulary.Name = "txtIrishVocabulary";
            this.txtIrishVocabulary.ReadOnly = true;
            this.txtIrishVocabulary.Size = new System.Drawing.Size(150, 20);
            this.txtIrishVocabulary.TabIndex = 13;
            this.txtIrishVocabulary.Text = "txtIrishVocabulary";
            // 
            // txtEnglishVocabulary
            // 
            this.txtEnglishVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtEnglishVocabulary.Location = new System.Drawing.Point(300, 70);
            this.txtEnglishVocabulary.Name = "txtEnglishVocabulary";
            this.txtEnglishVocabulary.ReadOnly = true;
            this.txtEnglishVocabulary.Size = new System.Drawing.Size(150, 20);
            this.txtEnglishVocabulary.TabIndex = 13;
            this.txtEnglishVocabulary.Text = "txtEnglishVocabulary";
            // 
            // lblTopics
            // 
            this.lblTopics.Location = new System.Drawing.Point(10, 20);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(50, 16);
            this.lblTopics.TabIndex = 0;
            this.lblTopics.Text = "Topics";
            // 
            // lblVocabulary
            // 
            this.lblVocabulary.Location = new System.Drawing.Point(20, 320);
            this.lblVocabulary.Name = "lblVocabulary";
            this.lblVocabulary.Size = new System.Drawing.Size(60, 16);
            this.lblVocabulary.TabIndex = 0;
            this.lblVocabulary.Text = "Vocabulary";
            // 
            // lblIrish
            // 
            this.lblIrish.Location = new System.Drawing.Point(250, 40);
            this.lblIrish.Name = "lblIrish";
            this.lblIrish.Size = new System.Drawing.Size(50, 16);
            this.lblIrish.TabIndex = 0;
            this.lblIrish.Text = "Irish";
            // 
            // lblEnglish
            // 
            this.lblEnglish.Location = new System.Drawing.Point(250, 70);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(50, 16);
            this.lblEnglish.TabIndex = 0;
            this.lblEnglish.Text = "English";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(500, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImage
            // 
            this.lblImage.Location = new System.Drawing.Point(250, 100);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(50, 16);
            this.lblImage.TabIndex = 0;
            this.lblImage.Text = "Image";
            // 
            // txtImageIMG
            // 
            this.txtImageIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtImageIMG.Location = new System.Drawing.Point(300, 100);
            this.txtImageIMG.Multiline = true;
            this.txtImageIMG.Name = "txtImageIMG";
            this.txtImageIMG.ReadOnly = true;
            this.txtImageIMG.Size = new System.Drawing.Size(150, 150);
            this.txtImageIMG.TabIndex = 13;
            this.txtImageIMG.Text = "THIS WILL BE WHERE THE PICTURE GOES WHEN READY";
            // 
            // pbxImages
            // 
            this.pbxImages.Location = new System.Drawing.Point(300, 100);
            this.pbxImages.Name = "pbxImages";
            this.pbxImages.Size = new System.Drawing.Size(150, 150);
            this.pbxImages.TabIndex = 14;
            this.pbxImages.TabStop = false;
            // 
            // lbxVocabulary
            // 
            this.lbxVocabulary.Items.AddRange(new object[] {
            "List",
            "Of",
            "Vocabulary"});
            this.lbxVocabulary.Location = new System.Drawing.Point(10, 50);
            this.lbxVocabulary.Name = "lbxVocabulary";
            this.lbxVocabulary.Size = new System.Drawing.Size(200, 290);
            this.lbxVocabulary.TabIndex = 0;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(80, 350);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(130, 24);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "Play a Game";
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(300, 260);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 24);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "|<";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(340, 260);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 24);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(380, 260);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 24);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(420, 260);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 24);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = ">|";
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.Location = new System.Drawing.Point(240, 300);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(130, 24);
            this.btnAddTopic.TabIndex = 1;
            this.btnAddTopic.Text = "Add Topic";
            // 
            // btnAddVocabulary
            // 
            this.btnAddVocabulary.Location = new System.Drawing.Point(380, 300);
            this.btnAddVocabulary.Name = "btnAddVocabulary";
            this.btnAddVocabulary.Size = new System.Drawing.Size(130, 24);
            this.btnAddVocabulary.TabIndex = 1;
            this.btnAddVocabulary.Text = "Add Vocabulary";
            // 
            // btnCancelAddTopic
            // 
            this.btnCancelAddTopic.Location = new System.Drawing.Point(240, 330);
            this.btnCancelAddTopic.Name = "btnCancelAddTopic";
            this.btnCancelAddTopic.Size = new System.Drawing.Size(130, 24);
            this.btnCancelAddTopic.TabIndex = 1;
            this.btnCancelAddTopic.Text = "Cancel Add Topic";
            // 
            // btnCancelAddVocabulary
            // 
            this.btnCancelAddVocabulary.Location = new System.Drawing.Point(380, 330);
            this.btnCancelAddVocabulary.Name = "btnCancelAddVocabulary";
            this.btnCancelAddVocabulary.Size = new System.Drawing.Size(130, 24);
            this.btnCancelAddVocabulary.TabIndex = 1;
            this.btnCancelAddVocabulary.Text = "Cancel Add Vocabulary";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(240, 360);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(130, 24);
            this.btnAddImage.TabIndex = 1;
            this.btnAddImage.Text = "Add Image";
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Location = new System.Drawing.Point(380, 360);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(130, 24);
            this.btnDeleteImage.TabIndex = 1;
            this.btnDeleteImage.Text = "Delete Image";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 24);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(500, 40);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(130, 24);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(500, 70);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(130, 24);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit User";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTopics);
            this.Controls.Add(this.cbxTopicList);
            this.Controls.Add(this.lbxVocabulary);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.lblVocabulary);
            this.Controls.Add(this.lblIrish);
            this.Controls.Add(this.txtIrishVocabulary);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.txtEnglishVocabulary);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.pbxImages);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnAddTopic);
            this.Controls.Add(this.btnAddVocabulary);
            this.Controls.Add(this.btnCancelAddTopic);
            this.Controls.Add(this.btnCancelAddVocabulary);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnEditUser);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Declaring Combo Boxes
        private System.Windows.Forms.ComboBox cbxTopicList;
        // Declaring Text Boxes
        private System.Windows.Forms.TextBox txtIrishVocabulary;
        private System.Windows.Forms.TextBox txtEnglishVocabulary;
        // Declaring Labels
        private System.Windows.Forms.Label lblTopics;
        private System.Windows.Forms.Label lblVocabulary;
        private System.Windows.Forms.Label lblIrish;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblImage;
        //Declaring Images
        private System.Windows.Forms.TextBox txtImageIMG;
        private System.Windows.Forms.PictureBox pbxImages;
        // Declaring List Boxes
        private System.Windows.Forms.ListBox lbxVocabulary;
        // Declaring Buttons
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAddTopic;
        private System.Windows.Forms.Button btnAddVocabulary;
        private System.Windows.Forms.Button btnCancelAddVocabulary;
        private System.Windows.Forms.Button btnCancelAddTopic;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnEditUser;
    }
}

