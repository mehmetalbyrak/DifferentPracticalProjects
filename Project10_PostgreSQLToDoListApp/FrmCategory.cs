using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_PostgreSQLToDoListApp
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;Port=5432;Database=ToDoApp;User Id=postgres;Password=rootPostgreSql";

        void CategoryList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Select * from Categories order by CategoryId";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            CategoryList();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Insert into Categories (CategoryName) values (@CategoryName)";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Category added successfully");
                connection.Close();
                CategoryList();


            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // int id = int.Parse(txtCategoryId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Delete from Categories where CategoryId=@CategoryId";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoryId", int.Parse(txtCategoryId.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Category deleted successfully");
                connection.Close();
                CategoryList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Update Categories set CategoryName=@CategoryName where CategoryId=@CategoryId";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoryId", int.Parse
                    (txtCategoryId.Text));
                command.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Category updated successfully");
                connection.Close();

                CategoryList();

            }
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Select * from Categories where CategoryId=@CategoryId";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoryId", int.Parse
                    (txtCategoryId.Text));
                var adapter = new NpgsqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();

            }
        }
    }
}
