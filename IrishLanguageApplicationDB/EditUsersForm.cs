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
        SqlConnection connection = new SqlConnection();

        List<string> usernames = new List<string>();
        List<string> firstnames = new List<string>();
        List<string> surnames = new List<string>();
        List<string> passwords = new List<string>();
        List<string> usertypes = new List<string>();
        List<string> formclass = new List<string>();
        string message;
        bool isNewUser = false;
        int index = 0;

        int numberOfUsers = 0;
        string currentUser = "", currentUserType = "", editUserTypeId = "", editUserType = "";

        public EditUsersForm(string username, string userType)
        {
            currentUser = username;
            currentUserType = userType;
            InitializeComponent();
        }

        private void EditUsersForm_Load(object sender, EventArgs e)
        {
            btnCancel.Hide();

            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            connection.Open();
            SqlCommand cmd;

            if (currentUserType == "Admin")
            {
                cmd = new SqlCommand("SELECT * FROM Users", connection);
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM Users WHERE user_type_id <> 1;", connection);
            }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usernames.Add(reader["user_id"].ToString());
                firstnames.Add(reader["forename"].ToString());
                surnames.Add(reader["surname"].ToString());
                passwords.Add(reader["password"].ToString());
                usertypes.Add(reader["user_type_id"].ToString());
                formclass.Add(reader["form_class"].ToString());

                usernames.ToArray();
                numberOfUsers = numberOfUsers + 1;
            }
            connection.Close();

            if (currentUserType == "Teacher")
            {
                btnAddUser.Hide();
                btnDeleteUser.Hide();
                txtFirstName.ReadOnly = true;
                txtSurname.ReadOnly = true;
                cbxUserType.Enabled = false;
                txtFormClass.ReadOnly = true;
            }
            loadUsers(index);
        }

        private void loadUsers(int newIndex)
        {
            txtUsername.Text = usernames[newIndex];
            txtFirstName.Text = firstnames[newIndex];
            txtSurname.Text = surnames[newIndex];
            txtPassword.Text = passwords[newIndex];
            txtConfirmPassword.Text = passwords[newIndex];
            cbxUserType.Text = usertypes[newIndex];
            txtFormClass.Text = formclass[newIndex];

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserTypes;", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            cbxUserType.Items.Clear();
            while (reader.Read())
            {
                cbxUserType.Items.Add(reader["user_type"].ToString());
            }

            connection.Close();

            connection.Open();
            editUserTypeId = cbxUserType.Text;

            cmd = new SqlCommand("SELECT * FROM UserTypes WHERE user_type_id = " + editUserTypeId + ";", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                editUserType = reader["user_type"].ToString();
            }

            cbxUserType.Text = editUserType;
            connection.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            isNewUser = true;
            txtUsername.Text = "";
            txtFirstName.Text = "";
            txtSurname.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtFormClass.Text = "";
            cbxUserType.SelectedIndex = 2;

            btnAddUser.Hide();
            btnCancel.Show();

            txtUsername.ReadOnly = false;
            btnDeleteUser.Enabled = false;
            btnFirst.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadUsers(index);

            isNewUser = false;
            btnAddUser.Show();
            btnCancel.Hide();

            txtUsername.ReadOnly = true;
            btnDeleteUser.Enabled = true;
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
        }

        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtConfirmPassword_GotFocus(object sender, EventArgs e)
        {
            txtConfirmPassword.SelectAll();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" & txtFirstName.Text != "" & txtSurname.Text != "" & txtPassword.Text != "" & txtConfirmPassword.Text != "" & cbxUserType.Text != "")
            {
                bool userExists = false;
                if (txtPassword.Text == txtConfirmPassword.Text)
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
                    if (isNewUser)
                    {
                        for (int i = 0; i < numberOfUsers; i++)
                        {
                            if (txtUsername.Text == usernames[i])
                            {
                                message = "Username " + txtUsername.Text + " already exists. Please enter a unique username";
                                MessageBox.Show(message);
                                userExists = true;
                            }
                        }

                        if (userExists == false)
                        {
                            if (txtFormClass.Text != "")
                            {
                                cmd = new SqlCommand("INSERT INTO Users (user_id, user_type_id, forename, surname, password, form_class) VALUES ('" + txtUsername.Text + "', " + userTypeId + ", '" + txtFirstName.Text + "', '" + txtSurname.Text + "','" + txtPassword.Text + "', '" + txtFormClass.Text + "');", connection);
                            }
                            else
                            {
                                cmd = new SqlCommand("INSERT INTO Users (user_id, user_type_id, forename, surname, password) VALUES ('" + txtUsername.Text + "', " + userTypeId + ", '" + txtFirstName.Text + "', '" + txtSurname.Text + "','" + txtPassword.Text + "');", connection);
                            }

                            message = "User " + txtUsername.Text + " has been added";
                            MessageBox.Show(message);
                        }
                    }
                    else
                    {
                        if (txtFormClass.Text != "")
                        {
                            cmd = new SqlCommand("UPDATE Users SET forename = '" + txtFirstName.Text + "', surname = '" + txtSurname.Text + "', password = '" + txtPassword.Text + "', form_class = '" + txtFormClass.Text + "', user_type_id = '" + userTypeId + "' WHERE user_id = '" + txtUsername.Text + "';", connection);
                        }
                        else
                        {
                            cmd = new SqlCommand("UPDATE Users SET forename = '" + txtFirstName.Text + "', surname = '" + txtSurname.Text + "', password = '" + txtPassword.Text + "', user_type_id = '" + userTypeId + "' WHERE user_id = '" + txtUsername.Text + "';", connection);
                        }

                        message = "User " + txtUsername.Text + "'s data has been updated";
                        MessageBox.Show(message);
                    }

                    reader = cmd.ExecuteReader();
                    connection.Close();

                }
                else
                {
                    message = "Please ensure the new password and confirm password match";
                    MessageBox.Show(message);
                }
            }
            else
            {
                message = "Please enter data for all required fields (marked with *)";
                MessageBox.Show(message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"C:\\Users\\Ryan Skillen\\Documents\\GitHub\\IrishLanguageApplicationDB\\IrishLanguageApplicationDB\\IrishAppDB.mdf\"; Integrated Security = True";
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE user_id = '" + txtUsername.Text + "'", connection);

            usernames.RemoveAt(index);
            firstnames.RemoveAt(index);
            surnames.RemoveAt(index);
            passwords.RemoveAt(index);
            usertypes.RemoveAt(index);
            formclass.RemoveAt(index);

            index = index - 1;
            loadUsers(index);

            usernames.ToArray();

            SqlDataReader reader = cmd.ExecuteReader();
            connection.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            loadUsers(index);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index = usernames.IndexOf(txtUsername.Text);
            if (index != 0)
            {
                index = index - 1;
                loadUsers(index);
            }
            else
            {
                loadUsers(index);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //index = usernames.IndexOf(txtUsername.Text);
            if (index != numberOfUsers - 1)
            {
                index = index + 1;
                loadUsers(index);
            }
            else
            {
                loadUsers(index);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = usernames.Count() - 1;
            loadUsers(index);
        }
    }
}
