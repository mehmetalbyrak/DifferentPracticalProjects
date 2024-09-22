using Project12_JwtToken.JWT;
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

namespace Project12_JwtToken
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-LAM2LI6\SQLEXPRESS; Initial Catalog=JWTDB; Integrated Security=True; TrustServerCertificate=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TokenGenerator tokenGenerator = new TokenGenerator();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Users where UserName=@userName and Password=@password", sqlConnection );
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@userName", txtUserName.Text);
            sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string myToken = tokenGenerator.GenerateJwtToken2(txtUserName.Text);
                MessageBox.Show(myToken);
                FrmEmployee frmEmployee = new FrmEmployee();
                frmEmployee.tokenGet = myToken;
                frmEmployee.Show();
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password");
                txtPassword.Clear();
                txtUserName.Clear();
                txtUserName.Focus();
            }

            sqlConnection.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
