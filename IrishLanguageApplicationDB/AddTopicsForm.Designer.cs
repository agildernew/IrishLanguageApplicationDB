namespace IrishLanguageApplicationDB
{
    partial class AddTopicsForm
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
            this.lblTopicNameIrish = new System.Windows.Forms.Label();
            this.lblTopicNameEnglish = new System.Windows.Forms.Label();
            this.txtTopicNameEnglish = new System.Windows.Forms.TextBox();
            this.txtTopicNameIrish = new System.Windows.Forms.TextBox();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTopicNameIrish
            // 
            this.lblTopicNameIrish.AutoSize = true;
            this.lblTopicNameIrish.Location = new System.Drawing.Point(12, 61);
            this.lblTopicNameIrish.Name = "lblTopicNameIrish";
            this.lblTopicNameIrish.Size = new System.Drawing.Size(145, 18);
            this.lblTopicNameIrish.TabIndex = 0;
            this.lblTopicNameIrish.Text = "Topic Name Irish";
            // 
            // lblTopicNameEnglish
            // 
            this.lblTopicNameEnglish.AutoSize = true;
            this.lblTopicNameEnglish.Location = new System.Drawing.Point(12, 28);
            this.lblTopicNameEnglish.Name = "lblTopicNameEnglish";
            this.lblTopicNameEnglish.Size = new System.Drawing.Size(167, 18);
            this.lblTopicNameEnglish.TabIndex = 1;
            this.lblTopicNameEnglish.Text = "Topic Name English";
            // 
            // txtTopicNameEnglish
            // 
            this.txtTopicNameEnglish.BackColor = System.Drawing.Color.White;
            this.txtTopicNameEnglish.Location = new System.Drawing.Point(185, 25);
            this.txtTopicNameEnglish.Name = "txtTopicNameEnglish";
            this.txtTopicNameEnglish.Size = new System.Drawing.Size(229, 27);
            this.txtTopicNameEnglish.TabIndex = 2;
            // 
            // txtTopicNameIrish
            // 
            this.txtTopicNameIrish.BackColor = System.Drawing.Color.White;
            this.txtTopicNameIrish.Location = new System.Drawing.Point(185, 58);
            this.txtTopicNameIrish.Name = "txtTopicNameIrish";
            this.txtTopicNameIrish.Size = new System.Drawing.Size(229, 27);
            this.txtTopicNameIrish.TabIndex = 3;
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.BackColor = System.Drawing.Color.White;
            this.btnAddTopic.Location = new System.Drawing.Point(210, 91);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(99, 28);
            this.btnAddTopic.TabIndex = 4;
            this.btnAddTopic.Text = "Add Topic";
            this.btnAddTopic.UseVisualStyleBackColor = false;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(315, 91);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddTopicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(432, 133);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddTopic);
            this.Controls.Add(this.txtTopicNameIrish);
            this.Controls.Add(this.txtTopicNameEnglish);
            this.Controls.Add(this.lblTopicNameEnglish);
            this.Controls.Add(this.lblTopicNameIrish);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Name = "AddTopicsForm";
            this.Text = "AddTopicsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopicNameIrish;
        private System.Windows.Forms.Label lblTopicNameEnglish;
        private System.Windows.Forms.TextBox txtTopicNameEnglish;
        private System.Windows.Forms.TextBox txtTopicNameIrish;
        private System.Windows.Forms.Button btnAddTopic;
        private System.Windows.Forms.Button btnClose;
    }
}