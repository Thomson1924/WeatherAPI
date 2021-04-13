using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WeatherAPI.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }

        [ForeignKey("WeatherDataModels")]
        public int weatherID { get; set; }

        public virtual ICollection<WeatherDataModel> WeatherDataModels { get; set; }
    }
}