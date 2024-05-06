using System.ComponentModel.DataAnnotations;

namespace GameProAppFanAPI.Models
{
    public class TeamComposition
    {
        public int TeamId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime dateOfArrive { get; set; }
        public int GameRoleId { get; set; }
        public DateTime? dateOfDepart { get; set; }
        public GameRole GameRole { get; set; }
        public Team Team { get; set; }
        public Participant Participant { get; set; }
    }
}
