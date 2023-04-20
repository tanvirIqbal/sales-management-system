using AutoMapper;
using SMS.Shared.DTO;
using SMS.Shared.Models;

namespace SMS.Server
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<SubElement, SubElementDTO>().ReverseMap();
            CreateMap<Window, WindowDTO>()
        .ForMember(dest => dest.SubElements, opt => opt.MapFrom(src => src.SubElements)).ReverseMap();
            CreateMap<Order, OrderDTO>()
        .ForMember(dest => dest.Windows, opt => opt.MapFrom(src => src.Windows)).ReverseMap();
        }

    }
}
