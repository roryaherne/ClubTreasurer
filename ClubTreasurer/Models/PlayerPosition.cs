using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClubTreasurer.Models
{
    public class PlayerPosition : BaseModel
    {
        [Required]
        public string Name { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
