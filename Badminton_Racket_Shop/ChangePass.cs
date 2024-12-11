using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badminton_Racket_Shop
{
    public partial class PassChange : Form
    {
        private string role;
        private int employeeId;
        private string employeePosition;

        public PassChange( int employeeId,string role )
        {
            this.employeeId = employeeId;
            this.role = role;
            InitializeComponent();
        }
        private void clearData()
        {
            tbNewPass.Text = string.Empty;
            tbConfirmPass.Text = string.Empty;
            tbNewPass.Focus();
        }
        private void RedirectPage(int employeeId, string authorityLevel)
        {
            if (authorityLevel == "Admin")
            {
                AD aD = new AD(authorityLevel, employeeId);
                this.Hide();
                aD.Show();
            }
            else if (authorityLevel == "Warehouse")
            {
                Warehouse_Form wareHouse = new Warehouse_Form(authorityLevel, employeeId);
                this.Hide();
                wareHouse.Show();
            }
            else if(authorityLevel == "OrderItems")
            {
                 StaffForm orderMN = new StaffForm(authorityLevel, employeeId);
                this.Hide();
                orderMN.Show();
            }
        }
        private void UpdateEmployee(int employeeId, string newPassword)
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "UPDATE Employee SET Password = @newpassword, PasswordChanged = 1 WHERE EmployeeID = @employeeId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("newPassword", newPassword);
                command.Parameters.AddWithValue("employeeId", employeeId);
                int isChanged = command.ExecuteNonQuery();
                if (isChanged > 0)
                {
                    MessageBox.Show(
                        "Successfully change password",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    RedirectPage(employeeId, role);
                }
                else
                {
                    MessageBox.Show(
                        "An error occur while change password",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    clearData();
                }
                connection.Close();
            }
        }
        private bool ValidateData(string newPassword, string confirmPassword)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show(
                    "New password connot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbNewPass.Focus();
                isValid = false;
            }
            else if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show(
                    "Confirm password cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbConfirmPass.Focus();
                isValid = false;
            }
            else if (newPassword != confirmPassword)
            {
                MessageBox.Show(
                    "New & confirm pass are not similar",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                clearData();
                isValid = false;
            }
            return isValid;

        }
        private void btChange_Click(object sender, EventArgs e)
        { 
            string newPassword = tbNewPass.Text;
            string confirmPassword = tbConfirmPass.Text;
            bool isValid = ValidateData(newPassword,confirmPassword);
            if (isValid)
            {
                UpdateEmployee(employeeId, newPassword);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
