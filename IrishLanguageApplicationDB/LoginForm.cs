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
    public partial class LoginForm : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;
        
        string userName = "", userPassword = "", userTypeIdStr = "", userType = "";
        int userTypeId = 0;

        public LoginForm(SqlConnection sqlConnection)
        {
            connection = sqlConnection;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                //connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM Users;", connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (txtUsername.Text == reader["username"].ToString())
                    {
                        userName = reader["username"].ToString();
                        userPassword = reader["password"].ToString();
                        userTypeIdStr = reader["user_type_id"].ToString();
                        userTypeId = Int16.Parse(userTypeIdStr);
                    }
                }
                connection.Close();

                if (userName.Length == 0)
                {
                    MessageBox.Show("Please enter a valid username");
                } 
                else
                {
                    connection.Open();
                    cmd = new SqlCommand("SELECT * FROM UserTypes WHERE user_type_id = " + userTypeIdStr + ";", connection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        userType = reader["user_type"].ToString();
                    }
                    connection.Close();

                    if (txtPassword.Text == userPassword)
                    {
                        this.Hide();
                        Form MainForm = new MainForm(connection, userName, userType);
                        MainForm.Closed += (s, args) => this.Close();
                        MainForm.Show();
                    }
                    else
                    {
                        string message = "Please enter a valid username and password.";
                        MessageBox.Show(message);
                    }
                }
            }
            else
            {
                string message = "Please enter a valid username and password.";
                MessageBox.Show(message);
            }
        }
    }
}
