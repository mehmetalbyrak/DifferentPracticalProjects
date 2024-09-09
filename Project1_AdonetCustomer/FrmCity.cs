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
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-LAM2LI6\SQLEXPRESS; Initial Catalog=CustomerDB; Integrated Security=true; TrustServerCertificate=True");
        private void btnList_Click(object sender, EventArgs e)
        {
            
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select * from TblCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


            sqlConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("insert into TblCity (CityName, CityCountry) values (@cityName, @cityCountry)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@cityName", txtCityName.Text);
            sqlCommand.Parameters.AddWithValue("@cityCountry", txtCountry.Text);
            sqlCommand.ExecuteNonQuery(); // affected row count --> etkilenen kayıt sayısı
            sqlConnection.Close();

            MessageBox.Show("Successfully added :d");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // delete process generally implemented according to id :d
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from TblCity where CityId = @cityId", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@cityId", txtCityId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("City is deleted as successfully", "Warn!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update TblCity Set CityName = @cityName, CityCountry = @cityCountry where CityId = @cityId", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@cityName", txtCityName.Text);
            sqlCommand.Parameters.AddWithValue("@cityCountry", txtCountry.Text);
            sqlCommand.Parameters.AddWithValue("@cityId", txtCityId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("City is updated as successfully", "Warn!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from TblCity where CityName = @cityName", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@cityName", txtCityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();


        }
    }
}
