using AutoMapper;
using Blogaj.WebUI.DTOs.SubscriberDtos;
using Blogaj.Entity.Entities;

namespace Blogaj.API.Mapping
{
    public class SubscriberMapping : Profile
    {
        public SubscriberMapping()
        {
            CreateMap<CreateSubscriberDto, Subscriber>().ReverseMap();
            CreateMap<UpdateSubscriberDto, Subscriber>().ReverseMap();

        }
    }
}
