
using System.ComponentModel.DataAnnotations;

namespace GameProAppFanAPI.Models
{
    public class Tournament
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        public int CityId { get; set; }
        public float prizeFund { get; set; }
        public int? TournamentTypeId { get; set; }
        public string tournamentImagePath { get; set; }
        public string? description { get; set; }
        public City City { get; set; }
        public TournamentType TournamentType { get; set; }
    }
}
