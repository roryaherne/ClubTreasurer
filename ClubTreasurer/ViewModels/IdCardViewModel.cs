using ClubTreasurer.Models;

namespace ClubTreasurer.ViewModels
{
    public class IdCardViewModel
    {
        public Player Player { get; set; }
        public string FeesPaidUntil { get; set; }
        public string ImageUrl { get; set; }
        public string BackgroundColor { get; set; }
    }
}
