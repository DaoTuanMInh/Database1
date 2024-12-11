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
    public partial class StaffForm : Form
    {
        private string authorityLevel;
        private int employeeId;

        public StaffForm(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }

        private void btCus_Click(object sender, EventArgs e)
        {
            CustomerMN customerMN = new CustomerMN(authorityLevel, employeeId);
            customerMN.Show();
            this.Close();
        }


        private void btExit_Click_1(object sender, EventArgs e)
        {
           Login login = new Login();
            this.Close();
        }

        private void btHis_Click(object sender, EventArgs e)
        {
            History history = new History(employeeId, authorityLevel);
            history.Show();
        }
    }
}
