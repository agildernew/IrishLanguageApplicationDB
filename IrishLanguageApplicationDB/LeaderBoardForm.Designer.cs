namespace IrishLanguageApplicationDB
{
    partial class LeaderBoardForm
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
            this.lblYearGroup = new System.Windows.Forms.Label();
            this.btnYear8 = new System.Windows.Forms.Button();
            this.btnYear9 = new System.Windows.Forms.Button();
            this.btnYear10 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAllYears = new System.Windows.Forms.Button();
            this.dgvLeaderBoardData = new System.Windows.Forms.DataGridView();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExerciseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderBoardData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYearGroup
            // 
            this.lblYearGroup.Location = new System.Drawing.Point(15, 15);
            this.lblYearGroup.Name = "lblYearGroup";
            this.lblYearGroup.Size = new System.Drawing.Size(781, 49);
            this.lblYearGroup.TabIndex = 0;
            this.lblYearGroup.Text = "These are the scores for the students in year xx for the topic xxxxx";
            // 
            // btnYear8
            // 
            this.btnYear8.BackColor = System.Drawing.Color.White;
            this.btnYear8.Location = new System.Drawing.Point(114, 403);
            this.btnYear8.Name = "btnYear8";
            this.btnYear8.Size = new System.Drawing.Size(96, 30);
            this.btnYear8.TabIndex = 55;
            this.btnYear8.Text = "Year 8";
            this.btnYear8.UseVisualStyleBackColor = false;
            this.btnYear8.Click += new System.EventHandler(this.btnYear8_Click);
            // 
            // btnYear9
            // 
            this.btnYear9.BackColor = System.Drawing.Color.White;
            this.btnYear9.Location = new System.Drawing.Point(216, 403);
            this.btnYear9.Name = "btnYear9";
            this.btnYear9.Size = new System.Drawing.Size(96, 30);
            this.btnYear9.TabIndex = 56;
            this.btnYear9.Text = "Year 9";
            this.btnYear9.UseVisualStyleBackColor = false;
            this.btnYear9.Click += new System.EventHandler(this.btnYear9_Click);
            // 
            // btnYear10
            // 
            this.btnYear10.BackColor = System.Drawing.Color.White;
            this.btnYear10.Location = new System.Drawing.Point(318, 403);
            this.btnYear10.Name = "btnYear10";
            this.btnYear10.Size = new System.Drawing.Size(96, 30);
            this.btnYear10.TabIndex = 57;
            this.btnYear10.Text = "Year 10";
            this.btnYear10.UseVisualStyleBackColor = false;
            this.btnYear10.Click += new System.EventHandler(this.btnYear10_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(675, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 30);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAllYears
            // 
            this.btnAllYears.BackColor = System.Drawing.Color.White;
            this.btnAllYears.Location = new System.Drawing.Point(12, 403);
            this.btnAllYears.Name = "btnAllYears";
            this.btnAllYears.Size = new System.Drawing.Size(96, 30);
            this.btnAllYears.TabIndex = 67;
            this.btnAllYears.Text = "All Years";
            this.btnAllYears.UseVisualStyleBackColor = false;
            this.btnAllYears.Click += new System.EventHandler(this.btnAllYears_Click);
            // 
            // dgvLeaderBoardData
            // 
            this.dgvLeaderBoardData.AllowUserToAddRows = false;
            this.dgvLeaderBoardData.AllowUserToDeleteRows = false;
            this.dgvLeaderBoardData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaderBoardData.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaderBoardData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Place,
            this.Score,
            this.ExerciseType,
            this.FormClass,
            this.Username});
            this.dgvLeaderBoardData.Location = new System.Drawing.Point(12, 67);
            this.dgvLeaderBoardData.MultiSelect = false;
            this.dgvLeaderBoardData.Name = "dgvLeaderBoardData";
            this.dgvLeaderBoardData.ReadOnly = true;
            this.dgvLeaderBoardData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaderBoardData.Size = new System.Drawing.Size(778, 321);
            this.dgvLeaderBoardData.TabIndex = 79;
            // 
            // Place
            // 
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // ExerciseType
            // 
            this.ExerciseType.Name = "ExerciseType";
            this.ExerciseType.ReadOnly = true;
            // 
            // FormClass
            // 
            this.FormClass.HeaderText = "Form Class";
            this.FormClass.Name = "FormClass";
            this.FormClass.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;

            this.dgvLeaderBoardData.Columns[0].Width = 60;
            this.dgvLeaderBoardData.Columns[1].Width = 60;
            this.dgvLeaderBoardData.Columns[3].Width = 120;
            // 
            // LeaderBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(799, 443);
            this.Controls.Add(this.dgvLeaderBoardData);
            this.Controls.Add(this.btnAllYears);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnYear10);
            this.Controls.Add(this.btnYear9);
            this.Controls.Add(this.btnYear8);
            this.Controls.Add(this.lblYearGroup);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Name = "LeaderBoardForm";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.LeaderBoardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderBoardData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblYearGroup;
        private System.Windows.Forms.Button btnYear8;
        private System.Windows.Forms.Button btnYear9;
        private System.Windows.Forms.Button btnYear10;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAllYears;
        private System.Windows.Forms.DataGridView dgvLeaderBoardData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerciseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
    }
}