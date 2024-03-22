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
    public partial class AdminManageOrderDoPayment : Form
    {
        public AdminManageOrderDoPayment()
        {
            InitializeComponent();
        }

        public void PopulateFieldsToDoPayment(string NIC, string orderId, string regId, string item, decimal amount, DateTime orderDate, DateTime currentDate)
        {
            // Populate the fields in the form with the provided data
            txtbxNIC.Text = NIC;
            txtbxOrderID.Text = orderId;
            txtbxRegID.Text = regId;
            txtbxItem.Text = item;
            txtbxAmount.Text = amount.ToString();
            txtbxOrderDate.Text = orderDate.ToString();
            txtbxCurrentDate.Text = currentDate.ToString();
        }

        private void AdminManageOrderDoPayment_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminManageOrderDetailsDashboard obj56 = new AdminManageOrderDetailsDashboard();
            obj56.Show();
            this.Close();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            PaymentController PaymentCtl = new PaymentController();
            Payments T1 = new Payments(txtbxNIC.Text, txtbxOrderID.Text,txtbxRegID.Text,txtbxItem.Text, DateTime.Parse(txtbxOrderDate.Text),decimal.Parse(txtbxAmount.Text));
            PaymentCtl.InsertNewPaidPaymentDetails(T1);
        }
    }
}
