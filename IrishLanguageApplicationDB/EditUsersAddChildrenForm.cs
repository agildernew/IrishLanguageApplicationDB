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
    public partial class EditUsersAddChildrenForm : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;

        string currentParentName = "", selectedUsername = "", selectedUserFormClass = "", currentChildUsername = "";
        List<string> usernames = new List<string>(), forenames = new List<string>(), surnames = new List<string>(), formclasses = new List<string>(), currentParentsChildren = new List<string>();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Hide();
        }

        private void dgvChildrensDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentChildUsername = dgvChildrensDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        public EditUsersAddChildrenForm(SqlConnection sqlConnection, string parentName)
        {
            connection = sqlConnection;
            currentParentName = parentName;
            InitializeComponent();
        }

        private void EditUsersAddChildren_Load(object sender, EventArgs e)
        {
            getChildren();

            currentChildUsername = dgvChildrensDetails.Rows[0].Cells[0].Value.ToString();
        }

        private void getChildren()
        {
            int studentUserTypeId = 0, numberOfStudents = 0;
            selectedUsername = "";
            selectedUserFormClass = "";

            usernames.Clear();
            forenames.Clear();
            surnames.Clear();
            formclasses.Clear();
            currentParentsChildren.Clear(); 

            txtParentName.Text = currentParentName;
            dgvChildrensDetails.Rows.Clear();

            connection.Open();
            cmd = new SqlCommand("SELECT * FROM UserTypes WHERE user_type = 'Student';", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                studentUserTypeId = Int32.Parse(reader["user_type_id"].ToString());
            }
            connection.Close();

            connection.Open();
            cmd = new SqlCommand("SELECT * FROM Users WHERE user_type_id = " + studentUserTypeId + ";", connection);

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usernames.Add(reader["username"].ToString());
                forenames.Add(reader["forename"].ToString());
                surnames.Add(reader["surname"].ToString());
                formclasses.Add(reader["form_class"].ToString());

                dgvChildrensDetails.Rows.Add(reader["username"].ToString(), reader["forename"].ToString(), reader["surname"].ToString(), reader["form_class"].ToString(), "");
                numberOfStudents = numberOfStudents + 1;
            }
            connection.Close();

            connection.Open();
            cmd = new SqlCommand("SELECT * FROM ParentStudent WHERE username = '" + currentParentName + "';", connection);

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                currentParentsChildren.Add(reader["student_username"].ToString());
            }
            connection.Close();

            Boolean[] currentChildIsParentsChild = new Boolean[usernames.Count];

            for (int i = 0; i < currentChildIsParentsChild.Length; i++)
            {
                currentChildIsParentsChild[i] = false;
            }

            for (int i = 0; i < currentParentsChildren.Count; i++)
            {

                for (int j = 0; j < usernames.Count; j++)
                {
                    if (currentParentsChildren[i] == usernames[j])
                    {
                        currentChildIsParentsChild[j] = true;
                    }
                }
            }

            for (int i = 0; i < usernames.Count; i++)
            {
                dgvChildrensDetails.Rows[i].Cells[4].Value = currentChildIsParentsChild[i];

            }
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            bool isAlreadyChildOfParent = false;

            for (int i = 0; i < currentParentsChildren.Count; i++)
            {
                if (currentChildUsername == currentParentsChildren[i])
                {
                    isAlreadyChildOfParent = true;
                }
            }

            if (!isAlreadyChildOfParent)
            {
                connection.Open();
                cmd = new SqlCommand("INSERT INTO ParentStudent (username, student_username) VALUES ('" + currentParentName + "', '" + currentChildUsername + "');", connection);

                reader = cmd.ExecuteReader();
                connection.Close();
                string message = currentParentName + " has been added as a parent of " + currentChildUsername;
                MessageBox.Show(message);
            }
            else
            {
                string message = currentParentName + " is already marked as a parent to " + currentChildUsername;
                MessageBox.Show(message);
            }

            currentChildUsername = dgvChildrensDetails.Rows[0].Cells[0].Value.ToString();

            getChildren();

        }

        private void btnDeleteChild_Click(object sender, EventArgs e)
        {
            bool isAlreadyChildOfParent = true;

            for (int i = 0; i < currentParentsChildren.Count; i++)
            {
                if (currentChildUsername == currentParentsChildren[i])
                {
                    isAlreadyChildOfParent = false;
                }
            }

            if (!isAlreadyChildOfParent)
            {
                connection.Open();
                cmd = new SqlCommand("DELETE FROM ParentStudent WHERE username = '" + currentParentName + "' AND student_username ='" + currentChildUsername + "';", connection);

                reader = cmd.ExecuteReader();
                connection.Close();
                string message = currentParentName + " has been removed as a parent of " + currentChildUsername;
                MessageBox.Show(message);
            }
            else
            {
                string message = currentParentName + " is not marked as a parent to " + currentChildUsername;
                MessageBox.Show(message);
            }

            currentChildUsername = dgvChildrensDetails.Rows[0].Cells[0].Value.ToString();

            getChildren();
        }
    }
}
