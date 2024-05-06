using System.ComponentModel.DataAnnotations;

namespace GameProAppFanAPI.Models
{
    public class Team
    {
        [Key]
        public int id { get; set; }
        public string teamName { get; set; }
        public string teamLogoPath { get; set; }
        public int? ParticipantId { get; set; }
        public virtual List<Match> Matches1 { get; set; }
        public virtual List<Match> Matches2 { get; set; }
        public Participant Participant { get; set; }
        public virtual List<TeamComposition> TeamCompositions { get; set; }
    }
}
