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
    public partial class History : Form
    {
        private int employeeId;
        private string authorityLevel;

        public History(int employeeId, string authorityLevel)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.authorityLevel = authorityLevel;
        }
        private void RedirectPage()
        {
            switch (this.authorityLevel)
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
        private void LoadOrderHistory()
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = @"
                    SELECT 
                        Sale.SaleDate, 
                        Employee.EmployeeName, 
                        Customer.CustomerName
                    FROM Sale
                    INNER JOIN Employee ON Sale.EmployeeID = Employee.EmployeeID
                    INNER JOIN Customer ON Sale.CustomerID = Customer.CustomerID";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgOrderHistory.DataSource = dataTable;

                connection.Close();
            }
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            RedirectPage();
        }
        private void History_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

    }
}
