using System;
using System.Data.Entity;
using System.Linq;
using WeatherAPI.Models;

namespace WeatherAPI
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext()
            : base("name=WeatherDbContext")
        {
        }

        public UserModel userModel { get; set; }
        public WeatherDataModel weatherDataModel { get; set; }
    }
}