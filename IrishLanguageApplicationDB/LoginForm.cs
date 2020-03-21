﻿using System;
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
    public partial class LoginForm : Form
    {
        string userPassword = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
                //connection.ConnectionString = Properties.Settings.Default.IrishAppDBConnectionString;
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users;", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (txtUsername.Text == reader["user_id"].ToString())
                    {
                        userPassword = reader["password"].ToString();
                    }
                }

                if (txtPassword.Text == userPassword)
                {
                    this.Hide();
                    Form MainForm = new MainForm(txtUsername.Text);
                    MainForm.Closed += (s, args) => this.Close();
                    MainForm.Show();
                }
                else
                {
                    string message = "Please enter a valid username and password.";
                    MessageBox.Show(message);
                }
                connection.Close();
            }
            else
            {
                string message = "Please enter a valid username and password.";
                MessageBox.Show(message);
            }
        }
    }
}
