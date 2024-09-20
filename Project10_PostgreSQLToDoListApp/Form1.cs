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
    public partial class FrmTodoList : Form
    {
        public FrmTodoList()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;Port=5432;Database=ToDoApp;User Id=postgres; Password=rootPostgreSql";

        void ToDoList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Select * from ToDoLists order by ToDoListId";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        void CategoryList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Select * from Categories order by CategoryId";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = dataTable;
            connection.Close();
        }



        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
        }

        private void FrmTodoList_Load(object sender, EventArgs e)
        {
            ToDoList();
            CategoryList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ToDoList();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            // inner join with Categories table
            string query = "Select ToDoLists.ToDoListId, ToDoLists.CategoryId, Categories.CategoryName, ToDoLists.Title, ToDoLists.Priority, ToDoLists.Description, ToDoLists.Status from ToDoLists inner join Categories on ToDoLists.CategoryId = Categories.CategoryId order by ToDoListId";

            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            string title = txtTitle.Text;
            string priority = txtPriority.Text;
            string description = txtDescription.Text;
            //string status = "B'0";

            //if (rdbDone.Checked)
            //{
            //    status = "B'1";
            //}
            //if (rdbInProgress.Checked)
            //{
            //    status = "B'0";
            //}

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Insert into ToDoLists (CategoryId, Title, Priority, Description, Status) values (@CategoryId, @Title, @Priority, @Description, B'1')";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Priority", priority);
                command.Parameters.AddWithValue("@Description", description);
                // command.Parameters.AddWithValue("@Status", "B'1'"); 
                command.ExecuteNonQuery();
                MessageBox.Show("To Do List added successfully");
                connection.Close();
                ToDoList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtToDoListId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Delete from ToDoLists where ToDoListId=@ToDoListId";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ToDoListId", id);
                command.ExecuteNonQuery();
                MessageBox.Show("To Do List deleted successfully");
                connection.Close();
                ToDoList();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtToDoListId.Text);
            int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            string title = txtTitle.Text;
            string priority = txtPriority.Text;
            string description = txtDescription.Text;

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Update ToDoLists set CategoryId=@CategoryId, Title=@Title, Priority=@Priority, Description=@Description where ToDoListId=@ToDoListId";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ToDoListId", id);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Priority", priority);
                command.Parameters.AddWithValue("@Description", description);
                command.ExecuteNonQuery();
                MessageBox.Show("To Do List updated successfully");
                connection.Close();
                ToDoList();

            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Select * from ToDoLists where Status=B'1' order by ToDoListId";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();

        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "Select * from ToDoLists where Status=B'0' order by ToDoListId";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();

        }
    }
}
