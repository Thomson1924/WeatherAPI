using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WeatherAPI.Models;

namespace WeatherAPI.Models
{
    public class WeatherDataModel
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Description { get; set; }
        public string Temp { get; set; }
        public string TempMax { get; set; }
        public string TempMin { get; set; }
        public string imgWeatherIconUrl { get; set; }
    }
}