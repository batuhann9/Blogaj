using AutoMapper;
using Blogaj.Business.Abstract;
using Blogaj.DTO.DTOs.ContactDtos;
using Blogaj.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blogaj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(
        IGenericService<Contact> _contactService,
        IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var value = _contactService.TGetById(Id);
            return Ok(value);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            _contactService.TDelete(Id);
            return Ok("Operation completed successfully.");
        }

        [HttpPost]
        public IActionResult Create(CreateContactDto createContactDto)
        {
            var newValue = _mapper.Map<Contact>(createContactDto);
            _contactService.TCreate(newValue);
            return Ok("Operation completed successfully.");
        }

        [HttpPut]
        public IActionResult Update(UpdateContactDto updateContactDto)
        {
            var newValue = _mapper.Map<Contact>(updateContactDto);
            _contactService.TUpdate(newValue); // TUpdate yoksa eklenmeli
            return Ok("Success.");
        }
    }
}
