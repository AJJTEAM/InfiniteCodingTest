using AutoMapper;
using InfiniteFrontEndApi.HttpClientModel;
using InfiniteFrontEndApi.Models;

namespace InfiniteFrontEndApi
{
    public class PeopleProfile:Profile
    {
        public PeopleProfile()
        {
            CreateMap<PeopleClientResponse, People>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.GivenName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.FamilyName))
                .ReverseMap();
        }
    }
}
