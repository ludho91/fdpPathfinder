using System.ComponentModel.DataAnnotations;

namespace FdpPathfinder.API.Models
{
    public class Character
    {
        public int Id { get; set; }
        public int PlayerId { get; set; } 
        [Required]
        public string nom  { get; set; } 
        public int  Level { get; set; }
        public int Experience { get; set; }
        public string Alignement { get; set; }
        public string Deity { get; set; }
        public string People { get; set; }
        public Player Player { get; set; }
        
    }
}