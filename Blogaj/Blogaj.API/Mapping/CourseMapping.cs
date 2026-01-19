using AutoMapper;
using Blogaj.WebUI.DTOs.CourseDtos;
using Blogaj.Entity.Entities;

namespace Blogaj.API.Mapping
{
    public class CourseMapping : Profile
    {
        public CourseMapping()
        {
            CreateMap<CreateCourseDto, Course>().ReverseMap();
            CreateMap<UpdateCourseDto, Course>().ReverseMap();
            CreateMap<ResultCourseDto, Course>().ReverseMap();
        }
    }
}
