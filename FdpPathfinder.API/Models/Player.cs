using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FdpPathfinder.API.Models
{
    public class Player
    {
        public int Id { get; set; }
        
        [Required]
        public string Username { get; set; }
        public string PasswordHasg { get; set; }
        
        public string PasswordSalt { get; set; }

        public ICollection<Character> Characters { get; set; }
    }
}