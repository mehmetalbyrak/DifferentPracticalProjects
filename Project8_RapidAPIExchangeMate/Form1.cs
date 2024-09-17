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

namespace Project8_RapidAPIExchangeMate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            #region Dollar
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
                {
                    { "x-rapidapi-key", "88e57dd0e5mshce05cd0b85d5861p173ce0jsn8a9d428b7355" },
                    { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var value = json["result"].ToString();
                lblDollar.Text = value;
            }
            #endregion

            #region Euro
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
                Headers =
                {
                    { "x-rapidapi-key", "88e57dd0e5mshce05cd0b85d5861p173ce0jsn8a9d428b7355" },
                    { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
                },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var json2 = JObject.Parse(body2);
                var value2 = json2["result"].ToString();
                lblEuro.Text = value2;
            }
            #endregion

            #region Pound
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
                Headers =
                {
                    { "x-rapidapi-key", "88e57dd0e5mshce05cd0b85d5861p173ce0jsn8a9d428b7355" },
                    { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
                },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var json3 = JObject.Parse(body3);
                var value3 = json3["result"].ToString();
                lblPound.Text = value3;
            }
            #endregion

            txtAmountToBePaid.Enabled = false;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            decimal amountOfUnit = decimal.Parse(txtUnitAmount.Text);
            decimal dollar = decimal.Parse(lblDollar.Text);
            decimal avro = decimal.Parse(lblEuro.Text);
            decimal pound = decimal.Parse(lblPound.Text);
            decimal totalPrice = 0;
            if (rdbDollar.Checked)
            {
                totalPrice = amountOfUnit * dollar;
            }
            if (rdbEuro.Checked)
            {
                totalPrice = amountOfUnit * avro;
            }
            if (rdbPound.Checked)
            {
                totalPrice = amountOfUnit * pound;
            }

            txtAmountToBePaid.Text = totalPrice.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}