using Microsoft.EntityFrameworkCore;
using Project6_APIWeather.Entities;

namespace Project6_APIWeather.Context
{
    public class WeatherContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LAM2LI6\\SQLEXPRESS; Initial Catalog=APIWeatherDB;\r\nIntegrated Security=true; TrustServerCertificate=True");
        }

        public DbSet<City> Cities { get; set; }
    }
}
