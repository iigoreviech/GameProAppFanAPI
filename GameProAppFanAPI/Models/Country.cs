using System.ComponentModel.DataAnnotations;

namespace GameProAppFanAPI.Models
{
    public class Country
    {
        [Key]
        public int id { get; set; }
        public string countryName { get; set; }
        public string countryImagePath { get; set; }
    }
}
