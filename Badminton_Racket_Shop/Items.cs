using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Badminton_Racket_Shop
{
    public partial class WarehouseMN : Form
    {
        private int productId;
        private int employeeId;
        private string authorityLevel;
        private string employeePosition;

        public WarehouseMN(string authorityLevel, int employeeId)
        {
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
            this.productId = productId;
            InitializeComponent();
        }

        private void LoadCategoryCombobox()
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT CategoryID, CategoryName FROM  Category";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cbCategory.DataSource = dataTable;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";
            }
        }

        private bool ValidateData(String itemsCode, String itemsName, String price, String inventoryQuantity)
        {
            double temp;
            int temp2;
            if (string.IsNullOrEmpty(itemsName))
            {
                return false;
            }
            if (string.IsNullOrEmpty(price))
            {
                return false;
            }
            if (double.TryParse(price, out temp))
            {
                return false;
            }
            if (string.IsNullOrEmpty(inventoryQuantity))
            {
                return false;
            }
            return int.TryParse(inventoryQuantity, out temp2);
        }

        

        private void LoadProductData()
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = @"
            SELECT 
                Items.ItemsID,
                Items.ItemsCode,
                Items.ItemsName,
                Items.Price,
                Items.InventoryQuantity,
                Category.CategoryName
            FROM Items
            INNER JOIN Category ON Items.CategoryID = Category.CategoryID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                tableWareHouse.DataSource = dataTable;
                connection.Close();
            }

        }

        private void ClearData()
        {
            tbCode.Text = string.Empty;
            tbName.Text = string.Empty;
            tbPrice.Text = string.Empty;
            tbPQ.Text = string.Empty;
            tbSearch.Text = string.Empty;
        }

        private void AddProduct()
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string productCode = tbCode.Text;
                string productName = tbName.Text;       
                string price = tbPrice.Text;
                string quantity = tbPQ.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);

                    string sql = "INSERT INTO Items VALUES (" +
                    "@ItemsCode, @ItemsName, @Price, @InventoryQuantity, @CategoryID)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("ItemsCode", productCode);
                    command.Parameters.AddWithValue("ItemsName", productName);
                    command.Parameters.AddWithValue("Price", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("InventoryQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("CategoryID", categoryId);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Successfully add new product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("Cannot add new product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                connection.Close();
            }
        }

        private void UpdateProduct()
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string productCode = tbCode.Text;
                string productName = tbName.Text;
                string price = tbPrice.Text;
                string quantity = tbPQ.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
                string sql = "UPDATE Items  SET ItemsCode =  @productCode, ItemsName = @productName, Price = @productPrice, InventoryQuantity = @productQuantity, CategoryID = @categoryId WHERE ItemsID =  @productId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("productCode", productCode);
                command.Parameters.AddWithValue("productName", productName);
                command.Parameters.AddWithValue("productPrice", Convert.ToDouble(price));
                command.Parameters.AddWithValue("productQuantity", Convert.ToInt32(quantity));
                command.Parameters.AddWithValue("categoryId", categoryId);
                command.Parameters.AddWithValue("productId", this.productId);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Successfully update new product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadProductData();
                }
                else
                {
                    MessageBox.Show("Cannot update new product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void DeleteProduct()
        {

            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "DELETE Items WHERE ItemsID  = @productId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("productId", this.productId);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Successfully delete product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadProductData();
                }
                else
                {
                    MessageBox.Show("Cannot delete product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private bool IsProductInOrder(int productId)
        {
            SqlConnection connection = Database_ConnectionString.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "SELECT COUNT (*) FROM SaleDetail WHERE ItemsID = @producctId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("productId", productId);
                int result = (int)command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            return false;
        }

        private void SearchProduct(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadProductData();
            }
            else
            {
                SqlConnection connection = Database_ConnectionString.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string query = "SELECT * FROM Items WHERE ItemsCode LIKE @search OR ItemsName LIKE @search OR Price LIKE @search OR InventoryQuantity LIKE @search OR CategoryID LIKE @search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("search", "%" + search + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    tableWareHouse.DataSource = table;
                    connection.Close();
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
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
                        Warehouse_Form warehouseManagerForm = new Warehouse_Form(this.authorityLevel, employeeId);
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


        private void tableWareHouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = tableWareHouse.CurrentCell.RowIndex;
            if (index != -1)
            {
                productId = Convert.ToInt32(tableWareHouse.Rows[index].Cells[0].Value);
                tbCode.Text = tableWareHouse.Rows[index].Cells[1].Value.ToString();
                tbName.Text = tableWareHouse.Rows[index].Cells[2].Value.ToString();
                tbPrice.Text = tableWareHouse.Rows[index].Cells[3].Value.ToString();
                tbPQ.Text = tableWareHouse.Rows[index].Cells[4].Value.ToString();
                tableWareHouse.Rows[index].Cells[5].Value.ToString();
                string categoryName = tableWareHouse.Rows[index].Cells[6].Value.ToString();
                for (int i = 0; i < tableWareHouse.Rows.Count; i++)
                {
                    if (cbCategory.SelectedText == categoryName)
                    {
                        cbCategory.SelectedIndex = i;
                        break;
                    }
                }

            }
        }

        private void WareHouseMN_Load(object sender, EventArgs e)
        {
            LoadProductData();
            LoadCategoryCombobox();
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            DeleteProduct();
        }
        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            String search = tbSearch.Text;
            SearchProduct(search);
        }

    }
}
