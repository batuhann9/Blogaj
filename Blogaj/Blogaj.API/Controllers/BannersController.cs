using AutoMapper;
using Blogaj.Business.Abstract;
using Blogaj.DTO.DTOs.AboutDtos;
using Blogaj.DTO.DTOs.BannerDtos;
using Blogaj.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blogaj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IGenericService<Banner> _bannerService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _bannerService.TGetList();
            return Ok(values);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var value = _bannerService.TGetById(Id);
            return Ok(value);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            _bannerService.TDelete(Id);
            return Ok("Operation completed successfully.");
        }

        [HttpPost]
        public IActionResult Create(CreateBannerDto createBannerDto)
        {
            var newValue = _mapper.Map<Banner>(createBannerDto);
            _bannerService.TCreate(newValue);
            return Ok("Operation completed successfully.");
        }

        [HttpPut]
        public IActionResult Update(UpdateBannerDto updateBannerDto)
        {
            var newValue = _mapper.Map<Banner>(updateBannerDto);
            _bannerService.TUpdate(newValue);
            return Ok("Success.");
        }

    }
}
