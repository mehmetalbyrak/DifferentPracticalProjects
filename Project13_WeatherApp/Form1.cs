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

namespace Project13_WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/istanbul/EN"),
                Headers =
    {
        { "x-rapidapi-key", "88e57dd0e5mshce05cd0b85d5861p173ce0jsn8a9d428b7355" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                
                var json = JObject.Parse(body);
                var fahrenheit = json["main"]["feels_like"].ToString();
                lblFahrenheit.Text = fahrenheit;

                var windSpeed = json["wind"]["speed"].ToString();
                lblWind.Text = windSpeed;

                var humidity = json["main"]["humidity"].ToString();
                lblHumidity.Text = humidity;

                
                var celcius = ((Convert.ToDouble(fahrenheit) - 32) / 1.8).ToString("F2");
                lblCelcius.Text = celcius;

                
            }
        }
    }
}
