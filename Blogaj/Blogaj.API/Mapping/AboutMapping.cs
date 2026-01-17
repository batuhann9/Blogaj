using AutoMapper;
using Blogaj.DTO.DTOs;
using Blogaj.Entity.Entities;

namespace Blogaj.API.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
