using Project12_JwtToken.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        public string tokenGet;
        SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-LAM2LI6\SQLEXPRESS; Initial Catalog=JWTDB; Integrated Security=True; TrustServerCertificate=True");


        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            TokenValidator tokenValidator = new TokenValidator();
            richTextBox1.Text = tokenGet;

            var principal = tokenValidator.ValidateJwtToken(tokenGet); 

            if (principal != null)
            {
                string userName = principal.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
                MessageBox.Show($"Welcome {userName}");

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Employees", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("Invalid Token :d ");
            }


            

        }
    }
}
