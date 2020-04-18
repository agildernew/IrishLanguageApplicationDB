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
            this.lblParentName = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvChildrensDetails = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Child = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(12, 19);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(127, 18);
            this.lblParentName.TabIndex = 0;
            this.lblParentName.Text = "Parent\'s Name";
            // 
            // txtParentName
            // 
            this.txtParentName.BackColor = System.Drawing.Color.White;
            this.txtParentName.Enabled = false;
            this.txtParentName.Location = new System.Drawing.Point(145, 10);
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(551, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.Child});
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
            this.FormClass.Name = "FormClass";
            this.FormClass.ReadOnly = true;
            // 
            // Child
            // 
            this.Child.Name = "Child";
            this.Child.ReadOnly = true;
            // 
            // EditUsersAddChildren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(685, 432);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Controls.Add(btnDeleteChild);
            this.Controls.Add(this.dgvChildrensDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.lblParentName);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Name = "EditUsersAddChildren";
            this.Text = "EditUsersAddChildren";
            this.Load += new System.EventHandler(this.EditUsersAddChildren_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildrensDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnCancel;
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
    }
}