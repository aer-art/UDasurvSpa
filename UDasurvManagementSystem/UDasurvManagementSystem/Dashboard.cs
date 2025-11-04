using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDasurvManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            UC_Employees employeesControl = new UC_Employees();
            addUserControl(employeesControl);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            UC_Bookings bookingsControl = new UC_Bookings();
            addUserControl(bookingsControl);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UC_Customers employeesControl = new UC_Customers();
            addUserControl(employeesControl);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            UC_Attendance attendanceControl = new UC_Attendance();
            addUserControl(attendanceControl);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            UC_Transactions transactionsControl = new UC_Transactions();
            addUserControl(transactionsControl);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            UC_Inventory inventoryControl = new UC_Inventory();
            addUserControl(inventoryControl);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
