using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IrishLanguageApplicationDB
{
    public partial class ChangePasswordForm : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;
        string userName = "", currentPassword = "", newPassword = "";

        public ChangePasswordForm(SqlConnection sqlConnection, string currentUserName)
        {
            connection = sqlConnection;
            userName = currentUserName;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Hide();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = userName;
            txtOldPassword.Focus();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text != "" && txtNewPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    connection.Open();
                    cmd = new SqlCommand("SELECT * FROM Users;", connection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (txtUsername.Text == reader["username"].ToString())
                        {
                            currentPassword = reader["password"].ToString();
                        } 
                    }
                    connection.Close();
                    if (currentPassword == txtOldPassword.Text)
                    {
                        newPassword = txtNewPassword.Text;
                        connection.Open();
                        cmd = new SqlCommand("UPDATE Users SET password = '" + newPassword + "' WHERE username = '" + userName + "';", connection);
                        reader = cmd.ExecuteReader();
                        connection.Close();

                        string message = "Your password has been changed.";
                        MessageBox.Show(message);
                    }
    
                }
                else
                {
                    string message = "Please ensure your new password matches the confirmed password.";
                    MessageBox.Show(message);
                }
            }
        }
    }
}
