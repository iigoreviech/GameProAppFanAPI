using System.ComponentModel.DataAnnotations;

namespace GameProAppFanAPI.Models
{
    public class City
    {
        [Key]
        public int id { get; set; }
        [Length(0,50)]
        public string cityName { get; set; }
    }
}
