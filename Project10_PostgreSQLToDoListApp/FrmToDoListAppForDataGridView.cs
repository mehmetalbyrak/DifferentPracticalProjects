using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Project10_PostgreSQLToDoListApp
{
    public partial class FrmToDoListAppForDataGridView : Form
    {
        public FrmToDoListAppForDataGridView()
        {
            InitializeComponent();
        }

        private void FrmToDoListAppForDataGridView_Load(object sender, EventArgs e)
        {

            using (var npgsqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;Database=ToDoApp;User Id=postgres;Password=rootPostgreSql"))
            {
                npgsqlConnection.Open(); // Bağlantıyı aç

                string query = "SELECT * FROM ToDoLists"; // Tablo adını doğru yaz
                using (var npgsqlDataAdapter = new NpgsqlDataAdapter(query, npgsqlConnection))
                {
                    DataSet dataSet = new DataSet();
                    npgsqlDataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0]; // DataGridView'ın verikaynağını ayarla
                    npgsqlConnection.Close();
                }
            }

        }
    }
}
