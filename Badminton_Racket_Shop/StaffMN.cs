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
    public partial class StaffMN : Form
    {
        private int employeeId;
        private string employeePosition;
        private string authorityLevel;

        public StaffMN(string employeePosition)
        {
            this.employeePosition = employeePosition;
            InitializeComponent();
            this.employeePosition = employeePosition;
        }
        private bool ValidateData(
            string employeeCode,
            string employeeName,
            string employeePosition,
            string employeeLevel,
            string employeeBirth,
            string employeephone,
            string userName,
            string password)
        {
            bool isValid = true;
            if (employeeCode == null || employeeCode == string.Empty)
            {
                MessageBox.Show(
                    "Staff code cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbCode.Focus();
                isValid = false;
            }
            else if (employeeName == null || employeeName == string.Empty)
            {
                MessageBox.Show(
                    "Staff Name cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbName.Focus();
                isValid = false;
            }
            else if (employeePosition == null || employeePosition == string.Empty)
            {
                MessageBox.Show(
                    "Staff Position cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cbRole.Focus();
                isValid = false;
            }
            else if (employeeLevel == null || employeeLevel == string.Empty)
            {
                MessageBox.Show(
                    "Staff Role cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cbRole.Focus();
                isValid = false;
            }
            else if (employeeBirth == null || employeeBirth == string.Empty)
            {
                MessageBox.Show(
                    "Staff Birth cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Birth.Focus();
                isValid = false;
            }
            else if (employeephone == null || employeephone == string.Empty)
            {
                MessageBox.Show(
                    "Staff Phone cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbPhone.Focus();
                isValid = false;
            }
            else if (userName == null || userName == string.Empty)
            {
                MessageBox.Show(
                    "User Name cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbCName.Focus();
                isValid = false;
            }
            else if (password == null || password == string.Empty)
            {
                MessageBox.Show(
                    "password cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbPass.Focus();
                isValid = false;
            }
            return isValid;
        }

        private void LoadEmployeeData()
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();

            if (connection != null)
            {
                connection.Open();

                string sql = "SELECT * FROM Employee ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql,connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tableStaff.DataSource = table;
                connection.Close();
            }
        }
        private void ClearData()
        {
            //FlushEmployeeID();
            tbCode.Text = string.Empty;
            tbName.Text = string.Empty;
            tbPosition.Text = string.Empty;
            cbRole.SelectedIndex = 0;
            tbPhone.Text = string.Empty;
            Birth.Text = string.Empty;
            tbCName.Text = string.Empty;
            tbPass.Text = string.Empty;
            tbCode.Focus();

        }
        public void InitializeCombobox()
        {
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Warehouse");
            cbRole.Items.Add("OrderItems");
            cbRole.SelectedIndex = 0;
        }
        private bool CheckExitstence(int employeeId)
        {
            bool isExist = false;
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = " SELECT * FROM Employee WHERE EmployeeID = @employeeId";
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);
                command.Parameters.AddWithValue("employeeId", employeeId);
                SqlDataReader reader = command.ExecuteReader();
                isExist = reader.HasRows;
                connection.Close();
            }
            return isExist;
        }
        private void AddUser(
            string employeeCode,
            string employeeName,
            string employeephone,
            string employeeBirth,
            string employeePosition,
            string employeeLevel,
            string userName,
            string password)
        {
            SqlConnection connection= Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open ();
                string sql = " INSERT INTO Employee Values (@employeeCode, @employeeName, @employeePhone, @employeeBirth,  @employeePostion, @authorityLevel, @username,@password,0)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("employeeCode", employeeCode);
                command.Parameters.AddWithValue("employeeName", employeeName);
                command.Parameters.AddWithValue("employeePhone", employeephone);
                command.Parameters.AddWithValue("employeeBirth", employeeBirth);
                command.Parameters.AddWithValue("employeePostion", employeePosition);
                command.Parameters.AddWithValue("authorityLevel", employeeLevel);
                command.Parameters.AddWithValue("userName", userName);
                command.Parameters.AddWithValue("password", password);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully add new user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();

                }
                else
                {
                    MessageBox.Show(
                        "Cannot add new user",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void Updateuser(
          string employeeCode,
          string employeeName,
          string employeephone,
          string employeeBirth,
          string employeePosition,
          string employeeLevel,


          string userName,
          string password)
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "UPDATE Employee SET Employeecode = @employeeCode, EmployeeName = @employeeName, EmployeePhone = @employeePhone, EmployeeBirth = @employeeBirth,  Position = @employeePosition, AuthorityLevel = @authorityLevel, Username = @username, Password = @password WHERE EmployeeID = @employeeId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("employeeCode", employeeCode);
                command.Parameters.AddWithValue("employeeName", employeeName);
                command.Parameters.AddWithValue("employeePhone", employeephone);
                command.Parameters.AddWithValue("employeeBirth", employeeBirth);
                command.Parameters.AddWithValue("employeePosition", employeePosition);
                command.Parameters.AddWithValue("authorityLevel", employeeLevel);
                command.Parameters.AddWithValue("username", userName);
                command.Parameters.AddWithValue("password", password); 
                command.Parameters.AddWithValue("employeeId", employeeId);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully update user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show(
                        "Cannot update user",
                        "Eroor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void DeleteUser(int employeeId)
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null) {
                connection.Open();
                string sql = "DELETE Employee WHERE EmployeeID = @employeeId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("employeeId", employeeId);
                    int result = command.ExecuteNonQuery();
                if (result > 0) {
                    MessageBox.Show(
                        "Successfully delete user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show(
                        "Cannot delete user",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void SearchUser(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadEmployeeData();
            }
            else
            {
                SqlConnection connection = Database_ConnectionString.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string query = "SELECT * FROM Employee WHERE EmployeeCode LIKE @search OR EmployeeName LIKE @search OR EmployeePhone LIKE @search OR EmployeeBirth LIKE @search OR Position LIKE @search OR AuthorityLevel LIKE @search OR Username LIKE @search OR Password LIKE @search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("search", "%" + search + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    tableStaff.DataSource = table;
                    connection.Close();
                }
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            switch (employeePosition)
            {
                case "Admin":
                    {
                        AD adminForm = new AD(this.employeePosition, employeeId);
                        this.Hide();
                        adminForm.Show();
                        break;
                    }
                case "Warehouse":
                    {
                        WarehouseMN warehouseManagerForm = new WarehouseMN(this.employeePosition, employeeId);
                        this.Hide();
                        warehouseManagerForm.Show();
                        break;
                    }
                case "OrderItems":
                    {
                        StaffForm saleForm = new StaffForm(this.authorityLevel, this.employeeId);
                        this.Hide();
                        saleForm.Show();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to delete this user",
                "warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteUser(employeeId);
            }
          
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            String employeeCode = tbCode.Text;
            string employeeName = tbName.Text;
            string employeePhone = tbPhone.Text;
            string employeeBirth = Birth.Text;
            string employeePosition = tbPosition.Text;
            string authorLevel = cbRole.Text;
            string username = tbCName.Text;
            string password = tbPass.Text;

            bool isValid = ValidateData(
                employeeCode,
                employeeName,
                employeePhone,
                employeeBirth,
                employeePosition,
                authorLevel,
                username,
                password);
            if (isValid)
            {
                AddUser(employeeCode, employeeName, employeePhone, employeeBirth, employeePosition, authorLevel, username, password);

            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            String employeeCode = tbCode.Text;
            string employeeName = tbName.Text;
            string employeePhone = tbPhone.Text;
            string employeeBirth = Birth.Text;
            string employeePosition = tbPosition.Text;
            string authorLevel = cbRole.Text;
            string username = tbCName.Text;
            string password = tbPass.Text;

            bool isValid = ValidateData(
                employeeCode,
                employeeName,
                employeePhone,
                employeeBirth,
                employeePosition,
                authorLevel,
                username,
                password);
            if (isValid)
            {
                Updateuser(employeeCode, employeeName, employeePhone, employeeBirth, employeePosition, authorLevel, username, password);
            }
        }

        private void StaffMN_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            InitializeCombobox();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            String search = tbSearch.Text;
            SearchUser(search);
        }

        private void tableStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = tableStaff.CurrentCell.RowIndex;
            if (index != -1)
            {
                employeeId = Convert.ToInt32(tableStaff.Rows[index].Cells[0].Value);
                //ChangeButtinStatus(true);
                tbCode.Text = tableStaff.Rows[index].Cells[1].Value.ToString();
                tbName.Text = tableStaff.Rows[index].Cells[2].Value.ToString();
                tbPhone.Text = tableStaff.Rows[index].Cells[3].Value.ToString();
                Birth.Text = tableStaff.Rows[index].Cells[4].Value.ToString();
                tbPosition.Text = tableStaff.Rows[index].Cells[5].Value.ToString();
                String authorityLevel = tableStaff.Rows[index].Cells[6].Value.ToString();
                if (authorityLevel == "Admin")
                {
                    cbRole.SelectedIndex = 0;
                }
                else if (authorityLevel == "Ware House")
                {
                    cbRole.SelectedIndex =1;
                }
                else if(authorityLevel == "Staff")
                {
                    cbRole.SelectedIndex=2;
                }
                tbCName.Text = tableStaff.Rows[index].Cells[7].Value.ToString();
                tbPass.Text = tableStaff.Rows[index].Cells[8].Value.ToString();

            }
        }

    }
    
}
