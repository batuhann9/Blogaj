using AutoMapper;
using Blogaj.WebUI.DTOs.TestimonialDtos;
using Blogaj.Entity.Entities;

namespace Blogaj.API.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
            CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
        }
    }
}
