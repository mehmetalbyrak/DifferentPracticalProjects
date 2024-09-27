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

namespace Project18_DashboardSuperStoreDataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-LAM2LI6\SQLEXPRESS; Initial Catalog=KaggleDB; Integrated Security=true; TrustServerCertificate=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Widgets

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select count(*) from superstore", sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lblCountOfProductsNumber.Text = reader[0].ToString();
                
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("select count(Distinct(State)) from superstore", sqlConnection);
            SqlDataReader reader2 = sqlCommand2.ExecuteReader();
            while (reader2.Read())
            {
                lblCountOfCityNumber.Text = reader2[0].ToString();

            }
            sqlConnection.Close();


            sqlConnection.Open();
            SqlCommand sqlCommand4 = new SqlCommand("select Sum(Quantity) from superstore", sqlConnection);
            SqlDataReader reader4 = sqlCommand4.ExecuteReader();
            while (reader4.Read())
            {
                lblTotalQuantityOfOrdersNumber.Text = reader4[0].ToString();

            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("select count(*) from superstore where country = 'Turkey'", sqlConnection);
            SqlDataReader reader3 = sqlCommand3.ExecuteReader();
            while (reader3.Read())
            {
                lblTotalCountsOfOrdersFromTRNumber.Text = reader3[0].ToString();

            }
            sqlConnection.Close();

            #endregion

            #region charts

            
            

            sqlConnection.Open();
            SqlCommand sqlCommand5 = new SqlCommand("select top(7) country, count(*) as countryNum from superstore group by Country\r\norder by count(*) desc", sqlConnection);
            SqlDataReader reader5 = sqlCommand5.ExecuteReader();
            while (reader5.Read())
            {
                chart1.Series["Series1"].Points.AddXY(reader5[0], reader5[1]);
            }
            sqlConnection.Close();


            sqlConnection.Open();
            SqlCommand sqlCommand6 = new SqlCommand("select top(3) country, sum(Quantity) from superstore group by Country\r\norder by sum(Quantity) desc", sqlConnection);
            SqlDataReader reader6 = sqlCommand6.ExecuteReader();
            while (reader6.Read())
            {
                chart2.Series["Series1"].Points.AddXY(reader6[0], reader6[1]);
            }
            sqlConnection.Close();


            sqlConnection.Open();
            SqlCommand sqlCommand7 = new SqlCommand("Select Order_Priority, Count(*) from superstore group by Order_Priority\r\norder by Order_Priority desc", sqlConnection);
            SqlDataReader reader7 = sqlCommand7.ExecuteReader();
            while (reader7.Read())
            {
                chart3.Series["Series1"].Points.AddXY(reader7[0], reader7[1]);
            }
            sqlConnection.Close();









            #endregion
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
