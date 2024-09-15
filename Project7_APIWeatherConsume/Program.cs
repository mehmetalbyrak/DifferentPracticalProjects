using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json.Nodes;

internal class Program
{
    private static async Task Main(string[] args)
    {
        #region Menu_beginning

        Console.WriteLine("Welcome to the api consume process :d");
        Console.WriteLine();
        Console.WriteLine("### Choose what do you want to for this process ###");
        Console.WriteLine(" 1- City List");
        Console.WriteLine(" 2- City and Weather List");
        Console.WriteLine(" 3- New City Addition");
        Console.WriteLine(" 4- City Deletion");
        Console.WriteLine(" 5- City Updating");
        Console.WriteLine(" 6- Get City By Id");
        Console.WriteLine();

        #endregion


        string number;

        Console.Write("Choose process: ");
        number = Console.ReadLine();

        if (number == "1")
        {
            string requestAddress = "https://localhost:7017/api/Weathers";
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(requestAddress);
                string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
                JArray jArray = JArray.Parse(responseBody);
                foreach (var item in jArray)
                {
                    string cityName = item["cityName"].ToString();
                    Console.WriteLine($"City: {cityName}");
                }
            }

        }
        if (number == "2")
        {
            string requestAddress = "https://localhost:7017/api/Weathers";
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"{requestAddress}");
                string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
                JArray jArray = JArray.Parse(responseBody);

                foreach (var item in jArray)
                {
                    string cityName = item["cityName"].ToString();
                    string temp = item["temp"].ToString();
                    string country = item["country"].ToString();

                    Console.WriteLine($"City: {cityName} --> Weather: {temp} and Country is --> {country}");
                }
            }
        }

        if (number == "3")
        {
            Console.WriteLine("### New Data Entrance ###");
            Console.WriteLine();

            string cityName, country, detail;
            decimal temp;

            Console.Write("City Name: ");
            cityName = Console.ReadLine();

            Console.Write("Country Name: ");
            country = Console.ReadLine();

            Console.Write("Weather Detail: ");
            detail = Console.ReadLine();

            Console.Write("Weather Temp: ");
            temp = decimal.Parse(Console.ReadLine());

            string requestAddress = "https://localhost:7017/api/Weathers";
            var newWeatherCity = new
            {
                CityName = cityName,
                Country = country,
                Detail = detail,
                Temp = temp
            };

            using (HttpClient httpClient = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(newWeatherCity);
                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json"); // Tr support
                HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(requestAddress, stringContent);
                httpResponseMessage.EnsureSuccessStatusCode();
                // string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
            }
        }

        if (number == "4")
        {

            string requestAddress = "https://localhost:7017/api/Weathers?id=";
            Console.WriteLine("Enter City Id what you want to delete :d");
            int enteredId = int.Parse(Console.ReadLine());

            using (HttpClient httpsClient = new HttpClient())
            {
                HttpResponseMessage httpResponseMessage = await httpsClient.DeleteAsync(requestAddress + enteredId);
                httpResponseMessage.EnsureSuccessStatusCode();
            }


        }

        if (number == "5")
        {
            Console.WriteLine("### Data Updating Process ###");
            Console.WriteLine();

            string cityName, country, detail;
            decimal temp;
            int cityId;

            Console.Write("City Id: ");
            cityId = int.Parse(Console.ReadLine());

            Console.Write("City Name: ");
            cityName = Console.ReadLine();

            Console.Write("Country Name: ");
            country = Console.ReadLine();

            Console.Write("Weather Detail: ");
            detail = Console.ReadLine();

            Console.Write("Weather Temp: ");
            temp = decimal.Parse(Console.ReadLine());

            string requestAddress = "https://localhost:7017/api/Weathers";

            var updatedWeatherValues = new
            {
                CityId = cityId,
                CityName = cityName,
                Country = country,
                Detail = detail,
                Temp = temp
            };

            using (HttpClient httpClient = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(updatedWeatherValues);
                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage httpResponseMessage = await httpClient.PutAsync(requestAddress, stringContent);
                httpResponseMessage.EnsureSuccessStatusCode();
            }
        }

        

    }
}