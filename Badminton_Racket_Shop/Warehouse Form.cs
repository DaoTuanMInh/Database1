using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badminton_Racket_Shop
{
    public partial class Warehouse_Form : Form
    {
        int employeeId;
        string authorityLevel;

        public Warehouse_Form(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
        }

            private void btExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btWare_Click(object sender, EventArgs e)
        {
            WarehouseMN warehouseMN = new WarehouseMN(authorityLevel, employeeId);
            warehouseMN.Show();
            this.Hide();
        }
    }
}
