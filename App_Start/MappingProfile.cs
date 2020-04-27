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
               // .ForMember(c=> c.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<Game, GameDto>();
              //  .ForMember(g => g.Id, opt => opt.Ignore());
            Mapper.CreateMap<GameDto, Game>()
                .ForMember(g => g.Id, opt => opt.Ignore());
        }
    }
}