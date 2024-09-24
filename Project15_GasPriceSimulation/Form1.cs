using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project15_GasPriceSimulation
{
    public partial class FrmGasPriceSimulation : Form
    {
        public FrmGasPriceSimulation()
        {
            InitializeComponent();
        }

        double dieselPrice = 0;
        double gasolinePrice = 0;
        double lpgPrice = 0;
        double fuelAmount = 0;
        double totalAmount = 0;
        int count = 0;

        private void btnBeginProcess_Click(object sender, EventArgs e)
        {
            fuelAmount = Convert.ToDouble(txtFuelAmount.Text);
            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.Text = count.ToString();
            
            if (rdbGasoline.Checked)
            {
                count++;

                if(count <= fuelAmount)
                {
                    totalAmount += gasolinePrice;
                    txtTotalAmount.Text = totalAmount.ToString();
                }
                else
                {
                    txtTotalAmount.Text = totalAmount.ToString();
                }
                

               progressBarInstantFuelPercentage.Value = count;

                if (count == fuelAmount)
                {
                    timer1.Stop();
                    MessageBox.Show("The process is completed.");
                }
            }

            if (rdbDieselFuel.Checked)
            {
                count++;

                if (count <= fuelAmount)
                {
                    totalAmount += dieselPrice;
                    txtTotalAmount.Text = totalAmount.ToString();
                }
                else
                {
                    txtTotalAmount.Text = totalAmount.ToString();
                }

                progressBarInstantFuelPercentage.Value = count;

                if (count == fuelAmount)
                {
                    timer1.Stop();
                    MessageBox.Show("The process is completed.");
                }
            }

            if (rdbLPG.Checked)
            {
                count++;

                if (count <= fuelAmount)
                {
                    totalAmount += lpgPrice;
                    txtTotalAmount.Text = totalAmount.ToString();
                }
                else
                {
                    txtTotalAmount.Text = totalAmount.ToString();
                }

                progressBarInstantFuelPercentage.Value = count;

                if (count == fuelAmount)
                {
                    timer1.Stop();
                    MessageBox.Show("The process is completed.");
                }
            }
        }

        private async void FrmGasPriceSimulation_Load(object sender, EventArgs e)
        {

            //MessageBox.Show("Api Fuel Prices are being fetched.");

            //txtGasoline.Text = gasolinePrice.ToString() + "₺";
            //txtDieselFuel.Text = dieselPrice.ToString() + "₺";
            //txtLPG.Text = lpgPrice.ToString() + "₺";

            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://akaryakit-fiyatlari.p.rapidapi.com/fuel/istanbul"),
                Headers =
    {
        { "x-rapidapi-key", "88e57dd0e5mshce05cd0b85d5861p173ce0jsn8a9d428b7355" },
        { "x-rapidapi-host", "akaryakit-fiyatlari.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json  = JObject.Parse(body);

                var gasolineJsonValue = json["data"][16]["prices"][0]["benzin"];
                txtGasoline.Text = gasolineJsonValue.ToString();



                var dieselJsonValue = json["data"][16]["prices"][0]["motorin"];
                txtDieselFuel.Text = dieselJsonValue.ToString();
                
                
                var lpgJsonValue = json["data"][16]["prices"][0]["lpg"];
                txtLPG.Text = lpgJsonValue.ToString();
                
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
