using Dapper;
using Project5_DapperNorthwind.Dtos.CategoryDtos;
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

namespace Project5_DapperNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-LAM2LI6\\SQLEXPRESS; Initial Catalog=DapperWithNorthwind; Integrated Security=true; TrustServerCertificate=True");
        private async void btnCategoryList_Click(object sender, EventArgs e)
        {
            string query = "Select * from Categories";
            var values = await sqlConnection.QueryAsync<ResultCategoryDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into Categories (CategoryName, Description) Values (@p1, @p2)";

            var parameters = new DynamicParameters();
            parameters.Add("@p1", txtCategoryName.Text);
            parameters.Add("@p2", txtCategoryDescription.Text);

            await sqlConnection.ExecuteAsync(sql, parameters);
            
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from Categories Where CategoryId = @categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", txtCategoryId.Text);
            await sqlConnection.ExecuteAsync(query, parameters);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Categories Set CategoryName = @categoryName, Description = @description Where CategoryId = @categoryId";

            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", txtCategoryName.Text);
            parameters.Add("@description", txtCategoryDescription.Text);
            parameters.Add("@categoryId", txtCategoryId.Text);

            await sqlConnection.ExecuteAsync(query, parameters);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Category Number
            string query = "Select Count(*) From Categories";
            var categoryCount = await sqlConnection.ExecuteScalarAsync<int>(query);
            lblCategoryCount.Text = "Total Category Count -->  " + categoryCount;

            // Product Number
            string query2 = "Select Count(*) From Products";
            var productCount = await sqlConnection.ExecuteScalarAsync<int>(query2);
            lblProductCount.Text = "Total Product Count --> " + productCount;

            // Average Product Stock Count
            string query3 = "Select Avg(UnitsInStock) From Products";
            var avgProductStock = await sqlConnection.ExecuteScalarAsync<int>(query3);
            lblAvgProductCount.Text = "Average Product Stock Count is --> " + avgProductStock;

            // Total Seafood Product Price
            string query4 = "Select Sum(UnitPrice) From Products Where CategoryId=(Select CategoryId From Categories Where CategoryName='SeaFood')";
            var totalSeaFoodPrice = await sqlConnection.ExecuteScalarAsync<decimal>(query4);
            lblSeafoodProductTotalPrice.Text = "Total Seafood Product Price --> " + totalSeaFoodPrice;

        }
    }
}
