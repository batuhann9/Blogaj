using AutoMapper;
using Blogaj.WebUI.DTOs.SocialMediaDtos;
using Blogaj.Entity.Entities;

namespace Blogaj.API.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<CreateSocialMediaDto, SocialMedia>().ReverseMap();
            CreateMap<UpdateSocialMediaDto, SocialMedia>().ReverseMap();
        }
    }
}
