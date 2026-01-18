using AutoMapper;
using Blogaj.Business.Abstract;
using Blogaj.DTO.DTOs.BlogDtos;
using Blogaj.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blogaj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IGenericService<Blog> _blogService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogService.TGetList();
            return Ok(values);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var value = _blogService.TGetById(Id);
            return Ok(value);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            _blogService.TDelete(Id);
            return Ok("Operation completed successfully.");
        }

        [HttpPost]
        public IActionResult Create(CreateBlogDto createBlogDto)
        {
            var newValue = _mapper.Map<Blog>(createBlogDto);
            _blogService.TCreate(newValue);
            return Ok("Operation completed successfully.");
        }

        [HttpPut]
        public IActionResult Update(UpdateBlogDto updateBlogDto)
        {
            var newValue = _mapper.Map<Blog>(updateBlogDto);
            _blogService.TUpdate(newValue);
            return Ok("Success.");
        }
    }
}
