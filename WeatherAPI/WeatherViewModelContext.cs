using System;
using System.Data.Entity;
using System.Linq;
using WeatherForecast.Models;

namespace WeatherAPI
{
    public class WeatherViewModelContext : DbContext
    {
        public WeatherViewModelContext()
            : base("name=WeatherViewModelContext")
        {
        }

        public DbSet<ResultViewModel> resultViewModels { get; set; }
        public DbSet<Coord> coords { get; set; }
        public DbSet<Weather> weathers { get; set; }
        public DbSet<Main> mains { get; set; }
        public DbSet<Wind> winds { get; set; }
        public DbSet<Clouds> clouds { get; set; }
        public DbSet<Sys> sys { get; set; }
        public DbSet<Root> roots { get; set; }
        public DbSet<RootObject> rootObjects { get; set; }
    }
}