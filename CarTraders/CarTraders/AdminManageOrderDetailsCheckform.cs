using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class AdminManageOrderDetailsCheckform : Form
    {
        public AdminManageOrderDetailsCheckform()
        {
            InitializeComponent();
        }
        public void PopulateFields(string ID, string OrderDate, string RegID, string Item, string Type, Decimal Price, string PaymentStatus, string DeliveryStatus, string NIC)
        {
            // Populate the fields in the form with the provided data
            txtbxOrderID.Text = ID;
            txtbxOrderDate.Text = OrderDate;
            txtbxRegID.Text = RegID;
            txtbxItem.Text = Item;
            txtbxType.Text = Type;
            txtbxAmount.Text = Price.ToString();
            txtbxPaymentStatus.Text = PaymentStatus;
            txtbxDeleveryStatus.Text = DeliveryStatus;
            txtbxNIC.Text = NIC;

        }

        private void AdminManageOrderDetailsCheckform_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminManageOrderDetailsDashboard backbtn = new AdminManageOrderDetailsDashboard();
            backbtn.Show();
            this.Close();
        }

        //delete order
        private void button1_Click(object sender, EventArgs e)
        {
            string orderIdToDelete = txtbxOrderID.Text;

            OrdersController ordersController = new OrdersController();
            ordersController.DeleteOrder(orderIdToDelete);
        }

        private void btnDoPayment_Click(object sender, EventArgs e)
        {
            // Get the required data from the current form
            string NIC = txtbxNIC.Text;
            string orderId = txtbxOrderID.Text;
            string regId = txtbxRegID.Text;
            string item = txtbxItem.Text;
            decimal amount = decimal.Parse(txtbxAmount.Text);
            DateTime orderDate = DateTime.Parse(txtbxOrderDate.Text);
            DateTime currentDate = DateTime.Now; // Assuming you want the current date



            // Create an instance of the AdminManageOrderDoPayment form
            AdminManageOrderDoPayment doPaymentForm = new AdminManageOrderDoPayment();

            // Pass the data to the AdminManageOrderDoPayment form
            doPaymentForm.PopulateFieldsToDoPayment(NIC, orderId, regId, item, amount, orderDate, currentDate);

            // Show the AdminManageOrderDoPayment form
            doPaymentForm.Show();
            this.Close();
        }

        private void btnUpdateDeliveryStatus_Click(object sender, EventArgs e)
        {
            PaymentController PaymentCtl = new PaymentController();
            Payments T1 = new Payments(txtbxNIC.Text, txtbxOrderID.Text, txtbxRegID.Text, txtbxItem.Text, DateTime.Parse(txtbxOrderDate.Text), decimal.Parse(txtbxAmount.Text));
            PaymentCtl.UpdateDeleiveyStatus(T1);
        }
    }
}
