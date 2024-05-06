using System.ComponentModel.DataAnnotations;

namespace GameProAppFanAPI.Models
{
    public class TournamentType
    {
        [Key]
        public int id { get; set; }
        public string titleType { get; set; }
        public string? description { get; set; }
    }
}
