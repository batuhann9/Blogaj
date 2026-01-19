using AutoMapper;
using Blogaj.Business.Abstract;
using Blogaj.WebUI.DTOs.CourseDtos;
using Blogaj.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blogaj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(
        IGenericService<Course> _courseService,
        IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _courseService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult Create(CreateCourseDto createCourseDto)
        {
            var newValue = _mapper.Map<Course>(createCourseDto);
            _courseService.TCreate(newValue);
            return Ok("Operation completed successfully.");
        }

        [HttpPut]
        public IActionResult Update(UpdateCourseDto updateCourseDto)
        {
            var newValue = _mapper.Map<Course>(updateCourseDto);
            _courseService.TUpdate(newValue);
            return Ok("Success.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseService.TDelete(id);
            return Ok("Operation completed successfully.");
        }
    }
}
