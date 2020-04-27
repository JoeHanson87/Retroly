using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Retroly.Dtos;
using Retroly.Models;

namespace Retroly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Game, GameDto>();
            Mapper.CreateMap<MembershipType, MemershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<GameDto, Game>()
                .ForMember(g => g.Id, opt => opt.Ignore());
        }
    }
}