using AutoMapper;
using Blogaj.DTO.DTOs.BlogCategoryDtos;
using Blogaj.DTO.DTOs.CategoryDtos;
using Blogaj.Entity.Entities;

namespace Blogaj.API.Mapping
{
    public class BlogCategoryMapping : Profile
    {
        public BlogCategoryMapping()
        {
            CreateMap<BlogCreateCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<BlogUpdateCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<ResultBlogCategoryDto, BlogCategory>().ReverseMap();
        }
    }
}
