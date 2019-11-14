using AutoMapper;
using ComedyEventsCore3.Dto;
using ComedyEventsCore3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComedyEventsCore3.Services
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            //CreateMap<Event[], EventDto[]>().ReverseMap();

            CreateMap<Event, EventDto>()
                .ReverseMap()
            .ForMember(v => v.Venue, o => o.Ignore());

            CreateMap<Gig, GigDto>()
                .ReverseMap()
                .ForMember(e => e.Event, o => o.Ignore())
                .ForMember(c => c.Comedian, o => o.Ignore());

            CreateMap<Comedian, ComedianDto>()
                .ReverseMap();
        }
    }
}
