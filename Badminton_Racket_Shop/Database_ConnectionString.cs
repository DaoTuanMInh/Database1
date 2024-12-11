using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace Badminton_Racket_Shop
{
    public class Database_ConnectionString
    {
        private static string _ConnectionString =
             "Data Source=MSI\\SQLEXPRESS;Initial Catalog=MINH;Integrated Security=True;";
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = null;
            try 
            {
                // lay ket noi toi csdl su dung chuoi ket noi
                connection = new SqlConnection(_ConnectionString);
            }
            //neu khong lay duoc ket noi hoac co loi say ra thi thong bao cho nguoi dung
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error while connecting to the datadase",
                    "Waring",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            // tra lai ve connection
            return connection;
        }

    }

}
