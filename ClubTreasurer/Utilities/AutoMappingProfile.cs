using AutoMapper;
using ClubTreasurer.Models;
using ClubTreasurer.ViewModels;

namespace ClubTreasurer.Utilities
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            // creates map in order from source -> destination
            CreateMap<Player, PlayerViewModel>().ReverseMap();
        }
    }
}
