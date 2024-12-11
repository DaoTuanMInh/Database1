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
using static System.Net.Mime.MediaTypeNames;

namespace Badminton_Racket_Shop
{
    public partial class CustomerMN : Form
    {
        private int customerId;
        private int employeeId;
        private string authorityLevel;
        private string employeePosition;

        public CustomerMN(string authorityLevel, int employeeId)
        {
            employeeId = 0;
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }
        private bool ValidateData(string customerCode, string customerName, string Phonenumber, string customerBirth, string customerAddress)
        {
            bool isValid = true;
            if (customerCode == null || customerCode == string.Empty)
            {
                MessageBox.Show(
                    "Customer Code cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isValid = false;
                tbCode.Focus();
            }
            else if (customerName == null || customerName == string.Empty)
            {
                MessageBox.Show(
                    "Customer Name cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isValid = false;
                tbName.Focus();
            }
            else if (Phonenumber == null || Phonenumber == string.Empty)
            {
                MessageBox.Show(
                    "Customer Phonenumber cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isValid = false;
                tbPhone.Focus();
            }
            else if (customerBirth == null || customerBirth == string.Empty)
            {
                MessageBox.Show(
                    "Customer Birth cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isValid = false;
                tbBirth.Focus();
            }
            else if (customerAddress == null || customerAddress == string.Empty)
            {
                MessageBox.Show(
                    "Customer Address cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isValid = false;
                tbAddress.Focus();
            }
            return isValid;
        }
        private void LoadCustomerData()
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT * FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                tableCustomer.DataSource = table;
                connection.Close();
            }
        }
        private bool CheckUserExistence(int customerId)
        {
            bool isExist = false;
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM Customer WHERE CustomerID = @customerId";
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);
                command.Parameters.AddWithValue("customerId", customerId);
                SqlDataReader reader = command.ExecuteReader();
                isExist = reader.HasRows;
                connection.Close();
            }
            return isExist;
        }
        private void AddCustomer(string customerCode, string customerName, string Phonenumber, string customerBirth, string customerAddress)
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = " INSERT INTO Customer ( CustomerCode, CustomerName, Phonenumber, customerBirth, Address) Values (@customerCode, @customerName, @phoneNumber, @customerBirth, @customerAddress)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("customerCode", customerCode);
                command.Parameters.AddWithValue("customerName", customerName);
                command.Parameters.AddWithValue("Phonenumber", Phonenumber);
                command.Parameters.AddWithValue("customerBirth", customerBirth);
                command.Parameters.AddWithValue("customerAddress", customerAddress);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Succesfully add new customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show(
                        "An error occur while adding customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
                ClearData(); 
                LoadCustomerData();
            }
        }
        private void updateCustomer(string customerCode, string customerName, string Phonenumber, string customerBirth, string customerAddress)
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null) {
                connection.Open();
                string query = "UPDATE Customer SET CustomerCode = @customerCode, CustomerName = @customerName, Phonenumber = @phoneNumber, CustomerBirth = @customerBirth, Address = @customerAddress WHERE CustomerID = @customerId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("customerCode", customerCode);
                command.Parameters.AddWithValue("customerName", customerName);
                command.Parameters.AddWithValue("Phonenumber", Phonenumber);
                command.Parameters.AddWithValue("customerBirth", customerBirth);
                command.Parameters.AddWithValue("customerAddress", customerAddress);
                command.Parameters.AddWithValue("customerId", customerId);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully update customer",
                        "Succes",

                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "An error occur while updating customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
                ClearData();
                LoadCustomerData();
            }
        }
        private void ClearData()
        {
            tbCode.Text = string.Empty;
            tbName.Text = string.Empty;
            tbBirth.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbCode.Focus();

        }
        private void DeleteCustomer(int customerId)
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string deleteOderDetaiQuery = "DELETE SaleDetail WHERE SaleDetailID IN (SELECT SaleID FROM Sale WHERE CustomerID = @customerId)";
                SqlCommand command = new SqlCommand(deleteOderDetaiQuery, connection);
                command.Parameters.AddWithValue("customerId",customerId);
                command.ExecuteNonQuery();

                string deleteOrderQuery = "DELETE Sale WHERE CustomerID = @customerId";
                command = new SqlCommand(deleteOrderQuery, connection);
                command.Parameters.AddWithValue("customerId", customerId);
                command.ExecuteNonQuery();

                string deleteCustomerQuery = "DELETE Customer WHERE CustomerID = @customerId";
                command = new SqlCommand(deleteCustomerQuery, connection);
                command.Parameters.AddWithValue("customerId", customerId);
                int deleteCustomerResult = command.ExecuteNonQuery();
                if (deleteCustomerResult > 0)
                {
                    MessageBox.Show(
                        "Successfully delete customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "An error while deleting customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
                ClearData();
                LoadCustomerData();
            }
        }
        private void Searchcustomer(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadCustomerData();
            }
            else
            {
                SqlConnection connection = Database_ConnectionString.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string query = "SELECT * FROM Customer WHERE CustomerCode LIKE @search OR CustomerName LIKE @search OR Phonenumber LIKE @search OR CustomerBirth LIKE @search OR Address LIKE @search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("search", "%" + search + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    tableCustomer.DataSource = table;
                    connection.Close();
                }
            }
        }

        private void CustomerMN_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string customerCode = tbCode.Text;
            string customerName = tbName.Text;
            string phoneNumber = tbPhone.Text;
            string customerBirth = tbBirth.Text;
            string customerAddress = tbAddress.Text;

            bool isVailid = ValidateData(customerCode, customerName, phoneNumber, customerBirth, customerAddress);
            if (isVailid)
            {
                AddCustomer(customerCode, customerName, phoneNumber, customerBirth, customerAddress);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
           string customerCode = tbCode.Text;
           string customerName = tbName.Text;
           string phoneNumber = tbPhone.Text;
           string customerBirth = tbBirth.Text;
           string customerAddress = tbAddress.Text;
           bool isValid = ValidateData(
              customerCode,
              customerName,
              phoneNumber,
              customerBirth,
              customerAddress);
           if (isValid)
           {
           updateCustomer(customerCode,customerName, phoneNumber, customerBirth, customerAddress);
           }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (customerId > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Do you want to delete this customer with all related data?",
                    "Waring",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    bool isUserExist = CheckUserExistence(customerId);
                    if (isUserExist)
                    {
                        DeleteCustomer(customerId);
                    }
                    else
                    {
                        MessageBox.Show(
                            "No customer found",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void btExit_Click(object sender, EventArgs e)
        {
            switch (authorityLevel)
            {
                case "Admin":
                    {
                        AD adminForm = new AD(this.authorityLevel, employeeId);
                        this.Hide();
                        adminForm.Show();
                        break;
                    }
                case "Warehouse":
                    {
                        WarehouseMN warehouseManagerForm = new WarehouseMN(this.authorityLevel, employeeId);
                        this.Hide();
                        warehouseManagerForm.Show();
                        break;
                    }
                case "OrderItems":
                    {
                        StaffForm saleForm = new StaffForm(this.authorityLevel, employeeId);
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

        private void tableCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = tableCustomer.CurrentCell.RowIndex;
            if (index > -1)
            {
                customerId = (int)tableCustomer.Rows[index].Cells[0].Value;
                tbCode.Text = tableCustomer.Rows[index].Cells[1].Value.ToString();
                tbName.Text = tableCustomer.Rows[index].Cells[2].Value.ToString();
                tbPhone.Text = tableCustomer.Rows[index].Cells[3].Value.ToString();
                tbBirth.Text = tableCustomer.Rows[index].Cells[4].Value.ToString();
                tbAddress.Text = tableCustomer.Rows[index].Cells[5].Value.ToString();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            String search = tbSearch.Text;
            Searchcustomer(search);
        }
    }
}
