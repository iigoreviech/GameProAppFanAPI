using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameProAppFanAPI.Models
{
    public class Match
    {
        [Key]
        public int id { get; set; }
        public int TournamentId { get; set; }
        public int TeamOneId { get; set; }
        public int? pointsTeamOne { get; set; }
        public int TeamTwoId { get; set; }
        public int? pointsTeamTwo { get; set;}
        public DateTime? dateTimeStart { get; set; }

        [ForeignKey("TeamOneId")]
        public virtual Team TeamOne { get; set; }

        [ForeignKey("TeamTwoId")]
        public virtual Team TeamTwo { get; set; }
        public virtual Tournament Tournament { get; set; }
        public virtual MatchStage MatchStage { get; set; }
    }
}
