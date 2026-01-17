using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Blogaj.Business.Abstract;
using Blogaj.DTO.DTOs;
using Blogaj.Entity.Entities;

namespace Blogaj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IGenericService<About> _aboutService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var value = _aboutService.TGetById(Id);
            return Ok(value);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            _aboutService.TDelete(Id);
            return Ok("Operation completed successfully.");
        }

        [HttpPost]
        public IActionResult Create(CreateAboutDto createAboutDto)
        {
            var newValue = _mapper.Map<About>(createAboutDto);
            _aboutService.TCreate(newValue);
            return Ok("" + "Operation completed successfully.");
        }

        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto)
        {
            var newValue = _mapper.Map<About>(updateAboutDto);
            _aboutService.TCreate(newValue);
            return Ok("Success.");
        }


    }
}
