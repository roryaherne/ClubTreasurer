using ClubTreasurer.Interfaces;

namespace ClubTreasurer.Models
{
    public class Player : Person
    {
        public byte[] Image { get; set; }

        public int PositionId { get; set; }

        public PlayerPosition Position { get; set; }

    }
}
