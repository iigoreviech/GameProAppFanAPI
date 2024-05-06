using System.ComponentModel.DataAnnotations;

namespace GameProAppFanAPI.Models
{
    public class MatchStage
    {
        [Key]
        public int id { get; set; }
        public string titleStage { get; set; }
    }
}
