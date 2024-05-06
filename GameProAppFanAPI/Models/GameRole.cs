using System.ComponentModel.DataAnnotations;

namespace GameProAppFanAPI.Models
{
    public class GameRole
    {
        [Key]
        public int id { get; set; }
        public string titleRole { get; set; }
        public string? description { get; set; }
    }
}
