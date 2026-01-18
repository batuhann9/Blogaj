using AutoMapper;
using Blogaj.DTO.DTOs.MessageDtos;
using Blogaj.Entity.Entities;

namespace Blogaj.API.Mapping
{
    public class MessageMapping:Profile
    {
        public MessageMapping()
        {
            CreateMap<CreateMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();

        }
    }
}
