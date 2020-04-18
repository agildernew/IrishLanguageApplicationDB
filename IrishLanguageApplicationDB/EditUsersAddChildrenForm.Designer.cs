namespace IrishLanguageApplicationDB
{
    partial class EditUsersAddChildrenForm
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
            System.Windows.Forms.Button btnDeleteChild;
            this.lblParentUserName = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvChildrensDetails = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsChild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnDeleteChild = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildrensDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteChild
            // 
            btnDeleteChild.BackColor = System.Drawing.Color.White;
            btnDeleteChild.Location = new System.Drawing.Point(423, 391);
            btnDeleteChild.Name = "btnDeleteChild";
            btnDeleteChild.Size = new System.Drawing.Size(122, 28);
            btnDeleteChild.TabIndex = 7;
            btnDeleteChild.Text = "Delete Child";
            btnDeleteChild.UseVisualStyleBackColor = false;
            btnDeleteChild.Click += new System.EventHandler(this.btnDeleteChild_Click);
            // 
            // lblParentUserName
            // 
            this.lblParentUserName.AutoSize = true;
            this.lblParentUserName.Location = new System.Drawing.Point(12, 19);
            this.lblParentUserName.Name = "lblParentUserName";
            this.lblParentUserName.Size = new System.Drawing.Size(170, 18);
            this.lblParentUserName.TabIndex = 0;
            this.lblParentUserName.Text = "Parent\'s User Name";
            // 
            // txtParentName
            // 
            this.txtParentName.BackColor = System.Drawing.Color.White;
            this.txtParentName.Enabled = false;
            this.txtParentName.Location = new System.Drawing.Point(188, 10);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(262, 27);
            this.txtParentName.TabIndex = 1;
            // 
            // btnAddChild
            // 
            this.btnAddChild.BackColor = System.Drawing.Color.White;
            this.btnAddChild.Location = new System.Drawing.Point(295, 391);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(122, 28);
            this.btnAddChild.TabIndex = 3;
            this.btnAddChild.Text = "Add Child";
            this.btnAddChild.UseVisualStyleBackColor = false;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(551, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvChildrensDetails
            // 
            this.dgvChildrensDetails.AllowUserToAddRows = false;
            this.dgvChildrensDetails.AllowUserToDeleteRows = false;
            this.dgvChildrensDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChildrensDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvChildrensDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChildrensDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Forename,
            this.Surname,
            this.FormClass,
            this.IsChild});
            this.dgvChildrensDetails.Location = new System.Drawing.Point(18, 51);
            this.dgvChildrensDetails.MultiSelect = false;
            this.dgvChildrensDetails.Name = "dgvChildrensDetails";
            this.dgvChildrensDetails.ReadOnly = true;
            this.dgvChildrensDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChildrensDetails.Size = new System.Drawing.Size(655, 321);
            this.dgvChildrensDetails.TabIndex = 6;
            this.dgvChildrensDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChildrensDetails_CellContentClick);
            // 
            // Username
            // 
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Forename
            // 
            this.Forename.Name = "Forename";
            this.Forename.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // FormClass
            // 
            this.FormClass.HeaderText = "Form Class";
            this.FormClass.Name = "FormClass";
            this.FormClass.ReadOnly = true;
            // 
            // IsChild
            // 
            this.IsChild.HeaderText = "Is Child?";
            this.IsChild.Name = "IsChild";
            this.IsChild.ReadOnly = true;
            // 
            // EditUsersAddChildrenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(685, 432);
            this.Controls.Add(btnDeleteChild);
            this.Controls.Add(this.dgvChildrensDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.lblParentUserName);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditUsersAddChildrenForm";
            this.Text = "Add Children";
            this.Load += new System.EventHandler(this.EditUsersAddChildren_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildrensDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParentUserName;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvChildrensDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Child;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsChild;
    }
}