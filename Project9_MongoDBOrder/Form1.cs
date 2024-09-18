using Project9_MongoDBOrder.Entities;
using Project9_MongoDBOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDBOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OrderOperation orderOperation = new OrderOperation();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City = txtCity.Text,
                CustomerName = txtCustomerName.Text,
                Town = txtTown.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text),
            };

            orderOperation.AddOrder(order);
            MessageBox.Show("Addition is done :d ");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Order> orders = orderOperation.GetAllOrders();
            dataGridView1.DataSource = orders;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Deletion is completion :d");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtOrderId.Text;
            var updateOrder = new Order
            {
                City = txtCity.Text,
                CustomerName = txtCustomerName.Text,
                Town = txtTown.Text,
                OrderId = id,
                TotalPrice = decimal.Parse(txtTotalPrice.Text),
            };

            orderOperation.UpdateOrder(updateOrder);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string id = txtOrderId.Text;
            Order orders = orderOperation.GetOrderById(id);
            dataGridView1.DataSource = new List<Order> { orders };
        }
    }
}
