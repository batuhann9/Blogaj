using AutoMapper;
using Blogaj.WebUI.DTOs.ContactDtos;
using Blogaj.Entity.Entities;

public class ContactMapping : Profile
{
    public ContactMapping()
    {
        CreateMap<CreateContactDto, About>().ReverseMap();
        CreateMap<UpdateContactDto, About>().ReverseMap();
    }
}
