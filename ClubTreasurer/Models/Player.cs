using System.ComponentModel.DataAnnotations;

namespace ClubTreasurer.Models
{
    public class Player : Person
    {
        public byte[] Image { get; set; }

        [Display(Name = "Position")]
        public int PositionId { get; set; }

        public PlayerPosition Position { get; set; }

    }
}
