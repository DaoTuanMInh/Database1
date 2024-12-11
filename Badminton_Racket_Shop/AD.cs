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
    public partial class AD : Form
    {
        int employeeId;
        string authorityLevel;

        public AD(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btMNstaff_Click(object sender, EventArgs e)
        {
            StaffMN staffMN = new StaffMN(authorityLevel);
            staffMN.Show();
            this.Hide();
        }

        private void btMNCustomer_Click(object sender, EventArgs e)
        {
            CustomerMN customerMN = new CustomerMN(authorityLevel, employeeId);
            customerMN.Show();
            this.Close();
        }

        private void btMNWareHouse_Click(object sender, EventArgs e)
        {
            WarehouseMN wareHouseMN = new WarehouseMN(authorityLevel, employeeId);
            wareHouseMN.Show(); 
            this.Close();
        }

        private void btMNOrder_Click(object sender, EventArgs e)
        {
            WarehouseMN orderMN = new WarehouseMN(authorityLevel, employeeId);
            orderMN.Show();
            this.Close();
        }

        private void btMNimport_Click(object sender, EventArgs e)
        {
            History importMN = new History(employeeId,authorityLevel);
            importMN.Show();
            this.Close();
        }

    }
}
