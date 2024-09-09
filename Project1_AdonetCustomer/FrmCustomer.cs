using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_AdonetCustomer
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-LAM2LI6\SQLEXPRESS; Initial Catalog=CustomerDB; Integrated Security=true; TrustServerCertificate=True");

        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("select CustomerId, CustomerName, CustomerLastName, CustomerBalance, CustomerStatus, CityName\r\nfrom TblCustomer\r\ninner join TblCity on\r\nTblCity.CityId = TblCustomer.CustomerCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewCustomer.DataSource = dataTable;


            sqlConnection.Close();
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Execute CustomerListWithCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewCustomer.DataSource = dataTable;


            sqlConnection.Close();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select * from TblCity", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            
            cmbCustomerCity.ValueMember = "CityId";
            cmbCustomerCity.DisplayMember = "CityName";
            cmbCustomerCity.DataSource = dataTable;


            sqlConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into TblCustomer (CustomerName, CustomerLastname, CustomerCity, CustomerBalance, CustomerStatus) values (@customerName, @customerLastname, @customerCity, @customerBalance, @customerStatus)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            sqlCommand.Parameters.AddWithValue("@customerLastName", txtCustomerLastName.Text);
            sqlCommand.Parameters.AddWithValue("@customerCity", cmbCustomerCity.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@customerBalance", txtCustomerBalance.Text);
            if (rdbActive.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@customerStatus", true);
            }if (rdbPassive.Checked)
                sqlCommand.Parameters.AddWithValue("@customerStatus", false);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Customer added as successfully :d");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from TblCustomer where CustomerId = @customerId", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Customer is deleted as successfully", "Warn!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE TblCustomer SET CustomerName = @customerName, CustomerLastname = @customerLastname, CustomerCity = @customerCity, CustomerBalance = @customerBalance, CustomerStatus = @customerStatus WHERE CustomerId = @customerId", sqlConnection);


            sqlCommand.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            sqlCommand.Parameters.AddWithValue("@customerLastName", txtCustomerLastName.Text);
            sqlCommand.Parameters.AddWithValue("@customerCity", cmbCustomerCity.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@customerBalance", txtCustomerBalance.Text);
            sqlCommand.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            if (rdbActive.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@customerStatus", true);
            }
            if (rdbPassive.Checked)
                sqlCommand.Parameters.AddWithValue("@customerStatus", false);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Customer updated as successfully :d");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("select CustomerId, CustomerName, CustomerLastName, CustomerBalance, CustomerStatus, CityName\r\nfrom TblCustomer\r\ninner join TblCity on\r\nTblCity.CityId = TblCustomer.CustomerCity WHERE CustomerName = @customerName", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewCustomer.DataSource = dataTable;


            sqlConnection.Close();
        }
    }
}
