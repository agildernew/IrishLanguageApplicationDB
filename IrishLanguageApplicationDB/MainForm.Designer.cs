﻿namespace IrishLanguageApplicationDB
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
            this.btnEditVocabulary = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteTopic = new System.Windows.Forms.Button();
            this.btnDeleteVocabulary = new System.Windows.Forms.Button();
            this.btnViewLeaderboard = new System.Windows.Forms.Button();
            this.btnAmhranNabhFiann = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTopicList
            // 
            this.cbxTopicList.BackColor = System.Drawing.Color.White;
            this.cbxTopicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTopicList.Location = new System.Drawing.Point(80, 20);
            this.cbxTopicList.Name = "cbxTopicList";
            this.cbxTopicList.Size = new System.Drawing.Size(298, 26);
            this.cbxTopicList.TabIndex = 6;
            this.cbxTopicList.SelectedIndexChanged += new System.EventHandler(this.cbxTopicList_SelectedIndexChanged);
            // 
            // txtIrishVocabulary
            // 
            this.txtIrishVocabulary.BackColor = System.Drawing.Color.White;
            this.txtIrishVocabulary.Location = new System.Drawing.Point(483, 40);
            this.txtIrishVocabulary.Name = "txtIrishVocabulary";
            this.txtIrishVocabulary.ReadOnly = true;
            this.txtIrishVocabulary.Size = new System.Drawing.Size(250, 27);
            this.txtIrishVocabulary.TabIndex = 13;
            this.txtIrishVocabulary.Text = "txtIrishVocabulary";
            // 
            // txtEnglishVocabulary
            // 
            this.txtEnglishVocabulary.BackColor = System.Drawing.Color.White;
            this.txtEnglishVocabulary.Location = new System.Drawing.Point(483, 73);
            this.txtEnglishVocabulary.Name = "txtEnglishVocabulary";
            this.txtEnglishVocabulary.ReadOnly = true;
            this.txtEnglishVocabulary.Size = new System.Drawing.Size(250, 27);
            this.txtEnglishVocabulary.TabIndex = 13;
            this.txtEnglishVocabulary.Text = "txtEnglishVocabulary";
            // 
            // lblTopics
            // 
            this.lblTopics.Location = new System.Drawing.Point(10, 20);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(70, 26);
            this.lblTopics.TabIndex = 0;
            this.lblTopics.Text = "Topics";
            // 
            // lblVocabulary
            // 
            this.lblVocabulary.Location = new System.Drawing.Point(480, 14);
            this.lblVocabulary.Name = "lblVocabulary";
            this.lblVocabulary.Size = new System.Drawing.Size(108, 22);
            this.lblVocabulary.TabIndex = 0;
            this.lblVocabulary.Text = "Vocabulary";
            // 
            // lblIrish
            // 
            this.lblIrish.Location = new System.Drawing.Point(405, 40);
            this.lblIrish.Name = "lblIrish";
            this.lblIrish.Size = new System.Drawing.Size(78, 24);
            this.lblIrish.TabIndex = 0;
            this.lblIrish.Text = "Irish";
            // 
            // lblEnglish
            // 
            this.lblEnglish.Location = new System.Drawing.Point(405, 73);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(78, 24);
            this.lblEnglish.TabIndex = 0;
            this.lblEnglish.Text = "English";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(739, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(254, 28);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImage
            // 
            this.lblImage.Location = new System.Drawing.Point(405, 106);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(78, 24);
            this.lblImage.TabIndex = 0;
            this.lblImage.Text = "Image";
            // 
            // txtImageIMG
            // 
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
            this.pbxImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImages.Location = new System.Drawing.Point(483, 106);
            this.pbxImages.Name = "pbxImages";
            this.pbxImages.Size = new System.Drawing.Size(250, 250);
            this.pbxImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImages.TabIndex = 14;
            this.pbxImages.TabStop = false;
            // 
            // lbxVocabulary
            // 
            this.lbxVocabulary.BackColor = System.Drawing.Color.White;
            this.lbxVocabulary.ItemHeight = 18;
            this.lbxVocabulary.Location = new System.Drawing.Point(10, 50);
            this.lbxVocabulary.Name = "lbxVocabulary";
            this.lbxVocabulary.Size = new System.Drawing.Size(368, 364);
            this.lbxVocabulary.TabIndex = 0;
            this.lbxVocabulary.SelectedIndexChanged += new System.EventHandler(this.lbxVocabulary_SelectedIndexChanged);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.BackColor = System.Drawing.Color.White;
            this.btnPlayGame.Location = new System.Drawing.Point(246, 433);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(132, 34);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "Play a Game";
            this.btnPlayGame.UseVisualStyleBackColor = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(547, 362);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(41, 31);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(594, 362);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(41, 31);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(641, 362);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(41, 31);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(692, 362);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(41, 31);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.BackColor = System.Drawing.Color.White;
            this.btnAddTopic.Location = new System.Drawing.Point(476, 399);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(169, 33);
            this.btnAddTopic.TabIndex = 1;
            this.btnAddTopic.Text = "Add Topic";
            this.btnAddTopic.UseVisualStyleBackColor = false;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // btnEditVocabulary
            // 
            this.btnEditVocabulary.BackColor = System.Drawing.Color.White;
            this.btnEditVocabulary.Location = new System.Drawing.Point(651, 399);
            this.btnEditVocabulary.Name = "btnEditVocabulary";
            this.btnEditVocabulary.Size = new System.Drawing.Size(169, 33);
            this.btnEditVocabulary.TabIndex = 1;
            this.btnEditVocabulary.Text = "Edit Vocabulary";
            this.btnEditVocabulary.UseVisualStyleBackColor = false;
            this.btnEditVocabulary.Click += new System.EventHandler(this.btnAddVocabulary_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(811, 50);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(182, 35);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.White;
            this.btnEditUser.Location = new System.Drawing.Point(811, 169);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(182, 33);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteTopic
            // 
            this.btnDeleteTopic.BackColor = System.Drawing.Color.White;
            this.btnDeleteTopic.Location = new System.Drawing.Point(476, 438);
            this.btnDeleteTopic.Name = "btnDeleteTopic";
            this.btnDeleteTopic.Size = new System.Drawing.Size(169, 33);
            this.btnDeleteTopic.TabIndex = 15;
            this.btnDeleteTopic.Text = "Delete Topic";
            this.btnDeleteTopic.UseVisualStyleBackColor = false;
            this.btnDeleteTopic.Click += new System.EventHandler(this.btnDeleteTopic_Click);
            // 
            // btnDeleteVocabulary
            // 
            this.btnDeleteVocabulary.BackColor = System.Drawing.Color.White;
            this.btnDeleteVocabulary.Location = new System.Drawing.Point(651, 438);
            this.btnDeleteVocabulary.Name = "btnDeleteVocabulary";
            this.btnDeleteVocabulary.Size = new System.Drawing.Size(169, 33);
            this.btnDeleteVocabulary.TabIndex = 16;
            this.btnDeleteVocabulary.Text = "Delete Vocabulary";
            this.btnDeleteVocabulary.UseVisualStyleBackColor = false;
            this.btnDeleteVocabulary.Click += new System.EventHandler(this.btnDeleteVocabulary_Click);
            // 
            // btnViewLeaderboard
            // 
            this.btnViewLeaderboard.BackColor = System.Drawing.Color.White;
            this.btnViewLeaderboard.Location = new System.Drawing.Point(811, 91);
            this.btnViewLeaderboard.Name = "btnViewLeaderboard";
            this.btnViewLeaderboard.Size = new System.Drawing.Size(182, 33);
            this.btnViewLeaderboard.TabIndex = 17;
            this.btnViewLeaderboard.Text = "View Leaderboard";
            this.btnViewLeaderboard.UseVisualStyleBackColor = false;
            this.btnViewLeaderboard.Click += new System.EventHandler(this.btnViewLeaderboard_Click);
            // 
            // btnAmhranNabhFiann
            // 
            this.btnAmhranNabhFiann.BackColor = System.Drawing.Color.White;
            this.btnAmhranNabhFiann.Location = new System.Drawing.Point(811, 130);
            this.btnAmhranNabhFiann.Name = "btnAmhranNabhFiann";
            this.btnAmhranNabhFiann.Size = new System.Drawing.Size(182, 33);
            this.btnAmhranNabhFiann.TabIndex = 18;
            this.btnAmhranNabhFiann.Text = "Amhrán na bhFiann";
            this.btnAmhranNabhFiann.UseVisualStyleBackColor = false;
            this.btnAmhranNabhFiann.Click += new System.EventHandler(this.btnAmhranNabhFiann_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1003, 490);
            this.Controls.Add(this.lblTopics);
            this.Controls.Add(this.lblVocabulary);
            this.Controls.Add(this.lblIrish);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lbxVocabulary);
            this.Controls.Add(this.cbxTopicList);
            this.Controls.Add(this.txtIrishVocabulary);
            this.Controls.Add(this.txtEnglishVocabulary);
            this.Controls.Add(this.pbxImages);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnAddTopic);
            this.Controls.Add(this.btnDeleteTopic);
            this.Controls.Add(this.btnEditVocabulary);
            this.Controls.Add(this.btnDeleteVocabulary);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnViewLeaderboard);
            this.Controls.Add(this.btnAmhranNabhFiann);
            this.Controls.Add(this.btnEditUser);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Name = "MainForm";
            this.Text = "Irish Vocabulary Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Button btnEditVocabulary;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteTopic;
        private System.Windows.Forms.Button btnDeleteVocabulary;
        private System.Windows.Forms.Button btnViewLeaderboard;
        private System.Windows.Forms.Button btnAmhranNabhFiann;
    }
}

