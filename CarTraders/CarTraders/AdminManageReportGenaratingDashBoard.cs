using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class AdminManageReportGenaratingDashBoard : Form
    {
        public AdminManageReportGenaratingDashBoard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminManageReportGenarateCars carsDetails = new AdminManageReportGenarateCars();
            carsDetails.Show();
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            AdminManageReportGenarateUsers users = new AdminManageReportGenarateUsers();
            users.Show();
            this.Close();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            AdminManageReportGenaratePayments pay = new AdminManageReportGenaratePayments();
            pay.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminDashboard home = new AdminDashboard();
            home.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminManageReportGenarateOrders orders = new AdminManageReportGenarateOrders();
            orders.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminManageReportGenarateCarsParts cartPartsDetails = new AdminManageReportGenarateCarsParts();
            cartPartsDetails.Show();
            this.Close();
        }
    }
}
