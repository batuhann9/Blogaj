using AutoMapper;
using Blogaj.WebUI.DTOs.BlogDtos;
using Blogaj.Entity.Entities;

namespace Blogaj.API.Mapping
{
    public class BlogMapping : Profile
    {
        public BlogMapping()
        {
            CreateMap<CreateBlogDto, Blog>().ReverseMap();
            CreateMap<UpdateBlogDto, Blog>().ReverseMap();
            CreateMap<ResultBlogDto, Blog>().ReverseMap();
        }
    }
}
