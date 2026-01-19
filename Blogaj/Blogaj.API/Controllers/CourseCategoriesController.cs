using AutoMapper;
using Blogaj.Business.Abstract;
using Blogaj.WebUI.DTOs.CourseCategoryDto;
using Blogaj.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blogaj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController(
        IGenericService<CourseCategory> _courseCategoryService,
        IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseCategoryService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _courseCategoryService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult Create(CreateCourseCategoryDto createCourseCategoryDto)
        {
            var newValue = _mapper.Map<CourseCategory>(createCourseCategoryDto);
            _courseCategoryService.TCreate(newValue);
            return Ok("Operation completed successfully.");
        }

        [HttpPut]
        public IActionResult Update(UpdateCourseCategoryDto updateCourseCategoryDto)
        {
            var newValue = _mapper.Map<CourseCategory>(updateCourseCategoryDto);
            _courseCategoryService.TUpdate(newValue);
            return Ok("Success.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseCategoryService.TDelete(id);
            return Ok("Operation completed successfully.");
        }
    }
}
