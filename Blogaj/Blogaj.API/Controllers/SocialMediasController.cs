using AutoMapper;
using Blogaj.Business.Abstract;
using Blogaj.DTO.DTOs.SocialMediaDtos;
using Blogaj.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blogaj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController(
        IGenericService<SocialMedia> _socialMediaService,
        IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _socialMediaService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult Create(CreateSocialMediaDto createSocialMediaDto)
        {
            var newValue = _mapper.Map<SocialMedia>(createSocialMediaDto);
            _socialMediaService.TCreate(newValue);
            return Ok("Operation completed successfully.");
        }

        [HttpPut]
        public IActionResult Update(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var newValue = _mapper.Map<SocialMedia>(updateSocialMediaDto);
            _socialMediaService.TUpdate(newValue);
            return Ok("Success.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _socialMediaService.TDelete(id);
            return Ok("Operation completed successfully.");
        }
    }
}
