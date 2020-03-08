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
            this.SuspendLayout();
            // 
            // lblTopicNameIrish
            // 
            this.lblTopicNameIrish.AutoSize = true;
            this.lblTopicNameIrish.Location = new System.Drawing.Point(12, 57);
            this.lblTopicNameIrish.Name = "lblTopicNameIrish";
            this.lblTopicNameIrish.Size = new System.Drawing.Size(87, 13);
            this.lblTopicNameIrish.TabIndex = 0;
            this.lblTopicNameIrish.Text = "Topic Name Irish";
            // 
            // lblTopicNameEnglish
            // 
            this.lblTopicNameEnglish.AutoSize = true;
            this.lblTopicNameEnglish.Location = new System.Drawing.Point(12, 28);
            this.lblTopicNameEnglish.Name = "lblTopicNameEnglish";
            this.lblTopicNameEnglish.Size = new System.Drawing.Size(102, 13);
            this.lblTopicNameEnglish.TabIndex = 1;
            this.lblTopicNameEnglish.Text = "Topic Name English";
            // 
            // txtTopicNameEnglish
            // 
            this.txtTopicNameEnglish.Location = new System.Drawing.Point(134, 21);
            this.txtTopicNameEnglish.Name = "txtTopicNameEnglish";
            this.txtTopicNameEnglish.Size = new System.Drawing.Size(193, 20);
            this.txtTopicNameEnglish.TabIndex = 2;
            // 
            // txtTopicNameIrish
            // 
            this.txtTopicNameIrish.Location = new System.Drawing.Point(134, 50);
            this.txtTopicNameIrish.Name = "txtTopicNameIrish";
            this.txtTopicNameIrish.Size = new System.Drawing.Size(193, 20);
            this.txtTopicNameIrish.TabIndex = 3;
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.Location = new System.Drawing.Point(252, 87);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(75, 23);
            this.btnAddTopic.TabIndex = 4;
            this.btnAddTopic.Text = "Add Topic";
            this.btnAddTopic.UseVisualStyleBackColor = true;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // AddTopicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 122);
            this.Controls.Add(this.btnAddTopic);
            this.Controls.Add(this.txtTopicNameIrish);
            this.Controls.Add(this.txtTopicNameEnglish);
            this.Controls.Add(this.lblTopicNameEnglish);
            this.Controls.Add(this.lblTopicNameIrish);
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
    }
}