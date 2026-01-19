using AutoMapper;
using Blogaj.Business.Abstract;
using Blogaj.WebUI.DTOs.BlogCategoryDtos;
using Blogaj.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blogaj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController(
        IGenericService<BlogCategory> _blogCategoryService,
        IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogCategoryService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _blogCategoryService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult Create(CreateBlogCategoryDto dto)
        {
            var entity = _mapper.Map<BlogCategory>(dto);
            _blogCategoryService.TCreate(entity);
            return Ok("Operation completed successfully.");
        }

        [HttpPut]
        public IActionResult Update(UpdateBlogCategoryDto dto)
        {
            var entity = _mapper.Map<BlogCategory>(dto);
            _blogCategoryService.TUpdate(entity);
            return Ok("Success.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogCategoryService.TDelete(id);
            return Ok("Operation completed successfully.");
        }
    }
}
