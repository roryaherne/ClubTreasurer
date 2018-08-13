using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Models
{
    public class Player : Person
    {
        public int ID { get; set; }
        public byte[] Image { get; set; }
        public PlayerPosition Position { get; set; }
    }
}
