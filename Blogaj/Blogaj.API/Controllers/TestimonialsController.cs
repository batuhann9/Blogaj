using AutoMapper;
using Blogaj.Business.Abstract;
using Blogaj.DTO.DTOs.TestimonialDtos;
using Blogaj.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blogaj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(
        IGenericService<Testimonial> _testimonialService,
        IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult Create(CreateTestimonialDto createTestimonialDto)
        {
            var newValue = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialService.TCreate(newValue);
            return Ok("Operation completed successfully.");
        }

        [HttpPut]
        public IActionResult Update(UpdateTestimonialDto updateTestimonialDto)
        {
            var newValue = _mapper.Map<Testimonial>(updateTestimonialDto);
            _testimonialService.TUpdate(newValue);
            return Ok("Success.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _testimonialService.TDelete(id);
            return Ok("Operation completed successfully.");
        }
    }
}
