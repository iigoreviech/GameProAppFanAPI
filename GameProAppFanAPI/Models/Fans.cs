using System.ComponentModel.DataAnnotations;

namespace GameProAppFanAPI.Models
{
    public class Fan
    {
        [Key]
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string? lastName { get; set; }
        public string firstName { get; set; }
        public string? patronymic { get; set; }
        public DateTime? birthDate { get; set; }
        public int? CountryId { get; set; }
        public string? fanImagePath { get; set; }
        public int? TeamId { get; set; }
        public Country Country { get; set; }
        public Team? Team { get; set; }
    }
}
