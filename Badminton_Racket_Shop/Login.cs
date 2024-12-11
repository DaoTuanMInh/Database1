using Azure.Core.Pipeline;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badminton_Racket_Shop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool validateData(string username, string password, string role)
        {
            bool isvalid = true;
            if (username == null || username == string.Empty)
            {
                MessageBox.Show(
                    "Username cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isvalid = false;
                tbName.Focus();

            }
            else if (password == null || password == string.Empty)
            {
                MessageBox.Show(
                    "Password cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isvalid = false;
                tbPass.Focus();

            }
            else if (role == null || role == string.Empty)
            {
                MessageBox.Show(
                    "No role selected",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isvalid = false;
                cbType.Focus();
            }
            return isvalid;
        }
        private void RedirectPage(string selectedRole, int employeeID, bool isChangePassWord)
        {
            if (isChangePassWord)
            {
                if (selectedRole != null)
                {
                    if (selectedRole == "Admin")
                    {
                        AD aD = new AD(selectedRole, employeeID);
                        this.Hide();
                        aD.Show();
                    }
                    else if (selectedRole == "Warehouse")
                    {
                        WarehouseMN wareHouse = new WarehouseMN(selectedRole, employeeID);
                        this.Hide();
                        wareHouse.Show();
                    }
                    else if (selectedRole == "OrderItems")
                    {
                        StaffForm items = new StaffForm(selectedRole, employeeID);
                        items.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                PassChange passChange = new PassChange(employeeID,selectedRole);
                passChange.Show();
                this.Hide();
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string password = tbPass.Text;
            string role = cbType.SelectedItem.ToString();

            bool isValid = validateData(username, password, role);
            if (isValid)
            {
                SqlConnection connection = Database_ConnectionString.GetConnection();
                if( connection != null)
                {
                    string query = "Select EmployeeID, PasswordChanged From Employee Where Username = @username and Password = @password and AuthorityLevel = @role";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);
                    command.Parameters.AddWithValue("role", role);

                    SqlDataReader reader = command.ExecuteReader();
                    int employeeID = 2;
                    bool passwordchanged = false;
                    while (reader.Read())
                    {
                        employeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                        passwordchanged = reader.GetBoolean(reader.GetOrdinal("PasswordChanged"));
                    }
                    if( employeeID > 0)
                    {
                        MessageBox.Show(
                            "Login success",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information );
                        RedirectPage(role, employeeID, passwordchanged);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Invalid login credential",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error );
                            ClearData();
                    }
                    connection.Close();
                }
            }
        }
        
        private void ClearData()
        {

        }
        private void btClear_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbPass.Clear();
            cbType.Text = "";
            tbName.Focus();
        }

    }

}
