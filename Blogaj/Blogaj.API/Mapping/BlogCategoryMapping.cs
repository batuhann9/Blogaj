using AutoMapper;
using Blogaj.WebUI.DTOs.BlogCategoryDtos;
using Blogaj.WebUI.DTOs.CategoryDtos;
using Blogaj.Entity.Entities;

namespace Blogaj.API.Mapping
{
    public class BlogCategoryMapping : Profile
    {
        public BlogCategoryMapping()
        {
            CreateMap<CreateBlogCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<UpdateBlogCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<ResultBlogCategoryDto, BlogCategory>().ReverseMap();
        }
    }
}
