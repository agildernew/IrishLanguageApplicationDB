namespace IrishLanguageApplicationDB
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTopics = new System.Windows.Forms.Label();
            this.lblIrish = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lbxTopics = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lblTopics
            // 
            this.lblTopics.AutoSize = true;
            this.lblTopics.Location = new System.Drawing.Point(55, 9);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(39, 13);
            this.lblTopics.TabIndex = 2;
            this.lblTopics.Text = "Topics";
            // 
            // lblIrish
            // 
            this.lblIrish.AutoSize = true;
            this.lblIrish.Location = new System.Drawing.Point(6, 45);
            this.lblIrish.Name = "lblIrish";
            this.lblIrish.Size = new System.Drawing.Size(26, 13);
            this.lblIrish.TabIndex = 3;
            this.lblIrish.Text = "Irish";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(6, 71);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(41, 13);
            this.lblEnglish.TabIndex = 4;
            this.lblEnglish.Text = "English";
            // 
            // lbxTopics
            // 
            this.lbxTopics.FormattingEnabled = true;
            this.lbxTopics.Location = new System.Drawing.Point(9, 177);
            this.lbxTopics.Name = "lbxTopics";
            this.lbxTopics.Size = new System.Drawing.Size(149, 251);
            this.lbxTopics.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxTopics);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblIrish);
            this.Controls.Add(this.lblTopics);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTopics;
        private System.Windows.Forms.Label lblIrish;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.ListBox lbxTopics;
        private System.Windows.Forms.Button button1;
    }
}

