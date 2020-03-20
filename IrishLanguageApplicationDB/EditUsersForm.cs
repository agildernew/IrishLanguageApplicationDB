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
    public partial class EditUsersForm : Form
    {
        List<string> usernames = new List<string>();
        List<string> firstnames = new List<string>();
        List<string> surnames = new List<string>();
        List<string> passwords = new List<string>();
        List<string> usertypes = new List<string>();
        List<string> formclass = new List<string>();
        int numberOfUsers = 0;

        public EditUsersForm()
        {
            InitializeComponent();
        }

        private void EditUsersForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users;", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usernames.Add(reader["user_id"].ToString());
                firstnames.Add(reader["forename"].ToString());
                surnames.Add(reader["surname"].ToString());
                passwords.Add(reader["password"].ToString());
                usertypes.Add(reader["user_type_id"].ToString());
                usertypes.Add(reader["form_class"].ToString());

                usernames.ToArray();
                numberOfUsers = numberOfUsers + 1;
            }
            connection.Close();

            loadUsers(0);
        }

        private void loadUsers(int newIndex)
        {
                txtUsername.Text = usernames[newIndex];
                txtFirstName.Text = firstnames[newIndex];
                txtSurname.Text = surnames[newIndex];
                txtPassword.Text = passwords[newIndex];
                txtConfirmPassword.Text = passwords[newIndex];
                cbxUserType.Text = usertypes[newIndex];
        }

        /*private void loadUsers(int newIndex)
        {
            if (!(newIndex > usernames.IndexOf(txtUsername.Text)) && !(newIndex < 0))
            {
                newIndex = newIndex + 1;
            }

            if (newIndex > 0)
            {
                txtUsername.Text = usernames[newIndex];
                txtFirstName.Text = firstnames[newIndex];
                txtSurname.Text = surnames[newIndex];
                txtPassword.Text = passwords[newIndex];
                txtConfirmPassword.Text = passwords[newIndex];
                cbxUserType.Text = usertypes[newIndex];
            };
        }*/

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtFirstName.Text = "";
            txtSurname.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserTypes;", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbxUserType.Items.Add(reader["user_type"].ToString());
            }
            cbxUserType.SelectedIndex = 2;
            connection.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" & txtFirstName.Text != "" & txtSurname.Text != "" & txtPassword.Text != "" & txtConfirmPassword.Text != "" & cbxUserType.Text != "")
            {
                string userTypeId = "";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserTypes WHERE user_type = '" + cbxUserType.Text + "';", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userTypeId = reader["user_type_id"].ToString();
                }
                connection.Close();

                connection.Open();
                if (txtFormClass.Text != "")
                {
                    cmd = new SqlCommand("INSERT INTO Users (user_id, user_type_id, forename, surname, password, form_class) VALUES ('" + txtUsername.Text + "', " + userTypeId + ", '" + txtFirstName.Text + "', '" + txtSurname.Text + "','" + txtPassword.Text + "', '" + txtFormClass.Text + "');", connection);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Users (user_id, user_type_id, forename, surname, password) VALUES ('" + txtUsername.Text + "', " + userTypeId + ", '" + txtFirstName.Text + "', '" + txtSurname.Text + "','" + txtPassword.Text + "');", connection);
                }
                reader = cmd.ExecuteReader();
                connection.Close();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE user_id = '" + txtUsername.Text + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            loadUsers(0);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int index = usernames.IndexOf(txtUsername.Text);
            if (index != 0)
            {
                loadUsers(index - 1);
            } 
            else
            {
                loadUsers(index);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = usernames.IndexOf(txtUsername.Text);
            if (index != numberOfUsers-1)
            {
                loadUsers(index + 1);
            }
            else
            {
                loadUsers(index);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int index = usernames.Count()-1;
            loadUsers(index);
        }
    }
}
