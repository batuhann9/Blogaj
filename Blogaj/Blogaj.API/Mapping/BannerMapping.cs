using AutoMapper;
using Blogaj.WebUI.DTOs.BannerDtos;
using Blogaj.Entity.Entities;

namespace Blogaj.API.Mapping
{
    public class BannerMapping:Profile
    {
        public BannerMapping() 
        { 
            CreateMap<CreateBannerDto, Banner>().ReverseMap();
            CreateMap<UpdateBannerDto, Banner>().ReverseMap();
        }
    }
}
